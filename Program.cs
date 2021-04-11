using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      Car toyota = new Car("1979 Toyota Corolla", 600, 1200000);
      Car secondCar = new Car("1981 Ford Pinto", 200, 36000);
      Car thirdCar = new Car("1990 Chevrolet Cavalier", 800, 127000);

      // string newMakeModel = "1991 Chevrolet Cavalier";
      // thirdCar.MakeModel(newMakeModel);
      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc, toyota, secondCar, thirdCar };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      yugo.Price = 300;

      Console.WriteLine(Car.MakeSound("chugga chugga"));

      foreach(Car automobile in Cars)
      {
        if(automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach (Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("-----------------------");
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.Miles + " miles");
        Console.WriteLine("$" + automobile.Price);
      }

      Console.WriteLine("Can we see somehow a private field of 'toyota' for example?");
      Console.WriteLine(toyota.MakeModel);
      toyota.MakeModel = "1999 Toyota Camry";
      Console.WriteLine(toyota.MakeModel);
    }
  }
}