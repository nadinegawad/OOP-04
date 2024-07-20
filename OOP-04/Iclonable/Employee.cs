using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Iclonable
{
    internal class Employee : ICloneable ,IComparable
    {
        public Employee() { }
        public Employee(Employee employee)
        {
            id = employee.id;
            name =employee.name;
            salary = employee.salary;
        }
        public int id {  get; set; }
        public string? name { get; set; }
        public decimal salary {  get; set; }

        public object Clone()
        {
            return new Employee(this);
            
               
        }

        public int CompareTo(object? obj)
        {
            Employee passedEmp= (Employee)obj;
            if(this.salary > passedEmp.salary)
            {
                return 1;
            }else if(this.salary < passedEmp.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Id : {id}\nName : {name}\nSalary : {salary}";
        }
    }
}
