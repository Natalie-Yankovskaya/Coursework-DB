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
    public partial class Report4 : Form
    {
        public Report4()
        {
            InitializeComponent();
        }

        private void Report4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Time1". При необходимости она может быть перемещена или удалена.
            this.time1TableAdapter.Fill(this.seriesDataSet.Time1);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
