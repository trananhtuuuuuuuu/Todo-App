namespace interview.Responses;

public class ApiFormatResponse {
    public int StatusCode { get; set; }
    public string Message { get; set; } = "";
    public object? Data { get; set; }
    
    public string Error { get; set; } = "";
    
    
    public ApiFormatResponse() {}
    
    public ApiFormatResponse(int statusCode, string message, object? data = null, string error = "") {
        StatusCode = statusCode;
        Message = message;
        Data = data;
        Error = error;
    }
    
}