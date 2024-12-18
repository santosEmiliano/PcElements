using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPcElements
{
    public class Users
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        public Users(int id, string name, string account, string password, bool admin)
        {
            this.Id = id;
            this.Name = name;
            this.Account = account;
            this.Password = password;
            this.Admin = admin;
        }
    }
}
