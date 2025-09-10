using Microsoft.AspNetCore.Mvc;

namespace ReelsCommerceSystem.Api.Controllers;

public class WelcomeController : AppBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome it will be good project 🙌🥰🥰🥰🥰");
    }
}

