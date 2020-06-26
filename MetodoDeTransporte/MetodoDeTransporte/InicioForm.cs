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

        //el metodo limpia el formulario
        private void limpiarTabla()
        {
            //vacio la tabla
            dvgTablaDatos.Columns.Clear();
            dvgTablaDatos.Columns.Clear();
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
            if(!String.IsNullOrEmpty(txtCantidadDemanda.Text) && !String.IsNullOrEmpty(txtCantidadOferta.Text))
            {

                int demanda = int.Parse(txtCantidadDemanda.Text);
                int oferta = int.Parse(txtCantidadOferta.Text);

                int numeroColumn = demanda + 2;
                int numeroRow = oferta + 1;
                int origen = 0;

                limpiarTabla(); //el metodo limpia el formulario

                //agrego las columnas
                for (int i = 0; i < numeroColumn; i++)
                {
                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                    
                    if(i == 0)
                    {
                        columna.HeaderText = "Destino/Origen";
                    } 
                    else if(i == numeroColumn - 1) {
                        columna.HeaderText = "Oferta";
                    }
                    else
                    {
                        columna.HeaderText = "D" + i;
                    }

                    columna.Width = 120;

                    dvgTablaDatos.Columns.Add(columna);
                }

                origen = 0;

                //agrego las filas
                for(int i = 0; i < numeroRow; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dvgTablaDatos.Rows[i].Clone();

                    origen++;

                    for (int j = 0; j < numeroColumn; j++)
                    {
                        //inserto un determinado valor en fila 0 de la columna 0
                        if(j == 0)
                        {
                            if (i == numeroRow - 1)
                            {
                                row.Cells[0].Value = "Demanda";
                            } else
                            {
                                row.Cells[j].Value = "O" + (i + 1);
                            }

                        }
                        else
                        {
                            row.Cells[j].Value = "";
                        }
                        
                    }

                    dvgTablaDatos.Rows.Add(row);

                }
            }

            else
            {
                MessageBox.Show("Ingrese todos los datos de la caja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //vacio las cajas
            txtCantidadDemanda.Text = null;
            txtCantidadOferta.Text = null;
            limpiarTabla(); //el metodo limpia el formulario
        }
    }
}
