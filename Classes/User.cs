using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

        public User(int UserId, string Fio, string Login, string Password, double Balance)
        {
            this.UserId = UserId;
            this.Fio = Fio;
            this.Login = Login;
            this.Password = Password;
            this.Balance = Balance;
        }
    }
}
