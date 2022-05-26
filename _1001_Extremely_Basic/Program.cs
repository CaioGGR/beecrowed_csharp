using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int soma = a + b;

    Console.WriteLine($"X = {soma}");
  }
}