using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_1
{
    class Program
    {
        static void Main(string[] args)
        {


            EmployeePromotion promotion = new EmployeePromotion();
            int check = 1;
            while (check == 1)
            {
                Employee employee = new Employee();
                employee.TakeEmployeeDetailsFromUser();

                try
                {
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    check = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input !!! Enter either 1 or 0 ");
                }

            }
            promotion.FindempbyID();
            Console.ReadKey();

        }
    }
}
