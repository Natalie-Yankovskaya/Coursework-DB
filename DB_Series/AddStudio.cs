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
    public partial class AddStudio : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");
        public AddStudio()
        {
            InitializeComponent();
            studiosTableAdapter.Fill(seriesDataSet.Studios);
        }

        private void studiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void AddStudio_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.seriesDataSet.Studios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name = Name1.Text;
            string slogan = Slogan.Text;
            string founder = Founder.Text;
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
            string sql = "INSERT INTO Studios VALUES(N'" + name + "', N'" + country + "', N'" + slogan + "', N'" + founder + "')";
            SqlCommand add = new SqlCommand(sql, sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //studiosTableAdapter.Insert(name, country, slogan, founder);
            studiosTableAdapter.Update(seriesDataSet.Studios);
            Close();
        }
    }
}
