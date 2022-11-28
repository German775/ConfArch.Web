using ConfArch.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConfArch.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User { Id = 3522, Name = "roland", Password = "NaDJL7yyBD2/8C6cQgeNssL4w9NW9NfkSrL1YuJ0F88=",
                FavoriteColor = "blue", Role = "Admin", GoogleId = "109067086294638238826" }
        };

        public User GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u => u.Name == username &&
                u.Password == password.Sha256());
            return user;
        }

        public User GetByGoogleId(string googleId)
        {
            var user = users.SingleOrDefault(u => u.GoogleId == googleId);
            return user;
        }
    }
}
