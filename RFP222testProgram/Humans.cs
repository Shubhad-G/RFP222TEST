using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RFP222testProgram
{
    internal class Humans
    {
        public string personName;
        public int phoneNumber;

        public void Talk()
        {
            Console.WriteLine("He/She can talk");

        }
        public void HumanDetails()
        {
            Console.WriteLine("Name:{0} Phone:{1}",personName,phoneNumber);
        }
    }

}
