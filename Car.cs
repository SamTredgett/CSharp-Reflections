using System;

namespace Reflection
{
    class Car 
    {
        private string make;
        private string model;
        private string registration;
        private double year;
        private double currentValue;

        public Car(string Make, string Model, string Registration, double Year, double CurrentVal)
        {
          this.make = Make;
          this.model = Model;
          this.registration = Registration;
          this.year = Year;
          this.currentValue = CurrentVal; 
        }

        public double getValue() { return this.currentValue;}
        public double getYear() {return this.year;}

        public override string ToString() {
            string sentence = $"This car is a  
            return $"This car is a {this.make} {this.model} with registration {this.registration} made in {this.getYear()} with a current value of {this.getValue()}";
        }

    }
}
