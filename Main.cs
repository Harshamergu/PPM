using System;
using System.Collections.Generic;
using PPM.Domain;


namespace PPM.Main
{
    public class Program
    {
        // public void AddProject()
        // {
        //     System.Console.WriteLine("Project Added Succesfully...");
        // }
        // public void ViewProject()
        // {
        //     System.Console.WriteLine("Here are list of projects...");
        // }
        // public void AddEmployee()
        // {
        //     System.Console.WriteLine("Employee Added succesfully...");
        // }
        // public void ViewEmployee()
        // {
        //     System.Console.WriteLine("Here are the Employee to view");
        // }
        // public void AddRole()
        // {
        //     System.Console.WriteLine("Roles added succesfully...");
        // }
        // public void ViewRole()
        // {
        //     System.Console.WriteLine("Here are the Roles to view...");
        // }

        // Main Method
        public static void Main(string[] args)
        {
            // Clear the Console 
            Console.Clear();

            int choice;
            Program obj = new Program();

            do
            {
                // Using BackgroundColor property
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                System.Console.WriteLine(" _____________________________________________________ ");
                System.Console.WriteLine("|                     << Menu >>                      |");
                System.Console.WriteLine("|     << Welcome to Prolifics Project Manager! >>     |");
                System.Console.WriteLine("|                -> 1: Add Project                    |");
                System.Console.WriteLine("|                -> 2: View Project                   |");
                System.Console.WriteLine("|                -> 3: Add Employee                   |");
                System.Console.WriteLine("|                -> 4: View Employee                  |");
                System.Console.WriteLine("|                -> 5: Add Role                       |");
                System.Console.WriteLine("|                -> 6: View Role                      |");
                System.Console.WriteLine("|                -> 7: Quit                           |");
                System.Console.WriteLine("|_____________________________________________________|");

                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine();
                System.Console.Write("Select your choice and Enter here : ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                choice = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                switch (choice)
                {
                    case 1:
                        ProjectRepo proObj = new ProjectRepo();
                        proObj.AddProject();
                        break;

                    case 2:
                        ProjectRepo viewProject = new ProjectRepo();
                        viewProject.ViewProject();
                        break;

                    case 3:
                        EmployeeRepo empObj = new EmployeeRepo();
                        empObj.AddEmployee();
                        break;

                    case 4:
                        EmployeeRepo viewEmployee = new EmployeeRepo();
                        viewEmployee.ViewEmployee();
                        break;

                    case 5:
                        RoleRepo roleObj = new RoleRepo();
                        roleObj.AddRole();
                        break;

                    case 6:
                        RoleRepo viewRole = new RoleRepo();
                        viewRole.ViewRole();
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine();
                        System.Console.WriteLine("     Thank you for using PPM :)     ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine();
                        System.Console.WriteLine("     Wrong choice! Try again :(     ");
                        System.Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            while (choice != 7);
        }
    }
}
