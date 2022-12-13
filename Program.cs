using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee var1 = new Employee("Ron", 24);
            //Employee var2 = new Employee("Tye", 32);
            //Employee var3 = new Employee("Simran", 15);
            //Employee var4 = new Employee("Rheader", 26);

            List<Employee> EMP_List = new List<Employee>();
            List<Employee> attr_list = new List<Employee>();

            EMP_List.Add(new Employee("Rony", 24));
            EMP_List.Add(new Employee("Rhea", 16));
            EMP_List.Add(new Employee("Simran", 15));
            EMP_List.Add(new Employee("Rheader", 26));

            var1.Name = "djfd";

            var result = from se in EMP_List
                         where se.Name.Length == 4
                         orderby se.age
                         select se;

            foreach (var i in result)
            {
                Console.WriteLine("Name: " + i.Name + " age: " + i.age);
            }

            Console.WriteLine(result);

            //Extracting property into new result2 collection
            var result2 = EMP_List.Select(s => s.Name).ToList();
            Console.WriteLine("Extracted Name property from Employee class");
            foreach (var i in result2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }

    class Employee
    {
        private string name;
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
