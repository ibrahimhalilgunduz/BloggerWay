using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }

    }
}
