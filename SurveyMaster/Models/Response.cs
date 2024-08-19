namespace SurveyMaster.Models
{
    public class Response
    {
        public int ResponseId { get; set; }
        public int QuestionId { get; set; }
        public string ResponseText { get; set; }
        public DateTime CreatedDate { get; set; }

        public Question Question { get; set; }
    }

}
