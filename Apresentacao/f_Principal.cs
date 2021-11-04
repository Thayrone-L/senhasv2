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



        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public f_Principal()
        {
            InitializeComponent();
            label2.Text = " Bem vindo " + Dadosdelogin.nomeUsuario + "!";
            
        }

        private void f_Principal_Load(object sender, EventArgs e)
        {
           
            cmd.CommandText = " SELECT User_Name, Plataformas, Senha FROM dbo.users WHERE User_Name = @login";
            cmd.Parameters.AddWithValue("@login", Dadosdelogin.nomeUsuario);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();


            int contador = 0;
            while (dr.Read())
            {

                /* os as tres colunas em uma linha apenas
                 * 
                 * 
                 * 
                string[] stdr = { "Nome de Usuário:       ", dr[0].ToString(), "Plataforma:       ", dr[1].ToString(), "Senha:       ", dr[2].ToString() };
               
                listBox1.Items.Add(String.Concat(stdr)); */
                contador++;
                listBox1.Items.Add(dr[0]);
                listBox2.Items.Add(dr[1]);
                listBox3.Items.Add(dr[2]);

            }
            dr.Close();
            dr.Dispose();
            con.desconectar();

            label5.Text = contador.ToString();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            listBox1.SelectedIndex = listBox3.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_GeraSenha gerasenha = new f_GeraSenha();
            gerasenha.Show();
            
        }
    }
}
