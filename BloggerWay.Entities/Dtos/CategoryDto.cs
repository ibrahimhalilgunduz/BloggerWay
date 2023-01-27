using BloggerWay.Entities.Concrete;

namespace BloggerWay.Entities.Dtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
