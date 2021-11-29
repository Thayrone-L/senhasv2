
namespace senhasv2.Apresentacao
{
    partial class f_CadastroUsuarios
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
            this.campoUsuario = new System.Windows.Forms.ComboBox();
            this.campoPlataforma = new System.Windows.Forms.ComboBox();
            this.rb_SenhaAleatoria = new System.Windows.Forms.RadioButton();
            this.rb_SenhaPropria = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_forcaSenha = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.Button();
            this.v2 = new System.Windows.Forms.Button();
            this.v3 = new System.Windows.Forms.Button();
            this.v4 = new System.Windows.Forms.Button();
            this.v5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.tb_ConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoUsuario
            // 
            this.campoUsuario.FormattingEnabled = true;
            this.campoUsuario.Location = new System.Drawing.Point(12, 51);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(181, 21);
            this.campoUsuario.TabIndex = 0;
            // 
            // campoPlataforma
            // 
            this.campoPlataforma.FormattingEnabled = true;
            this.campoPlataforma.Location = new System.Drawing.Point(199, 51);
            this.campoPlataforma.Name = "campoPlataforma";
            this.campoPlataforma.Size = new System.Drawing.Size(339, 21);
            this.campoPlataforma.TabIndex = 1;
            // 
            // rb_SenhaAleatoria
            // 
            this.rb_SenhaAleatoria.AutoSize = true;
            this.rb_SenhaAleatoria.Location = new System.Drawing.Point(12, 174);
            this.rb_SenhaAleatoria.Name = "rb_SenhaAleatoria";
            this.rb_SenhaAleatoria.Size = new System.Drawing.Size(119, 17);
            this.rb_SenhaAleatoria.TabIndex = 3;
            this.rb_SenhaAleatoria.TabStop = true;
            this.rb_SenhaAleatoria.Text = "Usar senha aleatóia";
            this.rb_SenhaAleatoria.UseVisualStyleBackColor = true;
            this.rb_SenhaAleatoria.CheckedChanged += new System.EventHandler(this.rb_SenhaAleatoria_CheckedChanged);
            // 
            // rb_SenhaPropria
            // 
            this.rb_SenhaPropria.AutoSize = true;
            this.rb_SenhaPropria.Location = new System.Drawing.Point(172, 174);
            this.rb_SenhaPropria.Name = "rb_SenhaPropria";
            this.rb_SenhaPropria.Size = new System.Drawing.Size(114, 17);
            this.rb_SenhaPropria.TabIndex = 4;
            this.rb_SenhaPropria.TabStop = true;
            this.rb_SenhaPropria.Text = "Usar senha propria";
            this.rb_SenhaPropria.UseVisualStyleBackColor = true;
            this.rb_SenhaPropria.CheckedChanged += new System.EventHandler(this.rb_SenhaPropria_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senha:";
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(12, 95);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(274, 20);
            this.tb_Senha.TabIndex = 6;
            this.tb_Senha.TextChanged += new System.EventHandler(this.tb_Senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plataforma";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 195);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Definir parâmetros manualmente";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_forcaSenha
            // 
            this.lbl_forcaSenha.AutoSize = true;
            this.lbl_forcaSenha.Location = new System.Drawing.Point(84, 27);
            this.lbl_forcaSenha.Name = "lbl_forcaSenha";
            this.lbl_forcaSenha.Size = new System.Drawing.Size(81, 13);
            this.lbl_forcaSenha.TabIndex = 10;
            this.lbl_forcaSenha.Text = "Força da senha";
            // 
            // v1
            // 
            this.v1.Enabled = false;
            this.v1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v1.ForeColor = System.Drawing.Color.Transparent;
            this.v1.Location = new System.Drawing.Point(66, 44);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(20, 5);
            this.v1.TabIndex = 11;
            this.v1.UseVisualStyleBackColor = true;
            this.v1.Visible = false;
            // 
            // v2
            // 
            this.v2.Enabled = false;
            this.v2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v2.ForeColor = System.Drawing.Color.Transparent;
            this.v2.Location = new System.Drawing.Point(86, 44);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(20, 5);
            this.v2.TabIndex = 12;
            this.v2.UseVisualStyleBackColor = true;
            this.v2.Visible = false;
            // 
            // v3
            // 
            this.v3.Enabled = false;
            this.v3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v3.ForeColor = System.Drawing.Color.Transparent;
            this.v3.Location = new System.Drawing.Point(106, 44);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(20, 5);
            this.v3.TabIndex = 13;
            this.v3.UseVisualStyleBackColor = true;
            this.v3.Visible = false;
            // 
            // v4
            // 
            this.v4.Enabled = false;
            this.v4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v4.ForeColor = System.Drawing.Color.Transparent;
            this.v4.Location = new System.Drawing.Point(126, 44);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(20, 5);
            this.v4.TabIndex = 14;
            this.v4.UseVisualStyleBackColor = true;
            this.v4.Visible = false;
            // 
            // v5
            // 
            this.v5.Enabled = false;
            this.v5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v5.ForeColor = System.Drawing.Color.Transparent;
            this.v5.Location = new System.Drawing.Point(146, 44);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(20, 5);
            this.v5.TabIndex = 15;
            this.v5.UseVisualStyleBackColor = true;
            this.v5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.v5);
            this.groupBox1.Controls.Add(this.v4);
            this.groupBox1.Controls.Add(this.v3);
            this.groupBox1.Controls.Add(this.v2);
            this.groupBox1.Controls.Add(this.v1);
            this.groupBox1.Controls.Add(this.lbl_forcaSenha);
            this.groupBox1.Location = new System.Drawing.Point(292, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 70);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Força da senha";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(378, 184);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 17;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(462, 184);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // tb_ConfirmaSenha
            // 
            this.tb_ConfirmaSenha.Location = new System.Drawing.Point(12, 138);
            this.tb_ConfirmaSenha.Name = "tb_ConfirmaSenha";
            this.tb_ConfirmaSenha.Size = new System.Drawing.Size(274, 20);
            this.tb_ConfirmaSenha.TabIndex = 20;
            this.tb_ConfirmaSenha.TextChanged += new System.EventHandler(this.tb_ConfirmaSenha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Confirma senha:";
            // 
            // f_CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(550, 222);
            this.Controls.Add(this.tb_ConfirmaSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_SenhaPropria);
            this.Controls.Add(this.rb_SenhaAleatoria);
            this.Controls.Add(this.campoPlataforma);
            this.Controls.Add(this.campoUsuario);
            this.Name = "f_CadastroUsuarios";
            this.Text = "Cadastrar novo usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_CadastroUsuarios_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox campoUsuario;
        private System.Windows.Forms.ComboBox campoPlataforma;
        private System.Windows.Forms.RadioButton rb_SenhaAleatoria;
        private System.Windows.Forms.RadioButton rb_SenhaPropria;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_forcaSenha;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Button v2;
        private System.Windows.Forms.Button v3;
        private System.Windows.Forms.Button v4;
        private System.Windows.Forms.Button v5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.TextBox tb_ConfirmaSenha;
        private System.Windows.Forms.Label label4;
    }
}