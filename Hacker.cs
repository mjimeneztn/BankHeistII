using System;

namespace heistPart2
{
    public class Hacker : IRob
    {
        public string Name {get; set;}
        public string Specialty {get;} = "Hacker";
        public int SkillLevel { get;set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
           int newAlarmScore = bank.AlarmScore - SkillLevel;
           bank.AlarmScore = newAlarmScore;
            if (newAlarmScore <= 0)
            Console.WriteLine($"{Name} has disabled the Alarm System!");
            else {
                Console.WriteLine($"{Name} has decreased Alarm security by {SkillLevel} points. Bank has an advantage of {newAlarmScore} alarm points.");
            }
        }


    }
}