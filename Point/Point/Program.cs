using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {                 
            
            try
            {
                Point myPointOne = new Point(1, 2, 3);
                Point myPointTwo = new Point(1, 2, 3);
                //myPoint.X = -10;
                Console.WriteLine(myPointOne);
                Console.WriteLine(myPointTwo);
                double distance = myPointOne.FindDistance(myPointOne, myPointTwo);
                Console.WriteLine(distance);
                Console.WriteLine(myPointOne.Equals(myPointTwo));
            }
            catch (Exception)
            {
                Console.WriteLine("Exeption");
            }

           
        }
    }
}
