using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreatMarketingFirmWithManager()
        {            
            string input = UserInterface.GetUserInputFor("What type of manager would you like to use for your sweepstakes? Stack or Queue");
            switch (input)
            {

                case "Stack":
                    SweepStakesStackManager stackManager = new SweepStakesStackManager();
                    MarketingFirm marketingFirmS = new MarketingFirm(stackManager);
                    break;

                case "Queue":
                    SweepStakesQueueManager queueManager = new SweepStakesQueueManager();
                    MarketingFirm marketingFirmQ = new MarketingFirm(queueManager);
                    break;

                default:
                    Console.WriteLine("Not a valid selection!");
                    CreatMarketingFirmWithManager();
                    break;

            }

            

            

        }
    }
}
