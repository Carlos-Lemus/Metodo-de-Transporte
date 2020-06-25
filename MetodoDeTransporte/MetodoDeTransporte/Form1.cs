using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace MetodoDeTransporte
{
    public partial class Form1 : Form
    {
        //bordes de los botones
        private IconButton btnActual;
        private Panel borderLeftBtn;
        private Color colorBtn = Color.FromArgb(68, 189, 50);


        public Form1()
        {
            InitializeComponent();

            btnSalir.ForeColor = Color.FromArgb(231, 76, 60);
            btnSalir.IconColor = Color.FromArgb(231, 76, 60);

            //agrego el border izquierdo al panel menu
            borderLeftBtn = new Panel();
            borderLeftBtn.Size = new Size(8, 90);
            panelMenu.Controls.Add(borderLeftBtn);
        }

        //metodo que cambia las propiedades de los IconButton del panelMenu al activarse
        private void activarBtn(object senderBtn, Color color)
        {
            //evaluo que el boton actual este activado
            if (senderBtn != null)
            {
                desactivarBtn(); //desactivo el boton seleccionado anterios

                //cambio las propiedades del boton y el borde izquierdo del boton

                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = Color.FromArgb(44, 62, 80);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //border izquierdo del boton
                borderLeftBtn.BackColor = color;
                borderLeftBtn.Location = new Point(0, btnActual.Location.Y);
                borderLeftBtn.Visible = true;
                borderLeftBtn.BringToFront();
            }

        }

        //metodo que cambia las propiedades de los IconButton del panelMenu al desactivarse
        private void desactivarBtn()
        {
            //evaluo que el boton actual este activado
            if (btnActual != null)
            {

                //cambio las propiedades del boton y el borde izquierdo del boton

                btnActual.BackColor = Color.FromArgb(52, 73, 94);
                btnActual.ForeColor = Color.White;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
                //border izquierdo del boton
                borderLeftBtn.Visible = false;
            }

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorBtn); //activo el btn para cambiar sus propiedades
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorBtn); //activo el btn para cambiar sus propiedades
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            desactivarBtn(); //desactivo el boton seleccionado anterios
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); //cierro la ventana
        }
    }
}

