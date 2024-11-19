using BookStorePortal_Project_.Models;

namespace BookStorePortal_Project_.Dto
{
    public class ResponseEmployeeDto
    {
        public int EmpId { get; set; }

        public string? Fname { get; set; }

        public string? Minit { get; set; }

        public string? Lname { get; set; }

        public int? JobId { get; set; }

        public string? JobLvl { get; set; }

        public int? PubId { get; set; }

        public DateTime? HireDate { get; set; }

    }
}
