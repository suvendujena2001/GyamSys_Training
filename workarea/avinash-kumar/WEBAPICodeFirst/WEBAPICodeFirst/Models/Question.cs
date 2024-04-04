namespace WEBAPICodeFirst.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        public string OptionA { get; set; }

        public string OptionB { get; set; } 

        public string OptionC { get; set; }

        public string OptionD { get; set; } 

        public string CorrectOption { get; set; } 

        public int Marks { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

    }
}
