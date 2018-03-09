using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    class Program
    {
        public static void WriteArray(string[] courseIDs, string[] courseNames)
        {
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
                Console.WriteLine($"{courseIDs[displayCount]} - {courseNames[displayCount]}");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Length(string[] courseIDs, string[] courseNames)
        {
            Console.WriteLine($"There are {courseIDs.Length} entries in the array Course IDs");
            Console.WriteLine($"There are {courseNames.Length} entries in the array Course Names");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Copy(string[] courseIDs, string[] courseNames, string[] courseIDs2, string[] courseNames2)
        {
            courseIDs.CopyTo(courseIDs2, 0);
            courseNames.CopyTo(courseNames2, 0);
            Console.WriteLine("Arrays have been copied");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Type(string[] courseIDs2, string[] courseNames2)
        {
            Console.WriteLine($"The array Course IDs is a {courseIDs2.GetType().GetElementType()} type");
            Console.WriteLine($"The array Course Names is a {courseNames2.GetType().GetElementType()} type");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Value5(string[] courseIDs2, string[] courseNames2)
        {
            Console.WriteLine($"The 5th instance of each array is {courseIDs2[4]} and {courseNames2[4]}");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Search(string[] courseIDs2, string[] courseNames2)
        {
            int sSelect = 2;
            do
            {
                Console.WriteLine("Would you like to search the Course IDs or the Course Names?");
                Console.WriteLine("Please enter either \"IDs\" or \"Names\"");
                string searchChoice = Console.ReadLine();
                if (searchChoice == "IDs" || searchChoice == "Ids" || searchChoice == "ids" || searchChoice == "IDS")
                {
                    Console.WriteLine("What Course ID are you looking for?");
                    string idSearch = Console.ReadLine();
                    sSelect = 1;
                }
                else if (searchChoice == "Names" || searchChoice == "names")
                {
                    Console.WriteLine("What Course Name are you Looking for?");
                    sSelect = 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter a valid selection");
                    Console.WriteLine("");
                }
            } while (sSelect == 2);

        }

        static void Reverse(string[]courseIDs2, string[]courseNames2)
        {
            Array.Reverse(courseIDs2);
            Array.Reverse(courseNames2);
            Console.WriteLine("The Arrays have been reversed");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void WriteV5(string[]courseIDs2, string[]courseNames2)
        {
            Console.WriteLine($"At location 5 the arrays contain {courseIDs2[4]} and {courseNames2[4]}");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
            
        static void Main(string[] args)
        {
            string[] courseIDs    = new string[10] { "COMP6209", "COMP5102", "COMP6211", "COMP6212", "COMP6210", "COMP6208", "COMP5104", "COMP5109", "COMP5010", "COMP5011" };
            string[] courseNames  = new string[10] { "Systems Analysis and Design", "Intro to Programming", "Algorithms and Data Structures", "Data Management", "Web Services and Design Methodologies", "Project Management", "Software Packages", "Computer Horticulture", "Computing in the Apocolypse", "Underwater Data Structures" };
            string[] courseIDs2   = new string[10];
            string[] courseNames2 = new string[10];

            WriteArray(courseIDs, courseNames);
            
            Length(courseIDs, courseNames);

            Copy(courseIDs, courseNames, courseIDs2, courseNames2);

            Type(courseIDs2, courseNames2);

            Value5(courseIDs2, courseNames2);

            Search(courseIDs2, courseNames2);

            Reverse(courseIDs2, courseNames2);

            WriteV5(courseIDs2, courseNames2);



            
            
            //Console.WriteLine("Which number in the arrays would you like to view");
            //int searchSelectConsole = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The items at location {searchSelectConsole} are {courseIDs2[searchSelectConsole]} and {courseNames2[searchSelectConsole]}");
            Console.ReadLine();
        }
    }
}
