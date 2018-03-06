using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courseIDs = new string[10] { "COMP6209", "COMP5102", "COMP6211", "COMP6212", "COMP6210", "COMP6208", "COMP5104", "COMP5109", "COMP5010", "COMP5011" };
            string[] courseNames = new string[10] { "Systems Analysis and Design", "Intro to Programming", "Algorithms and Data Structures", "Data Management", "Web Services and Design Methodologies", "Project Management", "Software Packages", "Computer Horticulture", "Computing in the Apocolypse", "Underwater Data Structures"};
            for (int displayCount = 0; displayCount < 10; displayCount = displayCount + 1)
            {
                Console.WriteLine($"Array contains {courseIDs[displayCount]}");
            }
            for (int displayCount = 0; displayCount < 10; displayCount = displayCount + 1)
            {
                Console.WriteLine($"Array contains {courseNames[displayCount]}");
            }
            for (int displayCount = 0; displayCount < 10; displayCount = displayCount + 1)
            {
                Console.WriteLine($"{courseIDs[displayCount]} is {courseNames[displayCount]}");
            }
            Console.WriteLine($"There are {courseIDs.Length} entries in the array (courseIDs.)");
            Console.WriteLine($"There are {courseNames.Length} entries in the array (courseName.)");
            string[] courseIDs2 = new string[10];
            courseIDs.CopyTo(courseIDs2, 0);
            string[] courseNames2 = new string[10];
            courseNames.CopyTo(courseNames2, 0);
            Console.WriteLine($"The array CourseIDs. is a {courseIDs2.GetType().GetElementType()} type");
            Console.WriteLine($"The 5th instance of each array is {courseIDs2[4]} and {courseNames2[4]}");
            Console.WriteLine("Would you like to search the Course IDs or the Course Names?");
            string searchChoice = Console.ReadLine();
            //Console.WriteLine("Which number in the arrays would you like to view");
            //int searchSelectConsole = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The items at location {searchSelectConsole} are {courseIDs2[searchSelectConsole]} and {courseNames2[searchSelectConsole]}");
            Array.Reverse(courseIDs2);
            Array.Reverse(courseNames2);
            for (int displayCount = 0; displayCount < 10; displayCount = displayCount + 1)
            {
                Console.WriteLine($"Array contains {courseIDs2[displayCount]}");
            }
            for (int displayCount = 0; displayCount < 10; displayCount = displayCount + 1)
            {
                Console.WriteLine($"Array contains {courseNames2[displayCount]}");
            }

            Console.ReadLine();
        }
    }
}
