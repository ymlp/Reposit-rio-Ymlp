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
    public partial class Estoque : Form
    {
        string connectionString = @"Data Source=DESKTOP-BD3ROGM;Initial Catalog=Restaurante_Japones; user=sa; password=1234567";
        public Estoque()
        {
            InitializeComponent();
            cbBusca.SelectedItem = "Nome";
        }

        private void btnEstoq_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM estoque", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvEstoq.DataSource = dtbl;

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

        private void Estoque_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {


                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM estoque", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvEstoq.DataSource = dtbl;

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
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_estoque,id_produto,nome_produto,descricao_produto,tipo_produto,quantidade_produto,unidade,simbolo_unidade,valor_unitario_produto,valor_produto_estoque,validade_produto FROM estoque WHERE nome_produto LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvEstoq.DataSource = busca;
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
                        
            while(cbBusca.Text == "Tipo")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        { 
                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_estoque,id_produto,nome_produto,descricao_produto,tipo_produto,quantidade_produto,unidade,simbolo_unidade,valor_unitario_produto,valor_produto_estoque,validade_produto FROM estoque WHERE tipo_produto LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvEstoq.DataSource = busca;
                            
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
   
            while(cbBusca.Text == "ID Produto")
            {
                if (txtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_estoque,id_produto,nome_produto,descricao_produto,tipo_produto,quantidade_produto,unidade,simbolo_unidade,valor_unitario_produto,valor_produto_estoque,validade_produto FROM estoque WHERE id_produto LIKE '%" + txtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvEstoq.DataSource = busca;
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

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
