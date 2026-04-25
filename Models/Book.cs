using System.ComponentModel.DataAnnotations.Schema;

namespace activity_w5_library.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Status { get; set; }
    
    [Column("loan_id")]
    public int? LoanId { get; set; }
}