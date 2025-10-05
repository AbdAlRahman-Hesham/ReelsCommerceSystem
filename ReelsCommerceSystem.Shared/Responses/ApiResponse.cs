using System.Net;

namespace ReelsCommerceSystem.Shared.Responses;

public class ApiResponse<T> 
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public Message Message { get; set; }
    public T? Data { get; set; }
    public List<ValidationError> Errors { get; set; }

    public ApiResponse()
    {
        Errors = new List<ValidationError>();
    }

    public static ApiResponse<T> SuccessResponse(T data,
        HttpStatusCode statusCode, string en = "Request completed successfully.", string ar = "تم تنفيذ الطلب بنجاح.")
    {
        return new ApiResponse<T>
        {
            Success = true,
            StatusCode = (int)statusCode,
            Message = new Message { En = en, Ar = ar },
            Data = data,
            Errors = null
        };
    }

    public static ApiResponse<T> ErrorResponse(HttpStatusCode statusCode,string en, string ar, List<ValidationError> errors = null)
    {
        return new ApiResponse<T>
        {
            Success = false,
            StatusCode = (int)statusCode,
            Message = new Message { En = en, Ar = ar },
            Data = null,
            Errors = errors
        };
    }
}

public class Message
{
    public string En { get; set; }
    public string Ar { get; set; }
}

public class ValidationError
{
    public string Field { get; set; }
    public string En { get; set; }
    public string Ar { get; set; }
}
