namespace Club_Debitos
{
    partial class frmParametros
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
            this.grdParametros = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtOrigen_Comercial = new System.Windows.Forms.TextBox();
            this.txtRazon_Social = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.txtTipo_Archivo = new System.Windows.Forms.TextBox();
            this.txtSecuencias = new System.Windows.Forms.TextBox();
            this.txtCodigo_Servicio = new System.Windows.Forms.TextBox();
            this.txtNumero_Servicio = new System.Windows.Forms.TextBox();
            this.txtCodigo_Sucursal = new System.Windows.Forms.TextBox();
            this.txtNumero_Establecimiento = new System.Windows.Forms.TextBox();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.datFecha_Secuencia = new System.Windows.Forms.DateTimePicker();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cboCobradores = new System.Windows.Forms.ComboBox();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.chkAgrupa_Tarjeta = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecuencia = new System.Windows.Forms.NumericUpDown();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTipoArchivo = new System.Windows.Forms.ComboBox();
            this.ArchivoFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdPathFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdParametros
            // 
            this.grdParametros.AllowUserToAddRows = false;
            this.grdParametros.AllowUserToDeleteRows = false;
            this.grdParametros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdParametros.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdParametros.Location = new System.Drawing.Point(9, 25);
            this.grdParametros.MultiSelect = false;
            this.grdParametros.Name = "grdParametros";
            this.grdParametros.ReadOnly = true;
            this.grdParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdParametros.Size = new System.Drawing.Size(1149, 206);
            this.grdParametros.TabIndex = 0;
            this.grdParametros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdParametros_CellContentClick);
            this.grdParametros.SelectionChanged += new System.EventHandler(this.grdParametros_SelectionChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(538, 534);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 25);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "button1";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Visible = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(136, 534);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 25);
            this.cmdGrabar.TabIndex = 17;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT.Location = new System.Drawing.Point(171, 293);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(167, 22);
            this.txtCUIT.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(171, 321);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(345, 22);
            this.txtProducto.TabIndex = 3;
            // 
            // txtOrigen_Comercial
            // 
            this.txtOrigen_Comercial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen_Comercial.Location = new System.Drawing.Point(171, 349);
            this.txtOrigen_Comercial.Name = "txtOrigen_Comercial";
            this.txtOrigen_Comercial.Size = new System.Drawing.Size(100, 22);
            this.txtOrigen_Comercial.TabIndex = 4;
            // 
            // txtRazon_Social
            // 
            this.txtRazon_Social.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazon_Social.Location = new System.Drawing.Point(171, 377);
            this.txtRazon_Social.Name = "txtRazon_Social";
            this.txtRazon_Social.Size = new System.Drawing.Size(345, 22);
            this.txtRazon_Social.TabIndex = 5;
            // 
            // txtSave
            // 
            this.txtSave.Enabled = false;
            this.txtSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.Location = new System.Drawing.Point(171, 405);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(345, 22);
            this.txtSave.TabIndex = 6;
            // 
            // txtTipo_Archivo
            // 
            this.txtTipo_Archivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo_Archivo.Location = new System.Drawing.Point(171, 433);
            this.txtTipo_Archivo.Name = "txtTipo_Archivo";
            this.txtTipo_Archivo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo_Archivo.TabIndex = 7;
            // 
            // txtSecuencias
            // 
            this.txtSecuencias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencias.Location = new System.Drawing.Point(297, 460);
            this.txtSecuencias.Name = "txtSecuencias";
            this.txtSecuencias.Size = new System.Drawing.Size(100, 22);
            this.txtSecuencias.TabIndex = 9;
            this.txtSecuencias.Visible = false;
            this.txtSecuencias.WordWrap = false;
            // 
            // txtCodigo_Servicio
            // 
            this.txtCodigo_Servicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo_Servicio.Location = new System.Drawing.Point(836, 271);
            this.txtCodigo_Servicio.Name = "txtCodigo_Servicio";
            this.txtCodigo_Servicio.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo_Servicio.TabIndex = 10;
            // 
            // txtNumero_Servicio
            // 
            this.txtNumero_Servicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero_Servicio.Location = new System.Drawing.Point(836, 299);
            this.txtNumero_Servicio.Name = "txtNumero_Servicio";
            this.txtNumero_Servicio.Size = new System.Drawing.Size(100, 22);
            this.txtNumero_Servicio.TabIndex = 11;
            // 
            // txtCodigo_Sucursal
            // 
            this.txtCodigo_Sucursal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo_Sucursal.Location = new System.Drawing.Point(836, 327);
            this.txtCodigo_Sucursal.Name = "txtCodigo_Sucursal";
            this.txtCodigo_Sucursal.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo_Sucursal.TabIndex = 12;
            // 
            // txtNumero_Establecimiento
            // 
            this.txtNumero_Establecimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero_Establecimiento.Location = new System.Drawing.Point(836, 355);
            this.txtNumero_Establecimiento.Name = "txtNumero_Establecimiento";
            this.txtNumero_Establecimiento.Size = new System.Drawing.Size(100, 22);
            this.txtNumero_Establecimiento.TabIndex = 13;
            // 
            // txtCaja
            // 
            this.txtCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(836, 383);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(100, 22);
            this.txtCaja.TabIndex = 14;
            // 
            // datFecha_Secuencia
            // 
            this.datFecha_Secuencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecha_Secuencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFecha_Secuencia.Location = new System.Drawing.Point(171, 489);
            this.datFecha_Secuencia.Name = "datFecha_Secuencia";
            this.datFecha_Secuencia.Size = new System.Drawing.Size(184, 22);
            this.datFecha_Secuencia.TabIndex = 9;
            this.datFecha_Secuencia.Value = new System.DateTime(2018, 8, 21, 20, 47, 48, 0);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(447, 534);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 25);
            this.cmdAgregar.TabIndex = 20;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Visible = false;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cboCobradores
            // 
            this.cboCobradores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCobradores.FormattingEnabled = true;
            this.cboCobradores.Location = new System.Drawing.Point(171, 237);
            this.cboCobradores.Name = "cboCobradores";
            this.cboCobradores.Size = new System.Drawing.Size(167, 24);
            this.cboCobradores.TabIndex = 1;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Location = new System.Drawing.Point(12, 534);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(118, 25);
            this.cmdNuevo.TabIndex = 16;
            this.cmdNuevo.Text = "Nuevo parámetro";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // chkAgrupa_Tarjeta
            // 
            this.chkAgrupa_Tarjeta.AutoSize = true;
            this.chkAgrupa_Tarjeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgrupa_Tarjeta.Location = new System.Drawing.Point(678, 409);
            this.chkAgrupa_Tarjeta.Name = "chkAgrupa_Tarjeta";
            this.chkAgrupa_Tarjeta.Size = new System.Drawing.Size(108, 20);
            this.chkAgrupa_Tarjeta.TabIndex = 15;
            this.chkAgrupa_Tarjeta.Text = "Agrupa tarjeta";
            this.chkAgrupa_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Fecha secuencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Secuencia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nombre de archivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Save:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Razón Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Origen comercial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "CUIT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(675, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Caja:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(675, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Número establecimiento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(675, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Código sucursal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(675, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Número servicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(675, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Código servicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cobrador:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencia.Location = new System.Drawing.Point(171, 461);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(100, 22);
            this.txtSecuencia.TabIndex = 8;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(217, 534);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(121, 25);
            this.cmdBorrar.TabIndex = 18;
            this.cmdBorrar.Text = "Eliminar parámetro";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(344, 534);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 25);
            this.cmdSalir.TabIndex = 39;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Club_Debitos.Properties.Resources.cross;
            this.pictureBox1.Location = new System.Drawing.Point(1149, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Tipo de Archivo:";
            // 
            // cboTipoArchivo
            // 
            this.cboTipoArchivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoArchivo.FormattingEnabled = true;
            this.cboTipoArchivo.Location = new System.Drawing.Point(171, 265);
            this.cboTipoArchivo.Name = "cboTipoArchivo";
            this.cboTipoArchivo.Size = new System.Drawing.Size(167, 24);
            this.cboTipoArchivo.TabIndex = 41;
            // 
            // cmdPathFolder
            // 
            this.cmdPathFolder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPathFolder.Location = new System.Drawing.Point(538, 406);
            this.cmdPathFolder.Name = "cmdPathFolder";
            this.cmdPathFolder.Size = new System.Drawing.Size(45, 21);
            this.cmdPathFolder.TabIndex = 43;
            this.cmdPathFolder.Text = "...";
            this.cmdPathFolder.UseVisualStyleBackColor = true;
            this.cmdPathFolder.Click += new System.EventHandler(this.cmdPathFolder_Click);
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1170, 581);
            this.Controls.Add(this.cmdPathFolder);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboTipoArchivo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAgrupa_Tarjeta);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cboCobradores);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.datFecha_Secuencia);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.txtNumero_Establecimiento);
            this.Controls.Add(this.txtCodigo_Sucursal);
            this.Controls.Add(this.txtNumero_Servicio);
            this.Controls.Add(this.txtCodigo_Servicio);
            this.Controls.Add(this.txtSecuencias);
            this.Controls.Add(this.txtTipo_Archivo);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtRazon_Social);
            this.Controls.Add(this.txtOrigen_Comercial);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.grdParametros);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParametros";
            this.Opacity = 0.9D;
            this.Text = "Parámetros de Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.grdParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdParametros;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtOrigen_Comercial;
        private System.Windows.Forms.TextBox txtRazon_Social;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.TextBox txtTipo_Archivo;
        private System.Windows.Forms.TextBox txtSecuencias;
        private System.Windows.Forms.TextBox txtCodigo_Servicio;
        private System.Windows.Forms.TextBox txtNumero_Servicio;
        private System.Windows.Forms.TextBox txtCodigo_Sucursal;
        private System.Windows.Forms.TextBox txtNumero_Establecimiento;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.DateTimePicker datFecha_Secuencia;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.ComboBox cboCobradores;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.CheckBox chkAgrupa_Tarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtSecuencia;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboTipoArchivo;
        private System.Windows.Forms.FolderBrowserDialog ArchivoFolder;
        private System.Windows.Forms.Button cmdPathFolder;
    }
}