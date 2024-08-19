using Microsoft.EntityFrameworkCore;
using SurveyMaster.Models;

public class SurveyContext : DbContext
{
    public SurveyContext(DbContextOptions<SurveyContext> options) : base(options) 
    {

    }

    public DbSet<Survey> Surveys { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Response> Responses { get; set; }
    public DbSet<SurveyParticipant> SurveyParticipants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SurveyParticipant>()
            .HasKey(sp => sp.ParticipantId);
    }
}
