namespace interview.Responses;

public class ApiFormatResponse<T> {
    public int StatusCode { get; set; }
    public string Message { get; set; } = "";
    public T? Data { get; set; }
    
    public string Error { get; set; } = "";
    
    
    public ApiFormatResponse() {}
    
    public ApiFormatResponse(int statusCode, string message, T? data = default, string error = "") {
        StatusCode = statusCode;
        Message = message;
        Data = data;
        Error = error;
    }
    
}