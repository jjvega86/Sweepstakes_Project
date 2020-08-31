using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public string Name;
        public Dictionary<int,Contestant> contestants;
        int mostRecentKey;
        

        public Sweepstakes(string name)
        {
            this.Name = name;
            contestants = new Dictionary<int, Contestant>();
            mostRecentKey = 0;
        }

        public void RegisterContestant(Contestant contestant)
        {
            int newKey = GenerateKey();
            contestant.GetContestantInformation();
            contestants.Add(newKey, contestant);
        }

        public Contestant PickWinner()
        {
            Contestant winner = new Contestant();
            Random random = new Random();

            contestants[random.Next(mostRecentKey)] = winner;

            return winner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"This contestant's name is {contestant.FirstName} {contestant.LastName}.\n");
            Console.WriteLine($"This contestant's email address is {contestant.EmailAddress}.\n");
            Console.WriteLine($"This contestant's registration number is {contestant.RegistrationNumber}.\n");
        } 

        private int GenerateKey()
        {            
            mostRecentKey++;

            return mostRecentKey;
        }

    }
}
