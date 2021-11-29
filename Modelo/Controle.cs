using senhasv2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senhasv2.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";


        public bool acessar(String login, String senha)
        {
            LoginDALcomandos loginDal = new LoginDALcomandos();
            tem = loginDal.verificarLogin(login,senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }
        public string cadastrar(String login, String senha, String ConfirmaSenha)  
        {
            LoginDALcomandos loginDAL = new LoginDALcomandos();
              this.mensagem = loginDAL.cadastrar(login, senha, ConfirmaSenha);
            if (loginDAL.tem)
            {

                this.tem = true;
            }
            return mensagem;
        }
        public string cadastrarUser(String login, String plataforma, String senha)
        {
            LoginDALcomandos loginDAL = new LoginDALcomandos();
            this.mensagem = loginDAL.cadastrarUser(login, plataforma, senha);
            if (loginDAL.tem)
            {

                this.tem = true;
            }
            return mensagem;
        }
    }
}
