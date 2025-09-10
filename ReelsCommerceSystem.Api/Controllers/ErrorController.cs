using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Api.Controllers;

public class ErrorController : AppBaseController
{
    [HttpGet("ExceptionHandlingTest")]
    public IActionResult ExceptionHandlingTest()
    {
        for (int i = 0; i < 1000; i++)
        {
            var num = 1 / i;

        }

        return Ok("");
    }
    [HttpPost("ValidationErrorHandlingTest")]
    public IActionResult ValidationErrorHandlingTest(Test test)
    {
       

        return Ok("");
    }
}

public class Test
{
    [Required]
    public int? Id { get; set; }
}