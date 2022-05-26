using System;

namespace _1007_Diference
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int c = Convert.ToInt32(Console.ReadLine());
      int d = Convert.ToInt32(Console.ReadLine());

      int diferenca = (a * b) - (c * d);

      Console.WriteLine($"DIFERENCA = {diferenca}");
    }
  }
}