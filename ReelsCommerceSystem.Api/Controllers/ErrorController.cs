using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Shared.Responses;
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
    [HttpGet("NotFound")]
    public IActionResult NotFound()
    {
        return NotFound(new ApiResponse<object>()
        {
            Success = false,
            StatusCode = 404,
            Message = new Message { En= "The requested resource was not found.", Ar = ".المورد المطلوب غير موجود" },
            Data = null
        });
    }
    [HttpPost("ValidationErrorHandlingTest")]
    public IActionResult ValidationErrorHandlingTest(Test test)
    {
       

        return Ok("");
    }
}

public class Test
{
    [Required(ErrorMessage ="This field is required")]
    public int? Id { get; set; }
    [EmailAddress(ErrorMessage = "Please Enter a valid email address")]
    public string?  Email { get; set; }
}