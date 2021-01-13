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
    public partial class AddActor : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public AddActor()
        {
            InitializeComponent();
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
            string sql = "INSERT INTO Actors VALUES(N'" + name + "', N'" + second + "', N'" + surname + "', '" + date1 + "', N'" + country + "')";
            SqlCommand add = new SqlCommand("INSERT INTO Actors VALUES(N'" + name + "', N'" + second + "', N'" + surname + "', '" + date1 + "', N'" + country + "')", sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //producersTableAdapter.Insert(name, second, surname, date, country);
            actorsTableAdapter1.Update(seriesDataSet1.Actors);
            seriesDataSet1.AcceptChanges();
            Close();
        }
    }
}
