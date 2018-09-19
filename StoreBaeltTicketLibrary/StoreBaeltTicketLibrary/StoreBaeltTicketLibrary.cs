using System;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltTicketLibrary : Car
    {
        public override double DiscountPrice()
        {
            return base.DiscountPrice();
        }

        public override string LicensePlate()
        {
            return base.LicensePlate();
        }

        public override double Price()
        {
            if (Date.DayOfWeek.ToString() == DayOfWeek.Saturday.ToString()||Date.DayOfWeek.ToString() == DayOfWeek.Sunday.ToString())
            {
                return base.Price()*0.8;
            }
            else
            {
                return base.Price();
            }
        }

        public override string Vehicle()
        {
            return base.Vehicle();
        }
    }
}
