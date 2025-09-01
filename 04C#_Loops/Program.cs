using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04C__Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loops

            //For(x;y;z) x: start, y: end, z: increase-decrease

            //int i;
            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine("Hello World");
            //}


            //for(int i=0;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for(int i=3;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //int num1,count=0;
            //Console.Write("Please enter a number : ");
            //num1 = int.Parse(Console.ReadLine());

            //if (num1 <= 1)
            //{
            //    Console.WriteLine("Please enter a number bigger than 1!");
            //}
            //else if(num1>1)
            //{
            //    for (int i = 2; i < num1; i++)
            //    {
            //        if (num1 % i == 0)
            //        {
            //            count++;
            //        }

            //    }
            //    if (count == 0)
            //    {
            //        Console.WriteLine("Your number is a prime number");
            //    }
            //    else if (count != 0)
            //    {
            //        Console.WriteLine("Your number is not a prime number");
            //    }
            //}
            #endregion

            #region While Loops

            //while(condition){operation}

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}


            //int num1,i=1;
            //Console.Write("Enter a number : ");
            //num1 = int.Parse(Console.ReadLine());

            //while(i<=num1)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //klavyeden girilen 3 basamaklı sayının basamaklşarı toplamını bulan kod yaz

            //int num,sum = 0,ones,tens,hundereds;
            //Console.Write("Enter a 3-digit number : ");
            //num = int.Parse(Console.ReadLine());

            //ones = num % 10;
            //tens = (num % 100) / 10;
            //hundereds = num / 100;

            //sum = ones + tens + hundereds;

            //Console.WriteLine(sum);
            #endregion

            #region Stars with loop

            //for(int i = 1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}


            //Alt alta her satırda 10 * olan 10 satırlık * grubu
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Right angled triangle
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Reverse right angled triangle
            //for(int i = 1;i<=5;i++)
            //{
            //    for(int j = 5; j>=i;j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //half diamond
            //for(int i=1;i<=5;i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int k=1;k<=5;k++)
            //{
            //    for(int l=5;l>=k;l--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Pyramid
            //for(int i=1;i<=5;i++)
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=i*2-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //*********    0   9   1   
            // *******     1   7   2
            //  *****      2   5   3
            //   ***       3   3   4
            //    *        4   1   5




            //Reverse Pyramid 
            //int n = 6;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - 1; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i * 2 - 1; k >= 1; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();

        }
    }
}
