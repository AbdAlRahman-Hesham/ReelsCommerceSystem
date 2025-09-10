namespace ReelsCommerceSystem.Shared.Responses;

public class ApiResponse
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public Message Message { get; set; }
    public object Data { get; set; }
    public List<ValidationError> Errors { get; set; }

    public ApiResponse()
    {
        Errors = new List<ValidationError>();
    }

    public static ApiResponse SuccessResponse(object data,
        int statusCode = 200, string en = "Request completed successfully.", string ar = "تم تنفيذ الطلب بنجاح.")
    {
        return new ApiResponse
        {
            Success = true,
            StatusCode = statusCode,
            Message = new Message { En = en, Ar = ar },
            Data = data,
            Errors = null
        };
    }

    public static ApiResponse ErrorResponse(int statusCode, string en, string ar, List<ValidationError> errors = null)
    {
        return new ApiResponse
        {
            Success = false,
            StatusCode = statusCode,
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