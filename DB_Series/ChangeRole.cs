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
    public partial class ChangeRole : Form
    {
        public ChangeRole()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void ChangeRole_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.seriesDataSet.Roles);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rolesBindingSource.EndEdit();
            rolesTableAdapter1.Update(seriesDataSet.Roles);
            seriesDataSet.AcceptChanges();
            Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
