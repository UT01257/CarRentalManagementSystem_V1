namespace CarRentalManagementSystem_V1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager();
            //CarRepository repository = new CarRepository();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Car Rental Management");
                Console.WriteLine("1. Add a new car");
                Console.WriteLine("2. view All car");
                Console.WriteLine("3. Update a car");
                Console.WriteLine("4. Delete a car");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        CreateCar(manager);
                        break;
                    case "2":
                        Console.Clear();
                        manager.ReadCars();
                        break;
                    case "3":
                        Console.Clear();
                        UpdateCar(manager);
                        break;
                    case "4":
                        Console.Clear();
                        DeleteCar(manager);
                        break;
                    case "5":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please Choose Valid Actions");
                        break;

                }
                if (!exit)
                {
                    Console.WriteLine("Press enter to continue.......");
                    break;
                }


            }
        }

        static void CreateCar(CarManager manager)
        {
            Console.WriteLine("Enter Car ID: ");
            string carId = Console.ReadLine();
            Console.WriteLine("Enter Car Brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter Car Model: ");
            string model = Console.ReadLine();
            //Console.WriteLine("Enter Valid Price:");
            //decimal price = decimal.Parse(Console.ReadLine());
            decimal price = manager.ValidateCarRentalPrice();

            manager.CreateCar(carId, brand, model, price);
           
        }

        static void UpdateCar(CarManager manager)
        {
            Console.WriteLine("Enter Car Id to find car");
            string carId = Console.ReadLine();
            Console.WriteLine("Enter New Brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter New model");
            string model = Console.ReadLine();
            decimal price = manager.ValidateCarRentalPrice();

            manager.UpdateCar(carId, brand, model, price);


        }

        static void DeleteCar(CarManager manager)
        {
            Console.WriteLine("Enter Car Id to delete Car: ");
            string carId = Console.ReadLine();
            manager.DeleteCar(carId);
  

        }
    }
    
}
