using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Categories { get; set; }

    }
}
