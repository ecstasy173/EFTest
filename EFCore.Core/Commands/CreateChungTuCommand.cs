using EFCore.Core.Domain.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Commands
{
    public record CreateChungTuCommand(ChungTuDto Dto) : IRequest<Unit>;
}
