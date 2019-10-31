using System;

namespace Calculator
{
  class CalcLogic
  {
    public void Calcuate(int num1, int num2, string MathOperator)
    {
      switch (MathOperator)
      {
        case "+":
          Console.WriteLine("Result: {0}", num1 + num2);
          break;
        case "-":
          Console.WriteLine("Result: {0}", num1 - num2);
          break;
        case "*":
          Console.WriteLine("Result: {0}", num1 * num2);
          break;
        case "/":
          Console.WriteLine("Result: {0}", num1 / num2);
          break;
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      int num1;
      int num2;
      string op;

      CalcLogic calculator = new CalcLogic();

      Console.WriteLine("First number: ");
      num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Second number: ");
      num2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Operator: ");
      op = Console.ReadLine().ToString();

      calculator.Calcuate(num1, num2, op);
    }
  }
}
