using System;
using System.ComponentModel.DataAnnotations;

namespace MoodTrackerApp.Models
{
    public class MoodEntry
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; } = DateTime.Today;

        [Display(Name = "Mood")]
        [Required(ErrorMessage = "Please select a mood")]
        public string Mood { get; set; }

        [Display(Name = "Note")]
        [StringLength(20000, ErrorMessage = "Note can't be longer than 20000 characters")]
        public string Note { get; set; }
    }
}
