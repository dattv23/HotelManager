using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class Validator
    {
        public static bool IsValidFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return false;
            }
            return true;
        }


        public static bool IsValidLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";

            if (Regex.IsMatch(email, emailPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidAddress(string address)
        {
            return !string.IsNullOrEmpty(address);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }
    }
}
