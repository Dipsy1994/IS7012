namespace RecruitCatSrivasdv.Models
{
    public class Company
    {
        public string? name { get; set; }
        public string? position { get; set; }
        public decimal? minimumSalary { get; set; }
        public decimal? maximumSalary { get; set; }
        public DateTime? startDate { get; set; }
        public string? location { get; set; }
        public int? companyId { get; set; }
        public int? noOfEmployees { get; set; }
        public decimal? revenue { get; set; }
        public string? ISIN { get; set; }
        public string? website { get; set; }
        public string? keyPeople { get; set; }
    }
}
