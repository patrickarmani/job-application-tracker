using System.Collections.Generic;

namespace JobApplicationTracker.Models
{
    public class DashboardViewModel
    {
        public int TotalApplications { get; set; }

        public Dictionary<ApplicationStatus, int> ApplicationsByStatus
        { get; set; } = new();

        public List<JobApplication> RecentApplications
        { get; set; } = new();
    }
}