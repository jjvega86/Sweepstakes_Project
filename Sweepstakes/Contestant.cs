﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
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

        public void GetContestantInformation()
        {
            FirstName = UserInterface.GetUserInputFor("Please enter your first name!");
            LastName = UserInterface.GetUserInputFor("Please enter your last name!");
            EmailAddress = UserInterface.GetUserInputFor("Please enter your email address!");           
            RegistrationNumber = UserInterface.AssignRegistrationNumber();

        }
    }
}
