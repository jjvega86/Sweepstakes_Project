﻿using System;
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
            string input = UserInterface.GetUserInputFor("What type of manager would you like to use for your sweepstakes? Stack or Queue");
            MarketingFirm marketingFirm = new MarketingFirm(SelectManagerType(input));
            marketingFirm.CreateSweepStake();
     
        }

        private ISweepStakesManager SelectManagerType(string input)
        {
            ISweepStakesManager manager = null;
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
                    CreateMarketingFirmWithManager();
                    break;

            }
            return manager;

        }
     
    }
}
