namespace JobApplicationTracker.Models
{
    public class JobApplication
    {
        public required string Company { get; set; }
        public required string Position { get; set; }

        public string? Location { get; set; }

        public DateTime ApplicationDate { get; set; }

        public ApplicationStatus Status { get; set; }
        public WorkModel WorkModel { get; set; }

        public string? JobUrl { get; set; }
        public string? Notes { get; set; }
    }
}