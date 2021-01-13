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
    public partial class Query4 : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Query4()
        {
            InitializeComponent();
        }


        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Studios.Name AS 'Имя Студии', AVG(Series.Rating) AS 'Средний рейтинг сериалов' FROM Series, Studios WHERE Series.Id_studio = Studios.Id_studio GROUP BY Studios.Name; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();

        }
        private void Query4_Load(object sender, EventArgs e)
        {
            disp_data();

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
