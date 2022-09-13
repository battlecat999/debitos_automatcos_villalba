using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using System.Data.OleDb;
using System.IO;

using System.Configuration;
using System.Collections.Specialized;
using System.Globalization;

namespace Club_Debitos
{
    class Genera_Tipo_Archivo_Macro
    {
        int intCantidad_Registros = 0;

        //string strNumero_Socio = "";
        //string strNombre_Archivo = "";
        //string strNombre_Mes = "";

        //string strReferencia_UNIVOCA = "";

        //string strProducto = "";
        //int intSecuencia = 0;

        //string strConsulta;
        //string strLinea;

        public bool Genera_Archivo(ProgressBar prgProgreso, string strConsulta, string strPlanilla, DateTimePicker datFecha_Presentacion, DateTimePicker datFecha_Vencimiento, bool blnPrimera_Vez)
        {
            OleDbDataReader dr;

            string strLinea = "";
            string strLineaGral = "";

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
                //Seteo el progress BAR
                strLinea = string.Empty;
                strLineaGral = string.Empty;

                prgProgreso.Minimum = 0;
                prgProgreso.Value = 0;
                prgProgreso.Maximum = dt.Rows.Count;
                prgProgreso.Refresh();

                string strFiller = "0";
                strLineaGral = strFiller;

                string strNroConvenio = dt.Rows[0]["Codigo_Servicio"].ToString().Trim();//5 posiciones.
                strLineaGral += strNroConvenio;

                string strNroServicio = dt.Rows[0]["Numero_Servicio"].ToString().Trim().PadLeft(10, ' ');//10 posicione;
                strLineaGral += strNroServicio;

                string strNroEmpresaSueldo = string.Empty;//5 posiciones
                strLineaGral += strNroEmpresaSueldo.PadLeft(5, '0');
                int intLargo_ceros_socios = Convert.ToInt32(dt.Rows[0]["Secuencia"].ToString());



                dr = Entidades.GetDataReader_Access(strConsulta);
                //guardo el archivo
                string pathArchivo_name;
                pathArchivo_name = dt.Rows[0]["RutaArchivo"].ToString().Trim() + "\\" + dt.Rows[0]["Nombre_Archivo"].ToString().Trim()  + ".txt";
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(pathArchivo_name);

                // ARMO LA CABECERA
                strLinea = String.Empty;
                //Filler
                strLinea += "1";//1
                //Nro de Convenio
                strLinea += strNroConvenio;//1+5
                //Nro de Servicio
                strLinea += strNroServicio;
                //Nro de Empresa de sueldos
                strLinea += "00000";
                //Fecha de Generacion del Archivo
                strLinea+= datFecha_Vencimiento.Value.Date.ToString("yyyyMMdd");
                //Importe Total del Movimiento
                string strTotal=string.Empty ;
                double total = dt.AsEnumerable().Sum(x => x.Field<double>("Saldo"));
                if (total !=0)
                {
                    total = Convert.ToDouble(total);
                    strTotal = total.ToString("N");
                    strTotal = strTotal.Replace(".", "");
                    strTotal = strTotal.Replace(",", "");
                    strTotal = strTotal.PadLeft(18, '0');
                }
                strLinea += strTotal;
                //Moneda + tipo movimiento
                strLinea += "080"+"01";
                //Inofmracion monetaria
                string strTMP = string.Empty;
                strLinea += strTMP.PadLeft(98, '0');
                //Blancos
                strTMP = string.Empty;
                strLinea += strTMP.PadLeft(69, ' ');
                //Relleno
                strLinea += "0";
                SaveFile.Write(strLinea + "\r\n");

                DataTable dtPrueba = new DataTable();


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
                    //grabo lo general
                    strLinea = strLineaGral ;
                    
                    //inicializo el objeto
                    CBU_Analisis_Gral CBU = new CBU_Analisis_Gral();
                    //paso el cbu original

                    if(dr["cbu"].ToString().Trim().Length != 22)
                    {
                        MessageBox.Show ("El Socio " + dr["ApellidoyNombres"].ToString().Trim() + " tiene un CBU incorrecto.");
                        SaveFile.Close();
                        return false;

                    }

                    CBU.CBU_General1 = dr["cbu"].ToString().Trim();
                    //ejecuto la función.
                    CBU.Formato_CBU_Macro();
                    //Código de Bano Adherente
                    strLinea += CBU.CBU_Parte_Banco_Adhe1;//3 posicione
                    //Código Sucursal
                    strLinea += CBU.CBU_Parte_Sucursal1;//0005 4

                    //obtengo los datos procesados.
                    strLinea += CBU.CBU_Parte_Tipo_Cuenta1;//1

                    strLinea += CBU.Cbu_Cuenta1;// 15 posiciones

                    //identificaciones
                    string str_Ident_del_Adhe = dr["IdSocio"].ToString().Trim().PadLeft(intLargo_ceros_socios, '0').PadRight(22,' ');//Se cambio, entes estaba PadRight'
                    //string str_Ident_del_Adhe = dr["IdSocio"].ToString().Trim().PadRight(22, ' ');//Se cambio, entes estaba PadRight'
                    strLinea += str_Ident_del_Adhe;

                    string str_Ident_Debito = dr["ApellidoyNombres"].ToString().Trim().PadRight(15, ' ').Substring(0,15);
                    str_Ident_Debito = str_Ident_Debito.Replace("Ñ", "n");

                    strLinea += str_Ident_Debito.ToUpper() ;
                    //
                    string str_Movimientos = string.Empty;
                    strLinea += str_Movimientos.PadLeft(2, ' ');

                    string str_Motivo_Rechazo = string.Empty;
                    strLinea += str_Motivo_Rechazo.PadLeft(4, ' ');
                    //Fecha de Vencimiento
                    strLinea += datFecha_Vencimiento.Value.Date.ToString("yyyyMMdd");
                    //
                    strLinea += "080";
                    //Importe y/o Saldo
                    double dblSaldo = 0;
                    string strSaldo = string.Empty;
                    if (dr["Saldo"] != null && dr["Saldo"] != DBNull.Value)
                    {
                        dblSaldo = Convert.ToDouble(dr["Saldo"]);
                        strSaldo = dblSaldo.ToString("N");
                        strSaldo = strSaldo.Replace(".", "");
                        strSaldo = strSaldo.Replace(",", "");
                        strSaldo = strSaldo.PadLeft(13, '0');
                    }
                    else
                    {
                        dblSaldo = 0;
                        strSaldo = dblSaldo.ToString("N");
                        strSaldo = strSaldo.Replace(".", "");
                        strSaldo = strSaldo.Replace(",", "");
                        strSaldo = strSaldo.PadLeft(13, '0');
                    }
                    
                    strLinea += strSaldo;
                    dblSaldo_Planilla += dblSaldo;
                    //Fehca de Reintento
                    string tmp = string.Empty;
                    strLinea += tmp.PadLeft(8, '0');//"00000000";
                    strLinea += tmp.PadLeft(13, '0');
                    //
                    strLinea += tmp.PadLeft(4, '0');
                    strLinea += tmp.PadLeft(1, '0');
                    strLinea += tmp.PadLeft(15, '0');// Nueva Cuenta bancaria
                    strLinea += tmp.PadLeft(22, ' ');
                    strLinea += tmp.PadLeft(40, ' ');
                    strLinea += tmp.PadLeft(5, ' ');
                    strLinea += strFiller;

                }
                SaveFile.Write(strLinea);
                SaveFile.Close();
                //se suma el total de la plantilla
                OleDbDataReader drMACRO_Total;

                strConsulta = string.Empty;
                strConsulta = "SELECT Sum(ItemPlaniCob.Saldo) AS SumaDeSaldo FROM ItemPlaniCob WHERE (((ItemPlaniCob.IdNroPlaniCob)=" + strPlanilla + "));";
                drMACRO_Total = Entidades.GetDataReader_Access(strConsulta);

                DataTable dtMACRO_Total = new DataTable();
                dtMACRO_Total.Load(drMACRO_Total);

                //MessageBox.Show("Total de Registros: " + intCantidad_Registros.ToString() + ". Total de la Planilla: " + Convert.ToDouble(dtCOMAFI_Total.Rows[0]["SumaDeSaldo"]).ToString("C"));

                MessageBox.Show("Total de Registros: " + intCantidad_Registros.ToString() + ". Total de la Planilla: " + Convert.ToDouble(dtMACRO_Total.Rows[0][0]).ToString("C"));

                MessageBox.Show("Proceso finalizado", "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
        }
    }
}
