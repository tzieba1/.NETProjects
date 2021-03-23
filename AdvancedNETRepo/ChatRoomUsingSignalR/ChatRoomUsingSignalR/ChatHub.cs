using ChatRoom.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomUsingSignalR
{
  public class ChatHub : Hub
  {
    /// <summary>
    /// Database context needed to be acted on asynchronously within this ChatHub.
    /// </summary>
    private readonly AppDbContext _dbContext;

    // Concurrent dictionary is thread-safe so that multiple connections can access it simultaneously.
    private static ConcurrentDictionary<string, string> CurrentUsers = new ConcurrentDictionary<string, string>();
    private static ConcurrentDictionary<string, Room> ChatRooms = new ConcurrentDictionary<string, Room>();

    /// <summary>
    /// Default constructor uses the current database context for this 
    /// </summary>
    /// <param name="dbContext"></param>
    public ChatHub(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }
  }
}
