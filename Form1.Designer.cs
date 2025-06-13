namespace Calculo_de_romedios
{
    partial class fmrCalculoPromedios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCalculoPromedios));
            this.gbRegistroNotas = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNotaTres = new System.Windows.Forms.Label();
            this.lblNotaDos = new System.Windows.Forms.Label();
            this.lblNotaUno = new System.Windows.Forms.Label();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btmSalir = new System.Windows.Forms.Button();
            this.btnAgregarPromedio = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegistroNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPromedio.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistroNotas
            // 
            this.gbRegistroNotas.Controls.Add(this.pictureBox1);
            this.gbRegistroNotas.Controls.Add(this.lblError);
            this.gbRegistroNotas.Controls.Add(this.txtNota2);
            this.gbRegistroNotas.Controls.Add(this.txtNota1);
            this.gbRegistroNotas.Controls.Add(this.txtNota3);
            this.gbRegistroNotas.Controls.Add(this.lblNotaTres);
            this.gbRegistroNotas.Controls.Add(this.lblNotaDos);
            this.gbRegistroNotas.Controls.Add(this.lblNotaUno);
            this.gbRegistroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroNotas.Location = new System.Drawing.Point(51, 68);
            this.gbRegistroNotas.Name = "gbRegistroNotas";
            this.gbRegistroNotas.Size = new System.Drawing.Size(750, 387);
            this.gbRegistroNotas.TabIndex = 0;
            this.gbRegistroNotas.TabStop = false;
            this.gbRegistroNotas.Text = "Registro de notas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculo_de_romedios.Properties.Resources.icons8_usuario_100;
            this.pictureBox1.Location = new System.Drawing.Point(598, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(105, 330);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 25);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(305, 171);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(240, 31);
            this.txtNota2.TabIndex = 5;
            this.tlpAyuda.SetToolTip(this.txtNota2, "Ingresa valores entre 0 y 10");            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(305, 73);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(240, 31);
            this.txtNota1.TabIndex = 4;
            this.tlpAyuda.SetToolTip(this.txtNota1, "Ingresa valores entre 0 y 10");
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(305, 266);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(240, 31);
            this.txtNota3.TabIndex = 3;
            this.tlpAyuda.SetToolTip(this.txtNota3, "Ingresa valores entre 0 y 10");            // 
            // lblNotaTres
            // 
            this.lblNotaTres.AutoSize = true;
            this.lblNotaTres.Location = new System.Drawing.Point(92, 273);
            this.lblNotaTres.Name = "lblNotaTres";
            this.lblNotaTres.Size = new System.Drawing.Size(88, 25);
            this.lblNotaTres.TabIndex = 2;
            this.lblNotaTres.Text = "Nota 3:";
            // 
            // lblNotaDos
            // 
            this.lblNotaDos.AutoSize = true;
            this.lblNotaDos.Location = new System.Drawing.Point(92, 178);
            this.lblNotaDos.Name = "lblNotaDos";
            this.lblNotaDos.Size = new System.Drawing.Size(88, 25);
            this.lblNotaDos.TabIndex = 1;
            this.lblNotaDos.Text = "Nota 2:";
            // 
            // lblNotaUno
            // 
            this.lblNotaUno.AutoSize = true;
            this.lblNotaUno.Location = new System.Drawing.Point(92, 80);
            this.lblNotaUno.Name = "lblNotaUno";
            this.lblNotaUno.Size = new System.Drawing.Size(88, 25);
            this.lblNotaUno.TabIndex = 0;
            this.lblNotaUno.Text = "Nota 1:";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.txtPromedio);
            this.gbPromedio.Controls.Add(this.label4);
            this.gbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromedio.Location = new System.Drawing.Point(51, 478);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(1040, 167);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.AcceptsReturn = true;
            this.txtPromedio.Location = new System.Drawing.Point(305, 75);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(240, 31);
            this.txtPromedio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Promedio Obtenido";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btmSalir);
            this.gbAcciones.Controls.Add(this.btnAgregarPromedio);
            this.gbAcciones.Controls.Add(this.btnNuevoRegistro);
            this.gbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(826, 68);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(265, 387);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btmSalir
            // 
            this.btmSalir.Image = global::Calculo_de_romedios.Properties.Resources.icons8_cerrar_ventana_48;
            this.btmSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmSalir.Location = new System.Drawing.Point(6, 266);
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(252, 106);
            this.btmSalir.TabIndex = 2;
            this.btmSalir.Text = "Salir";
            this.btmSalir.UseVisualStyleBackColor = true;
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // btnAgregarPromedio
            // 
            this.btnAgregarPromedio.Image = global::Calculo_de_romedios.Properties.Resources.icons8_añadir_usuario_masculino_48;
            this.btnAgregarPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPromedio.Location = new System.Drawing.Point(6, 30);
            this.btnAgregarPromedio.Name = "btnAgregarPromedio";
            this.btnAgregarPromedio.Size = new System.Drawing.Size(252, 95);
            this.btnAgregarPromedio.TabIndex = 1;
            this.btnAgregarPromedio.Text = "Agregar promedio";
            this.btnAgregarPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPromedio.UseVisualStyleBackColor = true;
            this.btnAgregarPromedio.Click += new System.EventHandler(this.btnAgregarPromedio_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Image = global::Calculo_de_romedios.Properties.Resources.icons8_escoba_48;
            this.btnNuevoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(6, 142);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(252, 96);
            this.btnNuevoRegistro.TabIndex = 0;
            this.btnNuevoRegistro.Text = "Nuevo registro";
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de ayuda";
            // 
            // fmrCalculoPromedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 669);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbRegistroNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrCalculoPromedios";
            this.Text = "Sistema de notas ITR";
            this.gbRegistroNotas.ResumeLayout(false);
            this.gbRegistroNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroNotas;
        private System.Windows.Forms.Label lblNotaTres;
        private System.Windows.Forms.Label lblNotaDos;
        private System.Windows.Forms.Label lblNotaUno;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btmSalir;
        private System.Windows.Forms.Button btnAgregarPromedio;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}

