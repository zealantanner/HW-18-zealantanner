using System;

namespace CS1405_Lab
{
    // class DatabaseException : System.Exception
    // {
    //     public DatabaseException(string? message, System.Data.SqlClient.SQLException? exception) : base(message, innerException: exception)
    //     {
    //     }
    //     public DatabaseException(string? message, System.Data.OracleClient.OracleException? exception) : base(message, innerException: exception)
    //     {
    //     }
    //     public DatabaseException()
    //     {
    //     }
    //     public DatabaseException(string message)
    //     {
    //     }
    //     public DatabaseException(string? message, Exception? exception) : base(message, innerException:exception)
    //     {
    //     }
    // }
    class SpecialException : System.Exception
    {
        public SpecialException()
        {
            Console.WriteLine("zero");
        }
        public SpecialException(string message1) : base(message1)
        {
            Console.WriteLine("one");
            Console.WriteLine(message1);
            
        }
        public SpecialException(string message1, Exception message2) : base(message1, message2)
        {
            Console.WriteLine("two");
            Console.WriteLine(message1);
            Console.WriteLine(message2);
        }
    }

    class Program
    {
        static string LoopingMethod(string word)
        {
            return LoopingMethod(word);
        }
        static int DumbMath(int num)
        {
            return (num / 0);
        }

        static void Main(string[] args)
        {
            int num = int.MaxValue;

            try
            {
                num += 1;
                Console.WriteLine($"The number is {num}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine();

            try
            {
                Console.WriteLine($"The answer is {DumbMath(2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            int[] neededItems = {0, 1, 2, 3};
            string[] myItems = {"a coin", "a rock"};
            foreach(int item in neededItems)
            {
                try
                {
                    Console.WriteLine($"You have {myItems[neededItems[item]]}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " You need more items.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("This part doesn't work");

            string word = "Hi";
            try
            {
                Console.WriteLine($"Your word was {LoopingMethod(word)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}