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

                    
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}
