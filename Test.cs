using System;

namespace Reflection
{
    class Test 
    {
        public void MakeCar() {
            Car car = new Car("Audi", "A4","SLD4 TYZ", 2004, 30000);
        }

        public void RunTests(Car car){
            Console.WriteLine(car.getValue());
            Console.WriteLine(car.getYear());
            Console.WriteLine(car.ToString());            
        }
    }
}
