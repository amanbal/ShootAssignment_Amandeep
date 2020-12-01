using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootAssignment_Amandeep.Classes
{
    public class gamePlay
    {
        public int RndNumber()
        {
            //create a random number
            Random num = new Random();
            int rndNum = num.Next(1, 7);
            //send the number back to the program
            return rndNum;

        }
    }
}
