namespace Labb3CVApi.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        // Foreign key property
        public int SkillId { get; set; }  // Foreign key

        // Navigation property to the Skills table
        public Skill Skill { get; set; }  // Navigation property to Skill

        public string Description { get; set; }
        public string GitHubLink { get; set; }
    }
}
