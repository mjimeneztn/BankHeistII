using System;

namespace heistPart2
{
    public class Muscle : IRob
    {
        public string Name {get; set;}
        public int SkillLevel { get;set; }
        public string Specialty {get;} = "Muscle Man";
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
           int newSecurityScore = bank.SecurityGuardScrore - SkillLevel;
           bank.SecurityGuardScrore = newSecurityScore;
            if (newSecurityScore <= 0)
            Console.WriteLine($"{Name} has subdued Guard Security!");
            else {
                Console.WriteLine($"{Name} has decreased Guard security by {SkillLevel} points. Bank has an advantage of {newSecurityScore} points.");
            }
        }

    }
}