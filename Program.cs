using System;
using System.Collections.Generic;

namespace heistPart2
{
    class Program
    {
        static void Main(string[] args)
        {


            Bank bank1 = new Bank();

            Report report1 = new Report();
            report1.GetMostSecure(bank1);
            List<IRob> Rolodex = new List<IRob>() {
                new Hacker(){  Name = "Michelle Jimenez", SkillLevel= 50},
                new LockSpecialist(){  Name="Bilbo", SkillLevel=50},
                new Muscle(){ Name="The Rock", SkillLevel= 100},
                new Hacker(){ Name="Mark Z", SkillLevel= 100},
                new LockSpecialist {Name= "Ricko Suave", SkillLevel= 60}
            };


            Console.WriteLine($"Current # of Operatives in Roladex: {Rolodex.Count}");

            Console.WriteLine($"Enter Name of new Member to Rolodex");
            string MemberName = (Console.ReadLine());
            while (MemberName != "")
            {




                Console.Write("---------------\n");
                Console.WriteLine($"What is {MemberName}'s Specialty?");
                Console.WriteLine("\n1) Hacker(Disables Alarms) \n2) Muscle(Disarms Guards)\n3) Lock Specialist(cracks Vault)");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {

                    Console.Write("\nEnter Skill Level(Between 0-100): ");
                    int skill = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter Percentage cut: ");
                    int cut = int.Parse(Console.ReadLine());
                    var x = new Hacker()
                    {
                        Name = MemberName,
                        SkillLevel = skill,
                        PercentageCut = cut,

                    };
                    Rolodex.Add(x);
                    Console.Write($"{MemberName} has been added to Rolodex as a Hacker!");
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine($"\nEnter Name of Crew Member to Rolodex");
                    MemberName = (Console.ReadLine());



                }
                else if (choice == 2)
                {

                    Console.Write("\nEnter Skill Level(Between 0-100): ");
                    int skill = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter Percentage cut: ");
                    int cut = int.Parse(Console.ReadLine());
                    var x = new Muscle()
                    {
                        Name = MemberName,
                        SkillLevel = skill,
                        PercentageCut = cut,

                    };
                    Rolodex.Add(x);
                    Console.Write($"{MemberName} has been added to Rolodex as Muscle!");
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine($"\nEnter Name of Crew Member to Rolodex");
                    MemberName = (Console.ReadLine());
                }
                else if (choice == 3)
                {

                    Console.Write("\nEnter Skill Level(Between 0-100): ");
                    int skill = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter Percentage cut: ");
                    int cut = int.Parse(Console.ReadLine());
                    var x = new LockSpecialist()
                    {
                        Name = MemberName,
                        SkillLevel = skill,
                        PercentageCut = cut,

                    };
                    Rolodex.Add(x);
                    Console.Write($"{MemberName} has been added to Rolodex as a Lock Specialist!");
                    Console.WriteLine("\n-------------------------------");
                    Console.WriteLine($"\nEnter Name of Crew Member to Rolodex");
                    MemberName = (Console.ReadLine());
                }

            }
            Console.WriteLine("--------------------");
            List<IRob> Crew = new List<IRob>();
            Console.WriteLine("Rolodex Selection");






            int i = 0;
            foreach (var member in Rolodex)

            {
                i++;

                Console.Write($"\n[{Rolodex.IndexOf(member)}]Name: {member.Name} \nSpecialty:{member.Specialty}  \nSkill Level: {member.SkillLevel} \nPercentageCut: {member.PercentageCut}");
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Please Select a Crew member by Number");
            string selection = (Console.ReadLine());




            // var crewPerson = Rolodex[Int32.Parse(selection)];
            // //    Rolodex.RemoveAll(x => x.Specialty == crewPerson.Specialty);
            // Rolodex.Remove(crewPerson);

            // Crew.Add(crewPerson);




            while (selection != "")
            {
                var crewPerson = Rolodex[Int32.Parse(selection)];
                //    Rolodex.RemoveAll(x => x.Specialty == crewPerson.Specialty);
                Rolodex.Remove(crewPerson);

                Crew.Add(crewPerson);
                foreach (var member in Rolodex)

                {
                    i++;

                    Console.Write($"\n[{Rolodex.IndexOf(member)}]Name: {member.Name} \nSpecialty:{member.Specialty}  \nSkill Level: {member.SkillLevel} \nPercentageCut: {member.PercentageCut}");
                    Console.WriteLine();
                }
                Console.WriteLine($"Crew has {Crew.Count} members");
                Console.WriteLine("Please Select a Crew member by Number");
                selection = (Console.ReadLine());
            }
             foreach (IRob member in Crew)
            {
                member.PerformSkill(bank1);
            }

            if (bank1.IsSecure)
            {
                Console.WriteLine("Your Heist was a fail.");
            }
            else
            {
                Console.WriteLine("Your Heist was a Success We're in!");
                int money = bank1.CashOnHand;
                foreach(IRob member in Crew)
                {
                    int paycut = money * member.PercentageCut/100;
                    money = money - paycut;
                    Console.WriteLine($"{member.Name} got {paycut}");
                }
                Console.WriteLine($"You are left with {money}! Congrats");


        }
    }
}
}

