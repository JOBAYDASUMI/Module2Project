using Project_Mid_03.Factories;
using Project_Mid_03.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mid_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mf = new ModelFactory();
            new TestClass(mf).TestAction();
            Console.ReadLine();

        }
    }
}
