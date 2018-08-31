using System;
using System.Collections.Generic;

namespace Laserfiche.Recruiting.Screening.Stamps
{
    abstract class BaseFactory
    {
        public abstract Stamp GetStamp(int indice);
        public abstract List<Stamp> Collect(int[] stampDenominations);
        protected abstract void Sort();

    }
}
