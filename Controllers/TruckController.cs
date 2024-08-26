using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.Mvc;
using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;
using TransportManagement.Interface;

namespace TransportManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : BaseApiController
    {
        private readonly ITruckService _truckService;
        public TruckController(ITruckService truckService)
        {
            _truckService = truckService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTruck()
        {
            var trucks = await _truckService.GetAllTruckAsync();
            return Ok(trucks);  
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTruckById(Guid id)
        {
            var truck = await _truckService.GetTruckByIdAsync(id);
            if(truck == null)
            {
                return NotFound();
            }
            return Ok(truck);
        }
        [HttpPost]
        public async Task<IActionResult> AddTruck(TruckDto addTruckDto)
        {
            var truckDto = await _truckService.AddTruckAsync(addTruckDto);
            return CreatedAtAction(nameof(GetAllTruck), truckDto);   
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditTruck(Guid id,TruckDto updateTruckDto)
        {
            try
            {
                await _truckService.EditTruckAsync(id, updateTruckDto);
                return NoContent();
            }
            catch(KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTruckAsync(Guid id)
        {
            try
            {
                await _truckService.DeleteTruckAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

    }
}
