using BloggerWay.Entities.Dtos;

namespace BloggerWay.MVC.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }
        public int ArticlesCount { get; set; }//aktif ve silinmemiş makaleler
        public int CommentsCount { get; set; }
        public int UsersCount { get; set; }
        public ArticleListDto Articles { get; set; }//tum makaleler

    }
}
