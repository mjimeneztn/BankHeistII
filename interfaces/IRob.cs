namespace heistPart2
{
    public interface IRob {
         string Name { get; set; }
         string Specialty {get;}
         int SkillLevel {get; set;}
         int PercentageCut {get; set;}
         void PerformSkill(Bank bank);

    }
}