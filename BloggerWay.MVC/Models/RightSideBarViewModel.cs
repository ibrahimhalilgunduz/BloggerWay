using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.MVC.Models
{
    public class RightSideBarViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
