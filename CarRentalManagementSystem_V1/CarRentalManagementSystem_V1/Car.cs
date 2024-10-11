using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    internal class Car
    {
        public string CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        public static int TotalCars { get; private set; } 

        public Car(string carId, string brand, string model, decimal rentalPrice)
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
            TotalCars++;
        }

        public virtual string DisplayCarInfo()
        {
            return $"Car ID: {CarId}, Brand: {Brand}, Model: {Model}, Rental Price: {RentalPrice:C}";
        }

        public override string ToString()
        {
            return DisplayCarInfo();
        }
    }

    internal class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int MotorPower { get; set; }

        public ElectricCar(string carId, string model, string brand, decimal rentalPrice, int batteryCapacity, int motorPower)
            : base(carId, brand, model, rentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;
        }

        public override string DisplayCarInfo()
        {
            return base.DisplayCarInfo() +
                   $", Battery Capacity: {BatteryCapacity} kWh, Motor Power: {MotorPower} HP";
        }
    }

    internal class PetrolCar : Car
    {
        public int FuelTankCapacity { get; set; }
        public int EngineCapacity { get; set; }

        public PetrolCar(string carId, string model, string brand, decimal rentalPrice, int fuelTankCapacity, int engineCapacity)
            : base(carId, model, brand, rentalPrice)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }

        public override string DisplayCarInfo()
        {
            return base.DisplayCarInfo() +
                   $", Fuel Tank Capacity: {FuelTankCapacity} L, Engine Capacity: {EngineCapacity} CC";
        }
    }
}
