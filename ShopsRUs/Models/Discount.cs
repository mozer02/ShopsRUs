using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public class Discount:Entity
    {
        public decimal DiscountAmount { get;private set; }
        public Discount(decimal price, decimal discountAmount)
        {
            Id = Guid.NewGuid().ToString();
            OnCreatedDate = DateTime.Now;
            SetDiscountAmount(discountAmount);            
        }
        public void SetDiscountAmount(decimal discountAmount)
        {
            if (discountAmount==null)
            {
                throw new Exception("Discount Amount cannot be empty!");
            }
            DiscountAmount = discountAmount;
        }
       
    }
}
