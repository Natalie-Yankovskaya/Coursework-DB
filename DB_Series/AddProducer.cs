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
    public partial class AddProducer : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");
        public AddProducer()
        {
            InitializeComponent();
            producersTableAdapter.Fill(seriesDataSet.Producers);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name = Name1.Text;
            string second = Second.Text;
            string surname = Surname.Text;
            DateTime date = Date.Value;
            string date1 = date.ToString("MM.dd.yyyy");
            string country = "";
            if (Country.SelectedIndex == 0)
            {
                country = "Австралия";
            }
            else if (Country.SelectedIndex == 1)
            {
                country = "Великобритания";
            }
            else if (Country.SelectedIndex == 2)
            {
                country = "Индия";
            }
            else if (Country.SelectedIndex == 3)
            {
                country = "Испания";
            }
            else if (Country.SelectedIndex == 4)
            {
                country = "Италия";
            }
            else if (Country.SelectedIndex == 5)
            {
                country = "Канада";
            }
            else if (Country.SelectedIndex == 6)
            {
                country = "Китай";
            }
            else if (Country.SelectedIndex == 7)
            {
                country = "Корея";
            }
            else if (Country.SelectedIndex == 8)
            {
                country = "Норвегия";
            }
            else if (Country.SelectedIndex == 9)
            {
                country = "Россия";
            }
            else if (Country.SelectedIndex == 10)
            {
                country = "США";
            }
            else if (Country.SelectedIndex == 11)
            {
                country = "Турция";
            }
            else if (Country.SelectedIndex == 12)
            {
                country = "Украина";
            }
            else if (Country.SelectedIndex == 13)
            {
                country = "Франция";
            }

            sqlconn.Open();
            string sql = "INSERT INTO Producers VALUES(N'" + name + "', N'" + second + "', N'" + surname + "', '" + date1 + "', N'" + country + "')";
            SqlCommand add = new SqlCommand("INSERT INTO Producers VALUES(N'" + name + "', N'" + second + "', N'" + surname + "', '" + date1 + "', N'" + country + "')", sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //producersTableAdapter.Insert(name, second, surname, date, country);
            producersTableAdapter.Update(seriesDataSet.Producers);
            seriesDataSet.AcceptChanges();
            Close();  
        }

        private void producersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void producersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.producersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void AddProducer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.seriesDataSet.Producers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Second_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void genreLabel_Click(object sender, EventArgs e)
        {

        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }

        private void sloganLabel_Click(object sender, EventArgs e)
        {

        }

        private void release_dateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
