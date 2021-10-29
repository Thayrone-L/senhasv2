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
            /* try
             {
                 this.usersTableAdapter.FillByLogin(this.senhasDataSet.users, Dadosdelogin.nomeUsuario);
             }
             catch (System.Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }*/
           


            cmd.CommandText = " SELECT User_Name, Plataformas, Senha FROM dbo.users WHERE User_Name = @login";
            cmd.Parameters.AddWithValue("@login", Dadosdelogin.nomeUsuario);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]);
                listBox2.Items.Add(dr[1]);
                listBox3.Items.Add(dr[2]);
            }
            dr.Close();
            dr.Dispose();
            con.desconectar();
        }

      
    }
}
