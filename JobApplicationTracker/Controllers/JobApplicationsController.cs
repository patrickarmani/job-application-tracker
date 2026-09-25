using Microsoft.AspNetCore.Mvc;
using JobApplicationTracker.Data;

namespace JobApplicationTracker.Controllers
{
    public class JobApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JobApplicationsController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var applications = _context.JobApplications.ToList();
            return View(applications);
        }

        public IActionResult Create() => View();

    }


}
