namespace MetodoDeTransporte
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelContentForm = new System.Windows.Forms.Panel();
            this.pbImagenMain = new System.Windows.Forms.PictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnResultado = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelContentForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnResultado);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 802);
            this.panelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 169);
            this.panel1.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(300, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1026, 108);
            this.panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Padding = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.labelTitulo.Size = new System.Drawing.Size(425, 98);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Modelo de Transporte";
            // 
            // panelContentForm
            // 
            this.panelContentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelContentForm.Controls.Add(this.txtInformacion);
            this.panelContentForm.Controls.Add(this.pbImagenMain);
            this.panelContentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentForm.Location = new System.Drawing.Point(300, 108);
            this.panelContentForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContentForm.Name = "panelContentForm";
            this.panelContentForm.Size = new System.Drawing.Size(1026, 694);
            this.panelContentForm.TabIndex = 3;
            // 
            // pbImagenMain
            // 
            this.pbImagenMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenMain.Image = global::MetodoDeTransporte.Properties.Resources.convoy_semi_truck;
            this.pbImagenMain.Location = new System.Drawing.Point(158, 276);
            this.pbImagenMain.Name = "pbImagenMain";
            this.pbImagenMain.Size = new System.Drawing.Size(733, 369);
            this.pbImagenMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenMain.TabIndex = 0;
            this.pbImagenMain.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 710);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(300, 92);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResultado.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.btnResultado.IconColor = System.Drawing.Color.White;
            this.btnResultado.IconSize = 32;
            this.btnResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultado.Location = new System.Drawing.Point(0, 261);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnResultado.Rotation = 0D;
            this.btnResultado.Size = new System.Drawing.Size(300, 92);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconSize = 32;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 169);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnInicio.Rotation = 0D;
            this.btnInicio.Size = new System.Drawing.Size(300, 92);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::MetodoDeTransporte.Properties.Resources.transporte;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 169);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtInformacion
            // 
            this.txtInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtInformacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacion.ForeColor = System.Drawing.Color.White;
            this.txtInformacion.Location = new System.Drawing.Point(136, 61);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ReadOnly = true;
            this.txtInformacion.Size = new System.Drawing.Size(788, 168);
            this.txtInformacion.TabIndex = 2;
            this.txtInformacion.Text = resources.GetString("txtInformacion.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 802);
            this.Controls.Add(this.panelContentForm);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Metodo de Transporte";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContentForm.ResumeLayout(false);
            this.panelContentForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnResultado;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panelContentForm;
        private System.Windows.Forms.PictureBox pbImagenMain;
        private System.Windows.Forms.TextBox txtInformacion;
    }
}

