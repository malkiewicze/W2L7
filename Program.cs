using System;

namespace W2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualOrNot();
            EvenOrOdd();
            PositiveOrNegative();
            LeapOrNot();
            CheckAge();
            CheckHeight();
            WhichGreatest();
            Recruitment();
            WhatTemp();
            Triangle();
            Rating();
            DayOfWeek();
            Calculator();
            Console.ReadKey();
        }

        public static void EqualOrNot()
        {
            Console.WriteLine("EX1");
            int a = 5;
            int b = 5;
            if (a > b)
            {
                Console.WriteLine($"{a} is bigger than {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} is smaller than {b}");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
        }

        public static void EvenOrOdd()
        {

            Console.WriteLine("EX2");
            Console.WriteLine("Enter the number");
            int a = Int32.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The entered number is even");
            }
            else
            {
                Console.WriteLine("The entered number is odd");
            }
        }

        public static void PositiveOrNegative()
        {

            Console.WriteLine("EX3");
            Console.WriteLine("Enter the number");
            int a = Int32.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine($"{a} is negative");
            }
            else if (a > 0)
            {
                Console.WriteLine($"{a} is positive");
            }
            else
            {
                Console.WriteLine($"{a} isn't negative or positive");
            }
        }

        public static void LeapOrNot()
        {

            Console.WriteLine("EX4");
            Console.WriteLine("Enter the year");
            int a = Int32.Parse(Console.ReadLine());
            if ((a % 4 == 0) && (a % 100 != 0) || (a % 400 == 0))
            {
                Console.WriteLine($"{a} year is leap");
            }
            else
            {
                Console.WriteLine($"{a} year isn't leap");
            }
        }

        public static void CheckAge()
        {

            Console.WriteLine("EX5");
            Console.WriteLine("Enter how old are you");
            int a = Int32.Parse(Console.ReadLine());
            if (a >= 35)
            {
                Console.WriteLine("You can become president");
            }
            else if (a >= 30)
            {
                Console.WriteLine("You can become a sentor");
            }
            else if (a >= 21)
            {
                Console.WriteLine("You can become an MP");
            }
            else
            {
                Console.WriteLine("You are too young");
            }
        }

        public static void CheckHeight()
        {
            Console.WriteLine("EX6");
            Console.WriteLine("Enter how tall are you");
            double a = Double.Parse(Console.ReadLine());
            if (a > 0 && a < 140)
            {
                Console.WriteLine("You are a hobbit");
            }
            else if (a >= 140 && a < 170)
            {
                Console.WriteLine("You are a dwarf");
            }
            else
            {
                Console.WriteLine("You are an elf");
            }
        }

        public static void WhichGreatest()
        {
            Console.WriteLine("EX7");
            Console.WriteLine("Enter the first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int c = Int32.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"{a} is the greatest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} is the greatest");
            }
            else
            {
                Console.WriteLine($"{c} is the greatest");
            }
        }

        public static void Recruitment()
        {
            Console.WriteLine("EX8");
            Console.WriteLine("Provide the result of the matura exam in mathematics:");
            int math = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Provide the result of the matura exam in physics:");
            int physics = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Provide the result of the matura exam in chemistry:");
            int chem = Int32.Parse(Console.ReadLine());
            if (math + physics + chem > 180)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else if (math + physics > 150 || math + chem > 150)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("Candidate not admitted to recruitment");
            }
        }

        public static void WhatTemp()
        {
            Console.WriteLine("EX9");
            Console.WriteLine("Provide the temperature:");
            double temp = Double.Parse(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp > 0 && temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp > 10 && temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp > 20 && temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp > 30 && temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }

        }

        public static void Triangle()
        {
            Console.WriteLine("EX10");
            Console.WriteLine("Enter the length of the first side:");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side:");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side:");
            double c = Double.Parse(Console.ReadLine());
            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                Console.WriteLine("You can build a triangle");
            }
            else
            {
                Console.WriteLine("You can't build a triangle");
            }
        }

        public static void Rating()
        {
            Console.WriteLine("EX11");
            Console.WriteLine("Enter rating:");
            int rating = Int32.Parse(Console.ReadLine());
            switch (rating)
            {
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("błędna ocena");
                    break;
            }
        }

        public static void DayOfWeek()
        {
            Console.WriteLine("EX12");
            Console.WriteLine("Enter the day of week:");
            int day = Int32.Parse(Console.ReadLine());
            switch (day)
            {
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
        }
        public static void Calculator()
        {
            Console.WriteLine("EX13");
            Console.WriteLine("Enter the first number:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of the operation to be performed: /r/n 1. Addition /r/n 2.Subtraction /r/n3.Multiplication /r/n4.Division");
            int operation = Int32.Parse(Console.ReadLine());
            int result;
            switch (operation)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine("Result: "+ result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine("Result: " + result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine("Result: " + result);
                    break;
                case 4:
                    result = a / b;
                    Console.WriteLine("Result: " + result);
                    break;
            }
        }

    }
}
