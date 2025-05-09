using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Data;
using TaskManagerApp.Models;
using Microsoft.AspNetCore.Mvc;

public class TasksModel : PageModel
{
    private readonly AppDbContext _context;
    public List<TaskItem> TaskList { get; set; } = [];

    [BindProperty]
    public string NewTaskTitle { get; set; } = "";

    public TasksModel(AppDbContext context)
    {
        _context = context;
    }

    public async Task OnGetAsync()
    {
        TaskList = await _context.Tasks.ToListAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!string.IsNullOrWhiteSpace(NewTaskTitle))
        {
            _context.Tasks.Add(new TaskItem { Title = NewTaskTitle, IsDone = false });
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}

