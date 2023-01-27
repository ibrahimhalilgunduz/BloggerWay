using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Entities.Abstract;

namespace BloggerWay.Entities.Dtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
