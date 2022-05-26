using System;

namespace _1003_Simple_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      int a, b, soma;

      a = Convert.ToInt32(Console.ReadLine());
      b = Convert.ToInt32(Console.ReadLine());

      soma = a + b;

      Console.WriteLine($"SOMA = {soma}");
    }
  }
}