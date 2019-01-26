using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Response;
                double divResponse;
                Console.WriteLine("Here is a large list of square numbers:");
                List<double> squares = new List<double>() { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 289, 324, 361, 400 };
                //List<double> original = new List<double>() { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 289, 324, 361, 400 };
                List<double> original = new List<double>(squares);
                for (int i = 0; i < squares.Count; i++)
                {
                    Console.WriteLine(squares[i] + "          is " + (i+1) + " squared");
                }
                Console.Write("\n\nWhich number do you want to divide these numbers by?   ");
                //prevent the user from entering in a ridiculous value
                do
                {
                    Response = Convert.ToInt32(Console.ReadLine());
                    if (Response <= 0 && Response > 200)
                        Console.WriteLine("Please enter in a positive number that is less than 200");
                } while (Response <= 0 && Response > 200);

                //to make sure a zero exception is thrown
                int blah = 5;
                blah /= Response;

                //Convert the integer Response into a double divResponse for proper division
                //if the numbers being divided are integers and NOT doubles, then 9/5 = 1 instead of 1.8
                divResponse = Convert.ToDouble(Response);
                for (int i = 0; i < squares.Count; i++)
                {
                    squares[i] /= divResponse;
                    //round the decimal places to prevent ugliness in the numbers
                    squares[i] = Math.Round(squares[i], 4);
                }
                Console.WriteLine("Here is the list of all numbers divided by your selected number:   ");
                for (int i = 0; i < squares.Count; i++)
                {
                    Console.WriteLine(original[i] + "      divided by " + Response + " is          " + squares[i]);
                }
                Console.ReadLine();
            }
            //format exception for incorrect response
            catch (FormatException exep)
            {
                Console.WriteLine("Uh oh! Please enter in a whole number. \n" + exep.Message);
                Console.ReadLine();
            }
            //format exeption incase 0 is inputted
            catch (DivideByZeroException exep)
            {
                Console.WriteLine("Uh oh! You cannot divide by zero. \n" + exep.Message);
                Console.ReadLine();
            }
            //other format exceptions
            catch (Exception exep)
            {
                Console.WriteLine(exep.Message);
                Console.ReadLine();
            }
        }
    }
}
