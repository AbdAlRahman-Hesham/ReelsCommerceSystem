using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Message;
using ReelsCommerceSystem.Application.DTOs.Response.Chat;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;


public class ChatController(IChatRoomService _chatRoomService,IUnitOfWork _unitOfWork) : AppBaseController
{

    private readonly IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }

    // GET /api/chat/rooms
    [HttpGet("rooms")]
    [Authorize]
    public async Task<IActionResult> GetAllRooms()
    {
        var userId = User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? String.Empty;

        var rooms = await _chatRoomService.GetUserRooms(userId);

        return Ok(rooms);
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
    public async Task<IActionResult> GetUnreadCount(string roomIdEncr)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value??String.Empty ;
        var roomId = int.Parse(EncryptionHelper.Decrypt(roomIdEncr));

        var count = await _chatRoomService.GetUnreadCount(roomId, userId);

        return Ok(count);
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
                    "?? ????? ??????? ?????"
                ));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    ex.Message,
                    "??? ???? ?? ?????? ???????"
                ));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Something went wrong",
                    "??? ??? ??",
                    new List<ValidationError>
                    {
                    new ValidationError
                    {
                        Field = "Server",
                        En = ex.Message,
                        Ar = "??? ????? ?? ???????"
                    }
                    }
                ));
            }
        }
    }

// POST /api/chat/room/test
[HttpPost("room/test")]
public async Task<IActionResult> CreateRoom([FromQuery] string userId)
{
    var currentUser = User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

    var roomId = await _chatRoomService.CreateRoom(currentUser, userId);

    return Ok(EncryptionHelper.Encrypt(roomId.ToString()));
}

// POST /api/chat/room?brandId=1
[HttpPost("room")]
[Authorize]
public async Task<IActionResult> CreateRoom([FromQuery] int brandId)
{
    var currentUser = User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

    var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(brandId);
    var roomId = await _chatRoomService.CreateRoom(currentUser, brand.UserId);

    return Ok(EncryptionHelper.Encrypt(roomId.ToString()));
}

    // POST /api/chat/status
    [HttpPost("status")]
    [Authorize]
    public IActionResult UpdateStatus(/*[FromBody] StatusReq request*/)
    {
        throw new NotImplementedException();
    }
    [HttpDelete("room/{roomIdEncr}")]
    public async Task<IActionResult> Delete(string roomIdEncr)
    {
        var roomId = int.Parse(EncryptionHelper.Decrypt(roomIdEncr));

        await _chatRoomService.DeleteRoom(roomId);

        return NoContent();
    }
}
