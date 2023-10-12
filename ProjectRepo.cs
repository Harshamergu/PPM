using System;
using System.Threading;
using System.Collections;

using PPM.Model;

namespace PPM.Domain
{
    public class ProjectRepo
    {
        static List<Project> listObj = new List<Project>();
        public void AddProject()
        {
            System.Console.WriteLine();
            System.Console.Write("Enter the number of project's you want : ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Project obj = new();

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Enter Project Id   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.ProjectId = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Enter Project Name : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.ProjectName = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Enter Start Date   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.Startdate = DateOnly.Parse(Console.ReadLine());
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Enter End Date     : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.Enddate = DateOnly.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                listObj.Add(obj);
                System.Console.WriteLine();
            }
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("Project's are added Successfully :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ViewProject()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine();
            System.Console.WriteLine("-> These are the Details of the Project's");
            foreach (var list in listObj)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                // Displays all details              
                System.Console.WriteLine("Project Id : {0}, Project Name : {1}, Start Date : {2}, End Date : {3}", list.ProjectId, list.ProjectName, list.Startdate, list.Enddate);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}