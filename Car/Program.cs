using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string RegistrationNumber { get; set; }
		public int Mileage { get; set; }

		public void UpdateMileage(int newMileage)
		{
			Mileage = newMileage;
		}
	}

	public class Customer
	{
		public string Name { get; set; }
		public List<Car> OwnedCars { get; set; }
	}

	static List<Car> cars = new List<Car>();

	public static List<Car> SearchByYear(int minYear, int maxYear)
	{
		return cars.Where(car => car.Year >= minYear && car.Year <= maxYear).ToList();
	}

	public static List<Car> SearchByMileage(int minMileage, int maxMileage)
	{
		return cars.Where(car => car.Mileage >= minMileage && car.Mileage <= maxMileage).ToList();
	}

	public static void BuyCar(Customer customer, Car car)
	{
		cars.Remove(car);
		customer.OwnedCars.Add(car);
	}

	public static void DisplayCarInfo(Car car)
	{
		Console.WriteLine($"Make: {car.Make}");
		Console.WriteLine($"Model: {car.Model}");
		Console.WriteLine($"Year: {car.Year}");
		Console.WriteLine($"Registration Number: {car.RegistrationNumber}");
		Console.WriteLine($"Mileage: {car.Mileage}");
	}

	public static void Main(string[] args)
	{
		// Create cars
		Car car1 = new Car
			{ Make = "Toyota", Model = "Corolla", Year = 2010, RegistrationNumber = "ABC123", Mileage = 50000 };
		Car car2 = new Car
			{ Make = "Honda", Model = "Civic", Year = 2015, RegistrationNumber = "DEF456", Mileage = 30000 };

		// Add cars to inventory
		cars.Add(car1);
		cars.Add(car2);

		// Create a customer
		Customer customer = new Customer { Name = "John Doe", OwnedCars = new List<Car>() };

		while (true)
		{
			Console.WriteLine("1. View all cars");
			Console.WriteLine("2. Search by year range");
			Console.WriteLine("3. Search by mileage range");
			Console.WriteLine("4. Buy a car");
			Console.WriteLine("5. Exit");
			Console.Write("Enter your choice: ");
			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					// Display all cars
					foreach (Car car in cars)
					{
						DisplayCarInfo(car);
					}

					break;
				case 2:
					// Search by year range
					Console.Write("Enter min year: ");
					int minYear = Convert.ToInt32(Console.ReadLine());
					Console.Write("Enter max year: ");
				break;	int maxYear = Convert.ToInt32(Console.ReadLine());
			}       
			
		}
	}
}