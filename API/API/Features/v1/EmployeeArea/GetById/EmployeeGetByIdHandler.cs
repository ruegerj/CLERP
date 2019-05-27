using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.GetById
{
    public class EmployeeGetByIdHandler : IRequestHandler<EmployeeGetByIdRequest, EmployeeResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public EmployeeGetByIdHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeResponse> Handle(EmployeeGetByIdRequest request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.FindByGuidAsync(request.EmployeeId, cancellationToken);

            if (employee == null)
            {
                return null;
            }

            return _mapper.Map<Employee, EmployeeResponse>(employee);
        }
    }
}
