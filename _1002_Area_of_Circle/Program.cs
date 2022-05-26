using System;

namespace _1002_Area_of_Circle
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      double pi = 3.14159;

      double R = Convert.ToDouble(Console.ReadLine()); //precisa ser convert.ToDouble

      double area = pi * Math.Pow(R, 2);

      Console.WriteLine($"A={area.ToString("f4")}");
    }
  }
}