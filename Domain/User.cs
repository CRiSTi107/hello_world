using System;

namespace hello_world
{
    public class User
    {
        public User(int Id, string Username, string Password)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
        }

        public User():this(-1, "", "")
        {

        }

        public int Id;
        public string Username {get; set;}
        public string Password {get; set;}

        public override string ToString()
        {
            return Id.ToString() + " " + Username + " " + Password;
        }
    }
}
