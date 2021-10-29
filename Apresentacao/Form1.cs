using senhasv2.Apresentacao;
using senhasv2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senhasv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Cadastro cad = new frm_Cadastro();
            cad.Show();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (tb_User.Text == "" || tb_Key.Text == "")
            {
                MessageBox.Show("Preencha todos os dados antes de logar no sistema", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Controle controle = new Controle();
                controle.acessar(tb_User.Text, tb_Key.Text);
                if (controle.tem)
                {
                   
                    f_Principal entra = new f_Principal();
                    entra.Show();
                    this.Hide();
       
                
                }
                else
                {
                    MessageBox.Show("Dados inválidos, verifique os dados ou crie um novo usuário", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

            }
        }
    }
}
