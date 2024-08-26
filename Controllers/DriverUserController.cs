using Microsoft.AspNetCore.Mvc;
using TransportManagement.Data.Dtos;
using TransportManagement.Interface;

namespace TransportManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverUserController : ControllerBase
    {
        private readonly IDriverUserService _driverUserService;
        public DriverUserController(IDriverUserService driverUserService) { 
            _driverUserService = driverUserService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDriverUser()
        {
            var driverUsers = await _driverUserService.GetAllDriverUserAsync();
            return Ok(driverUsers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDriverUserById(Guid id)
        {
            var driverUser = await _driverUserService.GetDriverUserByIdAsync(id);
            if (driverUser == null)
            {
                return NotFound();
            }
            return Ok(driverUser);
        }
        [HttpPost]
        public async Task<IActionResult> AddDriverUser(DriverUserDto addDriverUserDto)
        {
            var driverUserDto = await _driverUserService.AddDriverUserAsync(addDriverUserDto);
            return CreatedAtAction(nameof(GetAllDriverUser), driverUserDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditDriverUser(Guid id, DriverUserDto updateDriverUserDto)
        {
            try
            {
                await _driverUserService.EditDriverUserAsync(id, updateDriverUserDto);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriverUserAsync(Guid id)
        {
            try
            {
                await _driverUserService.DeleteDriverUserAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
