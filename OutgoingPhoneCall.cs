using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPhoneCalls
{
    class OutgoingPhoneCall:PhoneCall
    {
        private int callTimeInMinutes;
        
        public OutgoingPhoneCall(int time, string number, double price = 0.04) :base(number,price)
        {
            callTimeInMinutes = time;
        }
        public override string PhoneNumber()
        {
            return phoneNumber;
        }
        public override double PriceOfCall()
        {
            return callPrice;
        }
        public override void DisplayCallInformation()
        {
            Console.WriteLine("OutgoingPhoneCall subclass inherited from the PhoneCall abstract class" +
                "\nPhone number: " + phoneNumber +
                "\nRate per minute: " + callPrice +
                "\nNumber of minutes: "+callTimeInMinutes+
                "\nTotal Price: " + string.Format("{0:c}", (callPrice * callTimeInMinutes)));
        }
    }
}
