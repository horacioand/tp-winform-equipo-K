namespace Visual
{
    partial class frmPrincipal
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnEliminarArticuloFisico = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 30);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(686, 306);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(623, 346);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(12, 346);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 4;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnEliminarArticuloFisico
            // 
            this.btnEliminarArticuloFisico.Location = new System.Drawing.Point(93, 346);
            this.btnEliminarArticuloFisico.Name = "btnEliminarArticuloFisico";
            this.btnEliminarArticuloFisico.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArticuloFisico.TabIndex = 5;
            this.btnEliminarArticuloFisico.Text = "Eliminar";
            this.btnEliminarArticuloFisico.UseVisualStyleBackColor = true;
            this.btnEliminarArticuloFisico.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregar,
            this.tsmModificar,
            this.tsmEliminar});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(710, 24);
            this.msMenu.TabIndex = 6;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmAgregar
            // 
            this.tsmAgregar.BackColor = System.Drawing.Color.Linen;
            this.tsmAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarArticulo,
            this.tsmAgregarCategoria,
            this.tsmAgregarMarca});
            this.tsmAgregar.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tsmAgregar.Name = "tsmAgregar";
            this.tsmAgregar.Size = new System.Drawing.Size(61, 20);
            this.tsmAgregar.Text = "Agregar";

            // 
            // tsmAgregarArticulo
            // 
            this.tsmAgregarArticulo.Name = "tsmAgregarArticulo";
            this.tsmAgregarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarArticulo.Text = "Articulo";
            this.tsmAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // tsmAgregarCategoria
            // 
            this.tsmAgregarCategoria.Name = "tsmAgregarCategoria";
            this.tsmAgregarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarCategoria.Text = "Categoria";
            // 
            // tsmAgregarMarca
            // 
            this.tsmAgregarMarca.Name = "tsmAgregarMarca";
            this.tsmAgregarMarca.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarMarca.Text = "Marca";
            // 
            // tsmModificar
            // 
            this.tsmModificar.BackColor = System.Drawing.Color.Linen;
            this.tsmModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModificarArticulo,
            this.tsmModificarCategoria,
            this.tsmModificarMarca});
            this.tsmModificar.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(70, 20);
            this.tsmModificar.Text = "Modificar";
            // 
            // tsmModificarArticulo
            // 
            this.tsmModificarArticulo.Name = "tsmModificarArticulo";
            this.tsmModificarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarArticulo.Text = "Articulo";
            this.tsmModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // tsmModificarCategoria
            // 
            this.tsmModificarCategoria.Name = "tsmModificarCategoria";
            this.tsmModificarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarCategoria.Text = "Categoria";
            // 
            // tsmModificarMarca
            // 
            this.tsmModificarMarca.Name = "tsmModificarMarca";
            this.tsmModificarMarca.Size = new System.Drawing.Size(180, 22);
            this.tsmModificarMarca.Text = "Marca";
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.BackColor = System.Drawing.Color.Linen;
            this.tsmEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminarArticulo,
            this.tsmEliminarCategoria,
            this.tsmEliminarMarca});
            this.tsmEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(62, 20);
            this.tsmEliminar.Text = "Eliminar";
            // 
            // tsmEliminarArticulo
            // 
            this.tsmEliminarArticulo.Name = "tsmEliminarArticulo";
            this.tsmEliminarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarArticulo.Text = "Articulo";
            this.tsmEliminarArticulo.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tsmEliminarCategoria
            // 
            this.tsmEliminarCategoria.Enabled = false;
            this.tsmEliminarCategoria.Name = "tsmEliminarCategoria";
            this.tsmEliminarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarCategoria.Text = "Categoria";
            // 
            // tsmEliminarMarca
            // 
            this.tsmEliminarMarca.Enabled = false;
            this.tsmEliminarMarca.Name = "tsmEliminarMarca";
            this.tsmEliminarMarca.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminarMarca.Text = "Marca";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 381);
            this.Controls.Add(this.btnEliminarArticuloFisico);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnEliminarArticuloFisico;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarMarca;
    }
}

