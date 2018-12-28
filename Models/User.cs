using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class User
    {
       public string UserId { get; set; }
       public string UserName { get; set; }
       public User(string UserId,string UserName)
       {
           this.UserId = UserId;
           this.UserName = UserName;
       }
    }
}
