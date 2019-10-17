using System;

namespace heistPart2
{
    public class Bank
    {
        public Bank()
        {
            CashOnHand = CashOnHandFunc();
            AlarmScore = RandomSecurityFunc();
            SecurityGuardScrore= RandomSecurityFunc();
            VaultScore= RandomSecurityFunc();
        }
        private static readonly Random Random = new Random();
        public int CashOnHand{get; set;}
        public int CashOnHandFunc()
        {
            return Random.Next(50000, 1000000);
        }
        public int RandomSecurityFunc()
        {
            return Random.Next(0, 100);
        }
        public int AlarmScore{get; set;}

        public int VaultScore{get; set;}
        public int SecurityGuardScrore{get; set;}
        public bool IsSecure
        {
            get
            {
                if (AlarmScore + VaultScore + SecurityGuardScrore <= 0)
                {
                    return false;
                }
                else
                {
                    //DEFAULT value here.
                    return true;
                }
            }
            set
            {
                if (AlarmScore + VaultScore + SecurityGuardScrore > 0)
                {
                    IsSecure = true;
                }
                else
                {
                    //DEFAULT Value.
                    IsSecure = false; ;
                }
            }
        }
    }
}