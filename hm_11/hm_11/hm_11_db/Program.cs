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
            //db.CreateMoto("Vadz", "x300", 1989, 23000);
            //db.EraseDb();
            db.EraseIdentityDb();
            //db.CreateMoto("Igor", "224", 1989, 23000);
            //db.CreateMoto("Fsss", "x3213", 1989, 23000);
            //Motorcycle motorcycle = new Motorcycle();
            //db.GetMotorcycleByID("motodb", 4, motorcycle);
            

            //Motorcycle honda = new Motorcycle();
            //db.GetMotorcycleByID(13, honda);
            //Console.WriteLine(honda.Odometer);
            Console.Read();
        }
    }

    public interface IControl
    {
        Motorcycle GetMotorcycleByID(int idValue, Motorcycle motorcycle);
        //Motorcycle[] GetMotorcycles();
        //void CreateMotorcycle(Motorcycle motorcycle);
        //void UpdateMotorcycle(string id, Motorcycle motorcycle);
        //void DeleteMotorcycle(string id);
    }

    class Db : IControl
    {
        public void CreateMoto(string name, string model, int year, int odometr)
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

        public void GetMotorcycles(string dbName)
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

        public void EraseIdentityDb()
        {
            string connectionString = $@"Data Source=.\SQLEXPRESS;Initial Catalog=motodb;Integrated Security=True";
            string sqlExpression = $"alter table motos add tempColumn int";
            string sqlExpression2 = $"update motos set tempColumn2 = Id";
            string sqlExpression3 = $"drop column tempColumn";

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                SqlDataReader reader = command.ExecuteReader();
                SqlDataReader reader2 = command2.ExecuteReader();
                SqlDataReader reader3 = command3.ExecuteReader();
                reader.Close();
            }
        }



    }

    public class Motorcycle
    {

        public static Motorcycle[] motoArr = new Motorcycle[10];
        public string Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
    }
}
