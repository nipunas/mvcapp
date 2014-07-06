using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
    }
}