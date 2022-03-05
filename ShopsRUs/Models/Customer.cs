using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public enum CustomerStatus
    {
        Employee = 100,
        Affiliate = 101,
        DefaultCustomer = 102
    }
    public class Customer : Entity
    {
        public int IdentityNumber { get; set; }
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
        public int Status { get;private set; }

        private List<Invoice> invoices = new List<Invoice>();
        public IReadOnlyList<Invoice> Invoices => invoices;
        public Customer(string firstName,string lastName,CustomerStatus customerStatus,int identityNumber)
        {
            Id = Guid.NewGuid().ToString(); // Id oluşturuldu
            OnCreatedDate = DateTime.Now; //Oluşturulma tarihi atandı
            SetName(firstName,lastName);
            SetIdentityNumber(identityNumber);
            Status = (int)customerStatus; //Durum bilgisi atandı
        }
        
        /// <summary>
        /// Constructerdan gelen isim ve soyisimde hata yoksa atama yapıldı 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void SetName(string firstName,string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new Exception("First Name and Last Name is required.");         
            }
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
        }
        /// <summary>
        /// Müşteriye fatura ekleme metodu
        /// </summary>
        /// <param name="invoice"></param>
        public void AddInvoice(Invoice invoice)
        {
            this.invoices.Add(invoice);
            invoice.SetInvoiceNumber(invoices.Count());
        }
        /// <summary>
        /// Müşteriye Kimlik numarası atandı
        /// </summary>
        /// <param name="identityNumber"></param>
        public void SetIdentityNumber(int identityNumber)
        {
            if (identityNumber==null)
            {
                throw new Exception("Identity Number cannot be empty!");
            }
            IdentityNumber = identityNumber;
        }
    }
}
