using System;
using System.Linq;

namespace ReverseAndAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string inputReverse;

            Int64 number;
            Int64 numberReverse;
            Int64 numberResult;
            int counter;
           
            Console.WriteLine("Let\'s reverse and add!");
            Console.WriteLine();
            while (true) {
                Console.WriteLine();
                Console.Write("Please enter a whole non-negative number: ");
                
                input = Console.ReadLine();
                counter = 0;

                // I made an assumption that the program will stop after the keyword "exit"
                // in command line
                if (input == "exit" || string.IsNullOrEmpty(input)) 
                {
                    break;
                }
                //reverse the digits of the input number
                inputReverse = new string(input.ToCharArray().Reverse().ToArray());
                while (true) { 

                    number = Convert.ToInt64(input);
                    numberReverse = Convert.ToInt64(inputReverse);
                    //add the input number to the reversed number
                    numberResult = number + numberReverse;
                    counter += 1;
                    
                    // display the step number and the calculation to the console
                    Console.WriteLine("{3}: {0} + {1} = {2}", number, numberReverse, numberResult, counter);

                    //the program uses the sum from the last step as the new starting number
                    //and  reverses the sum of two number
                    input = numberResult.ToString();
                    inputReverse = new string(input.ToCharArray().Reverse().ToArray());

                    if (string.Compare(input,inputReverse)==0) // it's palindrome
                    {
                        //Console.WriteLine("palindrome!!");
                        break;//go back to get another whole number from the console
                    }
                }
            }
        }
    }
}
