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
    public partial class ChangeActor : Form
    {
        public ChangeActor()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void ChangeActor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.seriesDataSet.Actors);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.actorsBindingSource.EndEdit();
            actorsTableAdapter.Update(seriesDataSet.Actors);
            seriesDataSet.AcceptChanges();
            Close();

        }
    }
}
