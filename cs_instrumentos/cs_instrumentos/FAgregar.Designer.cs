namespace cs_instrumentos
{
    partial class FAgregar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAgregar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.tMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudUnidades = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.rbMetal = new System.Windows.Forms.RadioButton();
            this.rbMadera = new System.Windows.Forms.RadioButton();
            this.EnroCuerdas = new System.Windows.Forms.Label();
            this.nudCuerdas = new System.Windows.Forms.NumericUpDown();
            this.checkAfinado = new System.Windows.Forms.CheckBox();
            this.cbPercucion = new System.Windows.Forms.ComboBox();
            this.cbViento = new System.Windows.Forms.ComboBox();
            this.cbCuerda = new System.Windows.Forms.ComboBox();
            this.mtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidades)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuerdas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // bAgregar
            // 
            this.bAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAgregar.Location = new System.Drawing.Point(195, 283);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(290, 283);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // mtCodigo
            // 
            this.mtCodigo.Location = new System.Drawing.Point(61, 12);
            this.mtCodigo.Mask = "999";
            this.mtCodigo.Name = "mtCodigo";
            this.mtCodigo.ReadOnly = true;
            this.mtCodigo.Size = new System.Drawing.Size(100, 20);
            this.mtCodigo.TabIndex = 8;
            // 
            // tMarca
            // 
            this.tMarca.Location = new System.Drawing.Point(61, 109);
            this.tMarca.Name = "tMarca";
            this.tMarca.Size = new System.Drawing.Size(100, 20);
            this.tMarca.TabIndex = 11;
            this.tMarca.Validating += new System.ComponentModel.CancelEventHandler(this.tMarca_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(8, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad de Unidades";
            // 
            // nudUnidades
            // 
            this.nudUnidades.Location = new System.Drawing.Point(122, 155);
            this.nudUnidades.Name = "nudUnidades";
            this.nudUnidades.Size = new System.Drawing.Size(43, 20);
            this.nudUnidades.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gbMaterial);
            this.panel1.Controls.Add(this.EnroCuerdas);
            this.panel1.Controls.Add(this.nudCuerdas);
            this.panel1.Controls.Add(this.checkAfinado);
            this.panel1.Controls.Add(this.cbPercucion);
            this.panel1.Controls.Add(this.cbViento);
            this.panel1.Controls.Add(this.cbCuerda);
            this.panel1.Controls.Add(this.mtPrecio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudUnidades);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tMarca);
            this.panel1.Controls.Add(this.mtCodigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 258);
            this.panel1.TabIndex = 15;
            // 
            // gbMaterial
            // 
            this.gbMaterial.Controls.Add(this.rbMetal);
            this.gbMaterial.Controls.Add(this.rbMadera);
            this.gbMaterial.Location = new System.Drawing.Point(198, 137);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Size = new System.Drawing.Size(134, 51);
            this.gbMaterial.TabIndex = 25;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Material";
            this.gbMaterial.Visible = false;
            // 
            // rbMetal
            // 
            this.rbMetal.AutoSize = true;
            this.rbMetal.BackColor = System.Drawing.Color.LightGray;
            this.rbMetal.Location = new System.Drawing.Point(75, 19);
            this.rbMetal.Name = "rbMetal";
            this.rbMetal.Size = new System.Drawing.Size(51, 17);
            this.rbMetal.TabIndex = 24;
            this.rbMetal.TabStop = true;
            this.rbMetal.Text = "Metal";
            this.rbMetal.UseVisualStyleBackColor = false;
            this.rbMetal.Visible = false;
            // 
            // rbMadera
            // 
            this.rbMadera.AutoSize = true;
            this.rbMadera.BackColor = System.Drawing.Color.LightGray;
            this.rbMadera.Location = new System.Drawing.Point(8, 19);
            this.rbMadera.Name = "rbMadera";
            this.rbMadera.Size = new System.Drawing.Size(61, 17);
            this.rbMadera.TabIndex = 23;
            this.rbMadera.TabStop = true;
            this.rbMadera.Text = "Madera";
            this.rbMadera.UseVisualStyleBackColor = false;
            this.rbMadera.Visible = false;
            // 
            // EnroCuerdas
            // 
            this.EnroCuerdas.AutoSize = true;
            this.EnroCuerdas.BackColor = System.Drawing.Color.LightGray;
            this.EnroCuerdas.Location = new System.Drawing.Point(203, 105);
            this.EnroCuerdas.Name = "EnroCuerdas";
            this.EnroCuerdas.Size = new System.Drawing.Size(76, 13);
            this.EnroCuerdas.TabIndex = 22;
            this.EnroCuerdas.Text = "N° de Cuerdas";
            this.EnroCuerdas.Visible = false;
            // 
            // nudCuerdas
            // 
            this.nudCuerdas.Location = new System.Drawing.Point(288, 103);
            this.nudCuerdas.Maximum = new decimal(new int[] {
            224,
            0,
            0,
            0});
            this.nudCuerdas.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCuerdas.Name = "nudCuerdas";
            this.nudCuerdas.Size = new System.Drawing.Size(36, 20);
            this.nudCuerdas.TabIndex = 21;
            this.nudCuerdas.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCuerdas.Visible = false;
            // 
            // checkAfinado
            // 
            this.checkAfinado.AutoSize = true;
            this.checkAfinado.BackColor = System.Drawing.Color.LightGray;
            this.checkAfinado.Location = new System.Drawing.Point(217, 58);
            this.checkAfinado.Name = "checkAfinado";
            this.checkAfinado.Size = new System.Drawing.Size(62, 17);
            this.checkAfinado.TabIndex = 20;
            this.checkAfinado.Text = "Afinado";
            this.checkAfinado.UseVisualStyleBackColor = false;
            this.checkAfinado.Visible = false;
            // 
            // cbPercucion
            // 
            this.cbPercucion.FormattingEnabled = true;
            this.cbPercucion.Items.AddRange(new object[] {
            "Batería",
            "Bombo",
            "Tambor"});
            this.cbPercucion.Location = new System.Drawing.Point(61, 62);
            this.cbPercucion.Name = "cbPercucion";
            this.cbPercucion.Size = new System.Drawing.Size(121, 21);
            this.cbPercucion.Sorted = true;
            this.cbPercucion.TabIndex = 19;
            this.cbPercucion.Text = "Percución...";
            this.cbPercucion.Visible = false;
            // 
            // cbViento
            // 
            this.cbViento.FormattingEnabled = true;
            this.cbViento.Items.AddRange(new object[] {
            "Clarinete",
            "Flauta",
            "Saxofón"});
            this.cbViento.Location = new System.Drawing.Point(61, 62);
            this.cbViento.Name = "cbViento";
            this.cbViento.Size = new System.Drawing.Size(121, 21);
            this.cbViento.Sorted = true;
            this.cbViento.TabIndex = 18;
            this.cbViento.Text = "Viento...";
            this.cbViento.Visible = false;
            // 
            // cbCuerda
            // 
            this.cbCuerda.FormattingEnabled = true;
            this.cbCuerda.Items.AddRange(new object[] {
            "Arpa",
            "Bajo",
            "Guitarra",
            "Violín"});
            this.cbCuerda.Location = new System.Drawing.Point(61, 62);
            this.cbCuerda.Name = "cbCuerda";
            this.cbCuerda.Size = new System.Drawing.Size(121, 21);
            this.cbCuerda.Sorted = true;
            this.cbCuerda.TabIndex = 17;
            this.cbCuerda.Text = "Cuerda...";
            this.cbCuerda.Visible = false;
            // 
            // mtPrecio
            // 
            this.mtPrecio.Location = new System.Drawing.Point(87, 200);
            this.mtPrecio.Mask = "9999.99";
            this.mtPrecio.Name = "mtPrecio";
            this.mtPrecio.Size = new System.Drawing.Size(100, 20);
            this.mtPrecio.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(8, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio sin IVA";
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            // 
            // FAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(383, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAgregar";
            this.Text = "Agregar Instrumento";
            this.Load += new System.EventHandler(this.FAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuerdas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtCodigo;
        private System.Windows.Forms.TextBox tMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudUnidades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPercucion;
        private System.Windows.Forms.ComboBox cbViento;
        private System.Windows.Forms.ComboBox cbCuerda;
        private System.Windows.Forms.MaskedTextBox mtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMetal;
        private System.Windows.Forms.RadioButton rbMadera;
        private System.Windows.Forms.Label EnroCuerdas;
        private System.Windows.Forms.NumericUpDown nudCuerdas;
        private System.Windows.Forms.CheckBox checkAfinado;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
    }
}