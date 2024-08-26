using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportManagement.Data.Dtos;
using TransportManagement.Interface;

namespace TransportManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitManagementController : BaseApiController
    {
        private readonly IUnitManagementService _unitManagementService;
        public UnitManagementController(IUnitManagementService unitManagementService)
        {
            _unitManagementService = unitManagementService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUnitManagement()
        {
            var unitManagements = await _unitManagementService.GetAllUnitManagementAsync();
            return Ok(unitManagements);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnitManagementById(Guid id)
        {
            var unitManagement = await _unitManagementService.GetUnitManagementByIdAsync(id);
            if (unitManagement == null)
            {
                return NotFound();
            }
            return Ok(unitManagement);
        }
        [HttpPost]
        public async Task<IActionResult> AddUnitManagement(UnitManagementDto addUnitManagementDto)
        {
            var UnitManagementDto = await _unitManagementService.AddUnitManagementAsync(addUnitManagementDto);
            return CreatedAtAction(nameof(GetAllUnitManagement), UnitManagementDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditUnitManagement(Guid id, UnitManagementDto updateUnitManagementDto)
        {
            try
            {
                await _unitManagementService.EditUnitManagementAsync(id, updateUnitManagementDto);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitManagementAsync(Guid id)
        {
            try
            {
                await _unitManagementService.DeleteUnitManagementAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
