namespace cs_instrumentos
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percuciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lInstrumento = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCuerda = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPercucion = new System.Windows.Forms.RadioButton();
            this.rbViento = new System.Windows.Forms.RadioButton();
            this.bLimpiarFiltro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bFiltrarPrecios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtDesde = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bModificarInstrumento = new System.Windows.Forms.Button();
            this.bEliminarInstrumento = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vientoToolStripMenuItem,
            this.cuerdaToolStripMenuItem,
            this.percuciónToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Instrumento De";
            // 
            // vientoToolStripMenuItem
            // 
            this.vientoToolStripMenuItem.Name = "vientoToolStripMenuItem";
            this.vientoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vientoToolStripMenuItem.Text = "Viento";
            this.vientoToolStripMenuItem.Click += new System.EventHandler(this.vientoToolStripMenuItem_Click);
            // 
            // cuerdaToolStripMenuItem
            // 
            this.cuerdaToolStripMenuItem.Name = "cuerdaToolStripMenuItem";
            this.cuerdaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cuerdaToolStripMenuItem.Text = "Cuerda";
            this.cuerdaToolStripMenuItem.Click += new System.EventHandler(this.cuerdaToolStripMenuItem_Click);
            // 
            // percuciónToolStripMenuItem
            // 
            this.percuciónToolStripMenuItem.Name = "percuciónToolStripMenuItem";
            this.percuciónToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.percuciónToolStripMenuItem.Text = "Percución";
            this.percuciónToolStripMenuItem.Click += new System.EventHandler(this.percuciónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca del proyecto";
            // 
            // lInstrumento
            // 
            this.lInstrumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lInstrumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lInstrumento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lInstrumento.FormattingEnabled = true;
            this.lInstrumento.Location = new System.Drawing.Point(337, 33);
            this.lInstrumento.Name = "lInstrumento";
            this.lInstrumento.Size = new System.Drawing.Size(291, 262);
            this.lInstrumento.Sorted = true;
            this.lInstrumento.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.rbCuerda);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbPercucion);
            this.groupBox1.Controls.Add(this.rbViento);
            this.groupBox1.Location = new System.Drawing.Point(38, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instrumentos";
            // 
            // rbCuerda
            // 
            this.rbCuerda.AutoSize = true;
            this.rbCuerda.Location = new System.Drawing.Point(12, 44);
            this.rbCuerda.Name = "rbCuerda";
            this.rbCuerda.Size = new System.Drawing.Size(59, 17);
            this.rbCuerda.TabIndex = 3;
            this.rbCuerda.TabStop = true;
            this.rbCuerda.Text = "Cuerda";
            this.rbCuerda.UseVisualStyleBackColor = true;
            this.rbCuerda.CheckedChanged += new System.EventHandler(this.rbCuerda_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(12, 21);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 1;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbPercucion
            // 
            this.rbPercucion.AutoSize = true;
            this.rbPercucion.Location = new System.Drawing.Point(113, 44);
            this.rbPercucion.Name = "rbPercucion";
            this.rbPercucion.Size = new System.Drawing.Size(73, 17);
            this.rbPercucion.TabIndex = 4;
            this.rbPercucion.TabStop = true;
            this.rbPercucion.Text = "Percución";
            this.rbPercucion.UseVisualStyleBackColor = true;
            this.rbPercucion.CheckedChanged += new System.EventHandler(this.rbPercucion_CheckedChanged);
            // 
            // rbViento
            // 
            this.rbViento.AutoSize = true;
            this.rbViento.Location = new System.Drawing.Point(113, 21);
            this.rbViento.Name = "rbViento";
            this.rbViento.Size = new System.Drawing.Size(55, 17);
            this.rbViento.TabIndex = 2;
            this.rbViento.TabStop = true;
            this.rbViento.Text = "Viento";
            this.rbViento.UseVisualStyleBackColor = true;
            this.rbViento.CheckedChanged += new System.EventHandler(this.rbViento_CheckedChanged);
            // 
            // bLimpiarFiltro
            // 
            this.bLimpiarFiltro.BackColor = System.Drawing.Color.Silver;
            this.bLimpiarFiltro.Location = new System.Drawing.Point(108, 85);
            this.bLimpiarFiltro.Name = "bLimpiarFiltro";
            this.bLimpiarFiltro.Size = new System.Drawing.Size(75, 40);
            this.bLimpiarFiltro.TabIndex = 18;
            this.bLimpiarFiltro.Text = "Limpiar Precios";
            this.bLimpiarFiltro.UseVisualStyleBackColor = false;
            this.bLimpiarFiltro.Click += new System.EventHandler(this.bLimpiarFiltro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta:";
            // 
            // bFiltrarPrecios
            // 
            this.bFiltrarPrecios.BackColor = System.Drawing.Color.Silver;
            this.bFiltrarPrecios.Location = new System.Drawing.Point(16, 85);
            this.bFiltrarPrecios.Name = "bFiltrarPrecios";
            this.bFiltrarPrecios.Size = new System.Drawing.Size(75, 40);
            this.bFiltrarPrecios.TabIndex = 17;
            this.bFiltrarPrecios.Text = "Filtrar Precios";
            this.bFiltrarPrecios.UseVisualStyleBackColor = false;
            this.bFiltrarPrecios.Click += new System.EventHandler(this.bFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde:";
            // 
            // mtHasta
            // 
            this.mtHasta.Location = new System.Drawing.Point(66, 45);
            this.mtHasta.Mask = "99999.99";
            this.mtHasta.Name = "mtHasta";
            this.mtHasta.Size = new System.Drawing.Size(100, 20);
            this.mtHasta.TabIndex = 13;
            // 
            // mtDesde
            // 
            this.mtDesde.Location = new System.Drawing.Point(66, 19);
            this.mtDesde.Mask = "99999.99";
            this.mtDesde.Name = "mtDesde";
            this.mtDesde.Size = new System.Drawing.Size(100, 20);
            this.mtDesde.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.bLimpiarFiltro);
            this.groupBox2.Controls.Add(this.mtDesde);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mtHasta);
            this.groupBox2.Controls.Add(this.bFiltrarPrecios);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(38, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 134);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio";
            // 
            // bModificarInstrumento
            // 
            this.bModificarInstrumento.BackColor = System.Drawing.Color.Silver;
            this.bModificarInstrumento.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bModificarInstrumento.Location = new System.Drawing.Point(410, 310);
            this.bModificarInstrumento.Name = "bModificarInstrumento";
            this.bModificarInstrumento.Size = new System.Drawing.Size(85, 41);
            this.bModificarInstrumento.TabIndex = 18;
            this.bModificarInstrumento.Text = "Modificar Instrumento";
            this.bModificarInstrumento.UseVisualStyleBackColor = false;
            this.bModificarInstrumento.Click += new System.EventHandler(this.bModificarInstrumento_Click);
            // 
            // bEliminarInstrumento
            // 
            this.bEliminarInstrumento.BackColor = System.Drawing.Color.Silver;
            this.bEliminarInstrumento.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bEliminarInstrumento.Location = new System.Drawing.Point(515, 310);
            this.bEliminarInstrumento.Name = "bEliminarInstrumento";
            this.bEliminarInstrumento.Size = new System.Drawing.Size(84, 41);
            this.bEliminarInstrumento.TabIndex = 19;
            this.bEliminarInstrumento.Text = "Eliminar Instrumento";
            this.bEliminarInstrumento.UseVisualStyleBackColor = false;
            this.bEliminarInstrumento.Click += new System.EventHandler(this.bEliminarInstrumento_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 400);
            this.Controls.Add(this.bEliminarInstrumento);
            this.Controls.Add(this.bModificarInstrumento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lInstrumento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPrincipal";
            this.Text = "Sistema de Gestion de Instrumentos";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox lInstrumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCuerda;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPercucion;
        private System.Windows.Forms.RadioButton rbViento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtHasta;
        private System.Windows.Forms.MaskedTextBox mtDesde;
        private System.Windows.Forms.ToolStripMenuItem vientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percuciónToolStripMenuItem;
        private System.Windows.Forms.Button bFiltrarPrecios;
        private System.Windows.Forms.Button bLimpiarFiltro;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bModificarInstrumento;
        private System.Windows.Forms.Button bEliminarInstrumento;
    }
}

