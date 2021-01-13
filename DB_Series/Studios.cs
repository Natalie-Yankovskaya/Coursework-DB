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
    public partial class Studios : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Studios()
        {
            InitializeComponent();
        }

        private void studiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void Studios_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.seriesDataSet.Studios);
            listBox2.SetSelected(0, true);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddStudio add = new AddStudio();
            add.ShowDialog();
            studiosTableAdapter.Fill(seriesDataSet.Studios);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить студию?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Studios WHERE Id_studio =" + studiosDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                studiosTableAdapter.Fill(this.seriesDataSet.Studios);
                seriesDataSet.AcceptChanges();
                MessageBox.Show("Студия успешно удалена.");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();
            
            if (selected.Equals("Название"))
            {
                for (int i = 0; i < studiosDataGridView.RowCount; i++)
                {
                    studiosDataGridView.Rows[i].Selected = false;
                    for (int j = 1; j < 2; j++)
                        if (studiosDataGridView.Rows[i].Cells[j].Value != null)
                            if (studiosDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text))
                            {
                                studiosDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }

            }
            if (selected.Equals("Слоган"))
            {
                for (int i = 0; i < studiosDataGridView.RowCount; i++)
                {
                    studiosDataGridView.Rows[i].Selected = false;
                    for (int j = 3; j < 4; j++)
                        if (studiosDataGridView.Rows[i].Cells[j].Value != null)
                            if (studiosDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text))
                            {
                                studiosDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }

            }
            if (selected.Equals("Основатель"))
            {
                for (int i = 0; i < studiosDataGridView.RowCount; i++)
                {
                    studiosDataGridView.Rows[i].Selected = false;
                    for (int j = 4; j < 5; j++)
                        if (studiosDataGridView.Rows[i].Cells[j].Value != null)
                            if (studiosDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text))
                            {
                                studiosDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }

            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            for (int i = 0; i < studiosDataGridView.RowCount; i++)
            {
                studiosDataGridView.Rows[i].Selected = false;
            }
            listBox2.SetSelected(0, true);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeStudio change = new ChangeStudio();
            change.ShowDialog();
            studiosTableAdapter.Fill(seriesDataSet.Studios);
            seriesDataSet.AcceptChanges();
        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
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
            studiosBindingSource.Filter = "Country LIKE '" + country + "'";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            studiosBindingSource.Filter = null;

        }

        private void studiosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
