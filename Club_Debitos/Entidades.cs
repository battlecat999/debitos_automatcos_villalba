using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

using System.Data.OleDb;
using System.IO;
using System.Drawing;

namespace Club_Debitos
{
    public class Entidades
    {

        public static string CadenaConexion
        {
            

            get {
                string Cadena;
                string en_Cadena;

                encrypasocv.Encryption e = new encrypasocv.Encryption();
                Cadena= ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                en_Cadena = e.Decrypt(Cadena);
                return en_Cadena; 
            }
        }

        public static string Provider
        {
            get { return ConfigurationManager.ConnectionStrings["conexion"].ProviderName; }
        }

        public static string CadenaConexionParametros
        {
            get { return ConfigurationManager.ConnectionStrings["Parametros"].ConnectionString; }
        }

        public static DbProviderFactory DbPF
        {
            get
            {
                return DbProviderFactories.GetFactory(Provider);
            }
        }

        public static int EjecutaNonQuery(string strStoredProcedures, List<DbParameter> Parametros)
        {
            int ID = 0;
            try
            {
                using (DbConnection Con = DbPF.CreateConnection())
                {
                    Con.ConnectionString = CadenaConexion;
                    using (DbCommand cmd = DbPF.CreateCommand())
                    {
                        cmd.Connection = Con;
                        cmd.CommandText = strStoredProcedures;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DbParameter Param in Parametros)
                            cmd.Parameters.Add(Param);

                        Con.Open();
                        ID = cmd.ExecuteNonQuery();

                    }
                }
            }

            catch (Exception ex)
            {
                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(string.Concat(Directory.GetCurrentDirectory(), "\\Logs\\ErrorLog.txt"), ex.Message);
                throw;
                throw;
            }
            finally
            {

            }

            return ID;

        }
        

        public static DataSet GetDataSet(String strSqlConsulta)
        {

            DbDataAdapter dbDataAdapter = new SqlDataAdapter();
            SqlCommand Commando = new SqlCommand(strSqlConsulta);
            DataTable dataTable = new DataTable();

            using (DbConnection con = DbPF.CreateConnection())
            {
                con.ConnectionString = CadenaConexion;

                using (DbCommand commando = DbPF.CreateCommand())
                {
                    commando.Connection = con;
//                    commando.CommandText = strSqlConsulta;
//                    commando.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    DataSet dataSet = new DataSet();    
                    dbDataAdapter.SelectCommand = commando;
                    dbDataAdapter.SelectCommand.CommandText = strSqlConsulta;
                    dbDataAdapter.SelectCommand.Connection = con;

                    dbDataAdapter.Fill(dataSet);
                    
                    dataTable.EndLoadData();
                    dataSet.EnforceConstraints = false;
                    dataSet.Tables.Add(dataTable);

                    return dataSet;

                }
            }
        }

        public static OleDbDataReader GetDataReader_Access(string strConsulta)
        {

            try{
                OleDbConnection conConexion_Access;   // create connection
                OleDbCommand cmdComando_Consulta_Access;  // create command
                OleDbDataReader drData_Reader;  //Dataread for read data from database

                string strConnection_Access = CadenaConexion;

                conConexion_Access = new OleDbConnection(strConnection_Access);

                cmdComando_Consulta_Access = new OleDbCommand(strConsulta, conConexion_Access);

                conConexion_Access.Open();

                drData_Reader = cmdComando_Consulta_Access.ExecuteReader();

                //conConexion_Access.Close();

                return drData_Reader;
            }
            catch (Exception ex)
            {
                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(string.Concat(Directory.GetCurrentDirectory(), "\\Logs\\ErrorLog.txt"), ex.Message);
                throw;
            }

        }
        

        public static OleDbDataReader GetDataReader_Access(string strConsulta, string strCadena_Conexion)
        {

            OleDbConnection conConexion_Access;   // create connection
            OleDbCommand cmdComando_Consulta_Access;  // create command
            OleDbDataReader drData_Reader;  //Dataread for read data from database

            //string strConnection_Access = CadenaConexion;
            string strConnection_Access = "";
                
            if (strCadena_Conexion.Trim() == "")
            {
                strConnection_Access = CadenaConexion;
            }
            else
            {
                strConnection_Access = strCadena_Conexion;
            }
                
            conConexion_Access = new OleDbConnection(strConnection_Access);

            cmdComando_Consulta_Access = new OleDbCommand(strConsulta, conConexion_Access);

            conConexion_Access.Open();

            drData_Reader = cmdComando_Consulta_Access.ExecuteReader();

            //conConexion_Access.Close();

            return drData_Reader;

        }

        public static DataTable GetDataTable(String strConsulta)
        {
            DbDataAdapter dbDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            using (DbConnection con = DbPF.CreateConnection())
            {
                con.ConnectionString = CadenaConexion;

                using (DbCommand commando = DbPF.CreateCommand())
                {
                    commando.Connection = con;

                    con.Open();

                    DataSet dataSet = new DataSet();

                    dbDataAdapter.SelectCommand = commando;
                    dbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                    dbDataAdapter.SelectCommand.CommandTimeout = 0;
                    dbDataAdapter.SelectCommand.CommandText = strConsulta;
                    dbDataAdapter.SelectCommand.Connection = con;

                    dbDataAdapter.Fill(dataSet);

                    dataTable.EndLoadData();
                    dataSet.EnforceConstraints = false;
                    dataSet.Tables.Add(dataTable);

                    return dataSet.Tables[0]; 

                }
            }
        }

        public static DataTable GetDataTable(String strConsulta, string strConnectionString)
        {
            DbDataAdapter dbDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            using (DbConnection con = DbPF.CreateConnection())
            {
                //con.ConnectionString = CadenaConexion;
                con.ConnectionString = strConnectionString;

                using (DbCommand commando = DbPF.CreateCommand())
                {
                    commando.Connection = con;
                    commando.CommandTimeout = 0;

                    con.Open();

                    DataSet dataSet = new DataSet();

                    dbDataAdapter.SelectCommand = commando;
                    dbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                    dbDataAdapter.SelectCommand.CommandText = strConsulta;
                    dbDataAdapter.SelectCommand.Connection = con;

                    dbDataAdapter.Fill(dataSet);

                    dataTable.EndLoadData();
                    dataSet.EnforceConstraints = false;
                    dataSet.Tables.Add(dataTable);

                    return dataSet.Tables[0];

                }
            }
        }


        public static DataTable GetDataTable_New(String strConsulta)
        {
            DbDataAdapter dbDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            //string strStoredProcedure = "up_carga_OTs";

            using (DbConnection con = DbPF.CreateConnection())
            {
                //con.ConnectionString = CadenaConexion_AutoPack;
                con.ConnectionString = CadenaConexion;

                using (DbCommand commando = DbPF.CreateCommand())
                {
                    commando.Connection = con;
                    //commando.CommandText = strStoredProcedure;
                    //commando.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    DataSet dataSet = new DataSet();

                    dbDataAdapter.SelectCommand = commando;
                    dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dbDataAdapter.SelectCommand.CommandText = strConsulta;
                    dbDataAdapter.SelectCommand.Connection = con;

                    dbDataAdapter.Fill(dataSet);

                    dataTable.EndLoadData();
                    dataSet.EnforceConstraints = false;
                    dataSet.Tables.Add(dataTable);

                    return dataSet.Tables[0];

                }
            }
        }


    }
}