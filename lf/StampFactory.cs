using System;
using System.Collections.Generic;
using System.Linq;

namespace Laserfiche.Recruiting.Screening.Stamps
{
    class StampFactory  : BaseFactory
    {

        protected List<Stamp> stampCollection;


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

                this.stampCollection.Add(stamp);

            }

            this.Sort();

            return this.stampCollection;

        }

        public override Stamp GetStamp(int indice) {
            
            Stamp stamp = new Stamp();

            return stamp;

        }

        protected override void Sort()
        {

            this.stampCollection = stampCollection.OrderBy(x => x.StampValue)
           .ToList();
                      
        }

    }  
}
