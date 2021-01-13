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
    public partial class Series1 : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Series1()
        {
            InitializeComponent();
        }

        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Series.Id_series, Series.Title, Series.Genre, Series.Country, Series.Slogan, Series.[Release date], Series.[Сompletion date], Series.Rating, Producers.Name AS 'Producer', Studios.Name AS 'Studio', Series.[Episode duration], Series.[Number of episodes], Series.[Number of seasons], Series.[Total duration] FROM Series, Studios, Producers WHERE Series.Id_producer = Producers.Id_producer AND Studios.Id_studio = Series.Id_studio; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            sqlconn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Series1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet1.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.seriesDataSet1.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet1.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.seriesDataSet1.Producers);
            disp_data();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 1; j < 2; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddSeries add = new AddSeries();
            add.ShowDialog();
            disp_data();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить сериал?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Series WHERE Id_series =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                disp_data();
                seriesDataSet1.AcceptChanges();
                MessageBox.Show("Сериал успешно удален.");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeSeries change = new ChangeSeries();
            change.ShowDialog();
            disp_data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string country = "";
            if (comboBox5.SelectedIndex == 0)
            {
                country = "Австралия";
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                country = "Великобритания";
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                country = "Индия";
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                country = "Испания";
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                country = "Италия";
            }
            else if (comboBox5.SelectedIndex == 5)
            {
                country = "Канада";
            }
            else if (comboBox5.SelectedIndex == 6)
            {
                country = "Китай";
            }
            else if (comboBox5.SelectedIndex == 7)
            {
                country = "Корея";
            }
            else if (comboBox5.SelectedIndex == 8)
            {
                country = "Норвегия";
            }
            else if (comboBox5.SelectedIndex == 9)
            {
                country = "Россия";
            }
            else if (comboBox5.SelectedIndex == 10)
            {
                country = "США";
            }
            else if (comboBox5.SelectedIndex == 11)
            {
                country = "Турция";
            }
            else if (comboBox5.SelectedIndex == 12)
            {
                country = "Украина";
            }
            else if (comboBox5.SelectedIndex == 13)
            {
                country = "Франция";
            }
            string producer = comboBox1.SelectedValue.ToString();
            string studio = comboBox2.SelectedValue.ToString();
            int rating1 = Convert.ToInt32(comboBox3.Text);
            int rating2 = Convert.ToInt32(comboBox4.Text);
            int episodes1 = Convert.ToInt32(textBox1.Text);
            int episodes2 = Convert.ToInt32(textBox2.Text);
            int dur1 = Convert.ToInt32(textBox3.Text);
            int dur2 = Convert.ToInt32(textBox4.Text);


            if (comboBox1.Visible == true && (comboBox2.Visible == true) && (comboBox5.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[8].Value.ToString() == producer) && (dataGridView1.Rows[i].Cells[9].Value.ToString() == studio) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2)
                            && (dataGridView1.Rows[i].Cells[3].Value.ToString() == country))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }                
            }
            else if (comboBox1.Visible == false && (comboBox2.Visible == false) && (comboBox5.Visible == false))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if (Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }
            else if (comboBox1.Visible == true && (comboBox2.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[8].Value.ToString() == producer) && (dataGridView1.Rows[i].Cells[9].Value.ToString() == studio) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }
            else if (comboBox1.Visible == true && (comboBox5.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[8].Value.ToString() == producer) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2)
                            && (dataGridView1.Rows[i].Cells[3].Value.ToString() == country))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }
            else if (comboBox2.Visible == true && (comboBox5.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[9].Value.ToString() == studio) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2)
                            && (dataGridView1.Rows[i].Cells[3].Value.ToString() == country))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }
            else if (comboBox1.Visible == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[8].Value.ToString() == producer) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }
            else if (comboBox2.Visible == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[9].Value.ToString() == studio) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }
            else if (comboBox5.Visible == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((dataGridView1.Rows[i].Cells[3].Value.ToString() == country) &&
                            Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1 && Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value) >= rating1
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) >= episodes1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value) <= episodes2)
                            && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) >= dur1) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value) <= dur2))
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }
                    }
                }
            }

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label3.Visible = true;
            comboBox4.Visible = true;
            comboBox3.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label8.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            comboBox4.Visible = false;
            comboBox3.Visible = false;
            comboBox3.Text = "1";
            comboBox4.Text = "10";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Text = "1";
            textBox2.Text = "500";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label8.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox4.Text = "120";
            textBox3.Text = "1";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label8.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            comboBox2.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            label1.Visible = true;
            label3.Visible = true;
            comboBox4.Visible = true;
            comboBox3.Visible = true;
            label2.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBox5.Visible = true;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label8.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;

            label1.Visible = false;
            label3.Visible = false;
            comboBox4.Visible = false;
            comboBox3.Visible = false;
            label2.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox5.Visible = false;
            textBox4.Text = "120";
            textBox3.Text = "1";
            textBox1.Text = "1";
            textBox2.Text = "500";
            comboBox3.Text = "1";
            comboBox4.Text = "10";

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            comboBox5.Visible = true;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            comboBox5.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            disp_data();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Query1 query = new Query1();
            query.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Query2 query = new Query2();
            query.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Query4 query = new Query4();
            query.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Query3 query = new Query3();
            query.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Report1 report = new Report1();
            report.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Report2 report = new Report2();
            report.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Studios studios = new Studios();
            studios.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producers prod = new Producers();
            prod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actors report = new Actors();
            report.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void актёрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actors show = new Actors();
            show.Show();
        }

        private void студииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studios show = new Studios();
            show.Show();
        }

        private void режиссерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producers show = new Producers();
            show.Show();
        }

        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles show = new Roles();
            show.Show();
        }

        private void количествоСтранВКоторыхСнимаютсяСериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query1 query = new Query1();
            query.Show();

        }

        private void студииВКоторыхСнимаетсяБольшеСериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query2 query = new Query2();
            query.Show();
        }

        private void среднийРейтингСериаловОднойСтудииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query4 query = new Query4();
            query.Show();
        }

        private void продолжительностьСъемокСериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query3 query = new Query3();
            query.Show();
        }

        private void среднийРейтингСериаловСтудииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 report = new Report1();
            report.Show();

        }

        private void топ5СериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2 report = new Report2();
            report.Show();
        }

        private void длительностьСериаловОдногоЖанраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report4 report = new Report4();
            report.Show();
        }

        private void количествоАктеровОдногоГражданстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report3 report = new Report3();
            report.Show();
        }

        private void сериаломаныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users1 user = new Users1();
            user.ShowDialog();
        }
    }
}
