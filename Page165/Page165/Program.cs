using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page165
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 2019;
            int birthYear;
            char response;
            int age;

            try
            {
                Console.Write("How old are you?     ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0 || age > 150)
                    throw new System.FormatException();
                Console.WriteLine();
                Console.Write("Did your birthday already happen? (Answer Y for yes)   ");
                response = Convert.ToChar(Console.ReadLine());
                if (response == 'y' || response == 'Y')
                    birthYear = currentYear - age;
                else
                    birthYear = currentYear - age - 1;

                Console.WriteLine("\nYou were born in {0}", birthYear);

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter in a positive integer for the first question that is not too large.");
                Console.WriteLine("Please enter in a single character for the next question");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Uh oh. The program ran into some error.");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Program ran normally.");
                Console.ReadLine();
            }
        }
    }
}
