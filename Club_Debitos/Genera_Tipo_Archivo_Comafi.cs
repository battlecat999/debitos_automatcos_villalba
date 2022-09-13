using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using System.Data.OleDb;
using System.IO;

using System.Configuration;
using System.Collections.Specialized;
using System.Globalization;

namespace Club_Debitos
{
    public class Genera_Tipo_Archivo_Comafi
    {
            int intCantidad_Registros = 0;

            string strNumero_Socio = "";
            string strNombre_Archivo = "";
            string strNombre_Mes = "";

            string strReferencia_UNIVOCA = "";

            string strProducto = "";
            int intSecuencia = 0;

            //string strConsulta;
            //string strLinea;

        public bool Genera_Archivo(ProgressBar prgProgreso, string  strConsulta, string strPlanilla, DateTimePicker datFecha_Presentacion,DateTimePicker datFecha_Vencimiento,bool blnPrimera_Vez)
        {


            //Boolean blnPrimera_Vez = false;

            OleDbDataReader dr;

            string strLinea = "";

            blnPrimera_Vez = true;

            dr = Entidades.GetDataReader_Access(strConsulta);

            double dblSaldo_Planilla = 0;
            //SE CREA UN DATATABLE PARA PODER RECORRER LOS REGISTROS.
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count == 0)
            //if (dr.HasRows != true)
            {
                MessageBox.Show("No existen datos para mostrar", "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {

                prgProgreso.Minimum = 0;
                prgProgreso.Value = 0;
                prgProgreso.Maximum = dt.Rows.Count;
                prgProgreso.Refresh();

                SaveFileDialog cmdFileDialog = new SaveFileDialog();

                strNombre_Archivo = "";
                //strNombre_Archivo = "EB" + dr["Origen_Comercial"].ToString().Trim().PadRight(5, '0') + "." + this.datFecha_Presentacion.Value.Date.ToString("yyyyMMdd");
                strNombre_Archivo = "EB" + dt.Rows[0]["Origen_Comercial"].ToString().Trim().PadRight(5, '0') + "." + datFecha_Presentacion.Value.Date.ToString("yyyyMMdd");

                cmdFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                cmdFileDialog.FilterIndex = 2;
                cmdFileDialog.RestoreDirectory = true;
                cmdFileDialog.FileName = strNombre_Archivo;

                if (cmdFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                strNombre_Mes = "";
                strNombre_Mes = Obtiene_Nombre_Mes(datFecha_Presentacion.Value.Month);

                strReferencia_UNIVOCA = "CUOTA " + strNombre_Mes.Trim();

                if (strReferencia_UNIVOCA.Length > 15)
                {
                    strReferencia_UNIVOCA = strReferencia_UNIVOCA.Substring(0, 15); //SON 15 POSICIONES
                }

                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(cmdFileDialog.FileName);

                dr = Entidades.GetDataReader_Access(strConsulta);

                while (dr.Read())
                {

                    prgProgreso.Value++;
                    prgProgreso.Refresh();

                    intCantidad_Registros = intCantidad_Registros + 1;

                    //HAY UN PROBLEMA CON WRITELINE QUE PROVOCA UN RETORNO DE CARRO AL FINAL DE LA LÍNEA
                    //Cambió por "Write" y se agrega manualmente el retorno de línea, pero hay que controlar, sí es la última linea a generar
                    //para no agregar un retorno de carro que provoca una línea en blanco al final del archivo
                    if (!blnPrimera_Vez)
                    {
                        SaveFile.Write(strLinea + "\r\n");
                    }
                    else
                    {
                        blnPrimera_Vez = false;
                    }

                    strLinea = "";

                    //Código de Transacción
                    strLinea = "051";

                    //Fecha de Vencimiento
                    strLinea += datFecha_Vencimiento.Value.Date.ToString("ddMMyyyy");

                    //Código de Empresa
                    //strLinea += "00015";
                    strLinea += dr["Origen_Comercial"].ToString().Trim().PadLeft(5, '0');

                    intSecuencia = 0;
                    intSecuencia = int.Parse(dr["Secuencia"].ToString());

                    strNumero_Socio = "";
                    //strNumero_Socio = dr["iDSocio"].ToString().Trim().PadLeft(5, '0');
                    strNumero_Socio = dr["iDSocio"].ToString().Trim().PadLeft(intSecuencia, '0');

                    strLinea += strNumero_Socio.Trim().PadRight(22, ' ');

                    //Moneda
                    strLinea += "0";

                    //CBU
                    strLinea += dr["CBU"];

                    double dblSaldo = 0;
                    string strSaldo = string.Empty;
                    if (dr["Saldo"] != null && dr["Saldo"] != DBNull.Value)
                    {
                        dblSaldo = Convert.ToDouble(dr["Saldo"]);
                        strSaldo = dblSaldo.ToString("N");
                        strSaldo = strSaldo.Replace(".", "");
                        strSaldo = strSaldo.Replace(",", "");
                        strSaldo = strSaldo.PadLeft(10, '0');
                    }

                    //Saldo
                    //double dblSaldo = Convert.ToDouble(dr["Saldo"]);
                    //Int16 intDecimales = Convert.ToInt16(dblSaldo - Math.Truncate(dblSaldo) );

                    //Parte Entera 8 Posiciones
                    //strLinea += Math.Truncate(Convert.ToDouble(dr["Saldo"])).ToString().PadLeft(8, '0');
                    //strLinea += Math.Truncate(dblSaldo).ToString().PadLeft(8, '0');

                    //Parte Decimal 2 Posiciones
                    //strLinea += intDecimales.ToString().PadLeft(2, '0');
                    strLinea += strSaldo;//dblSaldo.ToString().Replace(",", "").PadLeft(10, '0');

                    dblSaldo_Planilla += dblSaldo;

                    //CUIT Empresa
                    //strLinea += dr["Cuit_Empresa"];
                    strLinea += dr["CUIT_Empresa"].ToString().Trim().PadLeft(11, '0');

                    //Presentación
                    strProducto = "";
                    if (dr["Producto"].ToString().Trim().Length > 10)
                    {
                        strProducto = dr["Producto"].ToString().Trim().Substring(0, 10);
                    }
                    else
                    {
                        strProducto = dr["Producto"].ToString().Trim().PadRight(10, ' ');
                    }

                    strLinea += strProducto;

                    //Referencia de la Operación
                    //strLinea += "               "; //15 Blancos
                    strLinea += strNumero_Socio.PadRight(15, ' ');

                    //Referencia Univoca
                    strReferencia_UNIVOCA = dr["Producto"].ToString().Trim() + " " + strNombre_Mes.Trim();
                    if (strReferencia_UNIVOCA.Length > 15)
                    {
                        strReferencia_UNIVOCA = strReferencia_UNIVOCA.Substring(0, 15); //SON 15 POSICIONES
                    }
                    strLinea += strReferencia_UNIVOCA.PadRight(15, ' '); //15 Blancos

                    //Cuenta de la Empresa
                    //strLinea += "               "; //15 Blancos
                    strLinea += dr["Codigo_Servicio"].ToString().Trim().PadLeft(15, '0');

                    //ID Cliente o CBU Nueva
                    strLinea += "                      "; //22 Blancos

                    //Código de Rechazo
                    strLinea += "   "; //3 Blancos

                    //Se quitó porque genera una línea en blanco al final del archivo y da error en las pruebas con el Banco.
                    //SaveFile.WriteLine(strLinea);

                }

                SaveFile.Write(strLinea);
                SaveFile.Close();
                //se suma el total de la plantilla
                OleDbDataReader drMACRO_Total;

                strConsulta = string.Empty;
                strConsulta = "SELECT Sum(ItemPlaniCob.Saldo) AS SumaDeSaldo FROM ItemPlaniCob WHERE (((ItemPlaniCob.IdNroPlaniCob)=" + strPlanilla + "));";
                drMACRO_Total = Entidades.GetDataReader_Access(strConsulta);

                DataTable dtCOMAFI_Total = new DataTable();
                dtCOMAFI_Total.Load(drMACRO_Total);

                //MessageBox.Show("Total de Registros: " + intCantidad_Registros.ToString() + ". Total de la Planilla: " + Convert.ToDouble(dtCOMAFI_Total.Rows[0]["SumaDeSaldo"]).ToString("C"));

                MessageBox.Show("Total de Registros: " + intCantidad_Registros.ToString() + ". Total de la Planilla: " + Convert.ToDouble(dtCOMAFI_Total.Rows[0][0]).ToString("C")); ;

                MessageBox.Show("Proceso finalizado", "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        private string Obtiene_Nombre_Mes(int intMes)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(intMes).ToUpper();
        }

        }


    }

