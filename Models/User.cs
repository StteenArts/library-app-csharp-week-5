using System.ComponentModel.DataAnnotations.Schema;

namespace activity_w5_library.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    [Column("last_name")]
    public string? Last_Name { get; set; }
    public string? Role { get; set; }
    public string? Email { get; set; }
    public string Status {get; set;}
    public string Password { get; set; }
}