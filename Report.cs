using System;
using System.Collections.Generic;
using System.Linq;

namespace heistPart2
{
    public class Report
    {
        public string leastSecure { get; set; }
        public string mostSecure { get; set; }


        public void GetMostSecure(Bank bank)
        {
            Dictionary<string, int> bankScores = new Dictionary<string, int>() { { "Vault system", bank.VaultScore }, { "Guard system", bank.SecurityGuardScrore }, { "Alarm system", bank.AlarmScore } };
            mostSecure = bankScores.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine($"The most Secure is the {mostSecure}");

        }
        public void GetLeastSecure(Bank bank)
        {
            Dictionary<string, int> bankScores = new Dictionary<string, int>() { { "Vault", bank.VaultScore }, { "Guards", bank.SecurityGuardScrore }, { "Alarms", bank.AlarmScore } };
            leastSecure = bankScores.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            Console.WriteLine($"The Least secure is the {leastSecure}");

        }


    }
}