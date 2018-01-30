using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsADO
{
    public class DAL
    {
        OleDbConnection micon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Neptuno.mdb");

        public DataSet GetClientes()
        {
            
            OleDbDataAdapter mida = new OleDbDataAdapter("SELECT * FROM Clientes", micon);
            DataSet mids = new DataSet();

            using (micon)
                try
                {
                    micon.Open();
                    mida.Fill(mids, "Clientes");
                }

                catch (Exception)
                {
                    throw new SystemException("No se ha encontrao na");
                }

                finally
                {
                    micon.Close();
                }

            return mids;
        }

        public List<string> GetNombreClientes()
        {
            List<string> nombreClientes = new List<string>();
            OleDbCommand miSelectComando = new OleDbCommand();
            miSelectComando.CommandType = CommandType.Text;
            miSelectComando.CommandText = "SELECT NombreContacto FROM Clientes";
            miSelectComando.Connection = micon;
            OleDbDataReader reader = null;


            try
            {
                micon.Open();
                reader = miSelectComando.ExecuteReader();
                while(reader.Read())
                {
                    string valor = string.Empty;
                    valor = reader.GetString(0) == null ? "0" : reader.GetString(0); 
                    nombreClientes.Add(reader.GetString(0));
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                reader.Close();
                micon.Close();
            }

            return nombreClientes;

        }

    }
}
