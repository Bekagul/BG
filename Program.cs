using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersMas = new int[10];
            int numb = 0;
            Console.WriteLine("pls enter 10 numbers :");
            for (int i = 0; i < numbersMas.Length; i++)
            {
                numbersMas[i] = InsertNumbers(numb);
            };
            Console.WriteLine("thinking,.........");
            Console.WriteLine("sorted array is:");
            MathSort(numbersMas);
            Console.WriteLine("highest number-lower is:");
            var answer = HighestMinusLowest(numbersMas);
            Console.WriteLine(answer);
            Console.WriteLine("is odd or even?");
            OddOrEven(numbersMas);
            Console.WriteLine($"Sum off array is: {SumOfArray(numbersMas)}");
            Console.WriteLine("goodbye");

            static int InsertNumbers(int number)
            {
                number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            static void MathSort(params int[] sortMath)
            {
                int MaxValue;
                for (int i = 0; i < sortMath.Length; i++)
                {
                    for (int j = i + 1; j < sortMath.Length; j++)
                    {
                        if (sortMath[i] > sortMath[j])
                        {
                            MaxValue = sortMath[i];
                            sortMath[i] = sortMath[j];
                            sortMath[j] = MaxValue;
                        }
                    }
                }
                for (int i = 0; i < sortMath.Length; i++)
                {
                    Console.WriteLine(sortMath[i]);
                }
            }

            static int HighestMinusLowest(params int[] array)
            {
                int lowest = 0;
                int highest = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    highest = array[0];
                    if (highest < array[i])
                    {
                        highest = array[i];
                    }
                    lowest = array[0];
                    if (highest < array[i])
                    {
                        highest = array[i];
                    }
                }
                return highest - lowest;
            }
            static void OddOrEven(params int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        Console.WriteLine($"{array[i]} is Odd");
                    }
                    else if (array[i] % 2 == 0 && array[i] % 3 == 0)
                    {
                        Console.WriteLine($"{array[i]} is even");
                    }
                    else
                    {
                        Console.WriteLine($"I am not sure but i think {array[i]} is Odd ");
                    }
                }
            }
            static int SumOfArray(params int[] array)
            {
                int answer = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    answer = answer + array[i];
                }
                return answer;
            }
        }
    }
}

