using System;
using System.Collections.Generic;
using System.Linq;

namespace Laserfiche.Recruiting.Screening.Stamps
{
    public class Stamp
    {

        private int stampValue;

        public Stamp() {
            
        }

        public Stamp(int stampValue)
         {

            this.stampValue = stampValue;
        }

        public int StampValue
        {
            get { return this.stampValue; }
            set { this.stampValue = value; }
        }


    }
}
