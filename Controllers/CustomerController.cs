using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportManagement.Data.Dtos;
using TransportManagement.Interface;
using TransportManagement.Services;

namespace TransportManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var customers = await _customerService.GetAllCustomerAsync();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(CustomerDto addCustomerDto)
        {
            var customerDto = await _customerService.AddCustomerAsync(addCustomerDto);
            return CreatedAtAction(nameof(GetAllCustomer), customerDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditCustomer(Guid id, CustomerDto updateCustomerDto)
        {
            try
            {
                await _customerService.EditCustomerAsync(id, updateCustomerDto);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerAsync(Guid id)
        {
            try
            {
                await _customerService.DeleteCustomerAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
