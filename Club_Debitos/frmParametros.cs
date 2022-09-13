using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace Club_Debitos
{
    public partial class frmParametros : Form
    {

        //private string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Hp/Documents/DataBases/spacecraftsDB.mdb;";
        readonly OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        Boolean blnSenial_Nuevo = false;

        public frmParametros()
        {
            InitializeComponent();

            Configura_Grilla();

            string conString = Entidades.CadenaConexion;

            con = new OleDbConnection(conString);

            Carga_Combo_Cobradores();
            Carga_Combo_TipoArchivos();
            retrieve();
            Limpia_Controles();

        }

        private void Configura_Grilla()
        {
            grdParametros.ColumnCount = 17;
            grdParametros.Columns[0].Name = "IdCobrador";
            grdParametros.Columns[0].Visible = false;
            grdParametros.Columns[1].Name = "nomCobrador";
            grdParametros.Columns[2].Name = "IdTipoArchivo";
            grdParametros.Columns[2].Visible = false;
            grdParametros.Columns[3].Name = "Archivo";

            grdParametros.Columns[4].Name = "Cuit";
            grdParametros.Columns[5].Name = "Producto";
            grdParametros.Columns[6].Name = "Origen_Comercial";
            grdParametros.Columns[7].Name = "Razon_Social";
            grdParametros.Columns[8].Name = "Save";
            grdParametros.Columns[9].Name = "Nombre_Archivo";
            grdParametros.Columns[10].Name = "Secuencia";
            grdParametros.Columns[11].Name = "Fecha_Secuencia";
            grdParametros.Columns[12].Name = "Codigo_Servicio";
            grdParametros.Columns[13].Name = "Numero_Servicio";
            grdParametros.Columns[14].Name = "Codigo_Sucursal";
            grdParametros.Columns[15].Name = "Numero_Establecimiento";
            grdParametros.Columns[16].Name = "Caja";

            DataGridViewCheckBoxColumn chkAgrupa_Tarjeta = new DataGridViewCheckBoxColumn();
            chkAgrupa_Tarjeta.Name = "Agrupa_Tarjeta";
            chkAgrupa_Tarjeta.HeaderText = "Agrupa Tarjeta";
            grdParametros.Columns.Add(chkAgrupa_Tarjeta);

            //grdParametros.Columns[14].Name = "Agrupa_Tarjeta";

            grdParametros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //SELECTION MODE
            grdParametros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdParametros.MultiSelect = false;
        }

        private void populate(string intId_Cobrador, string nomCobrador,string int_IdTipoArchivo, string nomTipoArchivo, 
                                string strCUIT, string strProducto, string strOrigen_Comercial, string strRazon_Social, 
                                    string strSave, string strTipo_Archivo, string strSecuencia, string strFecha_Secuencia, 
                                        string strCodigo_Servicio, string strNumero_Servicio, string strCodigo_Sucursal, string strNumero_Establecimiento, 
                                            string strCaja, bool blnAgrupa_Tarjeta)
        {
            grdParametros.Rows.Add( intId_Cobrador,  nomCobrador, int_IdTipoArchivo,  nomTipoArchivo, strCUIT, strProducto, strOrigen_Comercial, strRazon_Social, strSave, strTipo_Archivo, strSecuencia, strFecha_Secuencia, strCodigo_Servicio, strNumero_Servicio, strCodigo_Sucursal, strNumero_Establecimiento, strCaja, blnAgrupa_Tarjeta);
        }

        private void update(int intId_Cobrador, string nomCobrador, string int_IdTipoArchivo, string nomTipoArchivo, string strCUIT, string strProducto, string strOrigen_Comercial, string strRazon_Social, string strSave, string strTipo_Archivo, Int32 intSecuencia, DateTime datFecha_Secuencia, string strCodigo_Servicio, string strNumero_Servicio, string strCodigo_Sucursal, string strNumero_Establecimiento, string strCaja, bool blnAgrupa_Tarjeta)
        {

            string strSql = "UPDATE ParamBancos SET CUIT= '" + strCUIT + "', Producto = '" + strProducto + "', OrigenComercial = '" + strOrigen_Comercial + "', RazonSocial = '" + strRazon_Social + "', SAVE = '" + strSave + "', nombreArchivo = '" + strTipo_Archivo + "', Secuencia = " + intSecuencia + ", CodServicio = '" + strCodigo_Servicio + "', NroServicio = '" + strNumero_Servicio + "', CodSucursal = '" + strCodigo_Sucursal + "', NroEstablecimiento = '" + strNumero_Establecimiento + "', Caja = '" + strCaja + "', AgrupaTarjeta = " + blnAgrupa_Tarjeta;

            if (datFecha_Secuencia != null && datFecha_Secuencia.ToString() != "")
            {
                strSql += ", FechaSecuencia = '" + datFecha_Secuencia.ToString("dd/MM/yyy") + "'";
            }
            strSql += ", idArchivo='" + int_IdTipoArchivo + "' ";
            strSql += " Where idCobrador = " + intId_Cobrador;

            cmd = new OleDbCommand(strSql, con);

            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = strSql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    Limpia_Controles();
                    MessageBox.Show(@"Registro actualizado");
                }
                con.Close();

                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void retrieve()
        {
            grdParametros.Rows.Clear();

            String sql = "SELECT ParamBancos.IdCobrador, Cobradores.ApeyNom, ParamBancos.IdArchivo, TipoDeArchivosDBA.TipoArchivo, ParamBancos.CUIT, ParamBancos.Producto, " +
                        "ParamBancos.OrigenComercial, ParamBancos.RazonSocial, ParamBancos.save, ParamBancos.nombreArchivo, " +
                        "ParamBancos.secuencia,ParamBancos.FechaSecuencia, ParamBancos.CodServicio, ParamBancos.NroServicio, " + 
                        "ParamBancos.CodSucursal, ParamBancos.NroEstablecimiento, ParamBancos.Caja, ParamBancos.AgrupaTarjeta " +
                        "FROM (ParamBancos INNER JOIN Cobradores ON ParamBancos.IdCobrador = Cobradores.IdCobrador) INNER JOIN TipoDeArchivosDBA ON " +
                        "ParamBancos.IdArchivo = TipoDeArchivosDBA.idTipoArchivo;";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),
                        row[4].ToString(), row[5].ToString(), row[6].ToString(), 
                        row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString(),
                        row[14].ToString(), row[15].ToString(), row[16].ToString(),
                        Convert.ToBoolean(row[17]) );
                }

                con.Close();

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                blnSenial_Nuevo = true;
                con.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            retrieve();
            Limpia_Controles();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {

            if (!blnSenial_Nuevo)
            { 

                int selectedIndex = grdParametros.SelectedRows[0].Index;

                if (selectedIndex != -1)
                {
                    String selected = grdParametros.SelectedRows[0].Cells[0].Value.ToString();

                    int intCobrador = Convert.ToInt32(selected);

                    update(intCobrador,this.cboCobradores.Text ,this.cboTipoArchivo.SelectedValue.ToString(),this.cboTipoArchivo.Text , txtCUIT.Text, txtProducto.Text, txtOrigen_Comercial.Text, txtRazon_Social.Text, txtSave.Text, txtTipo_Archivo.Text, Convert.ToInt32(txtSecuencia.Value), datFecha_Secuencia.Value, txtCodigo_Servicio.Text, txtNumero_Servicio.Text, txtCodigo_Sucursal.Text, txtNumero_Establecimiento.Text, txtCaja.Text, chkAgrupa_Tarjeta.Checked );

                    Limpia_Controles();
                }

            }
            else
            {
                Graba_Nuevo_Parametros();
            }

        }

        private void grdParametros_SelectionChanged(object sender, EventArgs e)
        {

            Limpia_Controles();
            blnSenial_Nuevo = false; 

            try
            {
                int selectedIndex = grdParametros.SelectedRows[0].Index;

                this.cboCobradores.SelectedValue = grdParametros.SelectedRows[0].Cells[0].Value;

                if (selectedIndex != -1)
                {
                    if (grdParametros.SelectedRows[0].Cells[0].Value != null)
                    {
                        int int_tipoArchivo = Convert.ToInt32(grdParametros.SelectedRows[0].Cells[2].Value);
                        string strCUIT = grdParametros.SelectedRows[0].Cells[4].Value.ToString();
                        string strProducto = grdParametros.SelectedRows[0].Cells[5].Value.ToString();
                        string strOrigen_Comercial = grdParametros.SelectedRows[0].Cells[6].Value.ToString();

                        string strRazon_Social = grdParametros.SelectedRows[0].Cells[7].Value.ToString();
                        string strSave = grdParametros.SelectedRows[0].Cells[8].Value.ToString();
                        string strTipo_Archivo = grdParametros.SelectedRows[0].Cells[9].Value.ToString();

                        Int32 intSecuencia = 0;
                        if (grdParametros.SelectedRows[0].Cells[10].Value != null)
                        {
                            intSecuencia = Convert.ToInt32 (grdParametros.SelectedRows[0].Cells[10].Value);
                        }

                        DateTime datFecha_Secuencia = DateTime.Today; 
                        if (grdParametros.SelectedRows[0].Cells[11].Value != null && grdParametros.SelectedRows[0].Cells[11].Value.ToString() != "")
                        {
                            this.datFecha_Secuencia.CustomFormat = "dd/MM/yyyy";
                            Convert.ToDateTime(grdParametros.SelectedRows[0].Cells[11].Value);
                        }
                        else
                        {
                            this.datFecha_Secuencia.CustomFormat = " ";
                        }

                        string strCodigo_Servicio = grdParametros.SelectedRows[0].Cells[12].Value.ToString();

                        string strNumero_Servicio = grdParametros.SelectedRows[0].Cells[13].Value.ToString();
                        string strCodigo_Sucursal = grdParametros.SelectedRows[0].Cells[14].Value.ToString();
                        string strNumero_Establecimiento = grdParametros.SelectedRows[0].Cells[15].Value.ToString();

                        string strCaja = grdParametros.SelectedRows[0].Cells[16].Value.ToString();
                        Boolean blnAgrupa_Tarjeta = Convert.ToBoolean(grdParametros.SelectedRows[0].Cells[17].Value);

                        this.cboTipoArchivo.SelectedValue = int_tipoArchivo;
                        this.txtCUIT.Text  = strCUIT;
                        this.txtProducto.Text = strProducto;
                        this.txtOrigen_Comercial.Text = strOrigen_Comercial;

                        this.txtRazon_Social.Text = strRazon_Social;
                        this.txtSave.Text = strSave;
                        this.txtTipo_Archivo.Text = strTipo_Archivo;

                        this.txtSecuencia.Value = intSecuencia;
                        this.datFecha_Secuencia.Value = datFecha_Secuencia;
                        this.txtCodigo_Servicio.Text = strCodigo_Servicio;

                        this.txtNumero_Servicio.Text = strNumero_Servicio;
                        this.txtCodigo_Sucursal.Text = strCodigo_Sucursal;
                        this.txtNumero_Establecimiento.Text = strNumero_Establecimiento;

                        this.txtCaja.Text = strCaja;
                        //this.txtAgrupa_Tarjeta.Text = strAgrupa_Tarjeta;

                        this.chkAgrupa_Tarjeta.Checked = blnAgrupa_Tarjeta;
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void Limpia_Controles()
        {
            Carga_Combo_Cobradores();
            Carga_Combo_TipoArchivos();
        this.cboCobradores.SelectedIndex = -1;
        this.cboTipoArchivo.SelectedIndex = -1;
        this.txtCUIT.Text  = "";
        this.txtProducto.Text = "";
        this.txtOrigen_Comercial.Text = "";
        this.txtRazon_Social.Text = "";
        this.txtSave.Text = "";
        this.txtTipo_Archivo.Text = "";
        this.txtSecuencia.Value = 0;
        this.datFecha_Secuencia.CustomFormat = " ";
        //this.datFecha_Secuencia.Value = datFecha_Secuencia;
        this.txtCodigo_Servicio.Text = "";
        this.txtNumero_Servicio.Text = "";
        this.txtCodigo_Sucursal.Text = "";
        this.txtNumero_Establecimiento.Text = "";
        this.txtCaja.Text = "";
        //this.txtAgrupa_Tarjeta.Text = "";
        }

        private void Carga_Combo_Cobradores()
        {
            OleDbDataReader drCOBRADORES;

            string strConsulta = "select idCobrador, ApeyNom  from cobradores";

            drCOBRADORES = Entidades.GetDataReader_Access(strConsulta);

            DataTable dtCOBRADORES = new DataTable();
            dtCOBRADORES.Load(drCOBRADORES);

            //this.cboCobradores.SelectedValueChanged -= new System.EventHandler(this.cboCobrador_SelectedValueChanged);

            this.cboCobradores.DataSource = dtCOBRADORES;

            this.cboCobradores.ValueMember = "idCobrador";
            this.cboCobradores.DisplayMember = "ApeyNom";

            this.cboCobradores.SelectedIndex = -1;

            //this.cboCobradores.SelectedValueChanged += new System.EventHandler(this.cboCobrador_SelectedValueChanged);


        }
        private void Carga_Combo_TipoArchivos()
        {
            OleDbDataReader drTipoArchivos;

            string strConsulta = "select idTipoArchivo, TipoArchivo FROM TipoDeArchivosDBA";

            drTipoArchivos = Entidades.GetDataReader_Access(strConsulta);

            DataTable dtTipoArchivos = new DataTable();
            dtTipoArchivos.Load(drTipoArchivos);

            //this.cboCobradores.SelectedValueChanged -= new System.EventHandler(this.cboCobrador_SelectedValueChanged);

            this.cboTipoArchivo.DataSource = dtTipoArchivos;

            this.cboTipoArchivo.ValueMember = "idTipoArchivo";
            this.cboTipoArchivo.DisplayMember = "TipoArchivo";

            this.cboTipoArchivo.SelectedIndex = -1;
        }


        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Graba_Nuevo_Parametros();
        }

        private void Graba_Nuevo_Parametros()
        {

            string strSql = "INSERT INTO ParamBancos (idcobrador, idArchivo, cuit, producto, origencomercial, razonsocial, save, nombrearchivo, secuencia, fechasecuencia, codServicio, NroServicio, CodSucursal, NroEstablecimiento, Caja, AgrupaTarjeta)";
            strSql += " VALUES ( ";
            strSql += "@intId_Cobrador,@id_TipoArchivo, @strCUIT, @strProducto, @strOrigen_Comercial, @strRazon_Social, @strSave, @strTipo_Archivo, @intSecuencia, @datFecha_Secuencia, @strCodigo_Servicio, @strNumero_Servicio, @strCodigo_Sucursal, @strNumero_Establecimiento, @strCaja, @blnAgrupa_Tarjeta )";

            cmd = new OleDbCommand(strSql, con);

            cmd.Parameters.AddWithValue("@intId_Cobrador", this.cboCobradores.SelectedValue);
            cmd.Parameters.AddWithValue("@id_TipoArchivo", this.cboTipoArchivo.SelectedValue);
            cmd.Parameters.AddWithValue("@strCUIT", this.txtCUIT.Text);
            cmd.Parameters.AddWithValue("@strProducto", this.txtProducto.Text);
            cmd.Parameters.AddWithValue("@strOrigen_Comercial", this.txtOrigen_Comercial.Text);
            cmd.Parameters.AddWithValue("@strRazon_Social", this.txtRazon_Social.Text);
            cmd.Parameters.AddWithValue("@strSave", this.txtSave.Text);
            cmd.Parameters.AddWithValue("@strTipo_Archivo", this.txtTipo_Archivo.Text);
            cmd.Parameters.AddWithValue("@intSecuencia", this.txtSecuencia.Value);

            if (this.datFecha_Secuencia.Value != null && this.datFecha_Secuencia.Value.ToString() != "")
            {
                cmd.Parameters.AddWithValue("@datFecha_Secuencia", datFecha_Secuencia.Value.ToString("dd/MM/yyy"));
            }

            cmd.Parameters.AddWithValue("@strCodigo_Servicio", this.txtCodigo_Servicio.Text);
            cmd.Parameters.AddWithValue("@strNumero_Servicio", this.txtNumero_Servicio.Text);
            cmd.Parameters.AddWithValue("@strCodigo_Sucursal", this.txtCodigo_Sucursal.Text);
            cmd.Parameters.AddWithValue("@strNumero_Establecimiento", this.txtNumero_Establecimiento.Text);
            cmd.Parameters.AddWithValue("@strCaja", this.txtCaja.Text);
            cmd.Parameters.AddWithValue("@blnAgrupa_Tarjeta", Convert.ToBoolean(this.chkAgrupa_Tarjeta.Checked) );

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(@"Parámetro insertado");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            Limpia_Controles();
            this.cboCobradores.Focus();

            blnSenial_Nuevo = true;
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {

            int selectedIndex = grdParametros.SelectedRows[0].Index;

            if (selectedIndex != -1)
            {
                String selected = grdParametros.SelectedRows[0].Cells[0].Value.ToString();

                int intCobrador = Convert.ToInt32(selected);
                Eliminar(intCobrador);
                Limpia_Controles();
                retrieve();
            }
       
        }

        private void Eliminar(Int32 intId_Cobrador)
        {

            string strSql = "DELETE FROM ParamBancos ";
            strSql += " Where idCobrador = " + intId_Cobrador;

            cmd = new OleDbCommand(strSql, con);

            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = strSql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    Limpia_Controles();
                    MessageBox.Show(@"Parámetro eliminado");
                }
                con.Close();

                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


        }
        
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPathFolder_Click(object sender, EventArgs e)
        {
            this.ArchivoFolder.RootFolder = System.Environment.SpecialFolder.Desktop;
            this.ArchivoFolder.ShowNewFolderButton = true;
            this.ArchivoFolder.Description = "Seleccine la carpeta para guardar los archivos";
            if(this.ArchivoFolder.ShowDialog()==DialogResult.OK)
            {
                this.txtSave.Text = this.ArchivoFolder.SelectedPath;
            }
        }

        private void grdParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdParametros_SelectionChanged(sender, e);
        }
    }


}
