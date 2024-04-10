namespace WEBAPICodeFirst.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public int StudentIdFk { get; set; }
        public string ExamName { get; set; }
        public int ExamId_Fk { get; set; }
        public int FullMarks { get; set; }
        public int Score { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

    }
}
