using CLERP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CLERP.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(Guid employeeId);
        Task<Employee> GetByEmailAsync(string email);
        Task<Employee> GetByUsernameAsync(string username);
        Task CreateAsync(Employee employee);
        Task Update(Employee employee);
        Task Delete(Employee employee);
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<IEnumerable<Employee>> GetEmployeesByConditionAsync(Expression<Func<Employee, bool>> expression);
    }
}
