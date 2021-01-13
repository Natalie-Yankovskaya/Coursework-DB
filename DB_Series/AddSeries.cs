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
    public partial class AddSeries : Form
    {
        private readonly int id;
        readonly bool edit;
        string path = "";
        public AddSeries()
        {
            InitializeComponent();
            seriesTableAdapter1.Fill(seriesDataSet.Series);

            edit = false;
        }
        
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

       
        private void seriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void AddSeries_Load(object sender, EventArgs e)
        {
            seriesTableAdapter1.Fill(seriesDataSet.Series);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.seriesDataSet.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.seriesDataSet.Producers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            //this.seriesTableAdapter.Fill(this.seriesDataSet.Series);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string title = Title.Text;
            string slogan = Slogan.Text;

            DateTime release1 = Date.Value;
            string release = release1.ToString("MM.dd.yyyy");

            string comp4 = textBox1.Text;
            float rating = float.Parse(Rating.Text);
            int producer = Convert.ToInt32(Producer.SelectedValue);
            int studio = Convert.ToInt32(Studio.SelectedValue);
            int duration = Convert.ToInt32(Duration.Text);
            int seasons = Convert.ToInt32(Seasons.Text);
            int episodes = Convert.ToInt32(Episodes.Text);

            string genre = "";
            if (Genre.SelectedIndex == 0)
            {
                genre = "боевик";
            }
            else if (Genre.SelectedIndex == 1)
            {
                genre = "детектив";
            }
            else if (Genre.SelectedIndex == 2)
            {
                genre = "драма";
            }
            else if (Genre.SelectedIndex == 3)
            {
                genre = "комедия";
            }
            else if (Genre.SelectedIndex == 4)
            {
                genre = "криминал";
            }
            else if (Genre.SelectedIndex == 5)
            {
                genre = "мелодрама";
            }
            else if (Genre.SelectedIndex == 6)
            {
                genre = "мультсериал";
            }
            else if (Genre.SelectedIndex == 7)
            {
                genre = "приключения";
            }
            else if (Genre.SelectedIndex == 8)
            {
                genre = "триллер";
            }
            else if (Genre.SelectedIndex == 9)
            {
                genre = "ужасы";
            }
            else if (Genre.SelectedIndex == 10)
            {
                genre = "фантастика";
            }
            else if (Genre.SelectedIndex == 11)
            {
                genre = "фэнтези";
            }

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
            string sql = "INSERT INTO Series VALUES(N'" + title + "', N'" + genre + "', N'" + country + "', N'" + slogan + "', '" + release + "', '" + rating + "', '" + producer + "', '" + studio + "', '" + duration + "', '" + seasons + "', '" + episodes + "', '" + comp4 + "')";
            SqlCommand add = new SqlCommand(sql, sqlconn);
            add.ExecuteNonQuery();
            sqlconn.Close();
            //seriesTableAdapter1.Insert(title, genre, country, slogan, release1, rating, producer, studio, duration, seasons, episodes);
            //seriesTableAdapter1.Update(seriesDataSet.Series);
            seriesDataSet.AcceptChanges();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProducer add = new AddProducer();
            add.ShowDialog();
            producersTableAdapter.Fill(seriesDataSet.Producers);
            seriesDataSet.AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudio adds = new AddStudio();
            adds.ShowDialog();
            studiosTableAdapter.Fill(seriesDataSet.Studios);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.producersTableAdapter.FillBy(this.seriesDataSet.Producers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            AddProducer add = new AddProducer();
            add.ShowDialog();
            producersTableAdapter.Fill(seriesDataSet.Producers);
            seriesDataSet.AcceptChanges();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddStudio adds = new AddStudio();
            adds.ShowDialog();
            studiosTableAdapter.Fill(seriesDataSet.Studios);
            seriesDataSet.AcceptChanges();
        }
    }
}
