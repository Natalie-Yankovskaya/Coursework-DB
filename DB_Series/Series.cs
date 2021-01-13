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
    public partial class Series : Form
    {
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True";
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");
        public Series()
        {
            InitializeComponent();
            
        }

       

        private void seriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.seriesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }



        //Занесение данных таблицы в DataGridView
        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Series";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            seriesDataGridView.DataSource = dt;
            sqlconn.Close();

        }

        private void Series_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.seriesDataSet.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.seriesDataSet.Producers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);
            this.seriesTableAdapter.Update(this.seriesDataSet.Series);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Roles". При необходимости она может быть перемещена или удалена.

            listBox2.SetSelected(0, true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int producer = Convert.ToInt32(comboBox1.SelectedValue);
            int studio = Convert.ToInt32(comboBox2.SelectedValue);
            int rating1 = Convert.ToInt32(comboBox3.Text);
            int rating2 = Convert.ToInt32(comboBox4.Text);
            int episodes1 = Convert.ToInt32(textBox1.Text);
            int episodes2 = Convert.ToInt32(textBox2.Text);
            int dur1 = Convert.ToInt32(textBox3.Text);
            int dur2 = Convert.ToInt32(textBox4.Text);

            if (comboBox1.Visible == true && (comboBox2.Visible == true))
            {
                seriesBindingSource.Filter = "Rating >=" + rating1 + " AND Rating <=" + rating2 +
                     "AND [Number of episodes] >=" + episodes1 + " AND [Number of episodes] <=" + episodes2 +
                     "AND [Episode duration] >=" + dur1 + " AND [Episode duration] <=" + dur2 +
                     "AND Id_producer = " + producer +
                     "AND Id_studio = " + studio;

            }
            else if (comboBox1.Visible == true)
            {
                seriesBindingSource.Filter = "Rating >=" + rating1 + " AND Rating <=" + rating2 +
                    "AND [Number of episodes] >=" + episodes1 + " AND [Number of episodes] <=" + episodes2 +
                    "AND [Episode duration] >=" + dur1 + " AND [Episode duration] <=" + dur2 +
                    "AND Id_producer = " + producer;

            }
            else if(comboBox2.Visible == true)
            {
                seriesBindingSource.Filter = "Rating >=" + rating1 + " AND Rating <=" + rating2 +
                     "AND [Number of episodes] >=" + episodes1 + " AND [Number of episodes] <=" + episodes2 +
                     "AND [Episode duration] >=" + dur1 + " AND [Episode duration] <=" + dur2 +
                     "AND Id_studio = " + studio;

            }
            else if (comboBox1.Visible == false && (comboBox2.Visible == false))
            {
                seriesBindingSource.Filter = "Rating >=" + rating1 + " AND Rating <=" + rating2 +
                     "AND [Number of episodes] >=" + episodes1 + " AND [Number of episodes] <=" + episodes2 +
                     "AND [Episode duration] >=" + dur1 + " AND [Episode duration] <=" + dur2;


            }




            //seriesBindingSource.Filter = "Rating >=" + rating1 + " AND Rating <=" + rating2 +
            //     "AND [Number of episodes] >=" + episodes1 + " AND [Number of episodes] <=" + episodes2 +
            //     "AND [Episode duration] >=" + dur1 + " AND [Episode duration] <=" + dur2 +
            //     "AND Id_producer = " + producer;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            seriesBindingSource.Filter = null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddSeries add = new AddSeries();
            add.ShowDialog();
            seriesTableAdapter.Fill(seriesDataSet.Series);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить сериал?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Series WHERE Id_series =" + seriesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                seriesTableAdapter.Fill(this.seriesDataSet.Series);
                seriesDataSet.AcceptChanges();
                MessageBox.Show("Сериал успешно удален.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeSeries change = new ChangeSeries();
            change.ShowDialog();
            seriesTableAdapter.Fill(seriesDataSet.Series);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();



            if (selected.Equals("Общий"))
            {
                for (int i = 0; i < seriesDataGridView.RowCount; i++)
                {
                    seriesDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < seriesDataGridView.ColumnCount; j++)
                        if (seriesDataGridView.Rows[i].Cells[j].Value != null)
                            if (seriesDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                seriesDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }

            }

            else if (selected.Equals("Название"))
            {

                for (int i = 0; i < seriesDataGridView.RowCount; i++)
                {
                    seriesDataGridView.Rows[i].Selected = false;
                    for (int j = 1; j < 2; j++)
                        if (seriesDataGridView.Rows[i].Cells[j].Value != null)
                            if (seriesDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                seriesDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else if(selected.Equals("Жанр"))
            {
                for (int i = 0; i < seriesDataGridView.RowCount; i++)
                {
                    seriesDataGridView.Rows[i].Selected = false;
                    for (int j = 2; j < 3; j++)
                        if (seriesDataGridView.Rows[i].Cells[j].Value != null)
                            if (seriesDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                seriesDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }

            }

            else if (selected.Equals("Страна"))
            {
                for (int i = 0; i < seriesDataGridView.RowCount; i++)
                {
                    seriesDataGridView.Rows[i].Selected = false;
                    for (int j = 3; j < 4; j++)
                        if (seriesDataGridView.Rows[i].Cells[j].Value != null)
                            if (seriesDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                seriesDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            for (int i = 0; i < seriesDataGridView.RowCount; i++)
            {
                seriesDataGridView.Rows[i].Selected = false;
            }
            listBox2.SetSelected(0, true);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producers prod = new Producers();
            prod.Show();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Studios studios = new Studios();
            studios.Show();
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

        private void seriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seriesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Query3 query = new Query3();
            query.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Query4 query = new Query4();
            query.Show();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //string selected = listBox1.SelectedItem.ToString();
            ////MessageBox.Show("sd" + selected);
            //if (selected.Equals("Название"))
            //{

                

            //}
            ////{
            //sqlconn.Open();
            //string sql = "SELECT * FROM Series ORDER BY Title;";
            //SqlCommand add = new SqlCommand(sql, sqlconn);
            //add.ExecuteNonQuery();
            //sqlconn.Close();
            ////seriesTableAdapter.Update(seriesDataSet.Series);
            //seriesTableAdapter.Fill(seriesDataSet.Series);
            //seriesDataSet.AcceptChanges();


            //}
            //eriesBindingSource.Filter = "ORDER BY Title";*/
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

        private void button2_Click(object sender, EventArgs e)
        {
            Actors report = new Actors();
            report.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string selected = listBox3.SelectedItem.ToString();
        //    if (selected.Equals("Рейтинг"))
        //    {
        //        label1.Visible = true;
        //        label3.Visible = true;
        //        comboBox4.Visible = true;
        //        comboBox3.Visible = true;
        //    }
        //    if (selected.Equals("Серии"))
        //    {
        //        label2.Visible = true;
        //        label7.Visible = true;
        //        textBox1.Visible = true;
        //        textBox2.Visible = true;
        //    }

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


        private void pictureBox10_Click_1(object sender, EventArgs e)
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            comboBox1.Text = "1";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox2.Text = "1";
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
