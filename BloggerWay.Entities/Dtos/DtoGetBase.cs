using BloggerWay.Shared.Utilities.Results.ComplexTypes;

namespace BloggerWay.Entities.Dtos
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }

    }
}
