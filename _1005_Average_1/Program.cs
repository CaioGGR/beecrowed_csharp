using System;

namespace _1005_Average_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      double a = Convert.ToDouble(Console.ReadLine());
      double b = Convert.ToDouble(Console.ReadLine());

      double pesoa = a * 3.5;
      double pesob = b * 7.5;

      double media = (pesoa + pesob) / (3.5 + 7.5);

      Console.WriteLine($"MEDIA = {media.ToString("f5")}");
    }
  }
}