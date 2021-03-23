using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom.Models
{
  public class User
  {
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
  }
}
