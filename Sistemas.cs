using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnaliseCircuitos
{
    internal class Sistemas
    {
        public Sistemas(int numEquacoes, int numVariaveis)
        {
            NumEquacoes = numEquacoes;
            NumVariaveis = numVariaveis;
        }

        public int NumEquacoes { get; }

        public int NumVariaveis { get; }


        public MathNet.Numerics.LinearAlgebra.Matrix<double> CriarMatrizDeCoeficientes()
        {
            var A = Matrix<double>.Build.Dense(NumEquacoes, NumVariaveis);
            return A;
        }

        public MathNet.Numerics.LinearAlgebra.Vector<double> CriarVetorDeConstantes()
        {
            var B = Vector<double>.Build.Dense(NumEquacoes);
            return B;
        }

        public bool VerificarEquacao(System.Windows.Forms.TextBox equation, string equationPattern, int i, List<System.Windows.Forms.TextBox> textBoxes)
        {
            if (Regex.IsMatch(equation.Text, equationPattern)) //verifica se a equação atende ao padrão
            {
                return true;
            }
            else
            {
                //MessageBox.Show($"A equação {i + 1} não está no formato correto");
                equation.Clear();
                textBoxes[i].Focus();
                return false;
            }

        }

        public void GerarHistoricoDeEquacoes(List<System.Windows.Forms.TextBox> textBoxes, Vector<double> solucoes)
        {
            string caminhoArquivo = Path.Combine(Application.StartupPath, "HistoricoCircuitos.txt");

            // Verifica se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                using (StreamWriter sw = File.AppendText(caminhoArquivo))
                {
                    foreach (var textbox in textBoxes)
                    {
                        sw.WriteLine(DateTime.Now.ToString() + ": " + textbox.Text);
                    }

                    for (int i = 0; i < solucoes.Count; i++)
                    {
                        sw.WriteLine(DateTime.Now.ToString() + $": i{i + 1} = {solucoes[i]:N3}A");
                    }

                    // Pula uma linha no final
                    sw.WriteLine("");

                    MessageBox.Show("Resultados adicionados ao histórico:\n\n" + caminhoArquivo);

                    // Fecha o StreamWriter
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter sw = File.CreateText(caminhoArquivo))
                {
                    foreach (var textbox in textBoxes)
                    {
                        // Escreve conteúdo no arquivo
                        sw.WriteLine(DateTime.Now.ToString() +": " + textbox.Text);
                    }

                    for (int i = 0; i < solucoes.Count; i++)
                    {
                        sw.WriteLine(DateTime.Now.ToString() + $": i{i + 1} = {solucoes[i]:N3}A");
                    }

                    sw.WriteLine("");

                    MessageBox.Show("Um histórico foi gerado no seguinte arquivo:\n\n" + caminhoArquivo);

                    sw.Close();
                }
            }
        }

        public string GerarPadraoDeEquacao(int numVariaveis)
        {
            string equationPattern = "";

            switch (numVariaveis)//cria um padrão de inserção para as equações de acordo com o número de variáveis
            {
                case 1:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 2:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d*|[-+]?\d+)\s*i2\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 3:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 4:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*=\s*([-+]?\d*\.\d+|[-+]?\d+)$";
                    break;
                case 5:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 6:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 7:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 8:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i8\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 9:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i8\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i9\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
                case 10:
                    equationPattern = @"^([-+]?\d*\.\d+|[-+]?\d+)\s*i1\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i2\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i3\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i4\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i5\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i6\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i7\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i8\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i9\s*([-+])\s*([-+]?\d*\.\d+|[-+]?\d+)\s*i10\s*=\s*([-+]?\d*\.\d*|[-+]?\d+)$";
                    break;
            }

            return equationPattern;
        }
    }
}
