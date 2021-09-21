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
    public partial class Item : Form
    {
        string connectionString = @"Data Source=LOPESKUN\SQLEXPRESS;Initial Catalog=RestauranteTCM; user=sa; password=05386070";

        public Item()
        {
            InitializeComponent();
            
        }

        private void Cardapiobf_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT nome_item FROM item", con);
                    comm.CommandTimeout = 0;
                    SqlDataAdapter sqlDa = new SqlDataAdapter(comm);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    cbNome.DataSource = dtbl;
                    cbNome.DisplayMember = "nome_item";
                    cbNome.ValueMember = "nome_item";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
            

        }

        private void cbNome_SelectedValueChanged(object sender, EventArgs e)
        {
            string a = cbNome.Text.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter nome = new SqlDataAdapter("SELECT nome_item, valor_item,descricao_item FROM item WHERE nome_item LIKE '%" + a + "%' ", con);
                    DataTable nom = new DataTable();
                    nome.Fill(nom);

                    dgvCard.DataSource = nom;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

        private void dgvCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT descricao_item FROM item WHERE nome_item LIKE '%" +  + "%' ", con);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(comm);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    try
                    {
                        txtDesc.Text = Convert.ToString(dtbl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro:\n" + ex.Message.ToString());
                        
                    }
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

