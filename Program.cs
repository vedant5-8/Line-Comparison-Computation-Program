using System;

namespace LineComparison
{
    class Program
    {
        static void lengthOfLine()
        {
            int x1, x2, y1, y2;
            double length;

            Console.WriteLine("Enter x1 value");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            y2 = Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line is " + length);

        }

        static void TwoLinesEqualityCheck()
        {
            int x11, x12, y11, y12;
            int x21, x22, y21, y22;
            double lineOneLength;
            double lineTwoLength;

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

            lineOneLength = Math.Sqrt(Math.Pow((x12 - x11), 2) + Math.Pow((y12 - y11), 2));
            lineTwoLength = Math.Sqrt(Math.Pow((x22 - x21), 2) + Math.Pow((y22 - y21), 2));

            if (lineOneLength == lineTwoLength)
            {
                Console.WriteLine("Lines are equal.");
            }
            else
            {
                Console.WriteLine("Lines are unequal.");
            }

        }


        static void Main(string[] args)
        { 
            //Program.lengthOfLine();
            Program.TwoLinesEqualityCheck();
        }
    }
}