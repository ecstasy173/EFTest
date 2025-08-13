public class ApiResponse<T>
{
    public string Message { get; set; }
    public T? Data { get; set; }
    public string? Error { get; set; }

    public ApiResponse(string message, T? data = default, string? error = null)
    {
        Message = message;
        Data = data;
        Error = error;
    }
}