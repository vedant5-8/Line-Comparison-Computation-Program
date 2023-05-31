using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    interface LineCompare
    {
        void compareTwoLine();

        void TwoLinesEquality();
    }

    class Lines
    {
        public int x11 { get; set; }
        public int x12 { get; set; }
        public int y11 { get; set; }
        public int y12 { get; set; }
        public int x21 { get; set; }
        public int x22 { get; set; }
        public int y21 { get; set; }
        public int y22 { get; set; }

        public double lengthOfLineOne { get; set; }
        public double lengthOfLineTwo { get; set; }
    }
    internal class LineComparisonWithOOPs : LineCompare
    {
        public void compareTwoLine()
        {
            Lines line = new Lines();

            Console.WriteLine("First Line Co-ordinates");
            Console.WriteLine("Enter x1 value");
            line.x11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            line.x12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            line.y11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            line.y12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Line Co-ordinates");
            Console.WriteLine("Enter x1 value");
            line.x21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            line.x22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            line.y21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            line.y22 = Convert.ToInt32(Console.ReadLine());

            line.lengthOfLineOne = Math.Sqrt(Math.Pow((line.x12 - line.x11), 2) + Math.Pow((line.y12 - line.y11), 2));
            line.lengthOfLineTwo = Math.Sqrt(Math.Pow((line.x22 - line.x21), 2) + Math.Pow((line.y22 - line.y21), 2));

            int result = line.lengthOfLineOne.CompareTo(line.lengthOfLineTwo);

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

        public void TwoLinesEquality()
        {
            Lines line = new Lines();

            Console.WriteLine("First Line Co-ordinates");
            Console.WriteLine("Enter x1 value");
            line.x11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            line.x12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            line.y11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            line.y12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Line Co-ordinates");
            Console.WriteLine("Enter x1 value");
            line.x21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            line.x22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            line.y21 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            line.y22 = Convert.ToInt32(Console.ReadLine());

            line.lengthOfLineOne = Math.Sqrt(Math.Pow((line.x12 - line.x11), 2) + Math.Pow((line.y12 - line.y11), 2));
            line.lengthOfLineTwo = Math.Sqrt(Math.Pow((line.x22 - line.x21), 2) + Math.Pow((line.y22 - line.y21), 2));


            if (line.lengthOfLineOne == line.lengthOfLineTwo)
            {
                Console.WriteLine("Lines are equal.");
            }
            else
            {
                Console.WriteLine("Lines are unequal.");
            }

        }
    }
}
