using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDrillCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please enter the dimensions of your package: ");
            int height = 0;
            int length = 0;
            int width = 0;
            int weight = 0;
            int sum;
            double volume;

            do
            {
                do
                {
                    Console.Write("Enter the weight of the package (in lbs):   ");
                    weight = Convert.ToInt32(Console.ReadLine());
                    if (weight < 1 || weight > 100)
                        Console.WriteLine("The package is too heavy. 100 lbs is the maximum.");
                } while (weight < 1 || weight > 100);

                do
                {
                    Console.Write("Enter the height of the package:            ");
                    height = Convert.ToInt32(Console.ReadLine());
                    if (height < 1 || height > 50)
                        Console.WriteLine("The package is too big or you have not entered a resonable amount");
                } while (height < 1 || height > 50);

                do
                {
                    Console.Write("Enter the length of the package:            ");
                    length = Convert.ToInt32(Console.ReadLine());
                    if (length < 1 || length > 50)
                        Console.WriteLine("The package is too big or you have not entered a resonable amount");
                } while (length < 1 || length > 50);

                do
                {
                    Console.Write("Enter the width of the package:             ");
                    width = Convert.ToInt32(Console.ReadLine());
                    if (width < 1 || width > 50)
                    {
                        Console.WriteLine("The package is too big or you have not entered a resonable amount");
                    }
                } while (width < 1 || width > 50);

                sum = height + length + width;
                if (sum > 50)
                    Console.WriteLine("Unfortunately the package is too large.");

            } while (sum > 50);

            volume = weight * height * length * width;
            volume /= 100;

            Console.WriteLine("\n\nThe cost to ship your package is: $" + volume);
            Console.ReadLine();
        }
    }
}
