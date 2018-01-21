using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaia.Donostia.WinForms.Modelo;


namespace Gaia.Donostia.WinForms.Controlador
{
    public class Control1
    {
        AdventureWorks2012Entities context = new AdventureWorks2012Entities();

        public Customer getCustomerById (int id)
        {
            var Customer = context.Customer.Find(id);
            if (Customer != null)
            {
                return Customer;
            }
            else
            {
                throw new NullReferenceException("Customer not found");
            }
        }


        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customer.ToList();
        }
        

        public void SetCustomersById(Customer editCustomer)
        {
            var Customer = context.Customer.Find(editCustomer.CustomerID);
            if (Customer != null)
            {
                Customer.PersonID = editCustomer.PersonID;
                Customer.StoreID = editCustomer.StoreID;
                Customer.TerritoryID = editCustomer.TerritoryID;
                Customer.AccountNumber = editCustomer.AccountNumber;
                Customer.ModifiedDate = editCustomer.ModifiedDate;

                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Customer not found");
            }
        }

        public void NewCustomer(Customer nuevoCustomer)
        {
            context.Customer.Add(nuevoCustomer);
            context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var Customer = context.Customer.Find(id);
            if (Customer != null)
            {
                context.Customer.Remove(Customer);
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Customer not found");
            }
        }
    }
}
