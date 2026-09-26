using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JobApplicationTracker.Models;
using JobApplicationTracker.Data;

namespace JobApplicationTracker.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var applications = _context.JobApplications.ToList();
        return View(applications);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
