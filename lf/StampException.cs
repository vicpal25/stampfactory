using System;


namespace Laserfiche.Recruiting.Screening.Stamps
{
    public class StampException : Exception
    {
        public StampException(){}

        public StampException(string message)
            : base(message)
        {

            System.Console.WriteLine(message);
            
        }
    }
}
