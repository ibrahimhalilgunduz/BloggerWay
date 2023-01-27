using BloggerWay.Shared.Entities.Concrete;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;

namespace BloggerWay.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } // ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; } // ValidationErrors.Add
    }
}
