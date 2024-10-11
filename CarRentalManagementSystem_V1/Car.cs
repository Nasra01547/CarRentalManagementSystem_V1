using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class Car
    {
        public string carId {  get; set; }
        public string brand {  get; set; }
        public string model { get; set; }
        public decimal rentalPrice {  get; set; }
        public int TotalCars { get; private set; } = 0;

        public Car(string CarId, string Brand, string Model, decimal RentalPrice)
        {
            carId = CarId;
            brand = Brand;
            model = Model;
            rentalPrice = RentalPrice;
            TotalCars++;
        }

        public override string ToString()
        {
            return $"ID: {carId}, Brand: {brand}, Model: {model}, RentalPrice: {rentalPrice}";
        }

        public virtual string DisplayCarInfo()
        {
            return $"ID: {carId}, Brand: {brand}, Model: {model}, RentalPrice: {rentalPrice}";

        }


    }
}
