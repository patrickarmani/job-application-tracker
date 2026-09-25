using Microsoft.AspNetCore.Mvc;

namespace JobApplicationTracker.Controllers;

public class JobApplicationsController : Controller
{
    // GET: /JobApplications  ->  Views/JobApplications/Index.cshtml
    public IActionResult Index() => View();

    // GET: /JobApplications/Create  ->  Views/JobApplications/Create.cshtml
    public IActionResult Create() => View();
}
