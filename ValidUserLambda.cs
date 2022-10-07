using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationEx
{
    public class ValidUserLambda
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public int PhoneNumber;
        public ValidUserLambda(string firstName, string lastName, string email, string password, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
        public static void AddRecords(List<ValidUserLambda> user)
        {
            user.Add(new ValidUserLambda("subodh", "nagalwade", "subod@gmail.com", "maha", 1234567890));

            foreach (var person in user.OrderBy(x => x.FirstName))
            {
                Console.WriteLine("FirstName     : " + person.FirstName);
                Console.WriteLine("LastName      : " + person.LastName);
                Console.WriteLine("Email         : " + person.Email);
                Console.WriteLine("Password       : " + person.Password);
                Console.WriteLine("Mobile Number  : " + person.PhoneNumber);
            }
        }
    }
}
