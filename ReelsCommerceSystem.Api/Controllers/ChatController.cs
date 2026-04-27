using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Message;
using ReelsCommerceSystem.Application.DTOs.Response.Chat;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;


public class ChatController : AppBaseController
{

    private readonly IChatService _chatService;
    private readonly IChangeMessageStatusService _changeMessageStatusService;



    public ChatController(IChatService chatService, IChangeMessageStatusService changeMessageStatusService)
    {
        _chatService = chatService;
        _changeMessageStatusService = changeMessageStatusService;
    }

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
    public async Task<IActionResult> GetMessages
        (
            string roomIdEncr,
            [FromQuery] int? page,
            [FromQuery] int? pageSize,
            [FromQuery] bool? unreadOnly,
            [FromQuery] string? afterMessageId
        )
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var result = await _chatService.GetMessagesAsync(
            userId,
            roomIdEncr,
            page,
            pageSize,
            unreadOnly,
            afterMessageId);

        return Ok(result);
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
    public async Task<IActionResult> SendMessage([FromBody] SendMessageReq dto)
    {
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var result = await _chatService.SendMessageAsync(userId, dto);

                return Ok(ApiResponse<MessageRes>.SuccessResponse(
                    result,
                    HttpStatusCode.OK,
                    "Message sent successfully",
                    "تم ارسال الرساله بنجاح"
                ));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    ex.Message,
                   "غير مصرح لك بالدخول يرجي تسجيل الدخول"
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Something went wrong",
                    "حدث خطأ ما",
                    new List<ValidationError>
                    {
                    new ValidationError
                    {
                        Field = "Server",
                        En = ex.Message,
                       Ar = "حدث خطا"
                    }
                    }
                ));
            }
        }
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
    public async Task<IActionResult> ChangeMessageStatus(
    [FromBody] ChangeMessageStatusReq request)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

       var Result= await _changeMessageStatusService.ChangeStatusAsync(
            userId,
            request.RoomId,
            request.Status,
            request.MessageIdsEncrypted);

        return StatusCode(Result.StatusCode, Result);
    }

    [HttpDelete("message/{messageIdEnc}")]
    [Authorize]
    public async Task<IActionResult> DeleteMessage(string messageIdEnc)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var result = await _chatService.DeleteMessageAsync(userId, messageIdEnc);

        return Ok(result);
    }
    [HttpDelete("room/{roomIdEnc}/messages")]
    [Authorize]
    public async Task<IActionResult> DeleteAllMessages(string roomIdEnc)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        var result = await _chatService.DeleteAllMessagesAsync(userId, roomIdEnc);

        return Ok(result);
    }
}
