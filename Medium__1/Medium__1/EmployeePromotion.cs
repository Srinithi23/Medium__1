using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_1
{
    class EmployeePromotion : Employee
    {

        public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();


        public void FindempbyID()
        {
            int id = -1;
            try
            {
                Console.WriteLine("Please enter the employee ID : ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ID must be a number !!! Enter a number ");
                FindempbyID();
                return;
            }

            if (employees.ContainsKey(id))
            {
                Console.WriteLine(employees[id].ToString());
            }
            else
            {
                Console.WriteLine("Employee ID: {0} not found in Promotion List", id);
            }
        }
    }
}