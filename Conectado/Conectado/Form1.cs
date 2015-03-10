using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conectado
{
    public partial class Form1 : Form
    {
           Operaciones op = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            op.Ver();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            op.VerTodos();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            op.Ultimo();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            op.ValorUnico();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            op.Mostrar(numID,tbxNom,tbxApe,mtbDNI,tbxEmail,dtpFecha);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op.MostrarUltimo(numID, tbxNom, tbxApe, mtbDNI, tbxEmail, dtpFecha);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            op.MostrarTodos(numID, tbxNom, tbxApe, mtbDNI, tbxEmail, dtpFecha);
        }
    }
}
