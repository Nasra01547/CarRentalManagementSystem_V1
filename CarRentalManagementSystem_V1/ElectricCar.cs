using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class ElectricCar:Car
    {
   

        public int BatteryCapacity { get; set; }
        public int MotorPower { get; set; }

        public ElectricCar(string CarId, string Brand, string Model, decimal RentalPrice,int batteryCapacity, int motorPower) : base(CarId, Brand, Model, RentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;
        }

        public string DisplayElectricCarInfo()
        {
            return $"ID: {carId}, Brand: {brand}, Model: {model}, RentalPrice: {rentalPrice}, BatteryCapacity:{BatteryCapacity},MotorPower :{MotorPower}";

        }

        public override string DisplayCarInfo()
        {
            return $"{base.DisplayCarInfo()},BatteryCapacity:{BatteryCapacity},MotorPower:{MotorPower}";
        }
    }
}
