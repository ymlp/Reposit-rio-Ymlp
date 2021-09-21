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
    public partial class Fornecedor : Form
    {
        string connectionString = @"Data Source=DESKTOP-BD3ROGM;Initial Catalog=Restaurante_Japones; user=sa; password=1234567";

        public Fornecedor()
        {
            InitializeComponent();
            cbBusca.SelectedItem = "Nome";
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM fornecedor", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvForn.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_fornecedor,razao_social_fornecedor,cnpj_fornecedor,telefone_fornecedor,celular_fornecedor,email_fornecedor,rua_fornecedor,numero_rua_fornecedor,complemento_rua_fornecedor,cep_fornecedor,bairro_fornecedor,cidade_fornecedor,uf_fornecedor FROM fornecedor WHERE razao_social_fornecedor LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvForn.DataSource = busca;
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

            while(cbBusca.Text=="CNPJ")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_fornecedor,razao_social_fornecedor,cnpj_fornecedor,telefone_fornecedor,celular_fornecedor,email_fornecedor,rua_fornecedor,numero_rua_fornecedor,complemento_rua_fornecedor,cep_fornecedor,bairro_fornecedor,cidade_fornecedor,uf_fornecedor FROM fornecedor WHERE cnpj_fornecedor LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvForn.DataSource = busca;
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
                    MessageBox.Show("Insira uma referência primeiro");
                }
                return;
            }          
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
