namespace RecruitCatSrivasdv.Models
{
    public class Candidate
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public decimal? targetSalary { get; set; }
        public DateTime? optStartDate { get; set; }
        public string? contactNumber { get; set; }
        public string? address { get; set; }
        public bool? relocation { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public int? candidateID { get; set; }
        public bool? reference { get; set; }
        public string? referenceID { get; set; }
    }
}
