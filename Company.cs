using System;

namespace EmployeeList
{
    public class Company
    {
        public string companyName { get; set; };
        public DateTime dateFounded { get; set; };
        public List<Employee> EmployeeList { get; set; }
    }
}