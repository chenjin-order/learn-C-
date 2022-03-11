using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculators;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, result = 0;

            Console.WriteLine("请输入操作符：+，-，*，/");
            var op = Console.ReadLine();

            Console.WriteLine("请输入操作数X");
            var operandX=Console.ReadLine();
            Console.WriteLine("请输入操作数Y");
            var operandY = Console.ReadLine();

            x= int.Parse(operandX);
            y= int.Parse(operandY);
            IBinarycomputing computing;

            switch (op)
            {
                default:
                    computing = new Addition();
                    break;
                case "-":
                    computing = new Subtraction();
                    break;
                case "*":
                    computing = new Multiplication();
                    break;
                case "/":
                    computing = new Division();
                    break;
            }

            result = computing.Calculate(x, y);
            Console.WriteLine(result);
        }
    }
}
