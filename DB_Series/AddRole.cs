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
    public partial class AddRole : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public AddRole()
        {
            InitializeComponent();
        }

        private void AddRole_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.seriesDataSet.Actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string role = Role.Text;
            int series = Convert.ToInt32(Producer.SelectedValue);
            int actor = Convert.ToInt32(Studio.SelectedValue);
            sqlconn.Open();
            string sql = "INSERT INTO Roles VALUES(N'" + series + "', N'" + actor + "', N'" + role + "')";
            SqlCommand add = new SqlCommand(sql, sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //seriesTableAdapter1.Insert(title, genre, country, slogan, release1, rating, producer, studio, duration, seasons, episodes);
            
            seriesDataSet.AcceptChanges();
            Close();
        }
    }
}
