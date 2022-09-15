using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Club_Debitos
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wpara, int lparam);
        //private void mnuArchivo_COMAFI_Click(object sender, EventArgs e)
        //{
        //    frmComafi fCOMAFI = new frmComafi((Int32)EnumTipoArchivos.TipoArchivos.COMAFI);
        //    fCOMAFI.Show();
        //}

        private void mnuParametros_Click(object sender, EventArgs e)
        {
            frmParametros fParametros = new frmParametros();
            fParametros.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (mnuVertical.Width == 250)
            {
                mnuVertical.Width = 125;
                this.cmdComafi.ImageAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                mnuVertical.Width = 250;
                this.cmdComafi.ImageAlign = ContentAlignment.MiddleCenter;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("¿Desea cerrar la Aplicación?","Atención",MessageBoxButtons.YesNo)==DialogResult.Yes )
            {
                this.Close();
            }
            
        }

        private void BarraTitulos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = FormHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            
        }

        private void panelConfiguracion_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new frmParametros());
            Form h = new frmParametros();
            h.Show();
        }
        private void cmdComafi_Click(object sender, EventArgs e)
        {

            AbrirFormInPanel(new frmGeneradorArchivos((Int32)EnumTipoArchivos.TipoArchivos.COMAFI  ));
        }
        private void cmdVISACrédito_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGeneradorArchivos((Int32)EnumTipoArchivos.TipoArchivos.DEBLIQC));
        }

        private void cmdVISAElectron_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGeneradorArchivos((Int32)EnumTipoArchivos.TipoArchivos.DEBLIQD));
        }

        private void cmdMacro_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGeneradorArchivos((Int32)EnumTipoArchivos.TipoArchivos.MACRO));
        }

        private void BancoProvincia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGeneradorArchivos((Int32)EnumTipoArchivos.TipoArchivos.PROVINCIA));
        }

    }
}
