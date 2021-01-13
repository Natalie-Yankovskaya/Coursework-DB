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
    public partial class Finished : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Finished()
        {
            InitializeComponent();
        }

        private void users1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void Finished_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Users1". При необходимости она может быть перемещена или удалена.
            this.users1TableAdapter.Fill(this.seriesDataSet.Users1);

        }

        private void seriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int new1 = Convert.ToInt32(NewOne.SelectedValue);
            int id = Convert.ToInt32(id_userTextBox.Text);
            int finished = Convert.ToInt32(finished_seriesTextBox.Text);
            sqlconn.Open();
            string sql = "UPDATE Users1 Set [Current series] = '" + new1 + "', [Finished series] = ([Finished series] + 1), [Spent Time] = [Spent Time] + ( SELECT Series.[Total duration] FROM Users1, Series WHERE Series.Id_series = Users1.[Current series] AND Id_user = '" + id + "') WHERE Id_user = '" + id + "'";
            SqlCommand add = new SqlCommand(sql, sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //producersTableAdapter.Insert(name, second, surname, date, country);
            users1TableAdapter.Update(seriesDataSet.Users1);
            seriesDataSet.AcceptChanges();
            Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
