using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

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

        public bool VerificarEquacao(TextBox equation, string equationPattern, int i, List<System.Windows.Forms.TextBox> textBoxes)
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
    }
}
