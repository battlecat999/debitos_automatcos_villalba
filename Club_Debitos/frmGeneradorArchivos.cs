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
using System.IO;

using System.Configuration;
using System.Collections.Specialized;
using System.Globalization;

namespace Club_Debitos
{
    public partial class frmGeneradorArchivos : Form
    {
        private int Tipo_Archivo_Genera;
        private bool blnPrimera_Vez;
        public frmGeneradorArchivos(int int_id_Archivo_Genera)
        {

            InitializeComponent();
            Tipo_Archivo_Genera = int_id_Archivo_Genera;
            Carga_Combo_Cobradores(int_id_Archivo_Genera);

            this.cboPlanillas.DataSource = null;

            //this.datFecha_Presentacion.ValueChanged -= new System.EventHandler(datFecha_Presentacion_ValueChanged);
            this.datFecha_Presentacion.Value = DateTime.Today;
            //this.datFecha_Presentacion.ValueChanged += new System.EventHandler(datFecha_Presentacion_ValueChanged);

            //A LA FECHA DE PRESENTACIÓN LE AGREGA 3 DÍAS QUE CORRESPONDE A LA FECHA DE VENCIMIENTO.
            //this.datFecha_Vencimiento.Value = DateTime.Today.AddDays(3);

            this.cboCobrador.Focus();
            this.Refresh();

        }

        private void Carga_Combo_Cobradores(int int_id_Archivo_Genera)
        {
            OleDbDataReader drCOBRADORES;

            string strConsulta = "SELECT Cobradores.IdCobrador, Cobradores.ApeyNom " +
                                "FROM ParamBancos INNER JOIN Cobradores ON ParamBancos.IdCobrador = Cobradores.IdCobrador " +
                                "WHERE(((ParamBancos.IdArchivo) = " + int_id_Archivo_Genera + ")); ";

            drCOBRADORES = Entidades.GetDataReader_Access(strConsulta);

            DataTable dtCOBRADORES = new DataTable();
            dtCOBRADORES.Load(drCOBRADORES);

            this.cboCobrador.SelectedValueChanged -= new System.EventHandler(this.cboCobrador_SelectedValueChanged);

            this.cboCobrador.DataSource = dtCOBRADORES;

            this.cboCobrador.ValueMember = "idCobrador";
            this.cboCobrador.DisplayMember = "ApeyNom";

            this.cboCobrador.SelectedIndex = -1;

            this.cboCobrador.SelectedValueChanged += new System.EventHandler(this.cboCobrador_SelectedValueChanged);

        }

        private void Carga_Combo_Planillas(string strIdCobrador)
        {

            OleDbDataReader drPLANILLAS;

            string strConsulta = "select idnroPlaniCob from planicob where idCobrador = " + strIdCobrador + " and estado='Pendiente'";

            drPLANILLAS = Entidades.GetDataReader_Access(strConsulta, "");

            DataTable dtPLANILLAS = new DataTable();
            dtPLANILLAS.Load(drPLANILLAS);

            this.cboPlanillas.DataSource = dtPLANILLAS;

            this.cboPlanillas.ValueMember = "idNroPlaniCob";
            this.cboPlanillas.DisplayMember = "idNroPlaniCob";

        }

