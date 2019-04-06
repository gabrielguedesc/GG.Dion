using System.Threading.Tasks;
using GG.Dion.Application.Interfaces;
using GG.Dion.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GG.Dion.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomersController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerAppService.GetAllAsync();

            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CustomerViewModel customerViewModel)
        {
            var customer = await _customerAppService.AddAsync(customerViewModel);

            if (!customer.ValidationResult.IsValid)
                return BadRequest(customer.ValidationResult);

            return Ok(customer);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(CustomerViewModel customerViewModel)
        {
            var customer = await _customerAppService.UpdateAsync(customerViewModel);

            if (!customer.ValidationResult.IsValid)
                return BadRequest(customer.ValidationResult);

            return Ok(customer);
        }
    }
}