using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroUniversityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Header
            Console.WriteLine("Caro University of Venice - Administrative Updates");
            Console.WriteLine("-------------------------------------------------\n");

            //Administrative Changes
            Console.WriteLine("Administrive Changes for the New Academic Year: ");
            Console.WriteLine("- Replacement of outdated administrative facilities.");
            Console.WriteLine("- Expanision of faculty offices and student services.");
            Console.WriteLine("- Digitalization of student records and fee systems.");
            Console.WriteLine("- Hiring of new administrative staff.\n");


            //Branches and Courses
            Console.WriteLine("Available Branches and Courses:");
            Console.WriteLine("1. Engineering");
            Console.WriteLine("   - Computer Science");
            Console.WriteLine("   - Mechanical Engineering");
            Console.WriteLine("   - Civil Engineering");
            Console.WriteLine("2. Arts & Humanities");
            Console.WriteLine("   - History");
            Console.WriteLine("   - Literature");
            Console.WriteLine("   - Philosophy");
            Console.WriteLine("3. Business & Economics");
            Console.WriteLine("   - Accounting");
            Console.WriteLine("   - Marketing");
            Console.WriteLine("   - International Relations\n");

            //Footer
            Console.WriteLine(" For more updates, visit the university portal or contact the administration office.");
            Console.ReadLine(); //Keeps the window opens
        }
    }
}
