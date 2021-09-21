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

namespace RestauranteJapones.Consulta
{
    public partial class Cliente : Form
    {
        string connectionString= @"Data Source=LOPESKUN\SQLEXPRESS;Initial Catalog=RestauranteTCM; user=sa; password=05386070";

        public Cliente()
        {
            InitializeComponent();
            cbBusca.SelectedItem = "Nome";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {


                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM cliente", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvCli.AutoGenerateColumns = false;
                    dgvCli.DataSource = dtbl;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

		private void Cliente_Load(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                   con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM cliente", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvCli.AutoGenerateColumns = false;
                    dgvCli.DataSource = dtbl;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            while (cbBusca.Text =="Nome")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {

                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_cliente,nome_cliente,sobrenome_cliente,telefone_cliente,celular_cliente,email_cliente,cpf_cliente,rua_cliente,numero_rua_cliente,complemento_rua_cliente,cep_cliente,bairro_cliente,cidade_cliente,uf_cliente FROM cliente WHERE nome_cliente LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvCli.DataSource = busca;

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
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_cliente,nome_cliente,sobrenome_cliente,telefone_cliente,celular_cliente,email_cliente,cpf_cliente,rua_cliente,numero_rua_cliente,complemento_rua_cliente,cep_cliente,bairro_cliente,cidade_cliente,uf_cliente FROM cliente WHERE sobrenome_cliente LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvCli.DataSource = busca;

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
             
                
            while(cbBusca.Text =="CPF")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {


                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_cliente,nome_cliente,sobrenome_cliente,telefone_cliente,celular_cliente,email_cliente,cpf_cliente,rua_cliente,numero_rua_cliente,complemento_rua_cliente,cep_cliente,bairro_cliente,cidade_cliente,uf_cliente FROM cliente WHERE cpf_cliente LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvCli.DataSource = busca;

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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}