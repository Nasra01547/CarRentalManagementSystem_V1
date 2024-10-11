using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class PetrolCar : Car
    {
    
        public int FuelTankCapacity { get; set; }
        public int EngineCapacity { get; set; }

        public PetrolCar(string CarId, string Brand, string Model, decimal RentalPrice,int fuelTankCapacity, int engineCapacity) : base(CarId, Brand, Model, RentalPrice)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }

        public string DisplayPetrolCarInfo()
        {
            return $"ID: {carId}, Brand: {brand}, Model: {model}, RentalPrice: {rentalPrice}, FuelTankCapacity:{FuelTankCapacity},EngineCapacity :{EngineCapacity}";

        }

        public override string DisplayCarInfo()
        {
            return $"{base.DisplayCarInfo()},FuelTankCapacity:{FuelTankCapacity},EngineCapacity:{EngineCapacity}";
        }

    }
}
