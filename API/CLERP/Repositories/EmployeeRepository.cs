using CLERP.Domain.Models;
using CLERP.Persistence.Contexts;
using CLERP.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ClerpContext context) : base(context)
        {
        }

        public async Task CreateEmployee(Employee employee)
        {
            
        }

        public async Task DeleteEmployee(Employee employee)
        {
            Delete(employee);
            await SaveAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => String.Equals(e.Email, email, StringComparison.InvariantCultureIgnoreCase));
        }

        public async Task<Employee> GetEmployeeByIdAsync(Guid employeeGuid)
        {
            return await GetByIdAsync(employeeGuid);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
