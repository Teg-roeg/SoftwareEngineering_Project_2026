using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace CarServiceAdministration
{
    internal class Car
    {
        public int CarID { get; set; }
        public int CusID { get; set; }
        public string RegNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(int carID, int cusID, string regNumber, string brand, string model, int year)
        {
            CarID = carID;
            CusID = cusID;
            RegNumber = regNumber;
            Brand = brand;
            Model = model;
            Year = year;
        }

        public static Car GetCar(int id)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();

                string query = @"
                    SELECT CusID, RegNumber, Brand, Model, Year
                    FROM Cars
                    WHERE CarID = :id";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Car(
                                id,
                                Convert.ToInt32(dr["CusID"]),
                                dr["RegNumber"].ToString(),
                                dr["Brand"].ToString(),
                                dr["Model"].ToString(),
                                Convert.ToInt32(dr["Year"])
                            );
                        }
                    }
                }
            }

            return null;
        }

        public static DataTable GetAllCars()
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();

                string query = "SELECT CarID, CusID, RegNumber, Brand, Model, Year FROM Cars";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable FindCars(string input)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();

                string query = @"
                    SELECT CarID, CusID, RegNumber, Brand, Model, Year
                    FROM Cars
                    WHERE TO_CHAR(CusID) LIKE :input
                    OR RegNumber LIKE :input
                    ORDER BY CarID";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":input", "%" + input + "%");

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public void UpdateCar()
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();

                string query = @"
                    UPDATE Cars
                    SET CusID = :cusid,
                        RegNumber = :reg,
                        Brand = :brand,
                        Model = :model,
                        Year = :year
                    WHERE CarID = :id";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":cusid", OracleDbType.Int32).Value = CusID;
                    cmd.Parameters.Add(":reg", OracleDbType.Varchar2).Value = RegNumber;
                    cmd.Parameters.Add(":brand", OracleDbType.Varchar2).Value = Brand;
                    cmd.Parameters.Add(":model", OracleDbType.Varchar2).Value = Model;
                    cmd.Parameters.Add(":year", OracleDbType.Int32).Value = Year;
                    cmd.Parameters.Add(":id", OracleDbType.Int32).Value = CarID;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}