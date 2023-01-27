using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;

namespace BloggerWay.MVC.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public User User { get; set; }
    }

}
