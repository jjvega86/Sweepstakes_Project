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
            contestants.Add(newKey, contestant);
        }

        public Contestant PickWinner()
        {
            Contestant winner = new Contestant();

            return winner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        } 

        private int GenerateKey()
        {
            int newKey;
            mostRecentKey++;
            newKey = mostRecentKey;

            return newKey;
        }

    }
}
