using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page131
{
    public class Employee<T> : Person
    {
        public List<T> things { get; set; }
        //public List<T> wordThings { get; set; }
        //public List<int> numberThings { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Gender:     " + gender);
            Console.WriteLine("ID Number:  " + Identity);
        }
    }
}
