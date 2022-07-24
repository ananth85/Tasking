using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskIt.Data;
using TaskIt.Models;

namespace TaskIt.Pages.Issues
{
    public class DetailModel : PageModel
    {
        private readonly IssueDbContext _context;

        public DetailModel(IssueDbContext context)  => _context = context;
        public async void OnGet(uint id) => Issue = await _context.Issues.FindAsync(id);
        
        public async void OnGetResolve(uint id)
        {
            var _issueToUpdate =  _context.Issues.SingleOrDefault(i => i.Id == id);
            if (_issueToUpdate == null) return;
            _issueToUpdate.Completed = DateTime.Now;
            await _context.SaveChangesAsync();
        }
        public Issue? Issue { get; set; }
    }
}
