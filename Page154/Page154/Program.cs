using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number: ");
            int response = Convert.ToInt32(Console.ReadLine());
            //File.WriteAllText("C:\\Users\Sharath\\", response);

            string outputFileName = @"C:\Users\Sharath\Documents\aNumber.txt";
            StreamWriter toWrite = new StreamWriter(outputFileName);
            toWrite.WriteLine(string.Format("{0}", response));
            toWrite.Close();

            string getText = System.IO.File.ReadAllText(@"C:\Users\Sharath\Documents\aNumber.txt");
            int readBack = Convert.ToInt32(getText);
            Console.WriteLine("The number you enetered in the file is: {0}", readBack);
            Console.ReadLine();
        }
    }
}
