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
        private string carId {  get; set; }
        private string brand {  get; set; }
        private string model { get; set; }
        private decimal rentalPrice {  get; set; }

        public Car(string CarId, string Brand, string Model, decimal RentalPrice)
        {
            carId = CarId;
            brand = Brand;
            model = Model;
            rentalPrice = RentalPrice;
        }

        public override string ToString()
        {
            return $"ID: {carId}, Brand: {brand}, Model: {model}, RentalPrice: {rentalPrice}";
        }


    }
}
