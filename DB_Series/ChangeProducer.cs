﻿using System;
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
    public partial class ChangeProducer : Form
    {
        public ChangeProducer()
        {
            InitializeComponent();
        }

        private void producersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seriesDataSet);

        }

        private void ChangeProducer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Producers". При необходимости она может быть перемещена или удалена.
            this.producersTableAdapter.Fill(this.seriesDataSet.Producers);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.producersBindingSource.EndEdit();
            producersTableAdapter.Update(seriesDataSet.Producers);
            seriesDataSet.AcceptChanges();
            Close();
        }
    }
}
