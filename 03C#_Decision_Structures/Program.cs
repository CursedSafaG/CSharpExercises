using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03C__Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            //Console.Write("Please enter the Password : ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Correct Password!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Password!");
            //}


            //string capital, country;

            //Console.Write("Enter Country : ");
            //country = Console.ReadLine();

            //Console.Write("Enter Capital : ");
            //capital = Console.ReadLine();

            //if (country == "Turkey" & capital == "Ankara")
            //{
            //    Console.WriteLine("Correct Answer!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Answer!");
            //}


            //int number;
            //Console.Write("Enter a number : ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("The number that you entered is true");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong number");
            //}


            //int exam1, exam2, exam3,average;
            //Console.Write("Enter your first exam point : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter your second exam point : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter your third exam point : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Your exam average is : " + average);

            //if(average >= 0 & average < 50)
            //{
            //    Console.WriteLine("You failed the class!");
            //}
            //else if(average >=50 & average <=100)
            //{
            //    Console.WriteLine("You passed the class!");
            //}


            //string temp,username;
            //Console.Write("Please enter you username : ");
            //temp = Console.ReadLine();
            //username = temp.ToLower();

            //if(username == "admin")
            //{
            //    Console.WriteLine("Welcome!");
            //}
            //else if(username != "admin")
            //{
            //    Console.WriteLine("Wrong Username!");
            //}



            #endregion

            #region Mod Calculations

            //int number = 26, result;
            //result = number % 5;
            //Console.WriteLine(result);


            //int num1, num2, mod;
            //Console.Write("Enter your first number : ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter your second number : ");
            //num2 = int.Parse(Console.ReadLine());

            //mod = num1 % num2;

            //Console.WriteLine("1st numbers mod by 2nd number is : " + mod);


            //int num;
            //Console.Write("Enter a number : ");
            //num = int.Parse(Console.ReadLine());

            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("Your number is Even.");
            //}
            //else if(num % 2 == 1)
            //{
            //    Console.WriteLine("Your number is Odd.");
            //}
            #endregion

            #region Char if else

            //int team;
            //Console.Write("Enter a soccer teams initial : ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Your team is Galatasaray");
            //}
            //else if(team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Your team is Fenerbahçe");
            //}
            //else if(team == 'B' | team == 'b' )
            //{
            //    Console.WriteLine("Your team is Beşiktaş");
            //}
            //else if(team == 'T' | team == 't')
            //{
            //    Console.WriteLine("Your team is Trabzonspor");
            //}

            #endregion

            #region Project

            //int selection;

            //Console.WriteLine("***** Restaurant Menu *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("1-Main Course");
            //Console.WriteLine("2-Side dish");
            //Console.WriteLine("2-Sweets");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();
            //Console.Write("To see dishes please select a category : ");
            //selection = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (selection == 1)
            //{
            //    Console.WriteLine("--------------------Main Course--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Fried chicken");
            //    Console.WriteLine("2-Mushroom with cheese");
            //    Console.WriteLine("3-Beef");
            //}
            //else if (selection == 2)
            //{ 
            //    Console.WriteLine("--------------------Side Dishes--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-French fries");
            //    Console.WriteLine("2-Spring roll");
            //    Console.WriteLine("3-Haydari");
            //}
            //else if (selection == 3)
            //{

            //    Console.WriteLine("--------------------Sweets--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Pudding");
            //    Console.WriteLine("3-Kadayıf");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Please enter a months number : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1:Console.Write("January"); break;
            //    case 2:Console.Write("February"); break;
            //    case 3:Console.Write("March"); break;
            //    case 4: Console.Write("April"); break;
            //    case 5: Console.Write("May"); break;
            //    case 6: Console.Write("June"); break;
            //    case 7: Console.Write("July"); break;
            //    case 8: Console.Write("August"); break;
            //    case 9: Console.Write("September"); break;
            //    case 10: Console.Write("October"); break;
            //    case 11: Console.Write("November"); break;
            //    case 12: Console.Write("December"); break;
            //    default: Console.Write("Wrong month number!");break;
            //}


            //int num1, num2, result;
            //char calc;

            //Console.Write("Please enter number 1 : ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter number 2 : ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the calculation you want to do : ");
            //calc = char.Parse(Console.ReadLine());

            //switch(calc)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine(num1 + " + " +  num2 + " = " + result);break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine(num1 + " - " + num2 + " = " + result); break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine(num1 + " / " + num2 + " = " + result); break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine(num1 + " * " + num2 + " = " + result); break;
            //    default: Console.WriteLine("Wrong command!");break;
            //}


            #endregion

            Console.Read();
        }
    }
}
