namespace ExamAdda.Models
{
    public class Exam
    {
        public int ExamId { get; set; }

        public DateTime? ExamDate { get; set; }

        public string ExamName { get; set; }

        public int? Score { get; set; }

        public int Hours { get; set; }

        public int? PassingMarks { get; set; }


        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }
    }
}
