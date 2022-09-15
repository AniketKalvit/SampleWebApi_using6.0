using SampleWebApi.Models;

namespace SampleWebApi.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int ? id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int? id);
        public IEnumerable<City> GetCities();
    }
}
