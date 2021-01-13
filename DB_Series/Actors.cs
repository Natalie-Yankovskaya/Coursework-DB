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
    public partial class Actors : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Actors()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void Actors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.seriesDataSet.Actors);
            listBox2.SetSelected(0, true);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddActor add = new AddActor();
            add.ShowDialog();
            actorsTableAdapter.Fill(seriesDataSet.Actors);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить актера?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Actors WHERE Id_actor =" + actorsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                actorsTableAdapter.Fill(this.seriesDataSet.Actors);
                seriesDataSet.AcceptChanges();
                MessageBox.Show("Актёр успешно удален.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeActor change = new ChangeActor();
            change.ShowDialog();
            actorsTableAdapter.Fill(seriesDataSet.Actors);
            seriesDataSet.AcceptChanges();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();

            if (selected.Equals("Имя"))
            {

                for (int i = 0; i < actorsDataGridView.RowCount; i++)
                {
                    actorsDataGridView.Rows[i].Selected = false;
                    for (int j = 1; j < 2; j++)
                        if (actorsDataGridView.Rows[i].Cells[j].Value != null)
                            if (actorsDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                actorsDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else if (selected.Equals("Фамилия"))
            {

                for (int i = 0; i < actorsDataGridView.RowCount; i++)
                {
                    actorsDataGridView.Rows[i].Selected = false;
                    for (int j = 3; j < 4; j++)
                        if (actorsDataGridView.Rows[i].Cells[j].Value != null)
                            if (actorsDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                actorsDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            for (int i = 0; i < actorsDataGridView.RowCount; i++)
            {
                actorsDataGridView.Rows[i].Selected = false;
            }
            listBox2.SetSelected(0, true);
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
            actorsBindingSource.Filter = "Citizenship LIKE '" + country + "'";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            actorsBindingSource.Filter = null;
        }
    }
}
