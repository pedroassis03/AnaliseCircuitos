using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AnaliseCircuitos
{
    public partial class F_Historico : Form
    {
        public F_Historico()
        {
            InitializeComponent();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            F_MenuPrincipal f_MenuPrincipal = new F_MenuPrincipal();

            f_MenuPrincipal.Show();

        }

        private void btnLancamento_Click(object sender, EventArgs e)
        {
            string caminhoHistorico = "historico.txt";

            try
            {
                //Verifica se o arquivo existe
                if (File.Exists(caminhoHistorico))
                {
                    Process.Start(caminhoHistorico);
                }
                else
                {
                    MessageBox.Show("O arquivo de histórico não foi encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            string caminhoHistorico = "HistoricoCircuitos.txt";

            try
            {
                //Verifica se o arquivo existe
                if (File.Exists(caminhoHistorico))
                {
                    Process.Start(caminhoHistorico);
                }
                else
                {
                    MessageBox.Show("O arquivo de histórico não foi encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
