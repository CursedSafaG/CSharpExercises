using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05C__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Series

            ////variable_type[] array_name = new variable_type[number of element]
            //string[] colors = new string[4];
            //colors[0] = "White";
            //colors[1] = "Red";
            //colors[2] = "Blue";
            //colors[3] = "Black";

            //Console.WriteLine(colors[2]);


            //int[] numbers = new int[41];
            //numbers[10] = 83;
            //numbers[19] = 2873;
            //numbers[24] = 1238;
            //numbers[38] = 896;

            //Console.WriteLine(numbers[38]);
            //Console.WriteLine(numbers[1]);


            //string[] cities = { "İstanbul", "Hatay", "Adana", "Düzce" };

            //Console.WriteLine(cities[1]);

            #endregion

            #region Series Examples

            //int[] numbers = { 19, 26, 20, 17, 84, 34 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 27823, 8329, 261, 2397, 24, 86, 23, 41 };

            //for(int i = 0; i < numbers.Length;i++)
            //{
            //    if (numbers[i]%3 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //int[] numbers = { 23, 8329, 261, 2397, 24, 86, 20, 41 };
            //int maxnumber = numbers[0];

            //for(int i = 0;  i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxnumber)
            //    {
            //        maxnumber = numbers[i];
            //    }
            //}

            //Console.WriteLine(maxnumber);


            //string[] persons = { "Ali", "Babatürk", "Safa", "Berşan", "Renda" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 5, 123, 234, 75, 28, 442 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 5, 123, 234, 75, 28, 442 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Series Methods

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);


            //int[] numbers = { 21, 43, 732, 96, 1, 676 };
            //Console.WriteLine("Max value of array : " + numbers.Max() + " Min value of array : " + numbers.Min());


            //int[] numbers = new int[4];

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.Write("Enter a number : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //for(int k = 0; k<numbers.Length; k++)
            //{
            //    Console.WriteLine(numbers[k]);
            //}


            //int[] numbers = { 21, 412, 64, 23, 85, 4, 64, 97 };
            //Console.WriteLine("Even numbers :");

            //for(int i = 0;i<numbers.Length;i++)
            //{
            //    if (numbers[i]%2==0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Odd numbers :");

            //for (int k = 0;k<numbers.Length;k++)
            //{
            //    if(numbers[k]%2==1)
            //    {
            //        Console.WriteLine(numbers[k]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }   
        
}
