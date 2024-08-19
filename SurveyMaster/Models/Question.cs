using Azure;

namespace SurveyMaster.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int SurveyId { get; set; }
        public string QuestionText { get; set; }

        public Survey Survey { get; set; }
        public ICollection<Response> Responses { get; set; }
    }
}
