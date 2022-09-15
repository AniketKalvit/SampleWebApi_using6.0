using SampleWebApi.Models;

namespace SampleWebApi.Repositories
{
    public interface IEmployeeRepositoty
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int? id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int? id);
        IEnumerable<City> GetCities();
    }
}
