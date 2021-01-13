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
    public partial class ChangeSeries : Form
    {
        public ChangeSeries()
        {
            InitializeComponent();
            seriesTableAdapter.Fill(seriesDataSet.Series);
        }

        private void seriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void ChangeSeries_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Series". При необходимости она может быть перемещена или удалена.
            this.seriesTableAdapter.Fill(this.seriesDataSet.Series);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.seriesBindingSource.EndEdit();
            seriesTableAdapter.Update(seriesDataSet.Series);
            seriesDataSet.AcceptChanges();
            Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
