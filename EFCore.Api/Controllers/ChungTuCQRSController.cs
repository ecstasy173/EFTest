using EFCore.Core.Domain.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using EFCore.Core.Queries;
using EFCore.Core.Commands;

namespace EFCore.Api.Controllers
{
    public class ChungTuCQRSController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChungTuCQRSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<ChungTuDto>>> Get([FromRoute] long id)
        {
            var result = await _mediator.Send(new GetChungTuByIdQuery(id));
            if (result == null)
                return NotFound(new ApiResponse<ChungTuDto>("Không tìm thấy chứng từ", null, "NotFound"));
            return Ok(new ApiResponse<ChungTuDto>("Lấy dữ liệu thành công", result));
        }

        [HttpGet("{id}/{includeDetails}/lazy")]
        public async Task<ActionResult<ApiResponse<ChungTuDto>>> GetWithLazyLoading([FromRoute] long id, [FromRoute] bool includeDetails = false)
        {
            var result = await _mediator.Send(new GetChungTuByIdQuery(id, includeDetails));
            if (result == null)
                return NotFound(new ApiResponse<ChungTuDto>("Không tìm thấy chứng từ", null, "NotFound"));
            return Ok(new ApiResponse<ChungTuDto>("Lấy dữ liệu thành công (Lazy Loading)", result));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<object>>> Create([FromBody] ChungTuDto dto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(k => k.Key, v => v.Value.Errors.Select(e => e.ErrorMessage).ToArray());
                HttpContext.Items["ModelStateErrors"] = errors;
                return BadRequest(new ApiResponse<object>("Dữ liệu không hợp lệ", errors, "BadRequest"));
            }
            await _mediator.Send(new CreateChungTuCommand(dto));
            return Ok(new ApiResponse<object>("Tạo mới thành công", null));
        }
    }
}
