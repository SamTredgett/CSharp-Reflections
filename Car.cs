using System;

namespace Reflection
{
    class Car 
    {
        public string make;
        public string model;
        public string registration;
        public double year;
        public double currentValue;

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
            return "Make: " + make + "Model: " + model + "Registration: " + registration + "Year: "  + year + "Current Value: £"  + currentValue;
        }

    }
}
