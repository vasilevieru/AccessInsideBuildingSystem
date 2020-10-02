namespace AccessInsideBuildingSystem.Core.Domain
{
    public class Employee : BaseEntity
    {
        public string Function { get; set; }

        public int Experience { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }
    }
}
