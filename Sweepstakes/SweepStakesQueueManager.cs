using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakesQueueManager : ISweepStakesManager
    {
        private Queue<Sweepstakes> _queue;
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _queue.Enqueue(sweepstakes);
        }


        public Sweepstakes GetSweepstakes()
        {
            return _queue.Dequeue();

        }
    }
}
