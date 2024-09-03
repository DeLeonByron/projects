using Microsoft.AspNetCore.Mvc;
using ArithmeticCalculatorApi.Services;
using ArithmeticCalculatorApi.Models;

namespace ArithmeticCalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArithmeticController : ControllerBase
    {
        private readonly IArithmeticService _arithmeticService;

        public ArithmeticController(IArithmeticService arithmeticService)
        {
            _arithmeticService = arithmeticService;
        }

        [HttpGet("sum")]
        public IActionResult Sum([FromQuery] OperationRequest request)
        {
            if (request == null || request.Number1 == 0 || request.Number2 == 0)
                return BadRequest(new { message = "Invalid input parameters." });

            var result = _arithmeticService.Add(request.Number1, request.Number2);
            return Ok(new OperationResult { Result = result });
        }

        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] OperationRequest request)
        {
            if (request == null || request.Number1 == 0 || request.Number2 == 0)
                return BadRequest(new { message = "Parametros invalidos." });

            var result = _arithmeticService.Subtract(request.Number1, request.Number2);
            return Ok(new OperationResult { Result = result });
        }

        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] OperationRequest request)
        {
            if (request == null || request.Number1 == 0 || request.Number2 == 0)
                return BadRequest(new { message = "Parametros invalidos." });

            var result = _arithmeticService.Multiply(request.Number1, request.Number2);
            return Ok(new OperationResult { Result = result });
        }

        [HttpGet("divide")]
        public IActionResult Divide([FromQuery] OperationRequest request)
        {
            if (request == null || request.Number2 == 0)
                return BadRequest(new { message = "No se puede dividir por cero" });

            var result = _arithmeticService.Divide(request.Number1, request.Number2);
            return Ok(new OperationResult { Result = result });
        }
    }
}
