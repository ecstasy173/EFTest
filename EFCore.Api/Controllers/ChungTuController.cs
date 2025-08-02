using EFCore.Core.Domain.Dto;
using EFCore.Core.Interface;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<ChungTuDto>> Get(long id)
        {
            var result = await _chungTuService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<ChungTuDto>>> GetAll()
        {
            var result = await _chungTuService.GetAllAsync();
            return Ok(result.Take(10));
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ChungTuDto dto)
        {
            await _chungTuService.AddAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(long id, [FromBody] ChungTuDto dto)
        {
            if (id != dto.Id) return BadRequest();
            await _chungTuService.UpdateAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            await _chungTuService.DeleteAsync(id);
            return Ok();
        }
        [HttpGet("filter")]
        public async Task<ActionResult<(IList<ChungTuDto>, long)>> GetByFilter(
    [FromQuery] bool trangThaiChungTu,
    [FromQuery] string? keyword,
    [FromQuery] DateTime fromdate,
    [FromQuery] DateTime todate,
    [FromQuery] int pageindex = 1,
    [FromQuery] int pagesize = 20)
        {
            var (dataDto, total) = await _chungTuService.GetByFilterAsync(trangThaiChungTu, keyword, fromdate, todate, pageindex, pagesize);

            return Ok(new { dataDto, total });
        }
    }
}
