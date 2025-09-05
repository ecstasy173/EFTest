using EFCore.Core.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Commands
{
    public class CreateChungTuHandler : IRequestHandler<CreateChungTuCommand,Unit>
    {
        private readonly IChungTuService _service;

        public CreateChungTuHandler(IChungTuService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(CreateChungTuCommand request, CancellationToken cancellationToken)
        {
            await _service.AddAsync(request.Dto);
            return Unit.Value;
        }
    }
}
