using FluentValidationInApi.Models;
using FluentValidationInApi.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationInApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //more about tut => https://blog.christian-schou.dk/how-to-use-fluentvalidation-in-asp-net-core6/

        [HttpPost("add")]
        public IActionResult Add(Customer model)
        {
            if (!ModelState.IsValid)//flueant validator will be run automaticly after running ModelState.IsValid //todo check!
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }

        [HttpPut("update")]
        public IActionResult Update(Customer model)
        {
            CustomerValidator customerValidator = new();
            var validatorResult = customerValidator.Validate(model);//runned manually 

            if (!validatorResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult.Errors);
            }

            return StatusCode(StatusCodes.Status200OK, "Model is valid for update!");
        }
    }


}
