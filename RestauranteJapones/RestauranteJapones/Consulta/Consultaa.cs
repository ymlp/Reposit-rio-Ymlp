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
    public partial class Consultaa : Form
    {
        public Consultaa()
        {
            InitializeComponent();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoq = new Estoque();
            estoq.Show();
            //this.Hide();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Consulta.Cliente cli = new Consulta.Cliente();
            cli.Show();
            //this.Hide();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.Show();
            //this.Hide();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Show();
            //this.Hide();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            //this.Hide();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reserva reser = new Reserva();
            reser.Show();
            //this.Hide();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            Comanda com = new Comanda();
            com.Show();
            //this.Hide();
        }

        private void Consultaa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
