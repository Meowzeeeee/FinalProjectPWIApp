using Microsoft.AspNetCore.Identity;

namespace FinalProjectPWI.Areas.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
