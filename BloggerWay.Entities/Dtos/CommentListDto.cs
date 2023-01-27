using BloggerWay.Entities.Concrete;
using System.Collections.Generic;

namespace BloggerWay.Entities.Dtos
{
    public class CommentListDto
    {
        public IList<Comment> Comments { get; set; }
    }
}
