using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();
                int[] numbers = new int[10];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = random.Next(-10, 11);
                }
                Console.WriteLine("Сгенерированный массив: " + string.Join(", ", numbers));
                int sumPositive = 0;
                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        sumPositive += number;
                    }
                }
                Console.WriteLine("Сумма положительных чисел: " + sumPositive);
                Console.ReadLine();
            
        }
    }
}
