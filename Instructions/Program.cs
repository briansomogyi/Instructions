﻿using Microsoft.VisualBasic;

namespace Instructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            string[] strings = { "test", "test2", "test3" };

            for (int i = 0; i < ints.Length; i++)
            {
                int element = ints[i];
                Console.WriteLine(element);
            }

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            SamplesWithFor();
            SamplesWithSwitch();
            SamplesWithIf();
            Console.WriteLine("Hello, World!");
        }

        public static bool EvaluateCondition(bool condition, string message) 
        {
            Console.WriteLine(message);
            return condition;
        }

        public static void SamplesWithIf()
        {

            if (EvaluateCondition(false, "Eval Condition1"))
            {
                Console.WriteLine("Condition1 is true");
            }
            else if (EvaluateCondition(false, "Eval Condition2"))
            {
                Console.WriteLine("Condition2 is true");
            }
            else if (EvaluateCondition(true, "Eval Condition3"))
            {
                Console.WriteLine("Condition3 is true");
            }
            else
            {
                Console.WriteLine("None of Condition1, Condition2, Condition3 are true");
            }
        }

        public static void SamplesWithSwitch()
        {
            Console.WriteLine("Meniu: ");
            Console.WriteLine("1) File");
            Console.WriteLine("2) Edit");
            Console.WriteLine("3) View");
            Console.WriteLine("Your option is: ");
            string option = Console.ReadLine();

            if (int.TryParse(option, out int optionNumber))
            {
                switch (optionNumber)
                {
                    case 1:
                        {
                            int var = 1;
                            Console.WriteLine("You have selected File menu.");
                            Console.WriteLine("Avalable suboptions are: ");
                            Console.WriteLine("1) New");
                            Console.WriteLine("2) Open");
                        }
                        break;
                    case 2:
                        {
                            int var = 1;
                            Console.WriteLine("You have selected Edit menu.");
                            Console.WriteLine("Avalable suboptions are: ");
                            Console.WriteLine("1) Copy");
                            Console.WriteLine("2) Paste");
                        }
                        break;
                    case 3:
                        Console.WriteLine("You have selected View menu.");
                        Console.WriteLine("Avalable suboptions are: ");
                        Console.WriteLine("1) Open");
                        Console.WriteLine("2) Open With");
                        break;
                    default:
                        Console.WriteLine("You selected an imvalid menu option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric option.");
            }
        }

        public static void SamplesWithFor()
        {
            Console.Write("What is the number? ");
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);

            Console.Write("What is the stop number? ");
            string stopNumberAsString = Console.ReadLine();
            int stopNumber = int.Parse(stopNumberAsString);

            for (int i = 1; i <= number; i++)
            {
                if (i == stopNumber)
                {
                    return;
                }

                bool isOdd = i % 2 == 0;
                if (isOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}