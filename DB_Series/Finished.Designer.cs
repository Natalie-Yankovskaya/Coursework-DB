namespace DB_Series
{
    partial class Finished
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label id_userLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label current_seriesLabel;
            System.Windows.Forms.Label finished_seriesLabel;
            System.Windows.Forms.Label spent_TimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finished));
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.users1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users1TableAdapter = new DB_Series.SeriesDataSetTableAdapters.Users1TableAdapter();
            this.tableAdapterManager = new DB_Series.SeriesDataSetTableAdapters.TableAdapterManager();
            this.seriesTableAdapter = new DB_Series.SeriesDataSetTableAdapters.SeriesTableAdapter();
            this.users1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.users1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.NewOne = new System.Windows.Forms.ComboBox();
            this.seriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.id_userTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.current_seriesTextBox = new System.Windows.Forms.TextBox();
            this.finished_seriesTextBox = new System.Windows.Forms.TextBox();
            this.spent_TimeTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            id_userLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            current_seriesLabel = new System.Windows.Forms.Label();
            finished_seriesLabel = new System.Windows.Forms.Label();
            spent_TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users1BindingNavigator)).BeginInit();
            this.users1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 17);
            label1.TabIndex = 79;
            label1.Text = "New Series:";
            // 
            // id_userLabel
            // 
            id_userLabel.AutoSize = true;
            id_userLabel.Location = new System.Drawing.Point(29, 48);
            id_userLabel.Name = "id_userLabel";
            id_userLabel.Size = new System.Drawing.Size(55, 17);
            id_userLabel.TabIndex = 80;
            id_userLabel.Text = "Id user:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 82;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(29, 104);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(69, 17);
            surnameLabel.TabIndex = 84;
            surnameLabel.Text = "Surname:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(743, 698);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(51, 17);
            e_mailLabel.TabIndex = 86;
            e_mailLabel.Text = "E-mail:";
            // 
            // current_seriesLabel
            // 
            current_seriesLabel.AutoSize = true;
            current_seriesLabel.Location = new System.Drawing.Point(743, 726);
            current_seriesLabel.Name = "current_seriesLabel";
            current_seriesLabel.Size = new System.Drawing.Size(101, 17);
            current_seriesLabel.TabIndex = 88;
            current_seriesLabel.Text = "Current series:";
            // 
            // finished_seriesLabel
            // 
            finished_seriesLabel.AutoSize = true;
            finished_seriesLabel.Location = new System.Drawing.Point(743, 754);
            finished_seriesLabel.Name = "finished_seriesLabel";
            finished_seriesLabel.Size = new System.Drawing.Size(107, 17);
            finished_seriesLabel.TabIndex = 90;
            finished_seriesLabel.Text = "Finished series:";
            // 
            // spent_TimeLabel
            // 
            spent_TimeLabel.AutoSize = true;
            spent_TimeLabel.Location = new System.Drawing.Point(743, 782);
            spent_TimeLabel.Name = "spent_TimeLabel";
            spent_TimeLabel.Size = new System.Drawing.Size(84, 17);
            spent_TimeLabel.TabIndex = 92;
            spent_TimeLabel.Text = "Spent Time:";
            // 
            // seriesDataSet
            // 
            this.seriesDataSet.DataSetName = "SeriesDataSet";
            this.seriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users1BindingSource
            // 
            this.users1BindingSource.DataMember = "Users1";
            this.users1BindingSource.DataSource = this.seriesDataSet;
            // 
            // users1TableAdapter
            // 
            this.users1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = this.seriesTableAdapter;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Series.SeriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users1TableAdapter = this.users1TableAdapter;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // users1BindingNavigator
            // 
            this.users1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.users1BindingNavigator.BindingSource = this.users1BindingSource;
            this.users1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.users1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.users1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.users1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.users1BindingNavigatorSaveItem});
            this.users1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.users1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.users1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.users1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.users1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.users1BindingNavigator.Name = "users1BindingNavigator";
            this.users1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.users1BindingNavigator.Size = new System.Drawing.Size(1295, 27);
            this.users1BindingNavigator.TabIndex = 0;
            this.users1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // users1BindingNavigatorSaveItem
            // 
            this.users1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.users1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("users1BindingNavigatorSaveItem.Image")));
            this.users1BindingNavigatorSaveItem.Name = "users1BindingNavigatorSaveItem";
            this.users1BindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.users1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.users1BindingNavigatorSaveItem.Click += new System.EventHandler(this.users1BindingNavigatorSaveItem_Click);
            // 
            // NewOne
            // 
            this.NewOne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.seriesBindingSource1, "Id_series", true));
            this.NewOne.DataSource = this.seriesBindingSource;
            this.NewOne.DisplayMember = "Title";
            this.NewOne.FormattingEnabled = true;
            this.NewOne.Location = new System.Drawing.Point(139, 133);
            this.NewOne.Name = "NewOne";
            this.NewOne.Size = new System.Drawing.Size(153, 24);
            this.NewOne.TabIndex = 38;
            this.NewOne.ValueMember = "Id_series";
            // 
            // seriesBindingSource1
            // 
            this.seriesBindingSource1.DataMember = "Series";
            this.seriesBindingSource1.DataSource = this.seriesDataSet;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.seriesDataSet;
            // 
            // seriesDataGridView
            // 
            this.seriesDataGridView.AllowUserToAddRows = false;
            this.seriesDataGridView.AutoGenerateColumns = false;
            this.seriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.seriesDataGridView.DataSource = this.seriesBindingSource;
            this.seriesDataGridView.Location = new System.Drawing.Point(12, 221);
            this.seriesDataGridView.Name = "seriesDataGridView";
            this.seriesDataGridView.RowTemplate.Height = 24;
            this.seriesDataGridView.Size = new System.Drawing.Size(1192, 306);
            this.seriesDataGridView.TabIndex = 38;
            this.seriesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seriesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_series";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_series";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn4.HeaderText = "Country";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Slogan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Slogan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Release date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Release date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id_producer";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id_producer";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_studio";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_studio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Episode duration";
            this.dataGridViewTextBoxColumn10.HeaderText = "Episode duration";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Number of seasons";
            this.dataGridViewTextBoxColumn11.HeaderText = "Number of seasons";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Number of episodes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Number of episodes";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Total duration";
            this.dataGridViewTextBoxColumn13.HeaderText = "Total duration";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Сompletion date";
            this.dataGridViewTextBoxColumn14.HeaderText = "Сompletion date";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(94, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 78;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(5, 533);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 48);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 80;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // id_userTextBox
            // 
            this.id_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "Id_user", true));
            this.id_userTextBox.Location = new System.Drawing.Point(142, 45);
            this.id_userTextBox.Name = "id_userTextBox";
            this.id_userTextBox.Size = new System.Drawing.Size(150, 22);
            this.id_userTextBox.TabIndex = 81;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(142, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 22);
            this.nameTextBox.TabIndex = 83;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(142, 101);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 22);
            this.surnameTextBox.TabIndex = 85;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "E-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(856, 695);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 22);
            this.e_mailTextBox.TabIndex = 87;
            // 
            // current_seriesTextBox
            // 
            this.current_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "Current series", true));
            this.current_seriesTextBox.Location = new System.Drawing.Point(856, 723);
            this.current_seriesTextBox.Name = "current_seriesTextBox";
            this.current_seriesTextBox.Size = new System.Drawing.Size(100, 22);
            this.current_seriesTextBox.TabIndex = 89;
            // 
            // finished_seriesTextBox
            // 
            this.finished_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "Finished series", true));
            this.finished_seriesTextBox.Location = new System.Drawing.Point(856, 751);
            this.finished_seriesTextBox.Name = "finished_seriesTextBox";
            this.finished_seriesTextBox.Size = new System.Drawing.Size(100, 22);
            this.finished_seriesTextBox.TabIndex = 91;
            // 
            // spent_TimeTextBox
            // 
            this.spent_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users1BindingSource, "Spent Time", true));
            this.spent_TimeTextBox.Location = new System.Drawing.Point(856, 779);
            this.spent_TimeTextBox.Name = "spent_TimeTextBox";
            this.spent_TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.spent_TimeTextBox.TabIndex = 93;
            // 
            // Finished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 596);
            this.Controls.Add(id_userLabel);
            this.Controls.Add(this.id_userTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(current_seriesLabel);
            this.Controls.Add(this.current_seriesTextBox);
            this.Controls.Add(finished_seriesLabel);
            this.Controls.Add(this.finished_seriesTextBox);
            this.Controls.Add(spent_TimeLabel);
            this.Controls.Add(this.spent_TimeTextBox);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seriesDataGridView);
            this.Controls.Add(this.NewOne);
            this.Controls.Add(this.users1BindingNavigator);
            this.Name = "Finished";
            this.Text = "Finished";
            this.Load += new System.EventHandler(this.Finished_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users1BindingNavigator)).EndInit();
            this.users1BindingNavigator.ResumeLayout(false);
            this.users1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource users1BindingSource;
        private SeriesDataSetTableAdapters.Users1TableAdapter users1TableAdapter;
        private SeriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator users1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton users1BindingNavigatorSaveItem;
        private SeriesDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.ComboBox NewOne;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private System.Windows.Forms.DataGridView seriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource seriesBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox id_userTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox current_seriesTextBox;
        private System.Windows.Forms.TextBox finished_seriesTextBox;
        private System.Windows.Forms.TextBox spent_TimeTextBox;
    }
}