using Labb3CVApi.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }
    public int SkillLevel { get; set; }

    // Allow null 
    public ICollection<Project>? Projects { get; set; } = new List<Project>();
}
