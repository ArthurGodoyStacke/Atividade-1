using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            BancoDeDados();
        }

        private void BancoDeDados()
        {
            using (var BancoDeDados = new AppDbContext())
            {
                BancoDeDados.Database.Migrate();
            }
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            FrmChamados frmChamados = new FrmChamados();
            frmChamados.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
