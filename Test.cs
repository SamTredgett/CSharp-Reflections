using System;

namespace Reflection
{
    class Test 
    {
        public void RunTests(Car car){
            Console.WriteLine(car.getValue());
            Console.WriteLine(car.getYear());
            Console.WriteLine(car.toString());            
        }
    }
}
