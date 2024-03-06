using Practice.Helpers.ResponseMessages;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();

        EmployeeResponse GetById(Employee[] employees, int? id);

        Employee[] Search(Employee[] employees,string searchText);
    }
}
