using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }
        public int? CategoryId { get; set; }
    }
}
