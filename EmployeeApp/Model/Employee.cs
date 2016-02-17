using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    public class Employee
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public string Image { get; set; }

        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
    } //class Employee

    public class EmployeeViewModel
    {   //mallin sisäinen tietorakenne
        private List<Employee> employees = new List<Employee>();
        // ominaisuus, joka bindataan UI:hin
        public List<Employee> Employees 
        {
            get { return employees; }
        }

        public EmployeeViewModel()
        {
            employees.Add(new Employee { ID = "1001", Firstname = "Joseph", Lastname = "Howard", JobTitle = "Account Executive", Image = "Assets/Images/employee01.png" });
            employees.Add(new Employee { ID = "1002", Firstname = "Helen", Lastname = "Schmidt", JobTitle = "Actuary", Image = "Assets/Images/employee02.png" });
            employees.Add(new Employee { ID = "1003", Firstname = "Sean", Lastname = "White", JobTitle = "VP Sales", Image = "Assets/Images/employee03.png" });
            employees.Add(new Employee { ID = "1004", Firstname = "Chris", Lastname = "Cox", JobTitle = "Associate Professor", Image = "Assets/Images/employee04.png" });
            employees.Add(new Employee { ID = "1005", Firstname = "Lois", Lastname = "Fisher", JobTitle = "Administrative Officer", Image = "Assets/Images/employee05.png" });
            employees.Add(new Employee { ID = "1006", Firstname = "Maria", Lastname = "Johnson", JobTitle = "Sales Associate", Image = "Assets/Images/employee06.png" });
            employees.Add(new Employee { ID = "1007", Firstname = "Jean", Lastname = "Lane", JobTitle = "Design Engineer", Image = "Assets/Images/employee07.png" });
            employees.Add(new Employee { ID = "1008", Firstname = "Wayne", Lastname = "Gomez", JobTitle = "Geologist", Image = "Assets/Images/employee08.png" });
            employees.Add(new Employee { ID = "1009", Firstname = "Jeffrey", Lastname = "Martinez", JobTitle = "Assistant Media Planner", Image = "Assets/Images/employee09.png" });
            employees.Add(new Employee { ID = "1010", Firstname = "Billy", Lastname = "Simmons", JobTitle = "Senior Financial Analyst", Image = "Assets/Images/employee10.png" });
        }
    }
}
