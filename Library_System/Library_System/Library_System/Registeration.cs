using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System
{
    public static class Registeration
    {
        static Dictionary<int,User> users = new Dictionary<int,User>();

        public static void registerUser(int id, string name, string email, string password)
        {
            User user = new User(id, name, email, password);
            users.Add(id, user);
            program.currentuser = user;
        }


        public static void login(int id,string password)
        {
            if (users.ContainsKey(id))
            {
                if (users[id].verfiy(password))
                {
                    program.currentuser = users[id];
                    Console.WriteLine($"user{id} loged in");
                }

            }
            else Console.WriteLine("not vaild data");
        }
    }
}