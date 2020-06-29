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
    public partial class ResultadoForm : Form
    {
        public ResultadoForm()
        {
            InitializeComponent();
            textInfo();
        }

        public void textInfo()
        {
            if(Datos.resultadoGlobal > 0)
            {
                txtResultado.Text = "La solucion factible es: \n$" + Datos.resultadoGlobal.ToString();
            }
            else {
                txtResultado.Text = "No se ha realizado ninguna operacion";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Datos.resultadoGlobal = 0;
            txtResultado.Text = "No se ha realizado ninguna operacion";
        }
    }
}
