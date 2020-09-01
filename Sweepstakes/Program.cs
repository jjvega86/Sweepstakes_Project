using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sweepstakes sweepstakes = new Sweepstakes("Big Winner");
            //sweepstakes.RegisterContestant(new Contestant());
            //sweepstakes.RegisterContestant(new Contestant());
            //sweepstakes.RegisterContestant(new Contestant());

            //Contestant winner = sweepstakes.PickWinner();

            //sweepstakes.PrintContestantInfo(winner);

            Simulation simulation = new Simulation();
            simulation.CreatMarketingFirmWithManager();

            Console.ReadLine();

        }
    }
}
