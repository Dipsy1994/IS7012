namespace RecruitCatSrivasdv.Models
{
    public class Job_Title
    {
        public string? title { get; set; }
        public decimal? minimumSalary { get; set; }
        public decimal? maximumSalary { get; set; }
        public decimal? experienceRequired { get; set; }
        public int? jobID { get; set; }
        public DateTime? optionalStartDate { get; set; }
        public string? jobDescription { get; set; }
        public string? level { get; set; }
        public string? typeOfEmployee { get; set; }
    }
}
