using senhasv2.DAL;
using senhasv2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static senhasv2.Apresentacao.f_GeraSenha;
using static senhasv2.DAL.LoginDALcomandos;
using static senhasv2.Modelo.ChecaForcaSenha;
namespace senhasv2.Apresentacao
{
    public partial class f_CadastroUsuarios : Form
    {

        public void carregaForm()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;
            cmd.CommandText = " SELECT User_Plataforma, Plataformas, Senha FROM dbo.users WHERE User_Name = @login";
            cmd.Parameters.AddWithValue("@login", Dadosdelogin.nomeUsuario);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {


                campoUsuario.Items.Add(dr[0]);
                campoPlataforma.Items.Add(dr[1]);
                

            }
            dr.Close();
            dr.Dispose();
            con.desconectar();
        }


        f_Principal obj = (f_Principal)Application.OpenForms["f_Principal"];
       

        public f_CadastroUsuarios(Form principal)
        {
            InitializeComponent();
            rb_SenhaAleatoria.Checked = true;
            carregaForm();
           

            
        }

        private void rb_SenhaAleatoria_CheckedChanged(object sender, EventArgs e)
        {
            tb_Senha.Text = gerasenha(8, true, true, true);
            tb_ConfirmaSenha.Text = tb_Senha.Text;
        }

        private void rb_SenhaPropria_CheckedChanged(object sender, EventArgs e)
        {
            tb_Senha.Text = "";
            tb_ConfirmaSenha.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_GeraSenha f_GeraSenha = new f_GeraSenha(this);
            f_GeraSenha.Show();
        }

        private void tb_Senha_TextChanged(object sender, EventArgs e)
        {
           
                if (tb_Senha.Text != string.Empty)
                {
                    ChecaForcaSenha verifica = new ChecaForcaSenha();

                    ForcaDaSenha forca;


                    forca = verifica.GetForcaDaSenha(tb_Senha.Text);


                    lbl_forcaSenha.Text = forca.ToString();
                    if (lbl_forcaSenha.Text == "Forte")
                    {
                        lbl_forcaSenha.ForeColor = Color.Green;
                        v1.Visible = true;
                        v1.BackColor = Color.Green;
                        v2.Visible = true;
                        v2.BackColor = Color.Green;
                        v3.Visible = true;
                        v3.BackColor = Color.Green;
                        v4.Visible = true;
                        v4.BackColor = Color.Green;
                        v5.Visible = true;
                        v5.BackColor = Color.Green;

                    }
                    else if (lbl_forcaSenha.Text == "Segura")
                    {
                        lbl_forcaSenha.ForeColor = Color.Green;
                        v1.Visible = true;
                        v1.BackColor = Color.Green;
                        v2.Visible = true;
                        v2.BackColor = Color.Green;
                        v3.Visible = true;
                        v3.BackColor = Color.Green;
                        v4.Visible = true;
                        v4.BackColor = Color.Green;
                        v5.Visible = false;

                    }
                    else if (lbl_forcaSenha.Text == "Aceitavel")
                    {
                        lbl_forcaSenha.ForeColor = Color.Yellow;
                        v1.Visible = true;
                        v1.BackColor = Color.Yellow;
                        v2.Visible = true;
                        v2.BackColor = Color.Yellow;
                        v3.Visible = true;
                        v3.BackColor = Color.Yellow;

                        v4.Visible = false;
                        v5.Visible = false;


                    }
                    else if (lbl_forcaSenha.Text == "Fraca")
                    {
                        lbl_forcaSenha.ForeColor = Color.Red;
                        v1.Visible = true;
                        v1.BackColor = Color.Red;
                        v2.Visible = true;
                        v2.BackColor = Color.Red;
                        v3.Visible = false;
                        v4.Visible = false;
                        v5.Visible = false;

                    }
                    else if (lbl_forcaSenha.Text == "Inaceitavel")
                    {
                        lbl_forcaSenha.ForeColor = Color.Red;
                        v1.Visible = true;
                        v1.BackColor = Color.Red;
                        v2.Visible = false;
                        v3.Visible = false;
                        v4.Visible = false;
                        v5.Visible = false;
                    }
                    else
                    {
                        lbl_forcaSenha.ForeColor = Color.Black;
                        v1.Visible = false;
                        v2.Visible = false;
                        v3.Visible = false;
                        v4.Visible = false;
                        v5.Visible = false;
                    }
                }
                else
                {

                    lbl_forcaSenha.ForeColor = Color.Black;

                    lbl_forcaSenha.Text = "Insira uma senha";
                    v1.Visible = false;
                    v2.Visible = false;
                    v3.Visible = false;
                    v4.Visible = false;
                    v5.Visible = false;


                }
           
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O registro atual não foi salvo, Deseja mesmo sair sem salvar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tb_ConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (tb_Senha.Text != tb_ConfirmaSenha.Text)
            {
                lbl_forcaSenha.Text = "Senhas não conferem";
                lbl_forcaSenha.ForeColor = Color.Red;
                v1.Visible = false;
                v2.Visible = false;
                v3.Visible = false;
                v4.Visible = false;
                v5.Visible = false;
            }
            
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrarUser(campoPlataforma.Text, tb_Senha.Text, campoUsuario.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           
           

        }

        private void f_CadastroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
