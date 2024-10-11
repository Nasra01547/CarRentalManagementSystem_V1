using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class CarManager
    {
        
     
       public List<Car> cars;

       

        public CarManager()
        {
            cars = new List<Car>();
        }

        public void CreateCar(string id,string brand, string model,decimal price)
        {
            Car car = new Car(id,brand,model,price);
            cars.Add(car);
            Console.WriteLine("Create car successfully");
        }

        public void ReadCars()
        {
            if(cars != null)
            {
                foreach(var car in cars)
                {
                    Console.WriteLine(car.ToString());
                }
            }
            else
            {
                Console.WriteLine("Cars not available");
            }
        }

        public void UpdateCar(string id, string brand, string model,decimal price)
        {
            var car = cars.Find(car => car.carId == id);
            if(car != null)
            {
                car.brand = brand;
                car.model = model;
                car.rentalPrice = price;
                Console.WriteLine("car updated successfully");
            }
            else
            {
                Console.WriteLine("car id not found");
            }
        }

        public void DeleteCar(string id)
        {
            var car = cars.Find(car => car.carId == id);
            if(car != null)
            {
                cars.Remove(car);
                Console.WriteLine("car deleted successfully");
            }
            else
            {
                Console.WriteLine("car id not found");
            }
        }

        public decimal ValidateCarRentalPrice()
        {
            decimal price;

            while(true)
            {
                Console.WriteLine("Enter rental price");
                if(decimal.TryParse(Console.ReadLine(), out price)&& price > 0)
                {
                    return price;
                }
                else
                {
                    Console.WriteLine("Invalid price... enter positive value");
                }
            }
        }
    }
}
