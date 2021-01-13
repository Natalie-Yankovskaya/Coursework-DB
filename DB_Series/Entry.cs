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

    public partial class Entry : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Entry()
        {
            InitializeComponent();
        }
        public void disp_data()
        {
            

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            sqlconn.Open();
            string sql = "SELECT * FROM Users1 WHERE Name = N'" + Name + "' AND Surname = N'" + Surname + "'";
            SqlCommand add = new SqlCommand(sql, sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //producersTableAdapter.Insert(name, second, surname, date, country);
            users1TableAdapter.Update(seriesDataSet1.Users1);
            seriesDataSet1.AcceptChanges();
            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;

        }

        private void users1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet1);

        }

        private void Entry_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet1.Users1". При необходимости она может быть перемещена или удалена.
            this.users1TableAdapter.Fill(this.seriesDataSet1.Users1);

        }
    }
}
