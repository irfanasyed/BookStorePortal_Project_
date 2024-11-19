using BookStorePortal_Project_.Models;
using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class CreateEmployeeDto
    {
        
        [StringLength(50,ErrorMessage ="Fname cannot exceed 50 characters")]
        public string? Fname { get; set; }

        [StringLength(50,ErrorMessage = "Minit cannot exceed 50 characters")]
        public string? Minit { get; set; }

        [StringLength(50,ErrorMessage = "Lname cannot exceed 50 characters")]
        public string? Lname { get; set; }

        
        public int? JobId { get; set; }

        [StringLength(50, ErrorMessage = "JobLvl cannot exceed 50 characters")]
        public string? JobLvl { get; set; }
       
        public int? PubId { get; set; }

        public DateTime? HireDate { get; set; } = DateTime.Now;

    }
}
