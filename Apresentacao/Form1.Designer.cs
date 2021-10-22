
namespace senhasv2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.bnt_Exit = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(213, 108);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "Entrar";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // bnt_Exit
            // 
            this.bnt_Exit.Location = new System.Drawing.Point(345, 108);
            this.bnt_Exit.Name = "bnt_Exit";
            this.bnt_Exit.Size = new System.Drawing.Size(75, 23);
            this.bnt_Exit.TabIndex = 2;
            this.bnt_Exit.Text = "Sair";
            this.bnt_Exit.UseVisualStyleBackColor = true;
            this.bnt_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(157, 20);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(58, 16);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "Usuário:";
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key.Location = new System.Drawing.Point(157, 61);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(50, 16);
            this.lbl_Key.TabIndex = 4;
            this.lbl_Key.Text = "Senha:";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(213, 20);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(207, 20);
            this.tb_User.TabIndex = 5;
            // 
            // tb_Key
            // 
            this.tb_Key.Location = new System.Drawing.Point(213, 61);
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.PasswordChar = '*';
            this.tb_Key.Size = new System.Drawing.Size(207, 20);
            this.tb_Key.TabIndex = 6;
            // 
            // linkCadastro
            // 
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Location = new System.Drawing.Point(157, 141);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(52, 13);
            this.linkCadastro.TabIndex = 7;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Cadastrar";
            this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(443, 174);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.tb_Key);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.bnt_Exit);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button bnt_Exit;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.LinkLabel linkCadastro;
    }
}

