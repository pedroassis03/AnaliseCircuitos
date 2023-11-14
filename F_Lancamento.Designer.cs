namespace CanhaoAlvo
{
    partial class F_Lancamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lancamento));
            this.lblLimite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelEquacao = new System.Windows.Forms.LinkLabel();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBoxGeogebra = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_VisualizarGrafico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeogebra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLimite.Location = new System.Drawing.Point(306, 20);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(69, 32);
            this.lblLimite.TabIndex = 0;
            this.lblLimite.Text = "label";
            this.lblLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(309, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o ângulo em graus";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(307, 270);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(64, 25);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equação:";
            // 
            // linkLabelEquacao
            // 
            this.linkLabelEquacao.ActiveLinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabelEquacao.AutoSize = true;
            this.linkLabelEquacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelEquacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEquacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelEquacao.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelEquacao.Location = new System.Drawing.Point(307, 431);
            this.linkLabelEquacao.Name = "linkLabelEquacao";
            this.linkLabelEquacao.Size = new System.Drawing.Size(100, 25);
            this.linkLabelEquacao.TabIndex = 5;
            this.linkLabelEquacao.TabStop = true;
            this.linkLabelEquacao.Text = "linkLabel1";
            this.linkLabelEquacao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEquacao_LinkClicked);
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(564, 73);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(361, 26);
            this.txtAngulo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(312, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(613, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(314, 645);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(611, 43);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBoxGeogebra
            // 
            this.pictureBoxGeogebra.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxGeogebra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGeogebra.BackgroundImage")));
            this.pictureBoxGeogebra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxGeogebra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGeogebra.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGeogebra.ErrorImage")));
            this.pictureBoxGeogebra.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGeogebra.Image")));
            this.pictureBoxGeogebra.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGeogebra.InitialImage")));
            this.pictureBoxGeogebra.Location = new System.Drawing.Point(550, 515);
            this.pictureBoxGeogebra.Name = "pictureBoxGeogebra";
            this.pictureBoxGeogebra.Size = new System.Drawing.Size(144, 87);
            this.pictureBoxGeogebra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGeogebra.TabIndex = 9;
            this.pictureBoxGeogebra.TabStop = false;
            this.pictureBoxGeogebra.Visible = false;
            this.pictureBoxGeogebra.Click += new System.EventHandler(this.pictureBoxGeogebra_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 704);
            this.panel1.TabIndex = 10;
            // 
            // lb_VisualizarGrafico
            // 
            this.lb_VisualizarGrafico.AutoSize = true;
            this.lb_VisualizarGrafico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VisualizarGrafico.Location = new System.Drawing.Point(306, 540);
            this.lb_VisualizarGrafico.Name = "lb_VisualizarGrafico";
            this.lb_VisualizarGrafico.Size = new System.Drawing.Size(220, 32);
            this.lb_VisualizarGrafico.TabIndex = 11;
            this.lb_VisualizarGrafico.Text = "Visualizar o gráfico:";
            this.lb_VisualizarGrafico.Visible = false;
            // 
            // F_Lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(937, 700);
            this.Controls.Add(this.lb_VisualizarGrafico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxGeogebra);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAngulo);
            this.Controls.Add(this.linkLabelEquacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLimite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Lancamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Lancamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeogebra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelEquacao;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBoxGeogebra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_VisualizarGrafico;
    }
}