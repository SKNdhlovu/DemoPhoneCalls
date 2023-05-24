using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPhoneCalls
{
    class IncomingPhoneCall : PhoneCall
    {
        public IncomingPhoneCall(string number, double price = 0.02):base(number,price)
        {

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
            Console.WriteLine("IncomingPhoneCall subclass inherited from the PhoneCall abstract class" +
                "\nPhone Number: " +phoneNumber+
                "\nRate: " +callPrice+
                "\nPrice: "+string.Format("{0:c}", callPrice) +"\n");
        }
    }
}
