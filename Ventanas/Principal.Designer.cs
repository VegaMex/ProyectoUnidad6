namespace Ventanas {
    partial class Principal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblTabla = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJuegoToolStripMenuItem,
            this.modificarSeleccionadoToolStripMenuItem,
            this.eliminarSeleccionadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarJuegoToolStripMenuItem
            // 
            this.agregarJuegoToolStripMenuItem.Name = "agregarJuegoToolStripMenuItem";
            this.agregarJuegoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.agregarJuegoToolStripMenuItem.Text = "Agregar juego";
            this.agregarJuegoToolStripMenuItem.Click += new System.EventHandler(this.agregarJuegoToolStripMenuItem_Click);
            // 
            // modificarSeleccionadoToolStripMenuItem
            // 
            this.modificarSeleccionadoToolStripMenuItem.Name = "modificarSeleccionadoToolStripMenuItem";
            this.modificarSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.modificarSeleccionadoToolStripMenuItem.Text = "Modificar seleccionado";
            this.modificarSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.modificarSeleccionadoToolStripMenuItem_Click);
            // 
            // eliminarSeleccionadoToolStripMenuItem
            // 
            this.eliminarSeleccionadoToolStripMenuItem.Name = "eliminarSeleccionadoToolStripMenuItem";
            this.eliminarSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.eliminarSeleccionadoToolStripMenuItem.Text = "Eliminar seleccionado";
            this.eliminarSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarSeleccionadoToolStripMenuItem_Click);
            // 
            // tblTabla
            // 
            this.tblTabla.AllowUserToAddRows = false;
            this.tblTabla.AllowUserToDeleteRows = false;
            this.tblTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTabla.Location = new System.Drawing.Point(13, 28);
            this.tblTabla.Name = "tblTabla";
            this.tblTabla.ReadOnly = true;
            this.tblTabla.Size = new System.Drawing.Size(596, 193);
            this.tblTabla.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(13, 227);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por desarrollador:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(418, 230);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(534, 227);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 262);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tblTabla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarJuegoToolStripMenuItem;
        private System.Windows.Forms.DataGridView tblTabla;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ToolStripMenuItem modificarSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSeleccionadoToolStripMenuItem;
    }
}

