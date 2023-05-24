using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPhoneCalls
{
    abstract class PhoneCall
    {
        protected string phoneNumber;
        protected double callPrice;

        public PhoneCall(string number, double price = 0.00)
        {
            phoneNumber = number;
            callPrice = price;
        }
        public double CallPrice { set { callPrice = value; } }
        public abstract string PhoneNumber();
        public abstract double PriceOfCall();
        public abstract void DisplayCallInformation();
    }
}
