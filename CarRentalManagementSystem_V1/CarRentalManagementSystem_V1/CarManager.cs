using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1_
{
    internal class CarManager
    {
        public List<Car> Cars;
        public CarManager()
        {
            Cars = new List<Car>();


        }
        public void CreateCar(string carId, string brand, string model, decimal price)
        {
            Car car = new Car(carId, brand, model, price);
            Cars.Add(car);

            Console.WriteLine("Car Add Successfully");
        }

        public void ReadCars()
        {
            if (Cars == null)
            {
                Console.WriteLine("No cars Available");
            }
            else
            {
                Console.WriteLine("Cars List : ");
                foreach (var car in Cars)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }


        public void UpdateCar(string carId, string brand, string model, decimal price)


        {
            var FindCar = Cars.Find(c => c.CarId == carId);
            if (FindCar != null)
            {
                FindCar.Brand = brand;
                FindCar.Model = model;
                FindCar.RentalPrice = price;
                Console.WriteLine("Car Updated Successfully");


            }
            else
            {
                Console.WriteLine("No Car were found");

            }

        }

        public void DeleteCar(string id)
        {
            var FindCar = Cars.Find(c => c.CarId == id);
            if (FindCar != null)
            {
                Cars.Remove(FindCar);
                Console.WriteLine("Car Delete Successfully");

            }
            else
            {
                Console.WriteLine("No Car were found!");
            }
        }

        public decimal ValidateCarRentalPrice()
        {
            decimal price;
            while (true)
            {
                Console.WriteLine("Enter The Car Rental Price : ");
                if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
                {
                    return price;
                }

                Console.WriteLine("Invalid Price! please enter correct value");
            }
        }
    }
}
