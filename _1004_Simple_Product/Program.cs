using System;

namespace _1004_Simple_Product
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      int a, b, prod;

      a = Convert.ToInt32(Console.ReadLine());
      b = Convert.ToInt32(Console.ReadLine());

      prod = a * b;

      Console.WriteLine($"PROD = {prod}");
    }
  }
}