using System;

namespace LineComparison
{
    public class CompareTwoLines
    {
        public static void CompareLines()
        {
            int x11, x12, y11, y12;
            int x21, x22, y21, y22;
            double lengthOfLineOne;
            double lengthOfLineTwo;

            Console.WriteLine("First Line Co-ordinates");
            Console.WriteLine("Enter x1 value");
            x11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            x12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            y11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            y12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Line Co-ordinates");
            Console.WriteLine("Enter x1 value");
            x21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            x22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            y21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            y22 = Convert.ToInt32(Console.ReadLine());

            lengthOfLineOne = Math.Sqrt(Math.Pow((x12 - x11), 2) + Math.Pow((y12 - y11), 2));
            lengthOfLineTwo = Math.Sqrt(Math.Pow((x22 - x21), 2) + Math.Pow((y22 - y21), 2));

            int result = lengthOfLineOne.CompareTo(lengthOfLineTwo);

            switch (result)
            {
                case -1:
                    Console.WriteLine("Line 1 is less than Line 2");
                    break;
                case 0:
                    Console.WriteLine("Line 1 is equal to Line 2");
                    break;
                case 1:
                    Console.WriteLine("Line 1 is greater than Line 2");
                    break;
            }
        }
    }
}
