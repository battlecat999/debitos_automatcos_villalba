namespace Club_Debitos
{
    partial class frmGeneradorArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneradorArchivos));
            this.label1 = new System.Windows.Forms.Label();
            this.cboPlanillas = new System.Windows.Forms.ComboBox();
            this.datFecha_Presentacion = new System.Windows.Forms.DateTimePicker();
            this.datFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdGenerar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.prgProgreso = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.cboCobrador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(77, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Planilla:";
            // 
            // cboPlanillas
            // 
            this.cboPlanillas.FormattingEnabled = true;
            this.cboPlanillas.Location = new System.Drawing.Point(266, 136);
            this.cboPlanillas.Margin = new System.Windows.Forms.Padding(4);
            this.cboPlanillas.Name = "cboPlanillas";
            this.cboPlanillas.Size = new System.Drawing.Size(298, 26);
            this.cboPlanillas.TabIndex = 1;
            // 
            // datFecha_Presentacion
            // 
            this.datFecha_Presentacion.CustomFormat = "";
            this.datFecha_Presentacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFecha_Presentacion.Location = new System.Drawing.Point(266, 192);
            this.datFecha_Presentacion.Margin = new System.Windows.Forms.Padding(4);
            this.datFecha_Presentacion.Name = "datFecha_Presentacion";
            this.datFecha_Presentacion.Size = new System.Drawing.Size(151, 26);
            this.datFecha_Presentacion.TabIndex = 2;
            this.datFecha_Presentacion.ValueChanged += new System.EventHandler(this.datFecha_Presentacion_ValueChanged);
            // 
            // datFecha_Vencimiento
            // 
            this.datFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFecha_Vencimiento.Location = new System.Drawing.Point(266, 252);
            this.datFecha_Vencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.datFecha_Vencimiento.Name = "datFecha_Vencimiento";
            this.datFecha_Vencimiento.Size = new System.Drawing.Size(151, 26);
            this.datFecha_Vencimiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(77, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Presentación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(77, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Vencimiento:";
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerar.Location = new System.Drawing.Point(144, 342);
            this.cmdGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(112, 32);
            this.cmdGenerar.TabIndex = 4;
            this.cmdGenerar.Text = "Generar";
            this.cmdGenerar.UseVisualStyleBackColor = true;
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Location = new System.Drawing.Point(416, 342);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 32);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // prgProgreso
            // 
            this.prgProgreso.Location = new System.Drawing.Point(81, 417);
            this.prgProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.prgProgreso.Name = "prgProgreso";
            this.prgProgreso.Size = new System.Drawing.Size(483, 32);
            this.prgProgreso.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboCobrador
            // 
            this.cboCobrador.FormattingEnabled = true;
            this.cboCobrador.Location = new System.Drawing.Point(266, 86);
            this.cboCobrador.Margin = new System.Windows.Forms.Padding(4);
            this.cboCobrador.Name = "cboCobrador";
            this.cboCobrador.Size = new System.Drawing.Size(298, 26);
            this.cboCobrador.TabIndex = 0;
            this.cboCobrador.SelectedValueChanged += new System.EventHandler(this.cboCobrador_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(77, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione Cobrador";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGeneradorArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(651, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cboCobrador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prgProgreso);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datFecha_Vencimiento);
            this.Controls.Add(this.datFecha_Presentacion);
            this.Controls.Add(this.cboPlanillas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGeneradorArchivos";
            this.Text = "Generación archivo COMAFI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPlanillas;
        private System.Windows.Forms.DateTimePicker datFecha_Presentacion;
        private System.Windows.Forms.DateTimePicker datFecha_Vencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdGenerar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.ProgressBar prgProgreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboCobrador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}