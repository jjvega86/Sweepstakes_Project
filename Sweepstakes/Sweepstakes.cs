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
        private string _name; // where does this come into play?
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
            contestant.FirstName = UserInterface.GetUserInputFor("Please enter your first name!");
            contestant.LastName = UserInterface.GetUserInputFor("Please enter your last name!");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Please enter your email address!");
            contestant.RegistrationNumber = UserInterface.AssignRegistrationNumber();
            int newKey = GenerateKey();
            contestants.Add(newKey, contestant);
        }

        public Contestant PickWinner()
        {
            Contestant winner = new Contestant();
            Random random = new Random();

            winner = contestants[random.Next(mostRecentKey-1)];

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
