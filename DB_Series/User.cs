using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Mail;


namespace DB_Series
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        public static void SendEmail()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("natalie.yankovskaya0209@gmail.com", "Библиотека сериалов");
            // кому отправляем
            MailAddress to = new MailAddress("nataliia.iankovska@nure.ua");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Не забывай о сериалах";
            // текст письма
            m.Body = "<h2>Я люблю свой курсач</h2>";
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
                MessageBox.Show("Message sent successfully!");
            }
            catch
            {
                MessageBox.Show("Error!Message not sent!");
            }

        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.User". При необходимости она может быть перемещена или удалена.
            
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Users". При необходимости она может быть перемещена или удалена.
            ////this.usersTableAdapter.Fill(this.seriesDataSet.Users);
            ////// TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Users". При необходимости она может быть перемещена или удалена.
            ////this.usersTableAdapter.Fill(this.seriesDataSet.Users);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendEmail();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }
    }
}
