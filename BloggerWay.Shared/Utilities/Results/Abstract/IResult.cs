using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using System;

namespace BloggerWay.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } // ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get; }
    }
}
