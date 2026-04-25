namespace activity_w5_library.Response;

public class UserResponse<T>
{
    public T Data { get; set; }
    public bool Success { get; set; }
    public string? Message { get; set; }
}