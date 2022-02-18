using System;

// 22931 - Marcos Oliveira
namespace OPP_Sem2_Week4_Q1_Q2_Q3
{
    // Exercise 1
    class Exercise1
    {
        // Fild
        int _answer;

        // Constructor
        public Exercise1(int answer)
        {
            _answer = answer;
        }

        // Method
        public void MultiplicationTable()
        {
            Console.WriteLine("** Exercise 1 **");

            while (true) // Every time that i want to do a validation, i can use this WHILE structure
            {
                Console.Write("Please enter an Intege Number: ");
                int answer;

                // It compares if, what user typed is really int
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    for (int i = 2; i < 11; i++)
                    {
                        int result = answer * i;
                        Console.WriteLine(answer + " x " + i + " = " + result);
                    }
                    Environment.Exit(0); //It makes get out of the while loop
                }

                // It will running until user type the right answer = int 
                Console.WriteLine("Please try again!");
            }
        }
    }

    // Exercise 2
    class Exercise2
    {
        // Filds ?

        // Constructors ?

        // Main Method ?
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises Week 4\n");

            //Exercise1
            Exercise1 E1 = new(10); // This new OBJ is created when I execute my main method.
            E1.MultiplicationTable();

            //Exercise2
            //Exercise2 E2 = new();
            //E2. ??? ();
        }
    }
}


