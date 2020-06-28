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
    public partial class FormMain : Form
    {
        //bordes de los botones
        private IconButton btnActual;
        private Panel borderLeftBtn;
        private Color colorBtn = Color.FromArgb(68, 189, 50);
        private Form formActivo = null;

        public FormMain()
        {
            InitializeComponent();

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

        //el metodo abre uno de los formularios de la aplicacion
        private void abrirForm(Form childForm)
        {
            cierraForm(formActivo); //cierro el formulario activo

            //cambio las propiedados del formulario para agregarlo al panelContentForm
            formActivo = childForm;
            formActivo.TopLevel = false;
            formActivo.Dock = DockStyle.Fill;
            formActivo.FormBorderStyle = FormBorderStyle.None;
            panelContentForm.Controls.Add(formActivo);
            panelContentForm.Tag = formActivo;
            formActivo.BringToFront();
            formActivo.Show(); //muestro el formulario
        }

        //el metodo cierra uno de los formularios de la aplicacion
        private void cierraForm(Form form)
        {
            //evaluo que se halla enviado un formulario
            if (form != null)
            {
                form.Close(); //cierro el formulario activado
            }

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorBtn); //activo el btn para cambiar sus propiedades
            cierraForm(formActivo); //cierro el formulario activo
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            activarBtn(sender, colorBtn); //activo el btn para cambiar sus propiedades
            abrirForm(new CalcularForm()); //abro el formulario de resultados
        }

        private void btnResultado_Click_1(object sender, EventArgs e)
        {
            activarBtn(sender, colorBtn); //activo el btn para cambiar sus propiedades
            abrirForm(new ResultadoForm()); //abro el formulario de inicios
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            Datos.resultadoGloba = 0;
            desactivarBtn(); //desactivo el boton seleccionado anterios
            cierraForm(formActivo); //cierro el formulario activo
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); //cierro la ventana
        }

       
    }
}

