using AutoMapper;
using CLERP.API.Infrastructure.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea.GetAll
{
    public class WarehouseGetAllHandler : IRequestHandler<WarehouseGetAllRequest, WarehouseGetAllResponse>
    {
        private readonly ClerpContext _context;
        private readonly IMapper _mapper;

        public WarehouseGetAllHandler(ClerpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WarehouseGetAllResponse> Handle(WarehouseGetAllRequest request, CancellationToken cancellationToken)
        {
            var warehouses = await _context.Warehouses
                                .Include(w => w.Shelves)
                                    .ThenInclude(s => s.Compartments)
                                .Include(w => w.Address)
                                    .ThenInclude(a => a.City)
                                        .ThenInclude(c => c.Country)
                                .ToListAsync(cancellationToken);

            return new WarehouseGetAllResponse()
            {
                Warehouses = warehouses.Select(w =>
                {
                    var warehouseDto = _mapper.Map<WarehouseResponse>(w);
                    warehouseDto.Shelves = w.Shelves.Select(s =>
                    {
                        var shelfDto = _mapper.Map<WarehouseShelfResponse>(s);
                        shelfDto.Compartments = s.Compartments.Select(c => _mapper.Map<WarehouseCompartmentResponse>(c));

                        return shelfDto;
                    });

                    return warehouseDto;
                })
            };
        }
    }
}
