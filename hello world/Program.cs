using System;

namespace hello_world
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("We are going to Divide one number by another.");
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Console Log is complete.");
            }

        }
    }
}
