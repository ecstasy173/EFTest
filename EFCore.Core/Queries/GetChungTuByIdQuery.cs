using EFCore.Core.Domain.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Core.Queries
{
    public record GetChungTuByIdQuery(long Id, bool IncludeDetails = false) : IRequest<ChungTuDto?>;
}
