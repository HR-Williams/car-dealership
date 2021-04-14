using System;
using System.Collections.Generic;
public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}
public class Program
{
  public static void Main()
  {  
    Car volkswagon = new Car();
    volkswagon.MakeModel = "1974 Volkswagon Thing";
    volkswagon.Price = 1100;
    volkswagon.Miles = 368792;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 239001;

    Car ford = new Car();
    ford.MakeModel = "1988 Ford Country Squire";
    ford.Price = 1400;
    ford.Miles = 239001;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 400;
    amc.Miles = 198000;

    List<Car> Cars = new List<Car>() { volkswagon, yugo, ford, amc };
    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    foreach (Car automobile in Cars)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}