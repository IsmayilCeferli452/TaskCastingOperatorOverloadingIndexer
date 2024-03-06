using Practice.Models;
using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class EmployeeController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
            var employee = _employeeService.GetAll();

            foreach (var item in employee)
            {
                Console.WriteLine($"Name:{item.Name} | Surname:{item.Surname} | Age:{item.Age} | Address:{item.Address} | Email:{item.Email} | Birthday: {item.Birthday.ToString("MM-dd-yyyy")}");
            }
        }

        public void GetById()
        {
            var response = _employeeService.GetById(_employeeService.GetAll(), 1);

            if (response.ErrorMessage is null)
            {
                Console.WriteLine($"Name:{response.Employee.Name} | Surname:{response.Employee.Surname} | Age:{response.Employee.Age} | Address:{response.Employee.Address} | Email:{response.Employee.Email} | Birthday: {response.Employee.Birthday.ToString("MM-dd-yyyy")}");
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
        public void Search()
        {
            Name:  Console.WriteLine("Please add search text:");
            string searchText = Console.ReadLine();

            var result = _employeeService.Search(_employeeService.GetAll(), searchText);

            if (string.IsNullOrWhiteSpace(searchText))
            {
                goto Name;
            }

            if(result.Length == 0)
            {
                Console.WriteLine("Employee not found, please try again...");
                goto Name;
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"Name:{item.Name} | Surname:{item.Surname} | Age:{item.Age} | Birthday:{item.Birthday} | Email:{item.Email} | Address:{item.Address}");
                    return;
                }
            }
        }
    }
}
