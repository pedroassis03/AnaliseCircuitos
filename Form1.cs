using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using MathNet.Numerics.LinearAlgebra;

namespace AnaliseCircuitos
{
    public partial class F_Sistemas : Form
    {
        public List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox>();
        private List<Label> labels = new List<Label>();
        int NumEquacoes = 0;
        string EquationPattern = "";

        public F_Sistemas()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(tb_numEquacoes.Text, out NumEquacoes))
            {
                MessageBox.Show("O valor digitado é inválido");
                tb_numEquacoes.Clear();
                tb_numEquacoes.Focus();
                return;
            }
            else
            {
                if (NumEquacoes > 10 || NumEquacoes <= 0)
                {
                    MessageBox.Show("O valor digitado é inválido");
                    tb_numEquacoes.Clear();
                    tb_numEquacoes.Focus();
                    return;
                }

                for (int i = 0; i < NumEquacoes; i++)
                {
                    //Cria um label
                    Label label = new Label();
                    label.Text = $"Equação {i + 1}";
                    label.Location = new Point(3, 22 + i * 30); // Posição do Label na janela
                    pnl_Equacoes.Controls.Add(label);

                    //Cria uma textbox
                    System.Windows.Forms.TextBox textbox = new System.Windows.Forms.TextBox();
                    textbox.Name = $"tb_Equacão{i + 1}";
                    textbox.Location = new Point(label.Right + 10, label.Top - 3); // Posição da TextBox na janela
                    textbox.Width = 250;
                    pnl_Equacoes.Controls.Add(textbox);

                    textBoxes.Add(textbox);
                    labels.Add(label);
                }

                tb_numEquacoes.ReadOnly = true;
                btn_CalcularSistema.Show();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            pnl_Equacoes.Controls.Clear();
            tb_numEquacoes.Clear();

            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes.Clear();
                labels.Clear();
            }

            btn_CalcularSistema.Hide();
            tb_numEquacoes.ReadOnly = false;
            tb_numEquacoes.Focus();
        }

        private void btn_CalcularSistema_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_numEquacoes.Text, out int numEquacoes))
            {
                int numVariaveis = numEquacoes;
                Vector<double> solucao;

                Sistemas sistema = new Sistemas(numEquacoes, numVariaveis);

                // Criar a matriz de coeficientes (A) e o vetor de constantes (B)
                Matrix<double> A = sistema.CriarMatrizDeCoeficientes();
                Vector<double> B = sistema.CriarVetorDeConstantes();

                switch (numVariaveis)//cria um padrão de inserção para as equações de acordo com o número de equações
                {
                    case 1:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 2:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d*|[-+]?\d+)\s*i2\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 3:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 4:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*=\s*([-+]?\d*\.\d+|[-+]?\d+)$";
                        break;
                    case 5:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 6:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 7:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 8:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i8\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 9:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i8\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i9\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                    case 10:
                        EquationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i8\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i9\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i10\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                        break;
                }

                for (int i = 0; i < textBoxes.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(textBoxes[i].Text))
                    {
                        MessageBox.Show($"O valor da {labels[i].Text} está vazio");
                        textBoxes[i].Clear();
                        textBoxes[i].Focus();
                        return;
                    }
                    else
                    {
                        bool validValue = sistema.VerificarEquacao(textBoxes[i], EquationPattern, i, textBoxes);

                        if (validValue)
                        {
                            // Analisar a equação para extrair os coeficientes e o termo constante
                            string[] termos = textBoxes[i].Text.Split(new string[] { "i1", "i2", "i3", "i4", "i5", "i6", "i7", "i8", "i9", "i10", "=" }, StringSplitOptions.RemoveEmptyEntries);

                            for (int j = 0; j < numVariaveis; j++)
                            {
                                A[i, j] = double.Parse(termos[j].Replace(" ", ""));
                            }

                            B[i] = double.Parse(termos[termos.Length - 1]);

                        }
                        else
                        {
                            MessageBox.Show($"A equação{i + 1} digitada é inválida");
                            textBoxes[i].Clear();
                            textBoxes[i].Focus();
                            return;
                        }
                    }
                }

                // Resolver o sistema de equações
                solucao = A.Solve(B);

                // Exibir os resultados em uma única MessageBox
                string message = "";
                for (int j = 0; j < solucao.Count; j++)
                {
                    message += $"i{j + 1} = {solucao[j]:N3}A\n";
                }

                if (numEquacoes == 2)
                {
                    if (solucao[0] > solucao[1])
                    {
                        message += $"i3 = {solucao[0] - solucao[1]:N3}A";
                    }
                    else if (solucao[0] < solucao[1])
                    {
                        message += $"i3 = {solucao[1] - solucao[0]:N3}A";
                    }
                    else
                    {
                        message += "i3 = 0";
                    }
                }
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("O número de equações digitado é inválido.\n Digite novamente e confirme no botão");
            }
        }
    }
}
