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
    public partial class Producers : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Producers()
        {
            InitializeComponent();
        }

        private void producersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void Producers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.seriesDataSet.Producers);
            listBox2.SetSelected(0, true);
        }

        private void producersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddProducer add = new AddProducer();
            add.ShowDialog();
            producersTableAdapter.Fill(seriesDataSet.Producers);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить режиссера?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Producers WHERE Id_producer =" + producersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                producersTableAdapter.Fill(this.seriesDataSet.Producers);
                seriesDataSet.AcceptChanges();
                MessageBox.Show("Режиссер успешно удален.");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeProducer change = new ChangeProducer();
            change.ShowDialog();
            producersTableAdapter.Fill(seriesDataSet.Producers);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();
            
            if (selected.Equals("Имя"))
            {
                for (int i = 0; i < producersDataGridView.RowCount; i++)
                {
                    producersDataGridView.Rows[i].Selected = false;
                    for (int j = 1; j < 2; j++)
                        if (producersDataGridView.Rows[i].Cells[j].Value != null)
                            if (producersDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text))
                            {
                                producersDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            
            if (selected.Equals("Фамилия"))
            {
                for (int i = 0; i < producersDataGridView.RowCount; i++)
                {
                    producersDataGridView.Rows[i].Selected = false;
                    for (int j = 3; j < 4; j++)
                        if (producersDataGridView.Rows[i].Cells[j].Value != null)
                            if (producersDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text))
                            {
                                producersDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (selected.Equals("Гражданство"))
            {
                for (int i = 0; i < producersDataGridView.RowCount; i++)
                {
                    producersDataGridView.Rows[i].Selected = false;
                    for (int j = 5; j < 6; j++)
                        if (producersDataGridView.Rows[i].Cells[j].Value != null)
                            if (producersDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text))
                            {
                                producersDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            for (int i = 0; i < producersDataGridView.RowCount; i++)
            {
                producersDataGridView.Rows[i].Selected = false;
            }
            listBox2.SetSelected(0, true);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
            producersBindingSource.Filter = "Citizenship LIKE '" + country + "'";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            producersBindingSource.Filter = null;

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            string prod = producersDataGridView.SelectedRows[0].Cells[0].Value.ToString();

        }
    }
}
