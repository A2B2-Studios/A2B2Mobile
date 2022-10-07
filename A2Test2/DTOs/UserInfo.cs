using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Test2.DTOs
{
    public class UserInfo
    {
        [Required]
        public string Username { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
