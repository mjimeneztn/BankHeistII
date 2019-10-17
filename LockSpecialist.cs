using System;

namespace heistPart2
{
    public class LockSpecialist : IRob
    {
        public string Name {get; set;}
        public int SkillLevel { get;set; }
        public string Specialty {get;} = "Lock Specialist";
        public int PercentageCut { get; set; }

         public void PerformSkill(Bank bank)
        {
           int newVaultScore = bank.VaultScore - SkillLevel;
           bank.VaultScore = newVaultScore;
            if (newVaultScore <= 0)
            Console.WriteLine($"{Name} has disabled the Vault!");
            else {
                Console.WriteLine($"{Name} has decreased Vault security by {SkillLevel} points. Bank has an advantage of {newVaultScore} vault points.");
            }
        }


    }
}