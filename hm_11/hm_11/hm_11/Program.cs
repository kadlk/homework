using System;
using log4net;


namespace hm_11
{
    class Program
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Create controller object");
            Controller controller = new Controller();
            Motorcycle honda = new Motorcycle();
            FillMotoParams(honda);
            log.Info("Adding object to array");
            controller.CreateMotorcycle(honda);

            Motorcycle suzuki = new Motorcycle();
            FillMotoParams(suzuki);
            controller.CreateMotorcycle(suzuki);

            Motorcycle java = new Motorcycle();
            FillMotoParams(java);
            controller.CreateMotorcycle(java);

            Console.WriteLine("Which moto you want to delete. \nType moto id :");
            controller.DeleteMotorcycle(Console.ReadLine());

            Console.WriteLine("Which moto you want to update. \nType moto id :");
            Motorcycle temp = new Motorcycle();
            FillMotoParams(temp);
            controller.UpdateMotorcycle(Console.ReadLine(), temp);

            for (int i = 0; i < Motorcycle.UsableElements; i++)
            {
                Console.WriteLine(Motorcycle.motoArr[i].Id);
            }

            Console.ReadKey();
        }

        public static void FillMotoParams(Motorcycle motorcycle)
        {
            log.Info("Start filling params");

            Console.WriteLine("Lets create new moto. \nInput ID: ");
            motorcycle.Id = Console.ReadLine();
            Console.WriteLine("Input name: ");
            motorcycle.Name = Console.ReadLine();
            Console.WriteLine("Input model: ");
            motorcycle.Model = Console.ReadLine();
            Console.WriteLine("Input year: ");

            bool success = Int32.TryParse(Console.ReadLine(), out int number);
            while (!success)
            {
                Console.WriteLine("Input one more time year: ");
                success = Int32.TryParse(Console.ReadLine(), out number);
            }
            motorcycle.Year = number;

            Console.WriteLine("Input odometr: ");
            success = Int32.TryParse(Console.ReadLine(), out number);
            while (!success)
            {
                Console.WriteLine("Input odometr: ");
                success = Int32.TryParse(Console.ReadLine(), out number);
            }
            motorcycle.Odometer = number;
        }
    }

    public class Motorcycle
    {
        public static Motorcycle[] motoArr = new Motorcycle[10];
        public static int UsableElements { get; set; } = 0;
        public string Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
    }

    public interface IControl
    {
        Motorcycle GetMotorcycleByID(string id);
        Motorcycle[] GetMotorcycles();
        void CreateMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(string id, Motorcycle motorcycle);
        void DeleteMotorcycle(string id);
    }

    class Controller : IControl
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            log.Info("Create motorcycle object");

            Motorcycle.motoArr[Motorcycle.UsableElements] = motorcycle;
            Motorcycle.UsableElements++;
        }
        public void DeleteMotorcycle(string id)
        {

            for (int i = 0; i < Motorcycle.UsableElements; i++)
            {
                if (id.Equals(Motorcycle.motoArr[i].Id))
                {
                    for (int j = i; j < Motorcycle.UsableElements; j++)
                    {
                        Motorcycle.motoArr[j] = Motorcycle.motoArr[j + 1];
                    }
                    Motorcycle.UsableElements--;
                }
            }
            log.Info($"Deleted {id} moto with shifting left all array. Last usable element in array is {Motorcycle.UsableElements}");

        }
        public Motorcycle GetMotorcycleByID(string id)
        {
            for (int i = 0; i < Motorcycle.UsableElements; i++)
            {
                if (id.Equals(Motorcycle.motoArr[i].Id))
                {
                    return Motorcycle.motoArr[i];
                }
            }
            return null;
        }
        public Motorcycle[] GetMotorcycles()
        {
            return Motorcycle.motoArr;
        }
        public void UpdateMotorcycle(string id, Motorcycle motorcycle)
        {
            for (int i = 0; i < Motorcycle.UsableElements; i++)
            {
                if (id.Equals(Motorcycle.motoArr[i].Id))
                {
                    Motorcycle.motoArr[i] = motorcycle;
                }
            }
            log.Info($"Updated {id} moto");
        }
    }
}

