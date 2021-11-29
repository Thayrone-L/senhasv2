using senhasv2.DAL;
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
using static senhasv2.DAL.LoginDALcomandos;

namespace senhasv2.Apresentacao
{   
    public partial class f_Principal : Form
    {

      
     

        public f_Principal()
        {
            InitializeComponent();
           Text = " Bem vindo " + Dadosdelogin.nomeUsuario + "!";
          
            
        }

        private void f_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'senhasDataSet.users'. Você pode movê-la ou removê-la conforme necessário.
            try
            {
                this.usersTableAdapter.FillBy(this.senhasDataSet.users, Dadosdelogin.nomeUsuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            label5.Text = senhasDataSet.users.Count.ToString();
        }

        public void loaddata()
        {
            try
            {
                this.usersTableAdapter.FillBy(this.senhasDataSet.users, Dadosdelogin.nomeUsuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            f_GeraSenha gerasenha = new f_GeraSenha();
            gerasenha.Show();
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_CadastroUsuarios cadastroUsuarios = new f_CadastroUsuarios(this);
            cadastroUsuarios.Show();

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            f_CadastroUsuarios cadastroUsuarios = new f_CadastroUsuarios(this);
            cadastroUsuarios.Show();
        }

       

       
    }
}
