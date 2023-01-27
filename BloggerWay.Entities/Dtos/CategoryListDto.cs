using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Categories { get; set; }

    }
}
