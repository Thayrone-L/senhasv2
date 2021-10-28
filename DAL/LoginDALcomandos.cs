using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senhasv2.DAL
{
    class LoginDALcomandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public static class Dadosdelogin
        {
            public static string nomeUsuario;
        }

        public bool verificarLogin(String login, String senha)
        {
            
            cmd.CommandText = "SELECT * FROM usuarios_sistema WHERE [USER] = @login AND SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) 
                {
                    Dadosdelogin.nomeUsuario = login;
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro no banco de dados";
            }

            return tem;
        }

        public string cadastrar(String login, String senha, String ConfirmaSenha)
        {
            tem = false;
            if (senha.Equals(ConfirmaSenha)) 
            {
                cmd.CommandText = "INSERT INTO usuarios_sistema VALUES (@u, @s); ";
                cmd.Parameters.AddWithValue("@u", login);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Falha no banco de dados";
                }

            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
