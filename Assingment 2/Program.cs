using System;

namespace Assingment_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("*************************Calculator*************************");
            Console.WriteLine("These Are Your Commands:");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");
            Console.WriteLine("c : Clear");
            Console.WriteLine("e : Exit");
            Console.Write("Enter The First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()), num2 = default;
            while (k == 0)
            {
                Console.Write("Choose A Command: ");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.Write("Enter The Second Number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        num1 = num1 + num2;
                        Console.WriteLine($"The Answer is {num1}, You Can Choose Another Command For This Number:");
                        break;
                    case "-":
                        Console.Write("Enter The Second Number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        num1 = num1 - num2;
                        Console.WriteLine($"The Answer is {num1}, You Can Choose Another Command For This Number:");
                        break;
                    case "/":
                        Console.Write("Enter The Second Number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        while (num2 == 0)
                        {
                            Console.Write("A Number Can Not Be Divided By O, Enter Another Number Instead Of Zero: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        num1 = num1 / num2;
                        Console.WriteLine($"The Answer is {num1}, You Can Choose Another Command For This Number:");
                        break;
                    case "*":
                        Console.Write("Enter The Second Number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        num1 = num1 * num2;
                        Console.WriteLine($"The Answer is {num1}, You Can Choose Another Command For This Number:");
                        break;
                    case "c":
                        Console.Write("Enter A New Number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "e":
                        k = 1;
                        break;
                }
            }
        }
    }
}
