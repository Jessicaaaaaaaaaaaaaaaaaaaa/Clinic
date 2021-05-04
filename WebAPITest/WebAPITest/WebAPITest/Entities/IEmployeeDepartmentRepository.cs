using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public interface IEmployeeDepartmentRepository
    {
        IEnumerable<Employee> GetAllEmployees(int DepartmentId);
        void AddEmployee(Employee employee);
        Employee GetEmployee(int DeptId, int EmployeeId);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        IEnumerable<Department> GetDepartments();
        Department GetDept(int Id);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);


        void AddEmployeeToDepartment(EmployeeDepartment empDept);

    }
}
