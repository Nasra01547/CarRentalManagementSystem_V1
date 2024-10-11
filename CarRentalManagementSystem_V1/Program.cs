namespace CarRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("CAR_001", "TOYOTA", "PRIUS", 10);
            Console.WriteLine(car1);

            CarManager carManager = new CarManager();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Car Rental Management System:");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View All Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");

                string option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.Clear();
                        Createcar(carManager);
                        break;
                        case "2":
                        Console.Clear();
                        carManager.ReadCars();
                        break;
                        case "3":
                        Console.Clear();
                        Updatecar(carManager);
                        break;
                        case "4":
                        Console.Clear();
                        DeleteCar(carManager);
                        break;
                        case "5":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                    
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                }
            }

            static void Createcar(CarManager carManager)
            {
                Console.WriteLine("Enter car id");
                string id = Console.ReadLine();
                Console.WriteLine("Enter car brand");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter car model");
                string model = Console.ReadLine();
                Console.WriteLine("Enter rental price");
                decimal price = decimal.Parse(Console.ReadLine());

                carManager.CreateCar(id, brand, model, price);
            }
            static void Updatecar(CarManager carManager)
            {
                Console.WriteLine("Enter car id to update");
                string id = Console.ReadLine();
                Console.WriteLine("Enter new brand");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter new model");
                string model = Console.ReadLine();
                Console.WriteLine("Enter new rental price");
                decimal price = decimal.Parse(Console.ReadLine());

                carManager.UpdateCar(id, brand, model, price);
            }

            static void DeleteCar(CarManager carManager)
            {
                Console.WriteLine("Enter car id");
                string id = Console.ReadLine();
               

                carManager.DeleteCar(id);
            }
        }
    }
}
