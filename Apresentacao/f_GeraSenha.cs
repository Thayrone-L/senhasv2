using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace senhasv2.Apresentacao
{
    public partial class f_GeraSenha : Form
    {
        f_CadastroUsuarios instanciaf_CadastroUsuarios;
        

        public f_GeraSenha(f_CadastroUsuarios f_Cadastro = null)
        {
            InitializeComponent();
            instanciaf_CadastroUsuarios = f_Cadastro;
            
        }

        /*
        public f_GeraSenha(f_Principal f_Principal)
        {
            this.f_Principal = f_Principal;
        }
        */
        public static string gerasenha(int tamanho, bool temMaiuscula, bool temNumero, bool temSimbolo )
        {
            var charsbase = "abcdefghijklmnopqrstuvwxyz";
            var Maiusculas = "";
            var Numeros = "";
            var Simbilos = "";
            

            if (temMaiuscula)
            {
                Maiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (temNumero)
            {
                Numeros = "0123456789";
            }
            if (temSimbolo)
            {
                Simbilos = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            }



            string finalchars = charsbase + Maiusculas + Numeros +Simbilos ;


            var random = new Random();
            var result = new string(
                Enumerable.Repeat(finalchars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {

            int numero;
            if (int.TryParse(tb_Qtd.Text, out numero))
            {
                tb_Senha.Text = gerasenha(numero, cb_maiusculas.Checked ,cb_numeros.Checked,cb_simbolos.Checked);
            }
            else
            {
                MessageBox.Show("Digite um numero", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Qtd.Clear();
            }
            
        }

        private void f_GeraSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<f_CadastroUsuarios>().Count()>0) { 
            instanciaf_CadastroUsuarios.tb_Senha.Text = tb_Senha.Text;
            instanciaf_CadastroUsuarios.tb_Senha.Refresh();

            }
            
        }
    }
}
