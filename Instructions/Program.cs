namespace Instructions
{
    internal class Program
    {
        static void Main(string[] args)
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

            if (EvaluateCondition(false,"Eval Condition1"))
            {
                Console.WriteLine("Condition1 is true");
            }
            else if (EvaluateCondition(false,"Eval Condition2")) 
            {
                Console.WriteLine("Condition2 is true");
            }
            else if (EvaluateCondition(true,"Eval Condition3")) 
            {
                Console.WriteLine("Condition3 is true");
            }
            else
            {
                Console.WriteLine("None of Condition1, Condition2, Condition3 are true");
            }

            Console.WriteLine("Hello, World!");
        }

        public static bool EvaluateCondition(bool condition, string message) 
        {
            Console.WriteLine(message);
            return condition;
        }
    }
}