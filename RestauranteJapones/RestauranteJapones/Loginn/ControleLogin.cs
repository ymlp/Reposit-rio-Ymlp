using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestauranteJapones.Login
{
    class ControleLogin
    {
        public bool T;
        public string mensagem = "";

        public bool Acessar(string usuario, string senha)
        {
            ComandosLogin lcomando = new ComandosLogin();
            SqlCommand cmd = new SqlCommand();
            T = lcomando.VerificarLogin(usuario, senha);
            if (!lcomando.mensagem.Equals(""))
            {
                this.mensagem = lcomando.mensagem;
            }
            return T;

        }
    }
}
