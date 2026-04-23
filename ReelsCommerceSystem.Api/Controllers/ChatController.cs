using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReelsCommerceSystem.Api.Controllers;


public class ChatController : AppBaseController
{
    // GET /api/chat/rooms
    [HttpGet("rooms")]
    [Authorize]
    public IActionResult GetAllRooms()
    {
        throw new NotImplementedException();
    }

    // GET /api/chat/rooms/{roomIdEncr}/messages?page=1&pageSize=20&unreadonly=false&afterMessageId=XXX
    [HttpGet("rooms/{roomIdEncr}/messages")]
    [Authorize]
    public IActionResult GetMessages(
        string roomIdEncr,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20,
        [FromQuery] bool unreadonly = false,
        [FromQuery] string afterMessageId = null)
    {
        throw new NotImplementedException();
    }

    // GET /api/chat/rooms/unreadCount/{roomIdEncr}
    [HttpGet("rooms/unreadCount/{roomIdEncr}")]
    [Authorize]
    public IActionResult GetUnreadCount(string roomIdEncr)
    {
        throw new NotImplementedException();
    }

    

    // POST /api/chat/message
    [HttpPost("message")]
    [Authorize]
    public IActionResult SendMessage(/*[FromBody] SendMessageReq request*/)
    {
        throw new NotImplementedException();
    }

    // POST /api/chat/room?brandId=1
    [HttpPost("room")]
    [Authorize]
    public IActionResult CreateRoom([FromQuery] int brandId)
    {
        throw new NotImplementedException();
    }


    // POST /api/chat/status
    [HttpPost("status")]
    [Authorize]
    public IActionResult UpdateStatus(/*[FromBody] StatusReq request*/)
    {
        throw new NotImplementedException();
    }
}
