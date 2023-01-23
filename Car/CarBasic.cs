using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return String.Format("Brand: {0}, Model: {1}, Year: {2}, Age: {3}", this.Make, this.Model, this.Year, this.Age());
        }

        //public void display()
        //{
        //    var Car = new Car(Make, Model, Year);
        //}

        public int Age()
        {
            return DateTime.Now.Year - this.Year;
        }
    }
}
