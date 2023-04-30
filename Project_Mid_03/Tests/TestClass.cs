using Project_Mid_03.Factories;
using Project_Mid_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mid_03.Tests
{
    public class TestClass
    {
        private readonly IModelFactory modelFactory;
        public TestClass(IModelFactory modelFactory)
        {
            this.modelFactory = modelFactory;
        }
        public void TestAction()
        {
            List<Department> listDepartment = new List<Department>
            {
                modelFactory.Create<Department>(1, "IT"),
                modelFactory.Create<Department>(2, "Marketing"),
                modelFactory.Create<Department>(3, "Production")
            };
            Console.WriteLine("**********Departments************");
            listDepartment
            .ForEach(d => Console.WriteLine(d));

            List<Employee> listEmployees = new List<Employee>
            {
                modelFactory.Create< Employee>(1, "Hossain Bakar",1, new DateTime(2020, 5,3)),
                modelFactory.Create< Employee>(2, "Ali Ahmed",2, new DateTime(2019, 9,1)),
                modelFactory.Create< Employee>(3, "Masud Rana",1, new DateTime(2020, 2,2))
            };
            Console.WriteLine("**********Employees************");

            listEmployees
            .ForEach(emp => Console.WriteLine(emp));
        }
    }

}
