using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // We want to call the tests in here and make sure it all prints properly
            Test test = new Test();
            Car car = test.MakeCar();
            test.RunTests(car);
           
        }
    }
}
