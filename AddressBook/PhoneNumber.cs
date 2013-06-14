using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PhoneNumber
    {
        private int areaCode;
        private int firstPart;
        private int secondPart;

        public PhoneNumber(int areaCode, int firstPart, int secondPart) //constructor
        {
            this.areaCode = areaCode;
            this.firstPart = firstPart;
            this.secondPart = secondPart;
        }

        public override string ToString() //method for making phone number into string (its called ToString)
        {
            return areaCode.ToString() + '-' + firstPart.ToString() + '-' + secondPart.ToString();
        }

        public int AreaCode { get { return areaCode; } }
        public int FirstPart { get { return firstPart; } }
        public int SecondPart { get { return secondPart; } }
    }
}
