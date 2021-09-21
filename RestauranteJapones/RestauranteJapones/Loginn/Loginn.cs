using RestauranteJapones.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestauranteJapones
{
    public partial class Loginn : Form
    {
        SqlConnection con = new SqlConnection();
        public Loginn()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = DESKTOP-BNAKC3R;Initial Catalog = Restaurante_Japones; user = sa; password= 1234567";
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            RestauranteJapones.Login.ControleLogin controle = new RestauranteJapones.Login.ControleLogin();

            controle.Acessar(txtUsuario.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
                if (controle.T)
                {
                    MessageBox.Show("Usuario Logado com Sucesso", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Consultaa con = new Consultaa();
                    this.Hide();
                    con.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Senha Invalidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void picbLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
