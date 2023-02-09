using Microsoft.AspNetCore.Identity;

namespace D_D_Character_Creator.Data.account
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
