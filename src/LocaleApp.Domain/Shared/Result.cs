using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaleApp.Domain.Shared;
public sealed class Result<T>
{
    public T? Value { get; private set; }
    public bool IsSuccess { get; private set; }
    public bool IsFailure => !IsSuccess;
    public string[]? ErrorMessages { get; private set; }
    public string? Message { get; private set; }

    public Result(T? value,bool isSuccess, string[]? errorMessages,string? message)
    {
        Value=value;
        IsSuccess = isSuccess;
        ErrorMessages = errorMessages;
        Message = message;
    }

    public static Result<T> Success(T? value, string? message = null)
    {
        return new Result<T>(value, true, null, message);
    }
    public static Result<T> Failure(string? message=null,params string[]? errorMessages)
    {
        return new Result<T>(default, false, errorMessages, message);
    }

}
