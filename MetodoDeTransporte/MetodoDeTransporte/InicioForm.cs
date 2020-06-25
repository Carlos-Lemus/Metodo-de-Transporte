using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoDeTransporte
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();

            //selecciono el primer item del combobox
            cbTipoMetodo.SelectedIndex = 0;
        }

        private void txtCantidadDemanada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validaciones

            //condicion para solo números y backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtCantidadOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validaciones

            //condicion para solo números y backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //evaluo que los campos no esten vacios
            if(!String.IsNullOrEmpty(txtCantidadDemanada.Text) && !String.IsNullOrEmpty(txtCantidadOferta.Text))
            {

            }

            else
            {
                MessageBox.Show("Ingrese todos los datos de la caja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //vacio las cajas
            txtCantidadDemanada.Text = null;
            txtCantidadOferta.Text = null;
        }
    }
}
