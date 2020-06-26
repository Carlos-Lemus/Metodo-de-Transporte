namespace MetodoDeTransporte
{
    partial class InicioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgTablaDatos = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.cbTipoMetodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new FontAwesome.Sharp.IconButton();
            this.txtCantidadDemanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadOferta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResultados = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTablaDatos)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgTablaDatos
            // 
            this.dvgTablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTablaDatos.Location = new System.Drawing.Point(41, 39);
            this.dvgTablaDatos.Name = "dvgTablaDatos";
            this.dvgTablaDatos.RowHeadersWidth = 62;
            this.dvgTablaDatos.Size = new System.Drawing.Size(426, 256);
            this.dvgTablaDatos.TabIndex = 0;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.panelLateral.Controls.Add(this.cbTipoMetodo);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Controls.Add(this.btnOk);
            this.panelLateral.Controls.Add(this.txtCantidadDemanda);
            this.panelLateral.Controls.Add(this.label2);
            this.panelLateral.Controls.Add(this.txtCantidadOferta);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateral.Location = new System.Drawing.Point(509, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(175, 412);
            this.panelLateral.TabIndex = 1;
            // 
            // cbTipoMetodo
            // 
            this.cbTipoMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMetodo.FormattingEnabled = true;
            this.cbTipoMetodo.Items.AddRange(new object[] {
            "Esquina Noroeste",
            "Costo Minimo",
            "Vogel"});
            this.cbTipoMetodo.Location = new System.Drawing.Point(9, 256);
            this.cbTipoMetodo.Name = "cbTipoMetodo";
            this.cbTipoMetodo.Size = new System.Drawing.Size(154, 28);
            this.cbTipoMetodo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de metodo";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnOk.IconColor = System.Drawing.Color.White;
            this.btnOk.IconSize = 32;
            this.btnOk.Location = new System.Drawing.Point(22, 326);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOk.Rotation = 0D;
            this.btnOk.Size = new System.Drawing.Size(130, 40);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCantidadDemanda
            // 
            this.txtCantidadDemanda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadDemanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDemanda.Location = new System.Drawing.Point(7, 78);
            this.txtCantidadDemanda.Name = "txtCantidadDemanda";
            this.txtCantidadDemanda.Size = new System.Drawing.Size(156, 26);
            this.txtCantidadDemanda.TabIndex = 7;
            this.txtCantidadDemanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDemanada_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de Demanda";
            // 
            // txtCantidadOferta
            // 
            this.txtCantidadOferta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadOferta.Location = new System.Drawing.Point(8, 168);
            this.txtCantidadOferta.Name = "txtCantidadOferta";
            this.txtCantidadOferta.Size = new System.Drawing.Size(155, 26);
            this.txtCantidadOferta.TabIndex = 8;
            this.txtCantidadOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadOferta_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de oferta";
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultados.FlatAppearance.BorderSize = 0;
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.ForeColor = System.Drawing.Color.White;
            this.btnResultados.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnResultados.IconColor = System.Drawing.Color.White;
            this.btnResultados.IconSize = 32;
            this.btnResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultados.Location = new System.Drawing.Point(41, 363);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnResultados.Rotation = 0D;
            this.btnResultados.Size = new System.Drawing.Size(140, 40);
            this.btnResultados.TabIndex = 12;
            this.btnResultados.Text = "Calcular";
            this.btnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResultados.UseVisualStyleBackColor = false;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconSize = 32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(210, 363);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLimpiar.Rotation = 0D;
            this.btnLimpiar.Size = new System.Drawing.Size(140, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.dvgTablaDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioForm";
            this.Text = "InicioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTablaDatos)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTablaDatos;
        private System.Windows.Forms.Panel panelLateral;
        private FontAwesome.Sharp.IconButton btnOk;
        private System.Windows.Forms.TextBox txtCantidadDemanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadOferta;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnResultados;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.ComboBox cbTipoMetodo;
        private System.Windows.Forms.Label label3;
    }
}