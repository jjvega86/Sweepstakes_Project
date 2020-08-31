using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepStakesManager _manager;
        public MarketingFirm(ISweepStakesManager manager)
        {
            this._manager = manager;
        }

        public void CreateSweepStake()
        {

        }
    }
}
