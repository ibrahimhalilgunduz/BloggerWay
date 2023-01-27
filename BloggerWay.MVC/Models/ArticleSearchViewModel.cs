using BloggerWay.Entities.Dtos;

namespace BloggerWay.MVC.Models
{
    public class ArticleSearchViewModel
    {
        public ArticleListDto ArticleListDto { get; set; }
        public string Keyword { get; set; }
    }
}
