using EFCore.Core.Domain.Dto;
using EFCore.Core.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Queries
{
    public class GetChungTuByIdHandler : IRequestHandler<GetChungTuByIdQuery, ChungTuDto?>
    {
        private readonly IChungTuService _service;

        public GetChungTuByIdHandler(IChungTuService service)
        {
            _service = service;
        }

        public async Task<ChungTuDto?> Handle(GetChungTuByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.IncludeDetails)
                return await _service.GetByIdLazyLoadingAsync(request.Id, true);

            return await _service.GetByIdAsync(request.Id);
        }
    }
}
