using System;

namespace _1006_Average_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      double a = Convert.ToDouble(Console.ReadLine());
      double b = Convert.ToDouble(Console.ReadLine());
      double c = Convert.ToDouble(Console.ReadLine());

      double pesoa = a * 2.0;
      double pesob = b * 3.0;
      double pesoc = c * 5.0;

      double media = (pesoa + pesob + pesoc) / 10;

      Console.WriteLine($"MEDIA = {media.ToString("f1")}");
    }
  }
}