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
            Id = Guid.NewGuid().ToString();
            OnCreatedDate = DateTime.Now;
            SetName(firstName,lastName);
            SetIdentityNumber(identityNumber);
            Status = (int)customerStatus;
        }
        
        public void SetName(string firstName,string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new Exception("First Name and Last Name is required.");         
            }
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
        }
        public void AddInvoice(Invoice invoice)
        {
            this.invoices.Add(invoice);
            invoice.SetInvoiceNumber(invoices.Count());
        }
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
