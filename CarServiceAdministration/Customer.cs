using CarServiceAdministration.DBConnect;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceAdministration
{
    internal class Customer
    {
        public int CusID { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }

        public Customer(int cusID, string name, string phoneNum)
        {
            CusID = cusID;
            Name = name;
            PhoneNum = phoneNum;
        }
        public static Customer GetCustomer(int id)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();

                string query = "SELECT Name, PhoneNum FROM Customers WHERE CusID = :id";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                    OracleDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string name = dr["Name"].ToString();
                        string phone = dr["PhoneNum"].ToString();

                        return new Customer(id, name, phone);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public static DataTable FindCustomers(string input)
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();
                string query = @"SELECT CusID, Name, PhoneNum FROM Customers  WHERE Name LIKE :input OR TO_CHAR(CusID) LIKE :input ORDER BY Name";
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

        public void UpdateCustomer()
        {
            using (OracleConnection con = new OracleConnection(Database.connectionString))
            {
                con.Open();
                string query = @"UPDATE Customers 
                                 SET Name = :name, PhoneNum = :phone 
                                 WHERE CusID = :id";
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = Name;
                    cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = PhoneNum;
                    cmd.Parameters.Add(":id", OracleDbType.Int32).Value = CusID;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
    
}
