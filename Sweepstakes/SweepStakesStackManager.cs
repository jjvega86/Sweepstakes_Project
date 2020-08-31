using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakesStackManager : ISweepStakesManager
    {
        private Stack<Sweepstakes> stack;
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }


        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstake = new Sweepstakes("Default");

            return sweepstake;

        }
    }
}
