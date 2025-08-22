using EFCore.Core.Domain.Dto;
using EFCore.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFCore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChungTuController : ControllerBase
    {
        private readonly IChungTuService _chungTuService;

        public ChungTuController(IChungTuService chungTuService)
        {
            _chungTuService = chungTuService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<ChungTuDto>>> Get([FromRoute] long id)
        {
            var result = await _chungTuService.GetByIdAsync(id);
            if (result == null)
                return NotFound(new ApiResponse<ChungTuDto>("Không tìm thấy chứng từ", null, "NotFound"));
            return Ok(new ApiResponse<ChungTuDto>("Lấy dữ liệu thành công", result));
        }
        [HttpGet("{id}/{includeDetails}/lazy")]
        public async Task<ActionResult<ApiResponse<ChungTuDto>>> GetWithLazyLoading(
            [FromRoute] long id,
            [FromRoute] bool includeDetails = false)
        {
            var result = await _chungTuService.GetByIdLazyLoadingAsync(id, includeDetails);
            if (result == null)
                return NotFound(new ApiResponse<ChungTuDto>("Không tìm thấy chứng từ", null, "NotFound"));

            return Ok(new ApiResponse<ChungTuDto>("Lấy dữ liệu thành công (Lazy Loading)", result));
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<ChungTuDto>>>> GetAll([FromQuery] int? take = null)
        {
            var result = await _chungTuService.GetAllAsync();
            var data = take.HasValue ? result.Take(take.Value).ToList() : result;
            return Ok(new ApiResponse<List<ChungTuDto>>("Lấy danh sách thành công", data));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<object>>> Create([FromBody] ChungTuDto dto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    );
                HttpContext.Items["ModelStateErrors"] = errors;
                return BadRequest(new ApiResponse<object>("Dữ liệu không hợp lệ", errors, "BadRequest"));
            }

            if (!string.IsNullOrEmpty(dto.Email) && !IsValidEmail(dto.Email))
                return BadRequest(new ApiResponse<object>("Email không đúng định dạng", null, "BadRequest"));

            await _chungTuService.AddAsync(dto);
            return Ok(new ApiResponse<object>("Tạo mới thành công", null));
        }

        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<object>))]
        public async Task<ActionResult<ApiResponse<object>>> Update([FromRoute] long id, [FromBody] ChungTuDto dto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    );
                HttpContext.Items["ModelStateErrors"] = errors;
                return BadRequest(new ApiResponse<object>("Dữ liệu không hợp lệ", errors, "BadRequest"));
            }
            if (!string.IsNullOrEmpty(dto.Email) && !IsValidEmail(dto.Email))
                return BadRequest(new ApiResponse<object>("Email không đúng định dạng", null, "BadRequest"));
            if (id != dto.Id)
                return BadRequest(new ApiResponse<object>("Id không khớp", null, "BadRequest"));
            await _chungTuService.UpdateAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<object>>> Delete([FromRoute] long id)
        {
            await _chungTuService.DeleteAsync(id);
            return Ok(new ApiResponse<object>("Xóa thành công", null));
        }

        [HttpGet("filter")]
        public async Task<ActionResult<ApiResponse<object>>> GetByFilter(
            [FromQuery] bool trangThaiChungTu,
            [FromQuery] string? keyword,
            [FromQuery] DateTime fromdate,
            [FromQuery] DateTime todate,
            [FromQuery] int pageindex = 1,
            [FromQuery] int pagesize = 20)
        {
            var (dataDto, total) = await _chungTuService.GetByFilterAsync(trangThaiChungTu, keyword, fromdate, todate, pageindex, pagesize);
            return Ok(new ApiResponse<object>("Lọc dữ liệu thành công", new { data = dataDto, total }));
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
