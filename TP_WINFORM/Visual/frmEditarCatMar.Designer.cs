namespace Visual
{
    partial class frmEditarCatMar
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
            this.cboEdicionCatMar = new System.Windows.Forms.ComboBox();
            this.dgvEdicionCatMar = new System.Windows.Forms.DataGridView();
            this.lblElemento = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicionCatMar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEdicionCatMar
            // 
            this.cboEdicionCatMar.FormattingEnabled = true;
            this.cboEdicionCatMar.Location = new System.Drawing.Point(72, 12);
            this.cboEdicionCatMar.Name = "cboEdicionCatMar";
            this.cboEdicionCatMar.Size = new System.Drawing.Size(129, 21);
            this.cboEdicionCatMar.TabIndex = 0;
            this.cboEdicionCatMar.SelectedIndexChanged += new System.EventHandler(this.cboEdicionCatMar_SelectedIndexChanged);
            // 
            // dgvEdicionCatMar
            // 
            this.dgvEdicionCatMar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdicionCatMar.Location = new System.Drawing.Point(207, 12);
            this.dgvEdicionCatMar.Name = "dgvEdicionCatMar";
            this.dgvEdicionCatMar.Size = new System.Drawing.Size(258, 146);
            this.dgvEdicionCatMar.TabIndex = 1;
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(12, 15);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(54, 13);
            this.lblElemento.TabIndex = 2;
            this.lblElemento.Text = "Elemento:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(125, 39);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(125, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 93);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Nueva Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 109);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(368, 164);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(126, 135);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Location = new System.Drawing.Point(97, 39);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(22, 23);
            this.btnCancelarEdicion.TabIndex = 9;
            this.btnCancelarEdicion.Text = "X";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            this.btnCancelarEdicion.Visible = false;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // frmEditarCatMar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(475, 192);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.dgvEdicionCatMar);
            this.Controls.Add(this.cboEdicionCatMar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarCatMar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditarCatMar";
            this.Load += new System.EventHandler(this.frmEditarCatMar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicionCatMar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEdicionCatMar;
        private System.Windows.Forms.DataGridView dgvEdicionCatMar;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelarEdicion;
    }
}