using System;

namespace Tyd2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();
            task8();
            task9();
            task10();
            task11();
            task12();
        }
          public static void task1()
            {
                int a = 5, b = 5;
               
                if(a == b)
                {
                    Console.WriteLine("{0} and {1} are equal", a, b);
                }
                else
                {
                Console.WriteLine("{0} and {1} are different", a, b);
                }
            Console.ReadKey();
            }
        public static void task2()
        {
            double a;
            Console.WriteLine("Please, enter a number");
            a = double.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number {0} is even number", a);
            }
            else
            {
                Console.WriteLine("Number {0} is odd number", a);
            }
            Console.ReadKey();
        }
        public static void task3()
        {
            double a;
            Console.WriteLine("Please, enter a number");
            a = double.Parse(Console.ReadLine());
            if( a > 0)
            {
                Console.WriteLine("Number {0} is positive number", a);
            }
            else if (a < 0)
            {
                Console.WriteLine("Number {0} is negative number", a);
            }
            else
                Console.WriteLine("Number {0} is 0", a);
            Console.ReadKey();
        }
        public static void task4()
        {
            double a;
            Console.WriteLine("Please, enter a number");
            a = double.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number {0} is even number", a);
            }
            else
            {
                Console.WriteLine("Number {0} is odd number", a);
            }
            Console.ReadKey();
        }
        public static void task5()
        {
            int age;
            Console.WriteLine("Please enter your age");
            age = Int32.Parse(Console.ReadLine());
            if (age >= 21 && age < 30)
            {
                Console.WriteLine("You can become an MP");
            }
            else if (age >= 21 && age >= 30 && age < 35)
            {
                Console.WriteLine("You can become an MP, senator or Prime Minister");
            }
            else if (age >= 21 && age >= 30 && age >= 35)
            {
                Console.WriteLine("You can become an MP, senator, Prime Minister or President");
            }
            else
            {
                Console.WriteLine("I am sorry but you are too young to become a politician");
            }
        }
        public static void task6()
        {
            string height;
            Console.Write("Please enter your height");
            height = Console.ReadLine();
            Int32.TryParse(height, out int chosenHeight);

            if (chosenHeight <= 0)
                Console.WriteLine("You don't exist");
            else
            {
                if (chosenHeight >= 300)
                    Console.WriteLine("You are a Giant!");
                else if (chosenHeight >= 160)
                    Console.WriteLine("You are a Human.");
                else if (chosenHeight >= 140)
                    Console.WriteLine("You are an Elf.");
                else if (chosenHeight >= 120)
                    Console.WriteLine("You are an Dwarf.");
                else 
                        Console.WriteLine("You are a Gnom.");
            }
            Console.ReadKey();
        }
        public static void task7()
        {
            int a, b, c;
            Console.WriteLine("Please, enter first number");
                a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second number");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter third number");
            c = Int32.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The first number is the biggest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The Second number is the biggest");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The third number is the biggest");
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }
        public static void task8()
        {
            int mat = 80, chem = 20, phy = 51;

            if (mat > 70 || phy > 55 || chem > 45 || (mat + phy + chem) > 180)
            {
                Console.WriteLine("Congratulation!! you are approved to join the cours");
            }
            else if (mat + phy > 150 || mat + chem > 150)
            {
                Console.WriteLine("Congratulation!! you are approved to join the cours");
            }
            else
            {
                Console.WriteLine("Sorry you have been rejected for the course");
            }
            Console.ReadKey();

        }
        public static void task9()
        {
            int temp;
            Console.Write("Please, enter current temprature:");
            Int32.TryParse(Console.ReadLine(), out temp);

            if (temp < 0)
            {
                Console.WriteLine("Cholernie piździ."); //
            }
            else if (temp < 10)
            {
                Console.WriteLine("Zimno.");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Chłodno.");
            }
            else if (temp < 30)
            {
                Console.WriteLine("W sam raz.");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco.");
            }
            else
            {
                Console.WriteLine("A weź, wyprowadzam się na Alaskę.");
            }
        }
        public static void task10()
        {
            int a, b, c;
            Console.WriteLine("Please, enter first length");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second length");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter third length");
            c = Int32.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("You can make a triangle");
            }
            else
            {
                Console.WriteLine("You cannot make a triangle");
            }
            Console.ReadKey();
        }
        public static void task11()
        {
            Console.Write("Please, enetr your grade");
            string grade = Console.ReadLine();

            string result = grade switch
            {
                "1" => "unsatisfactory",
                "2" => "allowing",
                "3" => "satisfactory",
                "4" => "good",
                "5" => "very well",
                "6" => "perfect",
                _ => "There is no such a grade"
            };
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static void task12()
        {
            int dayOfWeek = 4;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("There is no such a day");
                    break;
            }
        }
        public static void task13()
        {
            Console.WriteLine("Please, enter first number");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second number");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please, choose between below operation ");
            Console.WriteLine("1.  Summary");
            Console.WriteLine("2.  Substraction");
            Console.WriteLine("3.  Multiplying");
            Console.WriteLine("4.  Dividing");
            int operationType = int.Parse(Console.ReadLine());
            float result;
            switch(operationType)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"Your result is {result}");
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine($"Your result is {result}");
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine($"Your result is {result}");
                    break;
                case 4:
                    result = a / b;
                    Console.WriteLine($"Your result is {result}");
                    break;
                default:
                    Console.WriteLine("There is no such an option");
                    break;

            }

        }
    }
}
