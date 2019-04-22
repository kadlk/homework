using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace hm_11_db
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True;Connection Timeout=60";

            // If we added credits to app.config
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


            //string sqlExpression = "INSERT INTO Motos (Name, Model, year ) VALUES ('Honda', 'x600', 2019)";
            //string sqlExpression = "UPDATE Motos SET Model='x600-1' WHERE Name='Honda'";

            Db db = new Db();
            //db.CreateMoto("Vadz", "x300", 1989, 23000);
            //db.CreateMoto("Vadz", "x300", 1989, 23000);
            //db.CreateMoto("Vadz", "x300", 1989, 23000);
            //db.CreateMotorcycle("Vadz", "x300", 1989, 23000);
            //db.CreateMotorcycle();
            //db.EraseDb();
            //Motorcycle.motoArr = db.GetMotorcycles();
           
            Motorcycle honda = new Motorcycle();
            db.GetMotorcycleByID(1, honda);
            db.UpdateMotorcycle(2, "wwww");
            Console.WriteLine(honda.Odometer);

            Console.Read();
        }
    }

    public interface IControl
    {
        Motorcycle GetMotorcycleByID(int idValue, Motorcycle motorcycle);
        //Motorcycle[] GetMotorcycles();
        void CreateMotorcycle();
        void UpdateMotorcycle(int id, string name);
        //void DeleteMotorcycle(string id);
    }

    class Db : IControl
    {
        public void CreateMotorcycle()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
            string sqlExpression = $"INSERT INTO Motos (Name, Model, Year, Odometr) VALUES ('empty', 'empty', 0, 0)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }
        public void CreateMotorcycle(string name, string model, int year, int odometr)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
            string sqlExpression = $"INSERT INTO Motos (Name, Model, Year, Odometr) VALUES ('{name}', '{model}', {year}, {odometr})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }
        public void ShowDb(string dbName)
        {
            string connectionString = $@"Data Source=.\SQLEXPRESS;Initial Catalog={dbName};Integrated Security=True";
            string sqlExpression = "SELECT * FROM Motos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object model = reader.GetValue(2);
                        object year = reader.GetValue(3);
                        object odometr = reader.GetValue(4);

                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", id, name, model, year, odometr);
                    }
                }

                reader.Close();
            }
        }
        public Motorcycle GetMotorcycleByID(int idValue, Motorcycle motorcycle)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
            string sqlExpression = $"SELECT * FROM Motos WHERE ID IN ({idValue})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        motorcycle.Id = (int)reader.GetValue(0);
                        motorcycle.Name = (string)reader.GetValue(1);
                        motorcycle.Model = (string)reader.GetValue(2);
                        motorcycle.Year = (int)reader.GetValue(3);
                        motorcycle.Odometer = (int)reader.GetValue(4);
                    }
                }
                reader.Close();
                return motorcycle;

            }
        }
        public void EraseDb()
        {
            string connectionString = $@"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
            string sqlExpression = $"DELETE FROM Motos;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
        }

        public void UpdateMotorcycle(int id, string name)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
            string sqlExpression = $"UPDATE Motos SET Name='{name}' WHERE Id={id}";
            //$" ( Model={model} Year={year} Odometr={odometr} )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }
        //public Motorcycle[] GetMotorcycles()
        //{
        //    string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
        //    string sqlExpression = $"SELECT * FROM Motos";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(sqlExpression, connection);
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                for (int i = 0; i < Motorcycle.motoArr.Length; i++)
        //                {
        //                    Motorcycle.motoArr[i].Id = (int)reader.GetValue(0);
        //                    Motorcycle.motoArr[i].Name = (string)reader.GetValue(1);
        //                    Motorcycle.motoArr[i].Model = (string)reader.GetValue(2);
        //                    Motorcycle.motoArr[i].Year = (int)reader.GetValue(3);
        //                    Motorcycle.motoArr[i].Odometer = (int)reader.GetValue(4);
        //                }
        //            }
        //        }
        //        reader.Close();

        //        return Motorcycle.motoArr;
        //    }
        //}
    }
        public class Motorcycle
        {

            public static Motorcycle[] motoArr = new Motorcycle[1000];
            public int Id { get; set; }
            public string Name { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public int Odometer { get; set; }
        }
    
}

