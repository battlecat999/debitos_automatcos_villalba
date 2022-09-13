using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;


namespace Club_Debitos
{
    public partial class frmParametro : Form
    {
        public frmParametro()
        {
            InitializeComponent();
        }

        private void Carga_Combo_Cobradores()
        {
            OleDbDataReader drCOBRADORES;

            string strConsulta = "select idCobrador, ApeyNom  from cobradores";

            drCOBRADORES = Entidades.GetDataReader_Access(strConsulta);

            DataTable dtCOBRADORES = new DataTable();
            dtCOBRADORES.Load(drCOBRADORES);

            //this.cboCobradores.SelectedValueChanged -= new System.EventHandler(this.cboCobradores_SelectedValueChanged);

            this.cboCobradores.DataSource = dtCOBRADORES;

            this.cboCobradores.ValueMember = "idCobrador";
            this.cboCobradores.DisplayMember = "ApeyNom";

            this.cboCobradores.SelectedIndex = -1;

            //this.cboCobradores.SelectedValueChanged += new System.EventHandler(this.cboCobradores_SelectedValueChanged);

        }

    }
}
