using Microsoft.AspNetCore.Identity;

namespace BloggerWay.Entities.Concrete
{

    public class UserLogin : IdentityUserLogin<int>

    {

        public override string LoginProvider { get => base.LoginProvider; set => base.LoginProvider = value; }

        public override string ProviderKey { get => base.ProviderKey; set => base.ProviderKey = value; }


    }
}
