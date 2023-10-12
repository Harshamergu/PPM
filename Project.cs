
using System;
using System.Collections.Generic;

namespace PPM.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public DateOnly Startdate { get; set; }
        public DateOnly Enddate { get; set; }
        public int EmployeeId { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Address { get; internal set; }
        public string Mobile { get; internal set; }
        public string Email { get; internal set; }       
        public int RoleId { get; internal set; }
        public string RoleName { get; internal set; }
    }
}
