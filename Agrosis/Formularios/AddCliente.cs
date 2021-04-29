using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrosis.Formularios
{
    public partial class AddCliente : Form
    {
        private Clases.Cliente Cli = new Clases.Cliente();
        public AddCliente()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listadatos();
            limpiar();
        }

        private void listadatos()
        {
            string Nombre, Tel, Dir, Nit, Dpi;
            Dpi = "N/E";
            Nombre = TxtNom.Text == "" ? "" : TxtNom.Text;
            Dir = TxtDir.Text == "" ? "" : TxtDir.Text;
            Nit = TxtNit.Text == "" ? "" : TxtNit.Text;
            Tel = TxtTel.Text == "" ? "" : TxtTel.Text;
            string[] datos = { Nombre,Dir,Nit,Dpi,Tel};
            if (Cli.ingreso_cli(datos))
            {
                MessageBox.Show("Cliente ingresado correctamente","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error ingresando datos del Cliente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void limpiar()
        {
            TxtNit.Clear();
            TxtDir.Clear();
            TxtTel.Clear();
            TxtNom.Clear();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
