using Microsoft.AspNetCore.Mvc;
using JobApplicationTracker.Data;
using JobApplicationTracker.Models;

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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var application = _context.JobApplications
                .FirstOrDefault(a => a.Id == id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(JobApplication application)
        {
            if (!ModelState.IsValid)
            {
                return View(application);
            }
            _context.JobApplications.Add(application);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }


}
