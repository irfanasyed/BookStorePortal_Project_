using BookStorePortal_Project_.Models;

namespace BookStorePortal_Project_.Dto
{
    public class ResponseJobDto
    {
        public int JobId { get; set; }

        public string? JobDesc { get; set; }

        public string? MinLvl { get; set; }

        public string? MaxLvl { get; set; }

        //public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
