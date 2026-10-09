using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; } = "";

        [Required]
        public string JobTitle { get; set; } = "";

        public string? Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime AppliedDate { get; set; } = DateTime.Today;

        public string Status { get; set; } = "Applied";

        public string? Notes { get; set; }
    }
}