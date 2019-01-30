using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page131
{
    public class Employee<T> : Person
    {
        public List<T> Things { get; set; }
        public List<string> wordThings { get; set; }
        public List<int> numberThings { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Gender:     " + gender);
            Console.WriteLine("ID Number:  " + Identity);
            Console.WriteLine("List of things: ");
            for (int i = 0; i < Things.Count; i++)
            {
                Console.WriteLine(Things[i]);
            }
            Console.WriteLine("List of integers: ");
            for (int j = 0; j < numberThings.Count; j++)
            {
                Console.WriteLine(numberThings[j]);
            }
        }
    }
}
