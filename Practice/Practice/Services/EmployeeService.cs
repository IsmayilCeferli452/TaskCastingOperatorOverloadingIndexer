using Practice.Helpers.ResponseMessages;
using Practice.Models;
using Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                Id = 1,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),
            };

            Employee employee2 = new()
            {
                Id = 2,
                Name = "Rufat",
                Surname = "Ismayilov",
                Age = 22,
                Email = "rufat@gmail.com",
                Address = "Baki",
                Birthday = new DateTime(2003, 9, 4),
            };

            Employee employee3 = new()
            {
                Id = 3,
                Name = "Cavid",
                Surname = "Bashirov",
                Age = 30,
                Email = "cavid@gmail.com",
                Address = "Siyezen",
                Birthday = DateTime.Now.AddYears(-30),
            };

            Employee employee4 = new()
            {
                Id = 4,
                Name = "Amirastan",
                Surname = "Mereyev",
                Age = 33,
                Email = "Amirastan@gmail.com",
                Address = "Xezer",
                Birthday = DateTime.Now.AddYears(-33),
            };

            Employee employee5 = new()
            {
                Id = 5,
                Name = "Esgerxan",
                Surname = "Bayramov",
                Age = 27,
                Email = "esgerxan@gmail.com",
                Address = "Berde",
                Birthday = DateTime.Now.AddYears(-27),
            };

            Employee employee6 = new()
            {
                Id = 6,
                Name = "Behruz",
                Surname = "Aliyev",
                Age = 21,
                Email = "bahruz@gmail.com",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),
            };

            Employee employee7 = new()
            {
                Id = 7,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),
            };
            Employee employee8 = new()
            {
                Id = 8,
                Name = "Ismayil",
                Surname = "Ceferli",
                Age = 24,
                Email = "ismayil@gmail.com",
                Address = "Ehmedli",
                Birthday = DateTime.Now.AddYears(-24),
            };

            return new Employee[] { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8 };
        }

        public EmployeeResponse GetById(Employee[] employees, int? id)
        {
            if(id is null)
            {
                return new EmployeeResponse { ErrorMessage = "Id can't be null" };
            }

            return new EmployeeResponse { Employee = employees.FirstOrDefault(m => m.Id == id) };
        }

        //public Employee Search(Employee[] employees, string? name, string? surname)
        //{
        //    return employees.FirstOrDefault(x => x.Name.Trim().ToLower() == name.Trim().ToLower() || x.Surname.Trim().ToLower() == surname.Trim().ToLower());
        //}

        public Employee[] Search(Employee[] employees, string searchText)
        {
            return employees.Where(m => m.Name.Trim().ToLower().Contains(searchText.Trim().ToLower()) || m.Surname.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();
        }
    }
}
