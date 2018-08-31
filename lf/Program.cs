namespace Laserfiche.Recruiting.Screening.Stamps
{
    using System.Collections.Generic;
    using System.Diagnostics;


    /// <summary>
    /// Facilitates dispensing stamps for a postage stamp machine.
    /// </summary>
    public class StampDispenser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StampDispenser"/> class that will be 
        /// able to dispense the given types of stamps.
        /// </summary>
        /// <param name="stampDenominations">
        /// The values of the types of stamps that the machine has.  
        /// Should be sorted in descending order and contain at least a 1.
        /// </param>
        public StampDispenser(int[] stampDenominations) 
        {
            List<Stamp> stampCollection = new List<Stamp>();
            StampFactory factory = new StampFactory();

            stampCollection = factory.Collect(stampDenominations);

            foreach(Stamp _stamp in stampCollection) {
                System.Console.WriteLine(_stamp.StampValue);
            }

                
        }

        /// <summary>
        /// Returns the minimum number of stamps that the machine can dispense to
        /// fill the given request.
        /// </summary>
        /// <param name="request">
        /// The total value of the stamps to be dispensed.
        /// </param>
        /// <returns>
        /// The minimum number of stamps needed to fill the given request.
        /// </returns>
        public int CalcMinNumStampsToFillRequest(int request)
        {
            return 0;
        }

        /// <summary>
        /// Program entry point.
        /// </summary>
        static void Main()
        {

            //Stamp stamp = new Stamp();


            StampDispenser stampDispenser = new StampDispenser(new int[] { 90, 30, 24, 10, 6, 2, 1 });
            Debug.Assert(stampDispenser.CalcMinNumStampsToFillRequest(18) == 3);

        
        }
    }
}
