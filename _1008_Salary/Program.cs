using System;

namespace _1008_Salary
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      int num = Convert.ToInt32(Console.ReadLine());
      int horas = Convert.ToInt32(Console.ReadLine());
      double valor = Convert.ToDouble(Console.ReadLine());

      double salario = horas * valor;

      Console.WriteLine($"NUMBER = {num}");
      Console.WriteLine($"SALARY = U$ {salario.ToString("f2")}");
    }
  }
}