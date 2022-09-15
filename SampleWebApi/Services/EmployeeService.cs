using SampleWebApi.Models;
using SampleWebApi.Repositories;

namespace SampleWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepositoty _repo;
        public EmployeeService(IEmployeeRepositoty repo)
        {
            _repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
           return _repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int? id)
        {
            return (_repo.DeleteEmployee(id));
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int? id)
        {
            return _repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee employee)
        {
            return _repo.UpdateEmployee(employee);
        }
        public IEnumerable<City> GetCities()
        {
            return _repo.GetCities();   
        }
    }
}
