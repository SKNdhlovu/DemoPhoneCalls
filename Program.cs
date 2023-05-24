using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPhoneCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            IncomingPhoneCall incoming = new IncomingPhoneCall("0833589273");
            OutgoingPhoneCall outgoing = new OutgoingPhoneCall(8, "0798562429");

            
            incoming.DisplayCallInformation();
            outgoing.DisplayCallInformation();

            Console.ReadLine();
        }
    }
}
