namespace Club_Debitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuVertical = new System.Windows.Forms.Panel();
            this.cmdBancoProvincia = new System.Windows.Forms.Button();
            this.cmdMacro = new System.Windows.Forms.Button();
            this.cmdVISAElectron = new System.Windows.Forms.Button();
            this.cmdVISACrédito = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelConfiguracion = new System.Windows.Forms.PictureBox();
            this.cmdComafi = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.PictureBox();
            this.BarraTitulos = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.mnuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).BeginInit();
            this.BarraTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuVertical
            // 
            this.mnuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mnuVertical.Controls.Add(this.cmdBancoProvincia);
            this.mnuVertical.Controls.Add(this.cmdMacro);
            this.mnuVertical.Controls.Add(this.cmdVISAElectron);
            this.mnuVertical.Controls.Add(this.cmdVISACrédito);
            this.mnuVertical.Controls.Add(this.lblVersion);
            this.mnuVertical.Controls.Add(this.panelConfiguracion);
            this.mnuVertical.Controls.Add(this.cmdComafi);
            this.mnuVertical.Controls.Add(this.panelLogo);
            this.mnuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuVertical.Location = new System.Drawing.Point(0, 0);
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(250, 548);
            this.mnuVertical.TabIndex = 2;
            // 
            // cmdBancoProvincia
            // 
            this.cmdBancoProvincia.BackColor = System.Drawing.Color.White;
            this.cmdBancoProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdBancoProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBancoProvincia.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBancoProvincia.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdBancoProvincia.Image = ((System.Drawing.Image)(resources.GetObject("cmdBancoProvincia.Image")));
            this.cmdBancoProvincia.Location = new System.Drawing.Point(0, 312);
            this.cmdBancoProvincia.Name = "cmdBancoProvincia";
            this.cmdBancoProvincia.Size = new System.Drawing.Size(250, 64);
            this.cmdBancoProvincia.TabIndex = 7;
            this.cmdBancoProvincia.Text = "}";
            this.cmdBancoProvincia.UseVisualStyleBackColor = false;
            this.cmdBancoProvincia.Click += new System.EventHandler(this.BancoProvincia_Click);
            // 
            // cmdMacro
            // 
            this.cmdMacro.BackColor = System.Drawing.Color.White;
            this.cmdMacro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdMacro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMacro.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMacro.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdMacro.Image = global::Club_Debitos.Properties.Resources.macro;
            this.cmdMacro.Location = new System.Drawing.Point(0, 252);
            this.cmdMacro.Name = "cmdMacro";
            this.cmdMacro.Size = new System.Drawing.Size(250, 64);
            this.cmdMacro.TabIndex = 6;
            this.cmdMacro.Text = "}";
            this.cmdMacro.UseVisualStyleBackColor = false;
            this.cmdMacro.Click += new System.EventHandler(this.cmdMacro_Click);
            // 
            // cmdVISAElectron
            // 
            this.cmdVISAElectron.BackColor = System.Drawing.Color.White;
            this.cmdVISAElectron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdVISAElectron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVISAElectron.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVISAElectron.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdVISAElectron.Image = global::Club_Debitos.Properties.Resources.visa_electron_icono;
            this.cmdVISAElectron.Location = new System.Drawing.Point(0, 191);
            this.cmdVISAElectron.Name = "cmdVISAElectron";
            this.cmdVISAElectron.Size = new System.Drawing.Size(250, 64);
            this.cmdVISAElectron.TabIndex = 5;
            this.cmdVISAElectron.UseVisualStyleBackColor = false;
            this.cmdVISAElectron.Click += new System.EventHandler(this.cmdVISAElectron_Click);
            // 
            // cmdVISACrédito
            // 
            this.cmdVISACrédito.BackColor = System.Drawing.Color.White;
            this.cmdVISACrédito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdVISACrédito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVISACrédito.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVISACrédito.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdVISACrédito.Image = global::Club_Debitos.Properties.Resources.visa_icono;
            this.cmdVISACrédito.Location = new System.Drawing.Point(0, 127);
            this.cmdVISACrédito.Name = "cmdVISACrédito";
            this.cmdVISACrédito.Size = new System.Drawing.Size(250, 64);
            this.cmdVISACrédito.TabIndex = 4;
            this.cmdVISACrédito.UseVisualStyleBackColor = false;
            this.cmdVISACrédito.Click += new System.EventHandler(this.cmdVISACrédito_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(81, 517);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(101, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "16/09/2022 3.1.0.0";
            // 
            // panelConfiguracion
            // 
            this.panelConfiguracion.Image = global::Club_Debitos.Properties.Resources.liferay_properties1;
            this.panelConfiguracion.Location = new System.Drawing.Point(0, 461);
            this.panelConfiguracion.Name = "panelConfiguracion";
            this.panelConfiguracion.Size = new System.Drawing.Size(75, 87);
            this.panelConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelConfiguracion.TabIndex = 2;
            this.panelConfiguracion.TabStop = false;
            this.panelConfiguracion.Click += new System.EventHandler(this.panelConfiguracion_Click);
            // 
            // cmdComafi
            // 
            this.cmdComafi.BackColor = System.Drawing.Color.White;
            this.cmdComafi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdComafi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComafi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComafi.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdComafi.Image = global::Club_Debitos.Properties.Resources.banco_comafi_400x400;
            this.cmdComafi.Location = new System.Drawing.Point(0, 63);
            this.cmdComafi.Name = "cmdComafi";
            this.cmdComafi.Size = new System.Drawing.Size(250, 64);
            this.cmdComafi.TabIndex = 1;
            this.cmdComafi.UseVisualStyleBackColor = false;
            this.cmdComafi.Click += new System.EventHandler(this.cmdComafi_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Image = global::Club_Debitos.Properties.Resources.logo_metaclub;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 63);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.TabStop = false;
            // 
            // BarraTitulos
            // 
            this.BarraTitulos.BackColor = System.Drawing.Color.White;
            this.BarraTitulos.Controls.Add(this.btnCerrar);
            this.BarraTitulos.Controls.Add(this.btnSlide);
            this.BarraTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulos.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulos.Name = "BarraTitulos";
            this.BarraTitulos.Size = new System.Drawing.Size(691, 63);
            this.BarraTitulos.TabIndex = 3;
            this.BarraTitulos.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulos_Paint);
            this.BarraTitulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulos_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::Club_Debitos.Properties.Resources.cross;
            this.btnCerrar.Location = new System.Drawing.Point(656, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::Club_Debitos.Properties.Resources.Mobile_Menu_Icon;
            this.btnSlide.Location = new System.Drawing.Point(3, 12);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 63);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(691, 485);
            this.panelContenedor.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 548);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulos);
            this.Controls.Add(this.mnuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmiClub";
            this.mnuVertical.ResumeLayout(false);
            this.mnuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).EndInit();
            this.BarraTitulos.ResumeLayout(false);
            this.BarraTitulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mnuVertical;
        private System.Windows.Forms.Panel BarraTitulos;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox panelLogo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button cmdComafi;
        private System.Windows.Forms.PictureBox panelConfiguracion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button cmdVISAElectron;
        private System.Windows.Forms.Button cmdVISACrédito;
        private System.Windows.Forms.Button cmdMacro;
        private System.Windows.Forms.Button cmdBancoProvincia;
    }
}