using AutoMapper;
using CLERP.API.Domain.Models;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.DepartmentArea.GetById
{
    public class DepartmentGetByIdHandler : IRequestHandler<DepartmentGetByIdRequest, DepartmentResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;
        public DepartmentGetByIdHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DepartmentResponse> Handle(DepartmentGetByIdRequest request, CancellationToken cancellationToken)
        {
            var department = await _context.Departments.FindByGuidAsync(request.DepartmentId, cancellationToken);

            if (department == null)
            {
                return null;
            }

            return _mapper.Map<Department, DepartmentResponse>(department);
        }
    }
}
