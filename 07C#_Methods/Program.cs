using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07C__Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //() kinda like functions on C
            //Void non-return method

            //void CustomerList()
            //{
            //    Console.WriteLine("Safa Gökalp Uğur");
            //    Console.WriteLine("Sinem Karadeli");
            //    Console.WriteLine("Niyazi Uğur");
            //}
            //CustomerList();


            //void Sum()
            //{
            //    int x = 6;
            //    int y = 19;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Non-return string parameter Methods

            //void WriteMethod(string customername)
            //{
            //    Console.WriteLine(customername);
            //}
            //WriteMethod("Safa Gökalp Uğur");


            //void CustomerCard(string name,string surname)
            //{
            //    Console.Write(name);
            //    Console.WriteLine(" "+surname);
            //}

            //Console.Write("Plese enter your name : ");
            //string id = Console.ReadLine();

            //Console.Write("Please enter your surname : ");
            //string surn =Console.ReadLine();

            //CustomerCard(id, surn);
            #endregion

            #region Non-return int parameter Methods

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 54, 2);

            #endregion

            #region Returnable Methods

            //string Name()
            //{
            //    return "Safa Gökalp Uğur";
            //}

            //Console.WriteLine(Name());


            //string StudentCard()
            //{
            //    string name = "Safa Gökalp";
            //    string surname = "Uğur";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Returnable String parameter Methods

            //string CountryCard(string Country,string Capital,string number)
            //{
            //    string Cardİnfo = "Country : " + Country + " - Capital : " + Capital + " - Number : " + number;
            //    return Cardİnfo;
            //}

            //Console.Write("Please enter your country : ");
            //string country = Console.ReadLine();

            //Console.Write("Please enter your countrys capital : ");
            //string capital = Console.ReadLine();

            //Console.Write("Please enter your flight number : ");
            //string flight = Console.ReadLine();

            //Console.WriteLine(CountryCard(country,capital,flight));
            #endregion

            #region Returnable İnt parameter Methods

            //int Sum(int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(13,45));
            //Console.WriteLine(Sum(231,63));
            //Console.WriteLine(Sum(97,49));


            //string ExamsResult()
            //{
            //    Console.Write("Please enter how many exams you took : ");
            //    int exams = int.Parse(Console.ReadLine());

            //    int total = 0;
            //    for(int i = 0; i < exams; i++)
            //    {
            //        Console.Write("Please enter your " + (i+1) + ". exam score : ");
            //        int score = int.Parse(Console.ReadLine());
            //        total += score;
            //    }
            //    double result = (double)total / exams;
                
            //    if(result > 50)
            //    {
            //        return "Your exam avarage is " + result + ". You passed!";
            //    }
            //    else
            //    {
            //        return "Your exam avarage is " + result + ". You failed!";
            //    }
            //}

            //Console.WriteLine(ExamsResult());
            #endregion

            Console.Read();
        }
    }
}
