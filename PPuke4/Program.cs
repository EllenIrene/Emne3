using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace PPuke4
{
	public class Program
	{
		public class Car
		{
			public string Make
			{
				get; set;
			}

			public string Model
			{
				get; set;
			}

			public int Year
			{
				get; set;
			}

			public string RegistrationNumber
			{
				get;
				set;
			}

			public int Mileage
			{
				get;
				set;
			}

			public Car(string make, string model, int year, string regnr, int kmstand)
			{
				Make = make;
				Model = model;
				Year = year;
				RegistrationNumber = regnr;
				Mileage = kmstand;
			}

			public static Car BMW = new Car("BMW", "3-Serie", 2015, "DF60215", 500000);

			public void UpdateMileGE(int newMilege)
			{
				Mileage = newMilege;

			}

			public class Customer
			{
				public string Name
				{
					get;
					set;
				}
				public List<Car>
					OwnedCars
				{
					get;
					set;
				}
				static List<Car> cars = new List<Car>();
				static List<Car> ownedCars = new List<Car>();

				public static List<Car>
					SearchByYear(int minYear, int maxYear)
				{
					return cars.Where(car => car.Year >= minYear && car.Year <= maxYear).ToList();
				}

				public static List<Car> SearchByMileage(int minMileage, int maxMileage)
				{
					return cars.Where(car => car.Mileage >= minMileage && car.Mileage <= maxMileage).ToList();
				}

				public static void
					BuyCar(Customer customer, Car car)
				{
					cars.Remove(car);
					customer.OwnedCars.Add(car);

				}
				public static void DisplayCarInfo(Car car)

				{
					Console.WriteLine($"Make: {car.Make}");
					Console.WriteLine($"Model :{car.Model}");
					Console.WriteLine($"Year: {car.Year}");
					Console.WriteLine($"Mileage: {car.Mileage}");

				}


				public static void Main(string[] args)
				{
                    Car BMW = new Car("BMW", "3-Serie", 2015, "DF60215", 500000);
                    Car car1 = new Car
					(
						"Toyota",
						" Corolla",
						2010,
						   
						 "ABC123",
						50000);

					cars.Add(car1);
					cars.Add(BMW);

					Menu();


                }

				public static void Menu()
				{
					Console.WriteLine("Hva vil du gjøre?");
					Console.WriteLine("1. Se alle biler");
					Console.WriteLine("2. Søk etter KM-stand");
					Console.WriteLine("3. Søk etter Årsmodell");
					Console.WriteLine("4. Kjøp en bil");
					Console.WriteLine("5. Avslutt");
					var choice = Convert.ToInt32(Console.ReadLine());

					switch (choice)
					{
						case 1:
							Console.Clear();
							ShowAllCarsInList();
							break;
						case 2:
							Console.Clear();
							ShowByMilage();
							break;
						case 3:
							Console.Clear();
							ShowByYear();
                            break;
						case 4:
							Console.Clear();
                            ShowAllCarsInList();
                            break;
						case 5:
							System.Environment.Exit(0);
							break;



                    }

					
				}

				public static void ShowAllCarsInList()
				{
					foreach(var car in cars)
					{
						Console.WriteLine($"Merke: {car.Make}");
					}
				}
				public static void ShowByMilage()
				{
					Console.WriteLine("Hva er minimun antall KM?");
					var ans1 = Convert.ToInt32(Console.ReadLine);
					Console.WriteLine("Hva er maksimum antall KM?");
					var ans2 = Convert.ToInt32(Console.ReadLine());

					for(int i = 0; i<cars.Count; i++)
					{
						if(ans1 <= cars[i].Mileage && ans2 <= cars[i].Mileage)
						{
							Console.WriteLine($"BilMerke: {cars[i].Make}");
							Console.WriteLine($"Modell: {cars[i].Model}");
							Console.WriteLine($"KM-stand: {cars[i].Mileage}");
						}
					}
				}
				public static void ShowByYear()
				{
                    Console.WriteLine("Mimiun fra?");
                    var ans1 = Convert.ToInt32(Console.ReadLine);
                    Console.WriteLine("Maks til?");
                    var ans2 = Convert.ToInt32(Console.ReadLine());

					for (int i = 0;i<cars.Count;i++)
					{
						if( ans1 >= cars[i].Year && ans2 <= cars[i].Year)
						{
                            Console.WriteLine($"BilMerke: {cars[i].Make}");
                            Console.WriteLine($"Modell: {cars[i].Model}");
                            Console.WriteLine($"KM-stand: {cars[i].Year}");
                        }
					}
                }
				public static void BuyCar()
				{
					ShowAllCarsInList();
					Console.WriteLine("Skriv navnet på bilen du vil kjøpe");

					var choice = Console.ReadLine();

					for (int i = 0; i < cars.Count; i++)
					{
						if(choice.ToLower() == cars[i].Make.ToLower())
						{
							cars.Remove(cars[i]);
							ownedCars.Add(cars[i]);
						}
						ShowAllCarsInList(cars);
					}


                }

                

                

                // private string _name;
                // public string GetName()
                // {
                //	return _name;
                // }
            }



		}

	}
}

