using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conectado
{
    class Operaciones:BD
    {
        public void Ver() {
            Abrir();
            var query = ("Select * from Estudiante");
            var command = new SqlCommand(query, con);
            var dr = command.ExecuteReader();
            dr.Read();
            var registro = dr.GetString(1) + ", " + dr.GetString(2) + ", " + dr.GetString(3) + ", " + dr.GetString(4) + ", " + dr.GetDateTime(5).ToShortDateString() + ", ";
            MessageBox.Show(registro);
            Cerrar();
        }

        public void Ultimo() {
            Abrir();
            var query = ("Select * from Estudiante where idEstudiante =(select max (idEstudiante) from Estudiante ) ");
            var command = new SqlCommand(query, con);
            var dr = command.ExecuteReader();
            dr.Read();
            var registro = dr.GetString(1) + ", " + dr.GetString(2) + ", " + dr.GetString(3) + ", " + dr.GetString(4) + ", " + dr.GetDateTime(5).ToShortDateString() + ", ";
            Cerrar();
            MessageBox.Show(registro);   
        }

        public void VerTodos()
        {
            Abrir();
            String query = ("Select * from Estudiante");
            SqlCommand command = new SqlCommand(query, con);
            var dr = command.ExecuteReader();
            while (dr.Read())
            {
                var registro = dr.GetString(1) + ", " + dr.GetString(2) + ", " + dr.GetString(3) + ", " + dr.GetString(4) + ", " + dr.GetDateTime(5).ToShortDateString() + ", ";
                MessageBox.Show(registro);
            }
            Cerrar();
        }

        public void ValorUnico()
        {
            var query = ("Select count (*) from Estudiante");
            var command = new SqlCommand(query, con);
            Abrir();
            var cantidad = command.ExecuteScalar();
            Cerrar();
            MessageBox.Show("Se han encontrado " + cantidad.ToString() + " registros");
        }

        public void Mostrar(NumericUpDown ide, TextBox nombre, TextBox apellido, MaskedTextBox dni, TextBox email, DateTimePicker fecha)
        {
            Abrir();
            var query = ("Select * from Estudiante");
            var command = new SqlCommand(query, con);
            var dr = command.ExecuteReader();
            dr.Read();
            ide.Value = dr.GetInt32(0);
            nombre.Text = dr.GetString(1);
            apellido.Text = dr.GetString(2);
            email.Text = dr.GetString(3);
            dni.Text = dr.GetString(4);
            fecha.Value = dr.GetDateTime(5);
            Cerrar();
        }

        public void MostrarUltimo(NumericUpDown ide, TextBox nombre, TextBox apellido, MaskedTextBox dni, TextBox email, DateTimePicker fecha)
        {

            Abrir();
            String query = ("Select * from Estudiante where idEstudiante=(select max (idEstudiante) from Estudiante )");
            SqlCommand command = new SqlCommand(query, con);
            var dr = command.ExecuteReader();
            dr.Read();
            ide.Value = dr.GetInt32(0);
            nombre.Text = dr.GetString(1);
            apellido.Text = dr.GetString(2);
            email.Text = dr.GetString(3);
            dni.Text = dr.GetString(4);
            fecha.Value = dr.GetDateTime(5);
            Cerrar();

        }

        public void MostrarTodos(NumericUpDown ide, TextBox nombre, TextBox apellido, MaskedTextBox dni, TextBox email, DateTimePicker fecha)
        {
            Abrir();
            var query = ("Select * from Estudiante");
            var command = new SqlCommand(query, con);
            var dr = command.ExecuteReader();
            var c = 1;
            while (dr.Read())
            {
                MessageBox.Show("Registro N: "+c.ToString());
                ide.Value = dr.GetInt32(0);
                nombre.Text = dr.GetString(1);
                apellido.Text = dr.GetString(2);
                email.Text = dr.GetString(3);
                dni.Text = dr.GetString(4);
                fecha.Value = dr.GetDateTime(5);
                c++;
            }
            Cerrar();
        }

    }
}
