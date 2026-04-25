using System.Diagnostics;
using activity_w5_library.Models;

namespace activity_w5_library.viewModels;

public class DashboardViewModel
{
    public List<User> Users { get; set; }
    public List<Book> Books { get; set; }
    
    public List<Loan>? Loans { get; set; }
    
}