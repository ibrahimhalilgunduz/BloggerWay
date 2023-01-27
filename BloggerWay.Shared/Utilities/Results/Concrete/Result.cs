using BloggerWay.Shared.Entities.Concrete;
using BloggerWay.Shared.Utilities.Results.Abstract;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;

namespace BloggerWay.Shared.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus, IEnumerable<ValidationError> validationErrors)
        {
            ResultStatus = resultStatus;
            ValidationErrors = validationErrors;
        }
        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message, IEnumerable<ValidationError> validationErrors)
        {
            ResultStatus = resultStatus;
            Message = message;
            ValidationErrors = validationErrors;
        }
        public Result(ResultStatus resultStatus, string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }
        public Result(ResultStatus resultStatus, string message, Exception exception, IEnumerable<ValidationError> validationErrors)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
            ValidationErrors = validationErrors;
        }
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
        // new Result(ResultStatus.Error,exception.message,exception)
    }
}
