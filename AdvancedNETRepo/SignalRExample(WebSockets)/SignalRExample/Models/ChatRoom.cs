using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample.Models
{
  public class ChatRoom
  {
    public string RoomName { get; set; }
    // Needed to be able to send specific information to a specific room.
    public List<string> ConnectionIds { get; set; }
  }
}
