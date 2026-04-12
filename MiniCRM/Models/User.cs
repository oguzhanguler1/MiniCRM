using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCRM.Models
{
    public class User
    {

        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;




    }
}
