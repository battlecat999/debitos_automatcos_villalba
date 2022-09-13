using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using System.IO;

namespace Club_Debitos
{


    public partial class Form1 : Form
    {

        //System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Leer();

            try
            {

                //Leer();

                // Insert code to process data.
            }
            catch (Exception ex)
            {
                CreateLogFiles Err = new CreateLogFiles();
                Err.ErrorLog(string.Concat(Directory.GetCurrentDirectory(), "\\Logs\\ErrorLog.txt"), ex.Message);
                
                MessageBox.Show("Failed to connect to data source");
                throw;
            }
            finally
            {
                //conn.Close();
            }

        }

        private void Leer()
        {
            OleDbDataReader drCOMAFI;

            string strConsulta = this.txtQuery.Text.ToString();

            drCOMAFI = Entidades.GetDataReader_Access(strConsulta);

            //if (drCOMAFI.HasRows)
            //{
            //    Genera_Archivo_COMAFI(drCOMAFI);
            //}
            //else
            //{
            //    MessageBox.Show("No existen datos para mostrar", "Sr. Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            DataTable dtTable = new DataTable();
            dtTable.Load(drCOMAFI);

            this.lblCantidad_Registros.Text = "";
            this.lblCantidad_Registros.Text = dtTable.Rows.Count.ToString();
            this.Refresh();

            grdDatos.DataSource = null;
            grdDatos.DataSource = dtTable;
            
        }

        private void Genera_Archivo_COMAFI(OleDbDataReader dtDatos )
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //while (drCOMAFI.Read())
            //{

            //    Console.WriteLine(drCOMAFI["idBanco"] + " " + drCOMAFI["nombreBanco"]);
            //}



        }
//        private void Leer()
//        {

//            using (conn)
//            {
//                using (System.Data.OleDb.OleDbCommand dataCommand = conn.CreateCommand())
//                {
//                    dataCommand.CommandText = "SELECT idbanco, nombrebanco FROM BANCOS";
//                    conn.Open();
//                    //dataCommand.Parameters.AddWithValue("@ID", ID);
//                    DataTable table = new DataTable();
//                    System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
//                    adapter.SelectCommand = dataCommand;
//                    adapter.Fill(table);



//                    //foreach (DataRow row in table.Rows)
//                    //{

//                    //    foreach (DataColumn column in table.Columns)
//                    //    {
//                    //        Console.WriteLine(row[column]);
//                    //    }
//                    //}

////                    bindingSource1.DataSource = table;

////                    dataGridView1.AutoResizeColums(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
////                    dataGridView1.ReadOnly = true;
////                    dataGridView1.DataSource = bindingSource1;
//                }
//            }

        }

    //}
}
