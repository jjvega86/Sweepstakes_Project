using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant : ISubscriber
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public Contestant()
        {
            FirstName = "Default";
            LastName = "Default";
            EmailAddress = "johndoe@noname.com";
            RegistrationNumber = 0;
            
        }

        public void NotifyWinner()
        {

        }

        public void NotifyNonWinners()
        {

        }
    }
}
