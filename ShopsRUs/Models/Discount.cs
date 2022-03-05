using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public class Discount:Entity
    {
        public decimal DiscountAmount { get; set; }
        public Discount(decimal discountAmount)
        {
            Id = Guid.NewGuid().ToString(); // Id oluşturuldu
            OnCreatedDate = DateTime.Now; //Oluşturulma tarihi atandı
            SetDiscountAmount(discountAmount);            
        }
        /// <summary>
        /// İndirim tutarı hatalı değilse eklendi
        /// </summary>
        /// <param name="discountAmount"></param>
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
