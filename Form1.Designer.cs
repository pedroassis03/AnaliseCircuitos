﻿namespace AnaliseCircuitos
{
    partial class F_Sistemas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_numEquacoes = new System.Windows.Forms.Label();
            this.tb_numEquacoes = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_CalcularSistema = new System.Windows.Forms.Button();
            this.pnl_Equacoes = new System.Windows.Forms.Panel();
            this.pn_Circuitos_Menu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_numEquacoes
            // 
            this.lb_numEquacoes.AutoSize = true;
            this.lb_numEquacoes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numEquacoes.Location = new System.Drawing.Point(323, 21);
            this.lb_numEquacoes.Name = "lb_numEquacoes";
            this.lb_numEquacoes.Size = new System.Drawing.Size(372, 28);
            this.lb_numEquacoes.TabIndex = 0;
            this.lb_numEquacoes.Text = "Digite o número de equações do sistema:";
            // 
            // tb_numEquacoes
            // 
            this.tb_numEquacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numEquacoes.Location = new System.Drawing.Point(729, 21);
            this.tb_numEquacoes.Name = "tb_numEquacoes";
            this.tb_numEquacoes.Size = new System.Drawing.Size(194, 30);
            this.tb_numEquacoes.TabIndex = 1;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.Location = new System.Drawing.Point(328, 66);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(595, 39);
            this.btn_Confirmar.TabIndex = 2;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Location = new System.Drawing.Point(328, 653);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(595, 39);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "Limpar Tudo";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_CalcularSistema
            // 
            this.btn_CalcularSistema.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_CalcularSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CalcularSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularSistema.Location = new System.Drawing.Point(328, 608);
            this.btn_CalcularSistema.Name = "btn_CalcularSistema";
            this.btn_CalcularSistema.Size = new System.Drawing.Size(595, 39);
            this.btn_CalcularSistema.TabIndex = 4;
            this.btn_CalcularSistema.Text = "Calcular Sistema";
            this.btn_CalcularSistema.UseVisualStyleBackColor = false;
            this.btn_CalcularSistema.Visible = false;
            this.btn_CalcularSistema.Click += new System.EventHandler(this.btn_CalcularSistema_Click);
            // 
            // pnl_Equacoes
            // 
            this.pnl_Equacoes.Location = new System.Drawing.Point(328, 111);
            this.pnl_Equacoes.Name = "pnl_Equacoes";
            this.pnl_Equacoes.Size = new System.Drawing.Size(595, 491);
            this.pnl_Equacoes.TabIndex = 5;
            // 
            // pn_Circuitos_Menu
            // 
            this.pn_Circuitos_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.pn_Circuitos_Menu.Location = new System.Drawing.Point(0, -1);
            this.pn_Circuitos_Menu.Name = "pn_Circuitos_Menu";
            this.pn_Circuitos_Menu.Size = new System.Drawing.Size(299, 703);
            this.pn_Circuitos_Menu.TabIndex = 6;
            // 
            // F_Sistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(937, 700);
            this.Controls.Add(this.pn_Circuitos_Menu);
            this.Controls.Add(this.pnl_Equacoes);
            this.Controls.Add(this.btn_CalcularSistema);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.tb_numEquacoes);
            this.Controls.Add(this.lb_numEquacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Sistemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise de Circuitos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_numEquacoes;
        private System.Windows.Forms.TextBox tb_numEquacoes;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_CalcularSistema;
        private System.Windows.Forms.Panel pnl_Equacoes;
        private System.Windows.Forms.Panel pn_Circuitos_Menu;
    }
}

