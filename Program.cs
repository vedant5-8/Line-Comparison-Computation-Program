using System;

namespace LineComparison
{
    class Program
    { 
        static void Main(string[] args)
        { 
            while (true)
            {
                Console.WriteLine("choose a number: ");
                Console.WriteLine("1. To find length of line.");
                Console.WriteLine("2. To check line 1 is equal or unequal to line 2.");
                Console.WriteLine("3. To check line 1 is greater, smaller and equal to line 2.");
                Console.WriteLine();
                Console.WriteLine("4. To check line 1 is equal or unequal to line 2 using OOPs");
                Console.WriteLine("5. To check line 1 is greater, smaller and equal to line 2 OOPs");
                Console.WriteLine("6. Exit.");
                Console.Write("=>");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LengthOfLine.LengthLine();
                        break;
                    case 2:
                        TwoLinesEqualityCheck.TwoLinesEquality();
                        break;
                    case 3:
                        CompareTwoLines.CompareLines();
                        break;
                    case 4:
                        LineComparisonWithOOPs l1 = new LineComparisonWithOOPs();
                        l1.compareTwoLine();
                        break;
                    case 5:
                        LineComparisonWithOOPs l2 = new LineComparisonWithOOPs();
                        l2.TwoLinesEquality();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter correct choice.");
                        break;
                }
            }

        }
    }
}