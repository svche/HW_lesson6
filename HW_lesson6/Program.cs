using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 1. Ввести с клавиатуры 2 числа. 
 В диапазоне между ними найти сумму чисел и среднее арифметическое. +
 (тут неважно какое число будет большим - первое или второе). +
Привести результат к типу int и проверить четное оно или нет. */

            /* */
            double sum = 0;
            double sumA;
            bool b = true;

            do
            {
                Console.Write("Enter two numbers. They must not be equal.\nEnter number first: ");
                int first = int.Parse(Console.ReadLine());

                Console.Write("Enter number second: ");
                int second = int.Parse(Console.ReadLine());
                    
                if (first > second)
                {
                    for (int i = second; i <= first; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("\nSum of all numbers from {0} to {1} is: {2}", second, first, sum);

                    sumA = sum / ((first - second) + 1);
                    Console.WriteLine("\nArithmetic mean of numbers {0} and {1} is: {2}", second, first, sumA);

                    sum = (int)sum;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("\nSum is odd");
                    } else
                    {
                        Console.WriteLine("Sum is even");
                    }

                    sumA = (int)sumA;
                    if (sumA % 2 == 0)
                    {
                        Console.WriteLine("Arithmetic mean is odd");
                    }
                    else
                    {
                        Console.WriteLine("Arithmetic mean is even");
                    }
                    break;
                }
                else if (second > first )
                {
                    for (int i = first; i <= second; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("\nSum of all numbers from {0} to {1} is: {2}", first, second, sum);

                    sumA = sum / ((second - first) + 1);
                    Console.WriteLine("\nArithmetic mean of numbers {0} and {1} is: {2}", first, second, sumA);

                    sum = (int)sum;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("\nSum is odd");
                    }
                    else
                    {
                        Console.WriteLine("Sum is even");
                    }

                    sumA = (int)sumA;
                    if (sumA % 2 == 0)
                    {
                        Console.WriteLine("Arithmetic mean is odd");
                    }
                    else
                    {
                        Console.WriteLine("Arithmetic mean is even");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Numbers must not be equal. Try again!\n");
                    b = true;
                }
            } while (b);
            


          






            Console.ReadLine();
        }
    }
}
