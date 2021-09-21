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
    public partial class Reserva : Form
    {
        string connectionString = @"Data Source=DESKTOP-K68VKQJ;Initial Catalog=RestauranteTCM; user=sa; password=1234567";
        public Reserva()
        {
            InitializeComponent();
            cbBusca.SelectedItem = "Nome";
        }

        private void btnReser_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM reserva", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvReser.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            while (cbBusca.Text == "Nome")
            {
                if (mtxtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {


                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_reserva,id_cliente,nome_cliente,sobrenome_cliente,descricao_reserva,data_reserva,hora_reserva,numero_pessoas FROM reserva WHERE nome_cliente LIKE '%" + mtxtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvReser.DataSource = busca;

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

            while (cbBusca.Text == "Data")
            {
                if (mtxtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_reserva,id_cliente,nome_cliente,sobrenome_cliente,descricao_reserva,data_reserva,hora_reserva,numero_pessoas FROM reserva WHERE data_reserva LIKE '%" + mtxtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvReser.DataSource = busca;
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

            while (cbBusca.Text == "Hora")
            {
                if (mtxtBusca.Text != "")
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {

                            con.Open();
                            SqlDataAdapter bsc = new SqlDataAdapter("SELECT id_reserva,id_cliente,nome_cliente,sobrenome_cliente,descricao_reserva,data_reserva,hora_reserva,numero_pessoas FROM reserva WHERE hora_reserva LIKE '%" + mtxtBusca.Text + "%' ", con);
                            DataTable busca = new DataTable();
                            bsc.Fill(busca);

                            dgvReser.DataSource = busca;

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

        private void Reserva_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM reserva", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvReser.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:\n" + ex.Message.ToString());
                    con.Close();
                }
            }
            
        }

        private void cbBusca_SelectedValueChanged(object sender, EventArgs e)
        {
            
            while(cbBusca.Text == "Nome")
            {
                mtxtBusca.Mask = "";
                return;
            }
            

            while (cbBusca.Text == "Data")
            {
                mtxtBusca.Mask = "00/00/0000";
                return;
            }

            while (cbBusca.Text == "Hora")
            {
                mtxtBusca.Mask = "00:00";
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
    }
}
