
namespace senhasv2.Apresentacao
{
    partial class f_GeraSenha
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
            this.tb_Qtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_numeros = new System.Windows.Forms.CheckBox();
            this.cb_simbolos = new System.Windows.Forms.CheckBox();
            this.cb_maiusculas = new System.Windows.Forms.CheckBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.lbl_SenhaGerada = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Qtd
            // 
            this.tb_Qtd.Location = new System.Drawing.Point(22, 41);
            this.tb_Qtd.Name = "tb_Qtd";
            this.tb_Qtd.Size = new System.Drawing.Size(130, 20);
            this.tb_Qtd.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quantidade de caracteres:";
            // 
            // cb_numeros
            // 
            this.cb_numeros.AutoSize = true;
            this.cb_numeros.Location = new System.Drawing.Point(22, 90);
            this.cb_numeros.Name = "cb_numeros";
            this.cb_numeros.Size = new System.Drawing.Size(94, 17);
            this.cb_numeros.TabIndex = 14;
            this.cb_numeros.Text = "Inclui numeros";
            this.cb_numeros.UseVisualStyleBackColor = true;
            // 
            // cb_simbolos
            // 
            this.cb_simbolos.AutoSize = true;
            this.cb_simbolos.Location = new System.Drawing.Point(22, 113);
            this.cb_simbolos.Name = "cb_simbolos";
            this.cb_simbolos.Size = new System.Drawing.Size(94, 17);
            this.cb_simbolos.TabIndex = 13;
            this.cb_simbolos.Text = "Inclui simbolos";
            this.cb_simbolos.UseVisualStyleBackColor = true;
            // 
            // cb_maiusculas
            // 
            this.cb_maiusculas.AutoSize = true;
            this.cb_maiusculas.Location = new System.Drawing.Point(22, 67);
            this.cb_maiusculas.Name = "cb_maiusculas";
            this.cb_maiusculas.Size = new System.Drawing.Size(106, 17);
            this.cb_maiusculas.TabIndex = 12;
            this.cb_maiusculas.Text = "Inclui maiúsculas";
            this.cb_maiusculas.UseVisualStyleBackColor = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(150, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(172, 24);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "Gerador de senhas";
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(197, 229);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(75, 23);
            this.btn_gerar.TabIndex = 10;
            this.btn_gerar.Text = "Gerar senha";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Qtd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_numeros);
            this.groupBox1.Controls.Add(this.cb_simbolos);
            this.groupBox1.Controls.Add(this.cb_maiusculas);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 153);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Senha);
            this.groupBox2.Controls.Add(this.lbl_SenhaGerada);
            this.groupBox2.Location = new System.Drawing.Point(197, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 153);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Senha";
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(6, 22);
            this.tb_Senha.Multiline = true;
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(261, 125);
            this.tb_Senha.TabIndex = 1;
            // 
            // lbl_SenhaGerada
            // 
            this.lbl_SenhaGerada.AutoSize = true;
            this.lbl_SenhaGerada.Location = new System.Drawing.Point(17, 25);
            this.lbl_SenhaGerada.Name = "lbl_SenhaGerada";
            this.lbl_SenhaGerada.Size = new System.Drawing.Size(0, 13);
            this.lbl_SenhaGerada.TabIndex = 0;
            // 
            // f_GeraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(482, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_gerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "f_GeraSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senhas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_GeraSenha_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Qtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_numeros;
        private System.Windows.Forms.CheckBox cb_simbolos;
        private System.Windows.Forms.CheckBox cb_maiusculas;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_SenhaGerada;
        private System.Windows.Forms.TextBox tb_Senha;
    }
}