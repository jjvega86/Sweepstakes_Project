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
        public ISweepStakesManager Manager { get { return _manager; } }
        public MarketingFirm(ISweepStakesManager manager)
        { 
            _manager = manager;
        }

        public void CreateSweepStake()
        {        
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("Please enter the name of your sweepstakes!"));
            _manager.InsertSweepstakes(sweepstakes);           
        }

        

       
    }
}
