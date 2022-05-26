using System;

namespace _1009_Salary_With_Bonus
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      string nome = Console.ReadLine();
      double salario = Convert.ToDouble(Console.ReadLine());
      double vendas = Convert.ToDouble(Console.ReadLine());

      double salarioTotal = ((15 / 100.0) * vendas) + salario;

      Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("f2")}");

    }
  }
}