using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            Thread.Sleep(5000);
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("userid")]
        public IActionResult GetById(int customerId)
        {
            var result = _customerService.GetById(customerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult PostAdd(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult PostDelete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult PostUpdate(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
