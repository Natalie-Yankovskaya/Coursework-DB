using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Net;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Data.SqlClient;

namespace DB_Series
{
    public partial class Users1 : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True");

        public Users1()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.ShowDialog();
        }

        private void users1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }
        public void disp_data()
        {
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Users1.Id_user, Users1.Name, Users1.Surname, Users1.[E-mail], Series.Title, Users1.[Finished series], Users1.[Spent Time]FROM Users1, Series WHERE Series.Id_series = Users1.[Current series]; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            sqlconn.Close();
        }

        private void Users1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Users1". При необходимости она может быть перемещена или удалена.
            this.users1TableAdapter.Fill(this.seriesDataSet.Users1);
            this.users1TableAdapter.Update(this.seriesDataSet.Users1);
            disp_data();
            
        }
        
        public void com()
        {
            string title = "";
            title = title.ToString() + Convert.ToString(dataGridView1.Rows[0].Cells[4].Value);

            int time;
            time =  Convert.ToInt32(dataGridView1.Rows[0].Cells[6].Value);


            string genre = "";
            string producer = "";
            string studio = "";
            string po = "";
            
            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Genre FROM Series WHERE Title LIKE N'" + title + "';";
            genre = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Id_producer FROM Series WHERE Title LIKE N'" + title + "';";
            producer = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Id_studio FROM Series WHERE Title LIKE N'" + title + "';";
            studio = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Title FROM Series WHERE Genre LIKE N'" + genre + "' AND Title NOT LIKE N'" + title + "';";
            po = cmd.ExecuteScalar().ToString();



            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;
            sqlconn.Close();
            MessageBox.Show("ed" + po);

        }
        

        private void users1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finished fin = new Finished();
            fin.ShowDialog();
            disp_data();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "";
            title = title.ToString() + Convert.ToString(dataGridView1.Rows[0].Cells[4].Value);
            int time;
            time = Convert.ToInt32(dataGridView1.Rows[0].Cells[6].Value);


            string genre = "";
            string producer = "";
            string studio = "";
            string new1 = "";

            sqlconn.Open();
            SqlCommand cmd = sqlconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Genre FROM Series WHERE Title LIKE N'" + title + "';";
            genre = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Id_producer FROM Series WHERE Title LIKE N'" + title + "';";
            producer = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Id_studio FROM Series WHERE Title LIKE N'" + title + "';";
            studio = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT Title FROM Series WHERE Genre LIKE N'" + genre + "' AND Title NOT LIKE N'" + title + "';";
            new1 = cmd.ExecuteScalar().ToString();
            sqlconn.Close();

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("natalie.yankovskaya0209@gmail.com", "Библиотека сериалов");
            // кому отправляем
            MailAddress to = new MailAddress("nataliia.iankovska@nure.ua");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Не забывай о сериалах";
            // текст письма
            m.Body = "Вы потратили на просмотр сериалов " + time + " часов. Ваш текущий сериал «" + title + "». Напишите, если закончили просмотр и выберите новый сериал для подсчета потраченого времени :) Советуем вам к последующему просмотру сериал «" + new1 + "»";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("natalie.yankovskaya0209@gmail.com", "Pt63dk7mjt");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(m);
                MessageBox.Show("Собщение успешно отправлено!");
            }
            catch
            {
                MessageBox.Show("Ошибка! Не удалось отправить сообщение!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.ShowDialog();
            disp_data();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.ShowDialog();
            disp_data();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить сериаломана?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Cancel)
            {
                sqlconn.Open();
                SqlCommand delete = sqlconn.CreateCommand();
                delete.CommandType = CommandType.Text;
                delete.CommandText = "DELETE FROM Users1 WHERE Id_user =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                delete.ExecuteNonQuery();
                sqlconn.Close();
                disp_data();
                seriesDataSet1.AcceptChanges();
                MessageBox.Show("Сериаломан успешно удален.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            com();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
