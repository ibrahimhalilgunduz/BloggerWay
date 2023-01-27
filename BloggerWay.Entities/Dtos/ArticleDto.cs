using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Entities.Abstract;

namespace BloggerWay.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }


    }
}
