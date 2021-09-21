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
    public partial class Funcionario : Form
    {
        string connectionString = @"Data Source=DESKTOP-BD3ROGM;Initial Catalog=Restaurante_Japones; user=sa; password=1234567";
        public Funcionario()
        {
            InitializeComponent();
            cbBusca.SelectedItem = "Nome";
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {


                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM funcionario", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvFunc.DataSource = dtbl;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            while(cbBusca.Text == "Nome")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {                           
                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_funcionario,nome_funcionario,sobrenome_funcionario,telefone_funcionario,celular_funcionario,email_funcionario,rua_funcionario,numero_rua_funcionarior,complemento_rua_funcionario,cep_funcionario,bairro_funcionario,cidade_for_funcionario,uf_funcionario,usuario FROM usuario WHERE nome_usuario LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvFunc.DataSource = busca;                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro:\n" + ex.Message.ToString());
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insira alguma referência primeiro.");
                }
                return;
            }
                       
            while(cbBusca.Text == "Sobrenome")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_funcionario,nome_funcionario,sobrenome_funcionario,telefone_funcionario,celular_funcionario,email_funcionario,rua_funcionario,numero_rua_funcionarior,complemento_rua_funcionario,cep_funcionario,bairro_funcionario,cidade_for_funcionario,uf_funcionario,usuario FROM usuario WHERE sobrenome_usuario LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvFunc.DataSource = busca;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro:\n" + ex.Message.ToString());
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insira alguma referência primeiro.");
                }
                return;
            }                         
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM funcionario", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvFunc.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
