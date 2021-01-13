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
    public partial class Query3 : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Query3()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CONCAT(CONCAT(CONCAT(CONCAT(N'Сериал «‎', Title), N'»‎ снимают на протяжении '), (Year(SYSDATETIME()) - Year([Release date]))), N' лет.') AS 'Продолжительность съемок' " +
                "FROM Series " +
                "WHERE[Сompletion date] IS NULL " +
                "UNION SELECT CONCAT(CONCAT(CONCAT(CONCAT(N'Сериал «‎', Title), N'»‎ снимали на протяжении '), (Year(CONVERT(DATETIME, [Сompletion date], 104)) - Year([Release date]))), N' лет.') AS 'Продолжительность съемок' " +
                "FROM Series " +
                "WHERE[Сompletion date] IS NOT NULL; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();

        }
        private void Query3_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
