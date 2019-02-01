using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page162
{
    public class Car
    {
        public string plate;
        public string brand;
        string model;
        int mileage;
        int year;
        const string dealership = "Folsom";


        public Car(string getPlate) : this(getPlate, "Toyota", "Corolla", 35, 2018)
        {

        }

        public Car(string setPlate, string getBrand, string getModel, int getMiles, int getYear)
        {
            this.plate = setPlate;
            this.brand = getBrand;
            this.model = getModel;
            this.mileage = getMiles;
            this.year = getYear;
        }

        public void Details()
        {
            Console.WriteLine("Car Brand:    " + brand);
            Console.WriteLine("Car Model:    " + model);
            Console.WriteLine("MPG:          " + mileage);
            Console.WriteLine("Year:         " + year);
            Console.WriteLine("Plate Number: " + plate);
            Console.WriteLine("Dealership:   " + dealership);
        }
    }
}
