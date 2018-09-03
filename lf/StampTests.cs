using NUnit.Framework;
using System;

namespace Laserfiche.Recruiting.Screening.Stamps
{
    
    public class StampTests
    {
        [Test()]
        public void TestCase()
        {

            StampDispenser stampDispenser = new StampDispenser(new int[] { 90, 30, 24, 10, 6, 2, 1 });

            Assert.AreEqual(stampDispenser.CalcMinNumStampsToFillRequest(18), 2);
            Assert.AreEqual(stampDispenser.CalcMinNumStampsToFillRequest(34), 3);
           
        }

 
       
    }
}
