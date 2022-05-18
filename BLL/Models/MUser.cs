using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MUser
    {
        public MUser()
        {
        }

        public MUser(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
