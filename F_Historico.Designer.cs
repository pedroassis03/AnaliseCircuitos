namespace AnaliseCircuitos
{
    partial class F_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Historico));
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLancamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSistema
            // 
            this.btnSistema.BackColor = System.Drawing.SystemColors.Control;
            this.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Location = new System.Drawing.Point(226, 237);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(206, 135);
            this.btnSistema.TabIndex = 0;
            this.btnSistema.Text = "Histórico Circuitos";
            this.btnSistema.UseVisualStyleBackColor = false;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(226, 424);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(474, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLancamento
            // 
            this.btnLancamento.BackColor = System.Drawing.SystemColors.Control;
            this.btnLancamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancamento.FlatAppearance.BorderSize = 0;
            this.btnLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamento.Location = new System.Drawing.Point(494, 237);
            this.btnLancamento.Name = "btnLancamento";
            this.btnLancamento.Size = new System.Drawing.Size(206, 135);
            this.btnLancamento.TabIndex = 2;
            this.btnLancamento.Text = "Histórico Lançamentos";
            this.btnLancamento.UseVisualStyleBackColor = false;
            this.btnLancamento.Click += new System.EventHandler(this.btnLancamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qual histórico você deseja visualizar:";
            // 
            // F_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(937, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLancamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLancamento;
        private System.Windows.Forms.Label label1;
    }
}