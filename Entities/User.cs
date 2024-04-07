using Microsoft.AspNetCore.Identity;

namespace LoginTemplate.Entities
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
