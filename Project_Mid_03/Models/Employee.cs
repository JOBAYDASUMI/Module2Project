using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mid_03.Models
{
    public class Employee : IDataModel
    {
        public Employee() { }
        public Employee(int id, string name, int departmentId, DateTime joinDate)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentId = departmentId;
            this.JoinDate = joinDate;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public DateTime JoinDate { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Dept. Id: {DepartmentId} Join Date: {JoinDate:yyyy-MM-dd}";
        }
    }

}
