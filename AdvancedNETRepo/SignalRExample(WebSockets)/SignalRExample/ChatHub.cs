using Microsoft.AspNetCore.SignalR;
using SignalRExample.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample
{
  public class ChatHub : Hub
  {
    // Database object needed to act on it.
    private readonly AppDbContext _dbContext;

    // Concurrent dictionary is thread-safe so that multiple connections can access it simultaneously.
    private static ConcurrentDictionary<string, string> CurrentUsers = new ConcurrentDictionary<string, string>();
    private static ConcurrentDictionary<string, ChatRoom> ChatRooms = new ConcurrentDictionary<string, ChatRoom>();

    public ChatHub(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // Message sent back to the client after they are connected. Need to update the javascript file 'site.js' after adding this method.
    public override async Task OnConnectedAsync()
    {
      await Clients.Caller.SendAsync("ReceiveMessage", "Chat Hub", DateTimeOffset.Now, "Welcome to Chat Hub!");

      await base.OnConnectedAsync();
    }

    public async Task SendMessage(string roomName, string userName, string textMessage)
    {
      // Here, the "Context" comes from Hub base class.
      if(!CurrentUsers.ContainsKey(Context.ConnectionId))
        CurrentUsers.TryAdd(Context.ConnectionId, userName);

      var message = new ChatMessage
      {
        UserName = userName,
        Message = textMessage,
        TimeStamp = DateTimeOffset.Now
      };

      //TODO: Add stuff to DB here


      // Send a message to a room using the Group() method for it to be receieved by JS code in 'site.js'.
      await Clients.Group(roomName.ToLower()).SendAsync("ReceiveMessage", message.UserName, message.TimeStamp, message.Message);
    }

    // Needed to add a user to a specific room.
    public async Task JoinRoom(string roomName)
    {
      roomName = roomName.ToLower();
      string currentConnectionId = Context.ConnectionId;

      // When no room name exist, add a new room with a connection id.
      if(!ChatRooms.ContainsKey(roomName))
      {
        ChatRoom newRoom = new ChatRoom()
        { 
          RoomName = roomName, 
          ConnectionIds = new List<string>() 
        };

        // Unique id per connection, NOT per user.
        newRoom.ConnectionIds.Add(currentConnectionId);

        // Add a room to this ChatHub's concurrent chatRooms dictionary
        ChatRooms.TryAdd(roomName, newRoom);
      }
      else  // Try to get the chatroom connection id value from this ChatHub's chatRooms dictionary.
      {
        ChatRoom existingRoom = new ChatRoom();
        ChatRooms.TryGetValue(roomName, out existingRoom);
        existingRoom.ConnectionIds.Add(currentConnectionId);

        // Try adding existing room with roomName as the key in the chatRooms dictionary.
        ChatRooms.TryAdd(roomName, existingRoom);
      }

      // Supply a connection id asynchronously to a group of connections with a roomName as the group name.
      await Groups.AddToGroupAsync(Context.ConnectionId, roomName);

      // Responding back to the caller who will use the ReceiveMessage javascript connection name from chat hub in this case with the datetime and roomName.
      await Clients.Caller.SendAsync("ReceiveMessage", "Chat Hub", DateTimeOffset.Now, $"You joined room {roomName}!");
    }

    public async Task SendAllMessage(string userName, string textMessage)
    {
      var message = new ChatMessage
      {
        UserName = userName,
        Message = textMessage,
        TimeStamp = DateTimeOffset.Now
      };
      
      // This is a way to allow all users to communicate, for example, in the same room.
      await Clients.All.SendAsync("ReceiveMessage", message.UserName, message.TimeStamp, message.Message);
    }
  }
}
