using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Series
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Series series = new Series();
            series.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string pass = textBox1.Text;
            

            if(pass == "12345")
            {
                Series1 series = new Series1();
                series.Show();
            }

            else
            {
                MessageBox.Show("Вы ввели неправильный пароль. Попробуйте еще раз");
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Users1 series = new Users1();
            series.Show();
        }

        private void Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
