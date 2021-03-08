using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter();

            PauseConsole();

            Counterthree(10);

            PauseConsole();

            EvenOrOdd(20);

            PauseConsole();

            IsPositiveOrNegative(52);

            PauseConsole();

            CanVote(19);

            PauseConsole();

            InRange();

            PauseConsole();

            MultiplicationTable();




            int usernumber1 = Getuserinput();
            int usernumber2 = Getuserinput();

            bool Equal = EqualChecker(usernumber1, usernumber2);
            Console.WriteLine($"{usernumber1} is equal to {usernumber2} This is: {Equal}");

            if (usernumber1 == usernumber2)                         // option to use.
            {
                Console.WriteLine("They are equal");
            }

            else
            {
                Console.WriteLine("They are totally different");
            }

            PauseConsole();


        }



        public static void MultiplicationTable()
        {
            Console.WriteLine("What`s the number");
            var number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} times {number} is equal to: {i * number}");
            }
        }

        public static void InRange()
        {

            Console.WriteLine("Enter you number");
            var userinput = Int32.Parse (Console.ReadLine());

            if (userinput >= -10 && userinput <= 10)
            {
                Console.WriteLine("It`s in the specific range");
            }

            else
            {
                Console.WriteLine("It`s not in the range");
            }
        }

        public static void CanVote(int x)
        {
            int num;

            Console.WriteLine("Please enter your age");
            var userinput = int.TryParse(Console.ReadLine(), out num);

            if (num >= 18)

            {
                Console.WriteLine("You can vote");
            }

            else

            {
                Console.WriteLine("Sorry! You can not vote");
            }

        }

        public static void IsPositiveOrNegative(int x)
        {

            if (x > 0)
            {
                Console.WriteLine("This number is positive");
            }

            else if (x < 0)
            {
                Console.WriteLine("This number is negative");
            }

            else
            {
                Console.WriteLine("This number is zero");
            }
        }

        public static bool EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("This number is Even");
                return true;
            }

            else
            {
                Console.WriteLine("This number is Odd");
                return false;
            }
        }

        public static int Getuserinput()
        {
            Console.Write("Give me a number: ");
            int usernumber = int.Parse(Console.ReadLine());

            return usernumber;
        }

        public static bool EqualChecker(int num1, int num2)
        {
            return num1 == num2;
        }

        public static void Counterthree(int x)
        {
            for (int i = 3; i <= 999; i+=3)

            {
                Console.WriteLine(i);
            }
        }

        public static void Counter()
        {
            int goal = -1000;

            for (int i = 1000; i >= goal; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void PauseConsole()
        {

            {
                Console.WriteLine();
                Console.ReadLine();
            }

        }

    }
}
