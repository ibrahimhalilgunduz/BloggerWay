using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BloggerWay.Entities.Concrete
{
    public class User : IdentityUser<Guid>
    {


        public string Picture { get; set; }


        public ICollection<Article> Articles { get; set; }
    }
}
