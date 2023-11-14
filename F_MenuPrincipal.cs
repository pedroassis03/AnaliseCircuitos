using CanhaoAlvo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseCircuitos
{
    public partial class F_MenuPrincipal : Form
    {
        public F_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Circuitos_Principal_Click(object sender, EventArgs e)
        {
            F_Sistemas f_sistemas = new F_Sistemas();

            f_sistemas.Show();
        }

        private void btn_Lancamento_Principal_Click(object sender, EventArgs e)
        {
            F_Lancamento f_lancamento = new F_Lancamento();

            f_lancamento.Show();
        }

        private void btn_Historico_Principal_Click(object sender, EventArgs e)
        {
            F_Historico f_Historico = new F_Historico();

            f_Historico.Show();
        }
    }
}
