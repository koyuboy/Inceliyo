using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Application.Wrappers
{
    public class CustomBaseResponse<T>
    {
        public T? Data { get; set; }

        public int StatusCode { get; set; }
        public List<String>? Errors { get; set; }

        public static CustomBaseResponse<T> Success(int statusCode, T data)
        {
            return new CustomBaseResponse<T> { StatusCode = statusCode, Data = data };
        }
        public static CustomBaseResponse<T> Success(int statusCode)
        {
            return new CustomBaseResponse<T> { StatusCode = statusCode };
        }

        public static CustomBaseResponse<T> Fail(int statusCode, List<String> errors)
        {
            return new CustomBaseResponse<T> { StatusCode = statusCode, Errors = errors };
        }

        public static CustomBaseResponse<T> Fail(int statusCode, String error)
        {
            return new CustomBaseResponse<T> { StatusCode = statusCode, Errors = new List<String> { error } };
        }
    }
}
