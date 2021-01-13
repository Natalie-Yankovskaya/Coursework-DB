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
    public partial class AddUser : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name = Title.Text;
            string surname = Slogan.Text;
            string mail = textBox1.Text;
            int series = Convert.ToInt32(Series.SelectedValue);

            sqlconn.Open();
            string sql = "INSERT INTO Users1 VALUES(N'" + name + "', N'" + surname + "', N'" + mail + "', N'" + series + "', N'" + 0 + "', N'" + 0 + "')";
            SqlCommand add = new SqlCommand(sql, sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //seriesTableAdapter1.Insert(title, genre, country, slogan, release1, rating, producer, studio, duration, seasons, episodes);
            //seriesTableAdapter1.Update(seriesDataSet.Series);
            seriesDataSet.AcceptChanges();
            Close();


        }
    }
}
