using System;

using PPM.Model;

namespace PPM.Domain
{
    public class RoleRepo
    {
        static List<Role> listObj = new();
        static Role obj = new();
        public void AddRole()
        {
            System.Console.WriteLine();
            System.Console.Write("Enter the number of role's : ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            for (int i = 0; i < number; i++)
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Enter Role Id   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.RoleId = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Enter Role Name : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.RoleName = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                listObj.Add(obj);
                System.Console.WriteLine();
            }
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("Role's are added Successfully :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ViewRole()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine();
            System.Console.WriteLine("-> These are the Details of the Role's");
            foreach (var list in listObj)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                // Displays all details              
                System.Console.WriteLine("Role Id : {0}, Role Name : {1}", list.RoleId, list.RoleName);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}