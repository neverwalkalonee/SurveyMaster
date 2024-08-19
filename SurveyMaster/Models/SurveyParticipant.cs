using System.ComponentModel.DataAnnotations;

namespace SurveyMaster.Models
{
    public class SurveyParticipant
    {
        [Key]
        public int ParticipantId { get; set; }
        public int SurveyId { get; set; }
        public string ParticipantName { get; set; }
        public DateTime SubmittedDate { get; set; }

        public Survey Survey { get; set; }
    }
}
