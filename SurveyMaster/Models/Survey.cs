namespace SurveyMaster.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
