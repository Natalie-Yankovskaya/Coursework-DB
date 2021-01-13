namespace DB_Series
{
    partial class ChangeProducer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeProducer));
            System.Windows.Forms.Label id_producerLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label second_nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label citizenshipLabel;
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producersTableAdapter = new DB_Series.SeriesDataSetTableAdapters.ProducersTableAdapter();
            this.tableAdapterManager = new DB_Series.SeriesDataSetTableAdapters.TableAdapterManager();
            this.producersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_producerTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.second_nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.citizenshipTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            id_producerLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            second_nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            citizenshipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingNavigator)).BeginInit();
            this.producersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // seriesDataSet
            // 
            this.seriesDataSet.DataSetName = "SeriesDataSet";
            this.seriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producersBindingSource
            // 
            this.producersBindingSource.DataMember = "Producers";
            this.producersBindingSource.DataSource = this.seriesDataSet;
            // 
            // producersTableAdapter
            // 
            this.producersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducersTableAdapter = this.producersTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Series.SeriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producersBindingNavigator
            // 
            this.producersBindingNavigator.AddNewItem = null;
            this.producersBindingNavigator.BindingSource = this.producersBindingSource;
            this.producersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.producersBindingNavigator.DeleteItem = null;
            this.producersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.producersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.producersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.producersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.producersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.producersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.producersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.producersBindingNavigator.Name = "producersBindingNavigator";
            this.producersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.producersBindingNavigator.Size = new System.Drawing.Size(352, 27);
            this.producersBindingNavigator.TabIndex = 0;
            this.producersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // id_producerLabel
            // 
            id_producerLabel.AutoSize = true;
            id_producerLabel.Location = new System.Drawing.Point(12, 42);
            id_producerLabel.Name = "id_producerLabel";
            id_producerLabel.Size = new System.Drawing.Size(84, 17);
            id_producerLabel.TabIndex = 1;
            id_producerLabel.Text = "Id producer:";
            // 
            // id_producerTextBox
            // 
            this.id_producerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "Id_producer", true));
            this.id_producerTextBox.Location = new System.Drawing.Point(117, 39);
            this.id_producerTextBox.Name = "id_producerTextBox";
            this.id_producerTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_producerTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(117, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // second_nameLabel
            // 
            second_nameLabel.AutoSize = true;
            second_nameLabel.Location = new System.Drawing.Point(12, 98);
            second_nameLabel.Name = "second_nameLabel";
            second_nameLabel.Size = new System.Drawing.Size(99, 17);
            second_nameLabel.TabIndex = 5;
            second_nameLabel.Text = "Second name:";
            // 
            // second_nameTextBox
            // 
            this.second_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "Second name", true));
            this.second_nameTextBox.Location = new System.Drawing.Point(117, 95);
            this.second_nameTextBox.Name = "second_nameTextBox";
            this.second_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.second_nameTextBox.TabIndex = 6;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(12, 126);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(69, 17);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(117, 123);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnameTextBox.TabIndex = 8;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(12, 155);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(91, 17);
            date_of_BirthLabel.TabIndex = 9;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.producersBindingSource, "Date of Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(117, 151);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_of_BirthDateTimePicker.TabIndex = 10;
            // 
            // citizenshipLabel
            // 
            citizenshipLabel.AutoSize = true;
            citizenshipLabel.Location = new System.Drawing.Point(12, 182);
            citizenshipLabel.Name = "citizenshipLabel";
            citizenshipLabel.Size = new System.Drawing.Size(80, 17);
            citizenshipLabel.TabIndex = 11;
            citizenshipLabel.Text = "Citizenship:";
            // 
            // citizenshipTextBox
            // 
            this.citizenshipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "Citizenship", true));
            this.citizenshipTextBox.Location = new System.Drawing.Point(117, 179);
            this.citizenshipTextBox.Name = "citizenshipTextBox";
            this.citizenshipTextBox.Size = new System.Drawing.Size(200, 22);
            this.citizenshipTextBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(107, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 49);
            this.button2.TabIndex = 44;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(15, 251);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(53, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 74;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // ChangeProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(id_producerLabel);
            this.Controls.Add(this.id_producerTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(second_nameLabel);
            this.Controls.Add(this.second_nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(citizenshipLabel);
            this.Controls.Add(this.citizenshipTextBox);
            this.Controls.Add(this.producersBindingNavigator);
            this.Name = "ChangeProducer";
            this.Text = "ChangeProducer";
            this.Load += new System.EventHandler(this.ChangeProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingNavigator)).EndInit();
            this.producersBindingNavigator.ResumeLayout(false);
            this.producersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private SeriesDataSetTableAdapters.ProducersTableAdapter producersTableAdapter;
        private SeriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator producersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_producerTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox second_nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox citizenshipTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}