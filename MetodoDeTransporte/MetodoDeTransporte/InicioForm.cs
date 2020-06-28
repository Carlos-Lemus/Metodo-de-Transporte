using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoDeTransporte
{
    public partial class InicioForm : Form
    {

        private EsquinaNoroeste esquinaNoroeste = new EsquinaNoroeste();

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //vacio las cajas
            txtCantidadDemanda.Text = null;
            txtCantidadOferta.Text = null;
            limpiarTabla(); //el metodo limpia el formulario
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //evaluo que los campos no esten vacios
            if(!String.IsNullOrEmpty(txtCantidadDemanda.Text) && !String.IsNullOrEmpty(txtCantidadOferta.Text))
            {

                int demanda = int.Parse(txtCantidadDemanda.Text);
                int oferta = int.Parse(txtCantidadOferta.Text);

                int numeroColumn = demanda + 2;
                int numeroRow = oferta + 1;

                limpiarTabla(); //el metodo limpia la tabla

                llenarColumnasTabla(numeroColumn);

                llenarFilasTabla(numeroColumn, numeroRow);
            }

            else
            {
                MessageBox.Show("Ingrese todos los datos de la caja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            calcular(); //el metodo hace las operaciones para calcular el resultado
        }

        //el metodo hace las operaciones para calcular el resultado
        private void calcular()
        {
            string tipoMetodo = "";

            try
            {
                tipoMetodo = cbTipoMetodo.SelectedItem.ToString();

                switch (tipoMetodo)
                {
                    case "Esquina Noroeste":
                        MessageBox.Show(esquinaNoroeste.calcularResultado(dvgTablaDatos).ToString());
                        break;

                    case "Costo Minimo":
                        MessageBox.Show("Costo Minimo");
                        break;

                    case "Vogel":
                        MessageBox.Show("Vogel");
                        break;

                    default:
                        MessageBox.Show("No ha seleccionado ninguno de los tipos de metodos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

            } catch(Exception ex) {
                MessageBox.Show("No se ha podido realizar el calculo\n" + "Mensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        //el metodo limpia el formulario
        private void limpiarTabla()
        {
            //vacio la tabla
            dvgTablaDatos.Columns.Clear();
            dvgTablaDatos.Columns.Clear();
        }

        //el metodo agrega las columnas de la tabla
        private void llenarColumnasTabla(int numeroColumn)
        {
            //agrego las columnas
            for (int i = 0; i < numeroColumn; i++)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();

                if (i == 0)
                {
                    columna.HeaderText = "Destino/Origen";
                }
                else if (i == numeroColumn - 1)
                {
                    columna.HeaderText = "Oferta";
                }
                else
                {
                    columna.HeaderText = "D" + i;
                }

                columna.Width = 120;

                dvgTablaDatos.Columns.Add(columna);
            }
        }

        //el metodo llena las filas de la tabla
        private void llenarFilasTabla(int numeroColumn, int numeroRow)
        {

            //agrego las filas
            for (int i = 0; i < numeroRow; i++)
            {

                //obtengo la fila actual
                DataGridViewRow row = (DataGridViewRow)dvgTablaDatos.Rows[i].Clone();

                for (int j = 0; j < numeroColumn; j++)
                {
                    //inserto un determinado valor en fila 0 de la columna 0
                    if (j == 0)
                    {
                        if (i == numeroRow - 1)
                        {
                            row.Cells[0].Value = "Demanda";
                        }
                        else
                        {
                            row.Cells[j].Value = "O" + (i + 1);
                        }

                    }
                    else
                    {
                        row.Cells[j].Value = "0";
                    }

                }

                dvgTablaDatos.Rows.Add(row);

            }
        }

    }

}