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
    public partial class ChangeStudio : Form
    {
        public ChangeStudio()
        {
            InitializeComponent();
        }

        private void studiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void ChangeStudio_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.seriesDataSet.Studios);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.studiosBindingSource.EndEdit();
            studiosTableAdapter.Update(seriesDataSet.Studios);
            seriesDataSet.AcceptChanges();
            Close();
        }
    }
}
