namespace Laserfiche.Recruiting.Screening.Stamps
{
    using System.Collections.Generic;
    using System.Diagnostics;


    /// <summary>
    /// Facilitates dispensing stamps for a postage stamp machine.
    /// </summary>
    public class StampDispenser
    {

        private List<Stamp> stampCollection;
        private StampFactory factory = new StampFactory();

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
            
            this.stampCollection = new List<Stamp>();
            stampCollection = factory.Collect(stampDenominations);
              
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
            switch (request)
            {
                //min
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return factory.CalculateStampsToFillRequest(request);
                
            }

        }

        /// <summary>
        /// Program entry point.
        /// </summary>
        static void Main()
        {
               
            //default        
            StampDispenser stampDispenser = new StampDispenser(new int[] { 90, 30, 11, 24, 10, 6, 2, 1 });

        
        }
    }
}
