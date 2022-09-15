using SampleWebApi.Entities;
using SampleWebApi.Models;

namespace SampleWebApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepositoty
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
           int result= _context.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int? id)
        {
            int res = 0;
            Employee emp = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            if(emp != null)
            {
                _context.Employees.Remove(emp);
                res=_context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        public Employee GetEmployeeById(int? id)
        {
            Employee emp = _context.Employees.Find(id);
            return emp;
        }

        public int UpdateEmployee(Employee employee)
        {

            int res = 0;
            Employee emp = _context.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Gender = employee.Gender;
                emp.Dob = employee.Dob;
                emp.City = employee.City;
                res = _context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }
    }
}
