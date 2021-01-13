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

namespace DB_Series
{
    public partial class Query1 : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Query1()
        {
            InitializeComponent();
        }

        private void Query1_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CONCAT(CONCAT(N'Сериалы снимаются в ', (COUNT (DISTINCT Country))), N' странах')  AS 'Количество стран' FROM Series; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
