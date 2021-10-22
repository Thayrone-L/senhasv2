
namespace senhasv2.Apresentacao
{
    partial class frm_Cadastro
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.tb_ConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lbl_Criar = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(16, 48);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(58, 16);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Usuário:";
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key.Location = new System.Drawing.Point(16, 100);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(47, 16);
            this.lbl_Key.TabIndex = 1;
            this.lbl_Key.Text = "Senha";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(16, 67);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(187, 20);
            this.tb_User.TabIndex = 3;
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(16, 119);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(187, 20);
            this.tb_Senha.TabIndex = 4;
            // 
            // tb_ConfirmaSenha
            // 
            this.tb_ConfirmaSenha.Location = new System.Drawing.Point(16, 175);
            this.tb_ConfirmaSenha.Name = "tb_ConfirmaSenha";
            this.tb_ConfirmaSenha.Size = new System.Drawing.Size(187, 20);
            this.tb_ConfirmaSenha.TabIndex = 5;
            // 
            // lbl_Criar
            // 
            this.lbl_Criar.AutoSize = true;
            this.lbl_Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Criar.Location = new System.Drawing.Point(48, 9);
            this.lbl_Criar.Name = "lbl_Criar";
            this.lbl_Criar.Size = new System.Drawing.Size(125, 16);
            this.lbl_Criar.TabIndex = 6;
            this.lbl_Criar.Text = "Criar novo cadastro";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(16, 217);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(128, 217);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirme a senha";
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(221, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Criar);
            this.Controls.Add(this.tb_ConfirmaSenha);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.lbl_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.TextBox tb_ConfirmaSenha;
        private System.Windows.Forms.Label lbl_Criar;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label1;
    }
}