using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

using PPM.Model;

namespace PPM.Domain
{
    public class EmployeeRepo
    {
        static List<Employee> listObj = new();
        static Employee obj = new();
        public void AddEmployee()
        {           
            System.Console.WriteLine();
            System.Console.Write("Enter the number of Employee's you want to add : ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            int number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                System.Console.WriteLine("   << Give Detail's of Employee >>  ");
                System.Console.WriteLine();
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Employee Id : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.EmployeeId = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("First Name  : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.FirstName = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Last Name   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.LastName = Console.ReadLine();
                
                email:
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Email       : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string email = Console.ReadLine();

                if (IsValidEmail(email))
                {
                    obj.Email = email;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Please, give corrrect credentials!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    goto email;
                }
                
                mobile:
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Mobile      : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string Mobile = Console.ReadLine();
                
                if(IsValidPhoneNumber(Mobile))
                {
                   obj.Mobile = Mobile;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.WriteLine("Please, give corrrect credentials!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    goto mobile;
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("Address     : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.Address = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.Write("RoleId      : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                obj.RoleId = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                listObj.Add(obj);
                System.Console.WriteLine();
            }

            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("Employee's are added Successfully :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Validating the Email Address 
        public static bool IsValidEmail(string Email)
        {
             if (Email != null)
             {
                 string emailExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                 return Regex.IsMatch(Email, emailExpression);
             }
             else
             {
                 return false;
             }
        }

        // Validating the Mobile Number
        public static bool IsValidPhoneNumber(string mobile)
        {
            if (mobile != null)
            {
                string phoneExpression = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
                return Regex.IsMatch(mobile, phoneExpression);
            }
            else
            {
                return false;
            }
        }

        public void ViewEmployee()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine();
            System.Console.WriteLine("-> These are the details of the Employee's");
            foreach (var list in listObj)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                // Displays all details of Employee's              
                System.Console.WriteLine(" -> Employee Id : {0}", list.EmployeeId);
                System.Console.WriteLine(" -> First Name  : {0}", list.FirstName);
                System.Console.WriteLine(" -> Last Name   : {0}", list.LastName);
                System.Console.WriteLine(" -> Email       : {0}", list.Email);
                System.Console.WriteLine(" -> Mobile      : {0}", list.Mobile);
                System.Console.WriteLine(" -> Address     : {0}", list.Address);
                System.Console.WriteLine(" -> Role Id     : {0}", list.RoleId);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}