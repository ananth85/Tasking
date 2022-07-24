using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskIt.Data;
using TaskIt.Models;


namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IssueDbContext _context;

        public IndexModel(IssueDbContext context) => _context = context;


        public async void OnGet()
        {
            Issues = await _context.Issues.Where(i => i.Completed == null).OrderByDescending(i => i.Created).ToListAsync();
            IssuesToDay = await _context.Issues.Where(i => i.Completed != null ).OrderByDescending(i => i.Created).ToListAsync();
        }

        public IEnumerable<Issue> Issues { get; set; } = Enumerable.Empty<Issue>(); 
        public IEnumerable<Issue> IssuesToDay { get; set; } = Enumerable.Empty<Issue>();
    }
}