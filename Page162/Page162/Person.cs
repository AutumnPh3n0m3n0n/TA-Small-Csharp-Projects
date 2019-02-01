using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page162
{
    class Person
    {
        string firstName;
        string lastName;
        int age;
        string occupation;
        string institution;
        const string city = "Folsom";
        const string region = "California";
        const string nationality = "USA";

        public Person(string first, string last) : this(first, last, 22, "Engineering Intern", "Microsoft")
        {

        }

        public Person(string first, string last, int years, string job, string place)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = years;
            this.occupation = job;
            this.institution = place;
        }

        public void Description()
        {
            Console.WriteLine("Name:        " + firstName + " " + lastName);
            Console.WriteLine("Age:         " + age);
            Console.WriteLine("Occupation:  " + occupation);
            Console.WriteLine("Company:     " + institution);
            Console.WriteLine("Hometown:    " + city + ", " + region + ", " + nationality);
        }
    }

}
