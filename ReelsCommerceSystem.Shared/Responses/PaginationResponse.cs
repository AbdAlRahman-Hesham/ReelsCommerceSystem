using System.Net;

namespace ReelsCommerceSystem.Shared.Responses;

public class PaginationResponse<T> where T : class
{
    public Meta Meta { get; set; }
    public List<T> Data { get; set; }

    public PaginationResponse()
    {
        Data = new List<T>();
    }

    public static ApiResponse<PaginationResponse<T>> SuccessResponse(
        List<T> data,
        Meta meta,
        HttpStatusCode statusCode,
        string en = "Request completed successfully.",
        string ar = "تم تنفيذ الطلب بنجاح.")
    {
        return new ApiResponse<PaginationResponse<T>>
        {
            Success = true,
            StatusCode = (int)statusCode,
            Message = new Message { En = en, Ar = ar },
            Data = new PaginationResponse<T>
            {
                Meta = meta,
                Data = data
            },
            Errors = null
        };
    }

    public static ApiResponse<PaginationResponse<T>> ErrorResponse(
        HttpStatusCode statusCode,
        string en,
        string ar,
        List<ValidationError> errors = null)
    {
        return new ApiResponse<PaginationResponse<T>>
        {
            Success = false,
            StatusCode = (int)statusCode,
            Message = new Message { En = en, Ar = ar },
            Data = null,
            Errors = errors
        };
    }
}

public class Meta
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalRecords { get; set; }

    public int TotalPages
    {
        get
        {
            if (PageSize <= 0) return 0;
            return (int)Math.Ceiling((double)TotalRecords / PageSize);
        }
    }
}
