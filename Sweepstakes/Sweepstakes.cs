using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        
        private string _name;
        public string Name { get { return _name; } }

        public Dictionary<int, Contestant> contestants;
        private int _mostRecentKey;
        private int _winningKey;
        

        public Sweepstakes(string name)
        {
            _name = name;
            contestants = new Dictionary<int, Contestant>();
            _mostRecentKey = 0;
            _winningKey = 0;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetUserInputFor("Please enter your first name!");
            contestant.LastName = UserInterface.GetUserInputFor("Please enter your last name!");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Please enter your email address!");
            contestant.RegistrationNumber = UserInterface.AssignRegistrationNumber();
            contestants.Add(_mostRecentKey, contestant);
            _mostRecentKey++;
        }

        public Contestant PickWinner()
        {
            Contestant winner;
            Random random = new Random();
            _winningKey = random.Next(_mostRecentKey - 1);
            winner = contestants[_winningKey];
            Notify();
   
            return winner;

        }

        public void Notify()
        {
            for (int i = 0; i < contestants.Count; i++)
            {
                if (i == _winningKey)
                {
                    Console.WriteLine($"{contestants[i].FirstName}, you won!");
                }
                else
                {
                    Console.WriteLine($"{contestants[i].FirstName}, {contestants[_winningKey].FirstName}{contestants[_winningKey].LastName} won! Thanks for entering.");
                }

            }

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"This contestant's name is {contestant.FirstName} {contestant.LastName}.\n");
            Console.WriteLine($"This contestant's email address is {contestant.EmailAddress}.\n");
            Console.WriteLine($"This contestant's registration number is {contestant.RegistrationNumber}.\n");
        } 

      

    }
}
