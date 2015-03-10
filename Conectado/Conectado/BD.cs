using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conectado
{
    class BD
    {  
       public SqlConnection con = new SqlConnection("Data Source=CEALER-LAPTOP;Initial Catalog=dbUAP;Integrated Security=True");

        public void Abrir() { con.Open(); }
        public void Cerrar() { con.Close(); }

    }
}