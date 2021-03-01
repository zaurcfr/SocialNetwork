using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    abstract class Human
    {
        public Human()
        {
            ID = Human_ID++;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public static int Human_ID { get; set; } = 1;

        public bool SignIn(string username, string password)
        {
            if (Username == username)
            {
                if (Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nUsername: {Username}";
        }

    }
}
