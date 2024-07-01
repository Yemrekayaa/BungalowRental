using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Domain.Entities
{
    public class CarPricing
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PricingID { get; set; }
        public Pricing Pricing{ get; set; }
        public decimal Amount { get; set; }

    }
}