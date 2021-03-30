using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Method
            //Print();
            //Sum(5, 6); //5,6 -arguments
            //Console.WriteLine(Sum(15, 16));
            //Check(20);
            //Sum(1, 6);
            //Sum(b:5,a:20);
            //Console.WriteLine(SumArr(new int[] { 1,2,3,4,5}));
            //Console.WriteLine(SumArr(1,2,3,4,5));

            //int a = 5;
            //var b = 5; //compile
            //dynamic c = 5; //runtime

            //c = "word";
            //c = 0.5;
            //c = ' ';
            #endregion

            Info("Kamran","Test","Test1");
        }

        #region Method overloading
        //Method signature - name of method,parametrs count, parametrs type
        static void Info(string name)
        {
            Console.WriteLine(name);
        }

        static void Info(string name, string surname = "Jabiyev")
        {
            Console.WriteLine($"{name} {surname}");
            //Console.WriteLine(name+" "+surname);
        }

        static void Info(params string[] arr)
        {
            string str = "";
            foreach (string item in arr)
            {
                str += item;
            }
            Console.WriteLine(str);
        }

        static void Info(char letter)
        {
            Console.WriteLine(letter);
        }
        #endregion


        #region Method Start
        static int SumArr(params int[] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                if (item % 2 != 0)
                    result += item;
            }
            return result;
        }

        static int Sum(int a,int b=1) //a,b - parametrs
        {
            if (a > b)
            {
                return a + b;
            }
            return 0;
        }

        static void Check(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Xosh gelmishsiniz");
                return;
            }
            Console.WriteLine("Get boyuyun gelsin!");
        }

        static void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.ResetColor();
        }
        #endregion
    }


}
