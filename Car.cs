using System;
using System.Collections.Generic;
public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}
public class Program
{
  public static void Main()
  {  
    Car volkswagon = new Car();
    volkswagon.MakeModel = "1974 Volkswagen Thing";
    volkswagon.Price = 1100;
    volkswagon.Miles = 368792;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 239001;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 400;
    amc.Miles = 198000;
  }
}