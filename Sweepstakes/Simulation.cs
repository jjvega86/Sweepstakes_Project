using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm marketingFirm = null;
            string input = UserInterface.GetUserInputFor("What type of manager would you like to use for your sweepstakes? Stack or Queue");
            switch (input)
            {

                case "Stack":
                    marketingFirm = new MarketingFirm(new SweepStakesStackManager());
                    break;

                case "Queue":
                    marketingFirm = new MarketingFirm(new SweepStakesQueueManager());
                    break;

                default:
                    Console.WriteLine("Not a valid selection!");
                    CreateMarketingFirmWithManager();
                    break;

            }

            
        }
     
    }
}
