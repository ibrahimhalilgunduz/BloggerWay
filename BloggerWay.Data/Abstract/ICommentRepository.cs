﻿using BloggerWay.Entities.Concrete;
using BloggerWay.Shared.Data.Abstract;

namespace BloggerWay.Data.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
