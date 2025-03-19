using System.Collections.Generic;
using ComunidadeCulinaria.Models;

namespace ComunidadeCulinaria.Services
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public User GetUser(string username)
        {
            return users.Find(u => u.Username == username);
        }
    }
}
