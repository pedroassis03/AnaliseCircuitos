using System;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;
using AnaliseCircuitos;

namespace CanhaoAlvo
{
    public partial class F_Lancamento : Form
    {
        double g = 9.8, x = 1000, H = 500, theta, v0;
        private double minThetaGraus;


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            F_MenuPrincipal formMenu = new F_MenuPrincipal();

            formMenu.Show();

            this.Close();
        }

        private void pictureBoxGeogebra_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.geogebra.org/calculator");
        }

        private void linkLabelEquacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(linkLabelEquacao.Text);
        }

        private void F_Lancamento_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            CalcularLimites();
            double thetaMinRad = minThetaGraus * (Math.PI / 180); // Converte thetaMin para radianos
            bool conversaoValida; //Valida a entrada do usuário
            try
            {
                theta = Convert.ToDouble(txtAngulo.Text);
                conversaoValida = true;

                theta = theta * Math.PI / 180;

                if (theta < thetaMinRad || theta >= Math.PI / 2)
                {
                    lblResultado.Text = "O alvo não será atingido nesse ângulo";
                    lblResultado.Visible = true;
                    label4.Visible = true;
                    linkLabelEquacao.Visible = false;
                    label5.Visible = false;

                    string historico2 = $"Ângulo: {theta * (180 / Math.PI)} graus\n{lblResultado.Text}\n================================================================";
                    EscreverNoHistorico(historico2);
                    return;
                }

                v0 = (Math.Sqrt((-g * Math.Pow(x, 2)) / ((H - Math.Tan(theta) * x) * 2 * Math.Pow(Math.Cos(theta), 2))));
            }
            catch (Exception)
            {
                conversaoValida = false;
            }

            if (conversaoValida)
            {
                double vx = v0 * Math.Cos(theta);
                double t = x / vx;

                double vy = v0 * Math.Sin(theta) - g * t;
                double a = -g / (2 * Math.Pow(v0, 2) * Math.Pow(Math.Cos(theta), 2));

                string movimento = vy > 0 ? "ascendente" : "descendente";

                if (v0 > 472)
                {
                    lblResultado.Text = "O alvo não será atingido nesse ângulo, pois a velocidade ultrapassa \na velocidade máxima de um tiro de canhão!";
                    lblResultado.Visible = true;
                    label4.Visible = true;
                    linkLabelEquacao.Visible = false;
                    label5.Visible = false;

                    string historico2 = $"Ângulo: {theta * (180 / Math.PI)} graus\n{lblResultado.Text}\n================================================================";
                    EscreverNoHistorico(historico2);

                    return;
                }

                lblResultado.Text = "Tempo: " + t.ToString("0.##") + " s \nVelocidade: " + v0.ToString("0.##") + " m/s" + "\nO movimento é: " + movimento;

                linkLabelEquacao.Text = "y = " + a.ToString(CultureInfo.InvariantCulture) + "x² + " + Math.Tan(theta).ToString(CultureInfo.InvariantCulture) + "x";
                linkLabelEquacao.Visible = true;
                label4.Visible = true;
                lblResultado.Visible = true;
                label5.Visible = true;

                string historico = $"Ângulo: {theta * (180 / Math.PI)} graus\n{lblResultado.Text}\nEquação: {linkLabelEquacao.Text}\n================================================================";
                EscreverNoHistorico(historico);
            }
            else
            {
                lblResultado.Text = "Por favor, insira um ângulo válido!";
                lblResultado.Visible = true;
                label4.Visible = true;
                linkLabelEquacao.Visible = false;
                label5.Visible = false;
            }

            lb_VisualizarGrafico.Show();
            pictureBoxGeogebra.Show();
        }

        public F_Lancamento()
        {
            InitializeComponent();
            CalcularLimites();

            linkLabelEquacao.Visible = false;
            lblResultado.Visible = false;
            label5.Visible = false;
            label4.Visible = false;

            PictureBox pictureBoxGeogebra = new PictureBox();

            // Adiciona PictureBox ao formulário
            Controls.Add(pictureBoxGeogebra);
        }



        private void CalcularLimites()
        {
            double tgTheta = H / x;
            double minTheta = Math.Atan(tgTheta);
            minThetaGraus = minTheta * 180 / Math.PI; // Transforma o ângulo de radianos para graus
            lblLimite.Text = "Ângulo mínimo para atingir o alvo: " + minThetaGraus.ToString("0.##") + " graus";
        }


        private static void EscreverNoHistorico(string historicoInfo)
        {
            // Caminho do arquivo de histórico
            string caminhoHistorico = Path.Combine(Application.StartupPath, "historico.txt");

            try
            {
                // Verifica se o arquivo já existe
                if (!File.Exists(caminhoHistorico))
                {
                    // Se não existir, cria o arquivo
                    using (StreamWriter sw = File.CreateText(caminhoHistorico))
                    {
                        sw.WriteLine("Histórico de Ângulos:\n\n");
                        MessageBox.Show("Um histórico foi gerado no seguinte arquivo:\n\n" + caminhoHistorico);

                        sw.Close();
                    }
                }

                // Adiciona as informações ao arquivo de histórico
                using (StreamWriter sw = File.AppendText(caminhoHistorico))
                {
                    sw.WriteLine(historicoInfo);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                // Trata exceções, como permissões insuficientes ou outros erros de arquivo
                MessageBox.Show($"Erro ao escrever no histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}