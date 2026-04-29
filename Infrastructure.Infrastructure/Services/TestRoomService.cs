using Microsoft.AspNetCore.Hosting;
using ReelsCommerceSystem.Application.DTOs.Response.ChatRoom;
using ReelsCommerceSystem.Application.DTOs.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class TestRoomService
    {
        private readonly string _filePath;

        public TestRoomService(IWebHostEnvironment env)
        {
            _filePath = Path.Combine(env.WebRootPath, "Test", "testRoom.json");
        }
        public async Task SaveRoomsAsync(List<TestChatRoomReq> rooms)
        {
            var json = JsonSerializer.Serialize(rooms, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            await File.WriteAllTextAsync(_filePath, json);
        }
        public async Task<List<ChatRoomRes>> GetRoomsAsync()
        {
            if (!File.Exists(_filePath))
                return new List<ChatRoomRes>();

            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<List<ChatRoomRes>>(json) ?? new();
        }
        public async Task SeedTestRooms()
        {
            var rooms = new List<TestChatRoomReq>
            {
                    new TestChatRoomReq
                {
                    User1Id = "user_1",
                    User2Id = "user_2",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-30)
                },
                new TestChatRoomReq
                {
                    User1Id = "user_1",
                    User2Id = "user_3",
                    CreatedAt = DateTime.UtcNow.AddHours(-2)
                },
                new TestChatRoomReq
                {
                    User1Id = "user_2",
                    User2Id = "user_4",
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                },
                new TestChatRoomReq
                {
                    User1Id = "user_5",
                    User2Id = "user_1",
                    CreatedAt = DateTime.UtcNow.AddDays(-3)
                },
                new TestChatRoomReq
                {
                    User1Id = "user_6",
                    User2Id = "user_7",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-5)
                }};

            await SaveRoomsAsync(rooms);
        }




    }
}
