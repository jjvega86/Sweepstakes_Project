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
            SelectSweepStakeManager(manager);
            _manager = manager;
        }

        public void CreateSweepStake()
        {        
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("Please enter the name of your sweepstakes!"));
            _manager.InsertSweepstakes(sweepstakes);           
        }

        private ISweepStakesManager SelectSweepStakeManager(ISweepStakesManager manager)
        {
            string input = UserInterface.GetUserInputFor("What type of manager would you like to use for your sweepstakes? Stack or Queue");
            switch (input)
            {
                case "Stack":
                    manager = new SweepStakesStackManager();
                    break;

                case "Queue":
                    manager = new SweepStakesQueueManager();
                    break;

                default:
                    Console.WriteLine("Not a valid selection!");
                    SelectSweepStakeManager(manager);
                    break;

            }

            return manager;

        }
    }
}
