using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Second_DayCSharp
{
    internal class Program
    {

        //static void printMsg() {
        //    Console.WriteLine("Welcome");
        //}


        //static void printName(string name)
        //{
        //    Console.WriteLine("Welcome "+name);
        //}


        //static float printNumber()
        //{
        //    return 3.4f;
        //}


        //static string info(string name, int age)
        //{
        //    //return "Your Name " + name + "and Your Age " + age;

        //    return $"Your Name is {name} and Your Age is {age}";
        //}


        //static void arrangedArray(int[] arr)
        //{
        //    Array.Sort(arr);

        //   foreach (int i in arr) {
        //        Console.WriteLine(i);
        //    }
        
        //}


        //static int [] arrangedArray1(int[] arr)
        //{
        //    Array.Sort(arr);
        //    return arr;

        //}


        //static string  swap(ref int x, ref int y) {
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;

        //    return $"After Sawpping Num1 {x} Num2 {y}";
        //}


        //static int FactNumber(int number)
        //{
        //    int res = 1;
        //    while (number > 1) {
        //        res *= number;
        //        number--;
        //    }

        //    return res;
        //}

        //static int Fact(int number)
        //{
        //    if (number == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return number * Fact(number-1);
        //    }
        //}

        static void Main(string[] args)
        {

			#region Assignment

            //•	Program to add two matrix[2D Array] and put the result in a third one, then print the result.
            //•	Program to find Sum &Average of 2D Array.
            //•	Program to Find the Frequency of Characters in a String
            //•	Program to Remove all Characters in a String Except Alphabet
            //•	Write a function takes array as parameter, and returns the largest number.
            //•	Program that takes an array of integers and pass that array to a function to print array values after multiplying them to 10.
            //•	Make function that calculate the sum of numbers from 1 to n using recursion.
            //•	Make recursion function that get the GCD for a number.

			#endregion

			#region  Array
			// Array => FixedSize , The Same DataType
			//int [] numbers = new int[5];
			//int[] numbers = new int[] { 1,2,3,4};
			//int [] number;
			//number = new int[5];

			//string[] names = new string[3];
			// //Set values in array
			//names[0] = "Nawal";
			//names[1] = "Ahmed";
			//names[2] = "Sarah";
			// names[3] = "Mohammed";
			// Get Values From Array
			// Console.WriteLine(names[3]);

			//for (int i = 0; i < 3; i++) {
			//    Console.WriteLine(names[i]);
			//}

			//for (int i = 0; i < names.Length; i++)
			//{
			//    Console.WriteLine(names[i]);
			//}


			//foreach (string name in names)
			//{
			//    Console.WriteLine(name);
			//}

			//foreach (var name in names)
			//{
			//    Console.WriteLine(name);
			//}

			//int j = 0;
			//while (j < 3)
			//{
			//    Console.WriteLine(names[j]);
			//    j++;
			//}


			//int size;
			//Console.WriteLine("Enter Your Size of Your Array !");
			//size = int.Parse(Console.ReadLine());

			//string[] Names = new string[size];

			//for (int i=0;i<Names.Length;i++)
			//{
			//    Console.WriteLine("Enter Your Name :");
			//    Names[i] = Console.ReadLine();
			//}


			//Console.WriteLine("Your Names are :");

			//foreach (string name in Names) {

			//    Console.WriteLine(name);
			//}






			#endregion

			#region  Array 2D
			//  [row,col]
			int[,] numbers = new int[2, 3];
            numbers[0, 2] = 10;


            for (int i = 0; i < 2; i++)  // i=1
            {
                for (int j = 0; j < 3; j++) //J=0
                {
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)  // i=1
            {
                for (int j = 0; j < 3; j++) //J=0
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            #endregion

            #region   ArrayList

            // Dynamic Size , Not The Same DataType

            //ArrayList arr = new ArrayList();
            //arr.Add("Nawal");
            //arr.Add(1);
            //arr.Add(true);
            //arr.Add(2.3);
            //arr.Add(3.4f);
            //arr.Add(true);
            //arr.Add('A');
            //arr.Remove(true);
            //arr.RemoveAt(5);
            //int[] numbers = new int[] { 1, 2, 3 };
            //arr.AddRange(numbers);
            //arr.Insert(2,"New Element");
            //arr.InsertRange(3, numbers);
            //  arr.Count
            //foreach(var item in arr) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            // DynamicSize , The Same DataType
            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.Sort();
            //numbers.Count();
            //numbers.AddRange(numbers);
            //numbers.InsertRange(2,numbers);
            //numbers.Insert(2, 3);
            //numbers.Reverse();




            #endregion

            #region  Dictionary

            // Dictionary<char,int> grades = new Dictionary<char, int>();

            // grades.Add('A', 100);
            // grades.Add('B', 90);
            // grades.Add('C', 80);
            // grades.Add('D', 70);

            // //char letter;
            // //int grade;
            // //Console.WriteLine("Enter Your Letter:");
            // //letter =char.Parse(Console.ReadLine());

            // //Console.WriteLine("Enter Your Grade:");
            // //grade = int.Parse(Console.ReadLine());


            // //grades.Add(letter, grade);

            // grades['A'] = 3000000;  //Change Value of Key ==> A

            // foreach (var item in grades)
            // {
            //     Console.WriteLine(item);
            //     //Console.WriteLine(item.Value);
            //     //Console.WriteLine(item.Key);
            // }



            // Console.WriteLine("Enter Your Letter to Find it");
            // char searchedLetter=char.Parse(Console.ReadLine());
            // bool res=grades.ContainsKey(searchedLetter);
            // if (res == true)
            // {
            //     Console.WriteLine("Your Letter is Founded");
            //     Console.WriteLine("The Of Value of Your Letter is " + grades[searchedLetter]);
            // }
            // else
            // {
            //     Console.WriteLine("Your Letter is not Founded");
            // }


            //bool res2= grades.Contains(new KeyValuePair<char, int>('C', 80));

            // Console.WriteLine(res2);

            //Console.WriteLine(grades['A']);



            //bool res=grades.ContainsKey('A');

            //bool res1 = grades.ContainsValue(20);

            //Console.WriteLine(res1);



            //foreach (char item in grades.Keys)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (int item in grades.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Functions

            //printMsg();

            //printName("Nawal");

            //float res = printNumber();
            //Console.WriteLine(res);



            //Console.WriteLine(info("Ali",20));


            //int[] numbers = new int[] { 2, 7, 1, 3, 4 };
            //arrangedArray(numbers);


            //int[] res = arrangedArray1(numbers);


            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}

            // int num1 = 10, num2 = 20;
            // Console.WriteLine("Before Swapping");
            // Console.WriteLine("Num1 :"+num1);
            // Console.WriteLine("Num2 :" + num2);
            ////string res=  swap(num1, num2);  // Passing By Value 
            // string res = swap( ref num1, ref num2);  // Passing By Ref. 

            // Console.WriteLine(res);


            // Console.WriteLine("After Swapping");
            // Console.WriteLine("Num1 :" + num1);
            // Console.WriteLine("Num2 :" + num2);


            //Console.WriteLine(Fact(5));


            #endregion





        }
    }
}
