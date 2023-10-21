using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Model
{

    public class User
    {
        public string name;
        public string phone;
        public string email;
        public string address;
        public int accountType;
        public Account acccount;

        public User(string name, string phone, string email, string address, int accountType, Account account)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.accountType = accountType;
            this.acccount = account;
        }

    }
}
