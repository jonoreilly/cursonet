using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaia.Donostia.WinFormsMVC.Modelos;

namespace Gaia.Donostia.WinFormsMVC.Controladores
{
    class ClientesControlador
    {
        AdventureWorks2012Entities context = new AdventureWorks2012Entities();

        public IEnumerable<Customer> GetClientes()
        {
            return context.Customer.ToList();
        }

        public Customer GetClientById (int id)
        {
            var cliente = context.Customer.Find(id);
            if  (cliente != null)
            {
                return cliente;
            }
            else
            {
                throw new NullReferenceException("Customer not found");
            }
        }

        public void SetClienteById (Customer editCliente)
        {
            var cliente = context.Customer.Find(editCliente.CustomerID);
            if (cliente != null)
            {
                cliente.PersonID = editCliente.PersonID;
                cliente.StoreID = editCliente.StoreID;
                cliente.TerritoryID = editCliente.TerritoryID;
                cliente.AccountNumber = editCliente.AccountNumber;
                cliente.ModifiedDate = editCliente.ModifiedDate;

                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Customer not found");
            }
        }

        public void NewCliente (Customer nuevoCliente)
        {
            context.Customer.Add(nuevoCliente);
            context.SaveChanges();
        }

        public void DeleteCliente (int id)
        {
            var cliente = context.Customer.Find(id);
            if (cliente != null)
            {
                context.Customer.Remove(cliente);
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Customer not found");
            }
        }
    }
}
