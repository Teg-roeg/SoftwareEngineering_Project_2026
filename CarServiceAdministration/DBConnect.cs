using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;

namespace CarServiceAdministration
{

    namespace DBConnect
    {

        class Database
        {
            public static string connectionString;
            static Database()
            {
                try
                {
                    string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    string filePath = Path.Combine(
                    userProfilePath + "\\OneDrive - Munster Technological University","Documents","OracleConnectionStringMTU.txt");

                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine($"File not found: {filePath}");
                        return;
                    }

                    connectionString = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading connection string: {ex.Message}");
                }
            }
        }
    }
 }