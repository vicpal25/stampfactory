using System;
using System.Collections.Generic;
using System.Linq;

namespace Laserfiche.Recruiting.Screening.Stamps
{
    class StampFactory  : BaseFactory
    {

        protected List<Stamp> stampCollection;

        /// <summary>
        /// Collects the stamp values, sorts them and checks for dups
        /// </summary>
        public override List<Stamp> Collect(int[] stampDenominations)
        {
               
            if (stampDenominations.Length == 0 || stampDenominations.Length < 0)
            {
                throw new StampException(StampConstants.INVALID_ENTRY);
            }

            this.stampCollection = new List<Stamp>();

            foreach (int stampEntry in stampDenominations)
            {

                Stamp stamp = new Stamp(stampEntry);

                bool exists = this.stampCollection.Exists(element => element.StampValue == stampEntry);

                if(!exists) {
                    this.stampCollection.Add(stamp);    
                }

            }

            this.stampCollection = this.stampCollection.Distinct().ToList();

            this.Sort();

            return this.stampCollection;

        }

        /// <summary>
        /// Calculates Stamps to fill requests
        /// </summary>
        public int CalculateStampsToFillRequest(int request) {
            
                int balance = request;
                int count = 0;

                int[] denominations = this.stampCollection.Select(x => x.StampValue).ToArray();

                for (int i = denominations.Length - 1; i > 0; i--)
                {
                    while (balance >= denominations[i])
                    {
                        balance -= denominations[i];
                        count++;
                    }
                }

                return count;

        }


        /// <summary>
        /// Get Stamp
        /// </summary>
        public override Stamp GetStamp(int indice) {
            
            Stamp stamp = new Stamp();

            return stamp;

        }

        /// <summary>
        /// sorts the list
        /// </summary>
        protected override void Sort()
        {
            this.stampCollection = stampCollection.OrderBy(x => x.StampValue)
           .ToList();
                      
        }

    }  
}
