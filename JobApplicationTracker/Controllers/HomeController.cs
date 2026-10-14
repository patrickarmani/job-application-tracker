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
        var applicationsByStatus = _context.JobApplications
            .GroupBy(a => a.Status)
            .Select(g => new
            {
                Status = g.Key,
                Count = g.Count()
            })
            .ToDictionary(x => x.Status, x => x.Count);

        var recentApplications = _context.JobApplications
            .OrderByDescending(a => a.ApplicationDate)
            .ThenByDescending(a => a.Id)
            .Take(5)
            .ToList();

        var dashboard = new DashboardViewModel
        {
            TotalApplications = _context.JobApplications.Count(),
            ApplicationsByStatus = applicationsByStatus,
            RecentApplications = recentApplications 
        };

        return View(dashboard);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
