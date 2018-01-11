using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace gaia.webforms.test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(@"Data Source=USUARIO-PC;Initial Catalog=AdventureWorks2012;Integrated Security=SSPI"))
            {
                string query = "SELECT * FROM Sales.SalesTerritory";

                SqlCommand cmd = new SqlCommand(query, cnn);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable
            }
        }

        protected void btnConectar_Click(object sender, EventArgs e)
        {
            using (SqlConnection miConn =
                new SqlConnection("Data Source=USUARIO-PC;Initial Catalog=AdventureWorks2012;Integrated Security=SSPI"))
            {
                SqlDataAdapter mida = new SqlDataAdapter();
                SqlCommand miSeleccionCommando = new SqlCommand();
                miSeleccionCommando.CommandType = CommandType.Text;
                miSeleccionCommando.CommandText = @"SELECT * FROM Sales.Customer WHERE Territory = 4";
                miSeleccionCommando.Connection = miConn;
                mida.SelectCommand = miSeleccionCommando;

                SqlParameter sqlParamId = new SqlParameter("@TerritoryID", SqlDbType.Int);

                //int parametro = 0;
                //if (int.TryParse(DropDownListTerritorios.SelectedValue, out parametro))
                //{
                //    sqlParamId.Value = parametro;
                //}

                sqlParamId.Value = Convert.ToInt32(DropDownListTerritorios.SelectedValue);

                miSeleccionCommando.Parameters.Add(sqlParamId);


                DataTable clientesTable = new DataTable();




                try
                {

                }

                catch
                {

                }

                finally
                {

                }

            }
                
        }

        protected void DropDownListTerritorios_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}