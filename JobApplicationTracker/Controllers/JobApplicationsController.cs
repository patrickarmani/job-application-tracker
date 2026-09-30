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

        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var application = _context.JobApplications.Find(id);

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, JobApplication application)
        {
            if (id != application.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(application);
            }

            // Retrieve the existing application so only permitted fields are updated
            var existingApplication = _context.JobApplications.Find(id);
            if (existingApplication == null)
            {
                return NotFound();
            }
            // Update only the fields that are allowed to be changed    

            existingApplication.Company = application.Company;
            existingApplication.Position = application.Position;
            existingApplication.Location = application.Location;
            existingApplication.ApplicationDate = application.ApplicationDate;
            existingApplication.Status = application.Status;
            existingApplication.WorkModel = application.WorkModel;
            existingApplication.JobUrl = application.JobUrl;
            existingApplication.Notes = application.Notes;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

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
