using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Market.DataAccess.Database.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Game> Games { get; set; }
        public User()
        {
            Games = new List<Game>();
        }
    }
}
