using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMeuChef
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Visible = false;//fecha a tela inicial

            frmTelaPrincipal ftp = new frmTelaPrincipal();//instancia a tela principal
            ftp.Show();//abre a tela principal
        }
    }
}
