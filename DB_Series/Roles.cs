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
    public partial class Roles : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Roles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }
        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Roles.Id_role AS 'Id', Series.Title AS 'Сериал', Actors.Name AS 'Имя Актёра', Actors.Surname AS 'Фамилия актера',  Roles.Role AS 'Роль' FROM Roles, Actors, Series WHERE Roles.Id_series = Series.Id_series AND Roles.Id_actor = Actors.Id_actor; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            sqlconn.Close(); 
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.seriesDataSet.Actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);
            disp_data();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            comboBox3.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 4; j < 5; j++)
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



        //фильтр
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string series = comboBox1.SelectedValue.ToString();
            string name = comboBox2.SelectedValue.ToString();
            string surname = comboBox3.SelectedValue.ToString();

            if (comboBox1.Visible == true && (comboBox2.Visible == true) && (comboBox3.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 4; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == series && dataGridView1.Rows[i].Cells[3].Value.ToString() == surname)
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

                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == series && dataGridView1.Rows[i].Cells[2].Value.ToString() == name)
                        {
                            dataGridView1.Rows[i].Visible = true && (dataGridView1.Rows[i].Visible = true);
                        }

                    }
                    
                }
        
            }
            else if(comboBox3.Visible == true && (comboBox2.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;

                    for (int j = 2; j < 1; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == name)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                }
            }
            else if (comboBox1.Visible == true && (comboBox3.Visible == true))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < 4; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == series && dataGridView1.Rows[i].Cells[3].Value.ToString() == surname)
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
                    for (int j = 1; j < 2; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == series)
                        {
                            dataGridView1.Rows[i].Visible = true;
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
                    for (int j = 2; j < 3; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == name)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                }

            }
            else if (comboBox3.Visible == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;

                    for (int j = 3; j < 4; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == surname)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                }
            }
        }





        private void pictureBox16_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            disp_data();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddRole add = new AddRole();
            add.ShowDialog();
            disp_data();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить роль", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Roles WHERE Id_role =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                disp_data();
                seriesDataSet.AcceptChanges();
                MessageBox.Show("Роль успешно удалена.");
                
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeRole change = new ChangeRole();
            change.ShowDialog();
            disp_data();
            int cha = 2;
        }
    }
}
