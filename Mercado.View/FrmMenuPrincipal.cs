using System;
using System.Windows.Forms;

namespace Mercado.View
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            rbtnAbm.Checked = true;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            new FrmEmpresa().ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            if(rbtnAbm.Checked)
                new FrmAbmLocal(null).ShowDialog();
            else
                new FrmConsultaLocal(null).ShowDialog();
        }
    }
}