        private string Busca_Datos_Planilla(string strCobrador, string strPlanilla)
        {
           
            string strConsulta = "select a.NroTarCred, a.IdSocio, a.ApellidoyNombres, '0' as Moneda, a.NroTarCred as CBU, '                                                                      ' as Espacios_Final, ";
            strConsulta += " IIf(d.origencomercial is null, '', d.origencomercial) as Origen_Comercial, IIf(d.CUIT is null, '', d.CUIT) as CUIT_Empresa, ";
            strConsulta+= "IIf(d.codServicio is null, '', d.codServicio) as Codigo_Servicio, IIf(d.nroServicio is null, '', d.nroServicio) as Numero_Servicio, IIf(d.producto is null, '', d.producto) as Producto, ";
            strConsulta += " IIf(d.secuencia is null, '', d.secuencia) as Secuencia, ";
            strConsulta += " IIf (d.save is null,'',d.save) as RutaArchivo, ";
            strConsulta += " d.nombreArchivo as Nombre_Archivo ,";
            strConsulta += " IIf (d.NroEstablecimiento is null,'',d.NroEstablecimiento) as Numero_Establecimiento, ";
            strConsulta += " Sum([b].[Saldo]) AS SALDO, d.RazonSocial";
            strConsulta += " From (((Socios a Inner Join ItemPlaniCob b ";
            strConsulta += " On a.NroTarCred = b.NumTarjeta ) ";
            strConsulta += " Inner Join PlaniCob c ";
            strConsulta += " On b.iDNroPlaniCob = c.iDNroPlaniCob ) ";
            strConsulta += " Inner Join ParamBancos d ";
            strConsulta += " On c.iDCobrador = d.iDCobrador ) ";
            strConsulta += " Where a.esTitularTarjeta = true ";
            strConsulta += " and c.estado = 'Pendiente' ";
            strConsulta += " and c.iDCobrador = " + strCobrador;
            strConsulta += " and c.iDNroPlaniCob = " + strPlanilla;
            strConsulta += " Group By a.NroTarCred, a.IdSocio, a.ApellidoyNombres, IIf(d.origencomercial is null, '', d.origencomercial), IIf(d.CUIT is null, '', d.CUIT), ";
            strConsulta += " IIf(d.codServicio is null, '', d.codServicio), IIf(d.producto is null, '', d.producto), IIf(d.nroServicio is null, '', d.nroServicio) , ";
            strConsulta += "IIf(d.secuencia is null, '', d.secuencia),IIf (d.save is null,'',d.save), d.nombreArchivo, IIf (d.NroEstablecimiento is null,'',d.NroEstablecimiento), d.RazonSocial";

            return strConsulta;
        }
        private void Genera_Archivo_COMAFI()
        {



        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {

            if (Valida())
            {
                string strCobrador = this.cboCobrador.SelectedValue.ToString();
                string strPlanilla = this.cboPlanillas.SelectedValue.ToString();
                string strConsulta = String.Empty;
                
                strConsulta  = Busca_Datos_Planilla(strCobrador,strPlanilla );

                switch (Tipo_Archivo_Genera)
                {
                    case (Int32)EnumTipoArchivos.TipoArchivos.DEBLIQC:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.DEBLIQD:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.VISAMOV:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.MASTERCARD:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.AMEX:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.COMAFI:
                        Genera_Tipo_Archivo_Comafi  gac = new Genera_Tipo_Archivo_Comafi();
                        gac.Genera_Archivo(this.prgProgreso,strConsulta ,strPlanilla,this.datFecha_Presentacion,datFecha_Vencimiento,blnPrimera_Vez  );
                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.GALICIA:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.FRANCES:

                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.MACRO:
                        Genera_Tipo_Archivo_Macro gam = new Genera_Tipo_Archivo_Macro();
                        gam.Genera_Archivo(this.prgProgreso, strConsulta, strPlanilla, this.datFecha_Presentacion, datFecha_Vencimiento, true);
                        break;

                    case (Int32)EnumTipoArchivos.TipoArchivos.PROVINCIA:
                        Genera_Tipo_Archivo_Provincia gap = new Genera_Tipo_Archivo_Provincia();
                        gap.Genera_Archivo(this.prgProgreso, strConsulta, strPlanilla, this.datFecha_Presentacion, datFecha_Vencimiento, true);
                        break;

                }

                //Genera_Archivo_COMAFI(); 
            }

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();
        }


        private void cboCobrador_SelectedValueChanged(object sender, EventArgs e)
        {
            string strID_Cobrador = this.cboCobrador.SelectedValue.ToString();

            this.cboPlanillas.DataSource = null;
            this.Refresh();

            Carga_Combo_Planillas(strID_Cobrador);
        }

        private Boolean Valida()
        {

            if (this.cboCobrador.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar a un Cobrador", "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboCobrador.Focus();
                this.Refresh();
                return false;
            }
            else
            {

                if (this.cboPlanillas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar a una Planilla", "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cboPlanillas.Focus();
                    this.Refresh();
                    return false;
                }
                else
                {
                    if (Tipo_Archivo_Genera== (Int32)EnumTipoArchivos.TipoArchivos.MACRO)
                    {


                        DateTime dat_Vencimiento = Calcula_Fecha_Vencimiento(this.datFecha_Presentacion.Value);

                        int intCantidad_Dias_Vencimiento_Real = 0;
                        intCantidad_Dias_Vencimiento_Real = dat_Vencimiento.Day - this.datFecha_Presentacion.Value.Day;

                        int intCantidad_Dias_Vencimiento_Usuario = 0;
                        intCantidad_Dias_Vencimiento_Usuario = this.datFecha_Vencimiento.Value.Day - this.datFecha_Presentacion.Value.Day;

                        string strMensaje = "La Fecha de Vencimiento no puede ser inferior \na los 3(Tres) días hábiles desde la Fecha de Presentación";

                        if (intCantidad_Dias_Vencimiento_Usuario < intCantidad_Dias_Vencimiento_Real)
                        {
                            MessageBox.Show(strMensaje, "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.datFecha_Vencimiento.Focus();
                            this.Refresh();
                            return false;
                        }

                    }

                    }

                }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmParametros fParametros = new frmParametros();
            fParametros.Show();
        }


        private void datFecha_Presentacion_ValueChanged(object sender, EventArgs e)
        {
            //bool blnSenial = false;

            //Int16 intCantidad_Dias = 0;

            //intCantidad_Dias++;

            //DateTime datFecha_Presentacion = this.datFecha_Presentacion.Value;
            //DateTime datFecha_Vencimiento = this.datFecha_Presentacion.Value.AddDays(1);

            //while (!blnSenial)
            //{

            //    if ( (datFecha_Vencimiento.DayOfWeek != DayOfWeek.Saturday) && (datFecha_Vencimiento.DayOfWeek != DayOfWeek.Sunday) )
            //    {
            //        intCantidad_Dias++;
            //    }

            //    datFecha_Vencimiento = datFecha_Vencimiento.AddDays(1);

            //    if (intCantidad_Dias > 3)
            //        {
            //            blnSenial = true;
            //        }

            //}

            //this.datFecha_Vencimiento.Value = datFecha_Vencimiento;

            this.datFecha_Vencimiento.Value = Calcula_Fecha_Vencimiento(this.datFecha_Presentacion.Value);

        }

        DateTime Calcula_Fecha_Vencimiento(DateTime datFecha_Presentacion)
        {
            //defino días maximo habiles
            int dias_maximo_habiles=0;

            switch (Tipo_Archivo_Genera)
            {
                case (Int32)EnumTipoArchivos.TipoArchivos.DEBLIQC:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.DEBLIQD:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.VISAMOV:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.MASTERCARD:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.AMEX:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.COMAFI:
                    dias_maximo_habiles = 3;
                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.GALICIA:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.FRANCES:

                    break;

                case (Int32)EnumTipoArchivos.TipoArchivos.MACRO:
                    dias_maximo_habiles = 0;
                    break;

            }



            bool blnSenial = false;

            Int16 intCantidad_Dias = 0;

            //intCantidad_Dias++;

            //DateTime datFecha_Presentacion = this.datFecha_Presentacion.Value;
            DateTime date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //DateTime date1 = new DateTime(this.datFecha_Presentacion.Value.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DateTime date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            int result = DateTime.Compare(date1, date2);
            int diasSumar;
            if (result > 0)
            {
                diasSumar = 1;
            }
            else
            {
                diasSumar = 0;
            }
            DateTime datFecha_Vencimiento = this.datFecha_Presentacion.Value.AddDays(diasSumar);


            while (!blnSenial)
            {

                if ((datFecha_Vencimiento.DayOfWeek == DayOfWeek.Saturday))
                {
                    intCantidad_Dias++;
                    dias_maximo_habiles++;
                    datFecha_Vencimiento = datFecha_Vencimiento.AddDays(1);

                }
                if ((datFecha_Vencimiento.DayOfWeek == DayOfWeek.Sunday))
                {
                    intCantidad_Dias++;
                    dias_maximo_habiles++;
                    datFecha_Vencimiento = datFecha_Vencimiento.AddDays(1);

                }

                if (intCantidad_Dias >= dias_maximo_habiles)
                {
                    blnSenial = true;
                }
                else
                {
                    intCantidad_Dias++;
                    datFecha_Vencimiento = datFecha_Vencimiento.AddDays(1);
                }
                

            }

            return datFecha_Vencimiento;

        }


    }
}



