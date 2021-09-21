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
    public partial class Comanda : Form
    {
        string connectionString = @"Data Source=DESKTOP-BD3ROGM;Initial Catalog=Restaurante_Japones; user=sa; password=1234567";
        public Comanda()
        {
            InitializeComponent();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT *FROM comanda", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgvCom.DataSource = dtbl;
            }
        }
    }
}
