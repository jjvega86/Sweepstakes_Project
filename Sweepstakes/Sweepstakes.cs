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
        Dictionary<int,Contestant> contestants;

        public Sweepstakes(string name)
        {
            this.Name = name;
            contestants = new Dictionary<int, Contestant>();

        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            Contestant winner = new Contestant();

            return winner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        } 

    }
}
