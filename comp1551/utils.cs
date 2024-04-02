using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comp1551
{
    internal class utils
    {
        // validates a phone number using a regular expression
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        // validates an email address using a regular expression
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }


        // this will be used for login as main purpose, and to identify the current user logged in the application
        public static class GlobalVariables
        {
            public static string UserName { get; set; }
            public static string UserRole { get; set; }

            public static int UserId { get; set; }
        }
    }
}
