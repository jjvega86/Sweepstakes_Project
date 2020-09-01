using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakesStackManager : ISweepStakesManager
    {
        private Stack<Sweepstakes> _stack;

        public SweepStakesStackManager()
        {
            _stack = new Stack<Sweepstakes>();
            
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _stack.Push(sweepstakes);

        }

        public Sweepstakes GetSweepstakes()
        {
            return _stack.Pop();
        }
    }
}
