namespace DB_Series
{
    partial class ChangeRole
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
            System.Windows.Forms.Label id_roleLabel;
            System.Windows.Forms.Label id_seriesLabel;
            System.Windows.Forms.Label id_actorLabel;
            System.Windows.Forms.Label roleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeRole));
            System.Windows.Forms.Label id_roleLabel1;
            System.Windows.Forms.Label id_seriesLabel1;
            System.Windows.Forms.Label id_actorLabel1;
            System.Windows.Forms.Label roleLabel1;
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new DB_Series.SeriesDataSetTableAdapters.RolesTableAdapter();
            this.tableAdapterManager = new DB_Series.SeriesDataSetTableAdapters.TableAdapterManager();
            this.id_roleTextBox = new System.Windows.Forms.TextBox();
            this.id_seriesTextBox = new System.Windows.Forms.TextBox();
            this.id_actorTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rolesTableAdapter1 = new DB_Series.SeriesDataSetTableAdapters.RolesTableAdapter();
            this.id_roleTextBox1 = new System.Windows.Forms.TextBox();
            this.id_seriesTextBox1 = new System.Windows.Forms.TextBox();
            this.id_actorTextBox1 = new System.Windows.Forms.TextBox();
            this.roleTextBox1 = new System.Windows.Forms.TextBox();
            id_roleLabel = new System.Windows.Forms.Label();
            id_seriesLabel = new System.Windows.Forms.Label();
            id_actorLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            id_roleLabel1 = new System.Windows.Forms.Label();
            id_seriesLabel1 = new System.Windows.Forms.Label();
            id_actorLabel1 = new System.Windows.Forms.Label();
            roleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).BeginInit();
            this.rolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // id_roleLabel
            // 
            id_roleLabel.AutoSize = true;
            id_roleLabel.Location = new System.Drawing.Point(52, 508);
            id_roleLabel.Name = "id_roleLabel";
            id_roleLabel.Size = new System.Drawing.Size(51, 17);
            id_roleLabel.TabIndex = 1;
            id_roleLabel.Text = "Id role:";
            id_roleLabel.Visible = false;
            // 
            // id_seriesLabel
            // 
            id_seriesLabel.AutoSize = true;
            id_seriesLabel.Location = new System.Drawing.Point(52, 58);
            id_seriesLabel.Name = "id_seriesLabel";
            id_seriesLabel.Size = new System.Drawing.Size(65, 17);
            id_seriesLabel.TabIndex = 3;
            id_seriesLabel.Text = "Id series:";
            // 
            // id_actorLabel
            // 
            id_actorLabel.AutoSize = true;
            id_actorLabel.Location = new System.Drawing.Point(52, 86);
            id_actorLabel.Name = "id_actorLabel";
            id_actorLabel.Size = new System.Drawing.Size(59, 17);
            id_actorLabel.TabIndex = 5;
            id_actorLabel.Text = "Id actor:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(52, 114);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(41, 17);
            roleLabel.TabIndex = 7;
            roleLabel.Text = "Role:";
            // 
            // seriesDataSet
            // 
            this.seriesDataSet.DataSetName = "SeriesDataSet";
            this.seriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.seriesDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.SeriesTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Series.SeriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users1TableAdapter = null;
            // 
            // id_roleTextBox
            // 
            this.id_roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Id_role", true));
            this.id_roleTextBox.Location = new System.Drawing.Point(123, 505);
            this.id_roleTextBox.Name = "id_roleTextBox";
            this.id_roleTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_roleTextBox.TabIndex = 2;
            this.id_roleTextBox.Visible = false;
            // 
            // id_seriesTextBox
            // 
            this.id_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Id_series", true));
            this.id_seriesTextBox.Location = new System.Drawing.Point(123, 55);
            this.id_seriesTextBox.Name = "id_seriesTextBox";
            this.id_seriesTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_seriesTextBox.TabIndex = 4;
            // 
            // id_actorTextBox
            // 
            this.id_actorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Id_actor", true));
            this.id_actorTextBox.Location = new System.Drawing.Point(123, 83);
            this.id_actorTextBox.Name = "id_actorTextBox";
            this.id_actorTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_actorTextBox.TabIndex = 6;
            // 
            // roleTextBox
            // 
            this.roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Role", true));
            this.roleTextBox.Location = new System.Drawing.Point(123, 111);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(100, 22);
            this.roleTextBox.TabIndex = 8;
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
            // rolesBindingNavigator
            // 
            this.rolesBindingNavigator.AddNewItem = null;
            this.rolesBindingNavigator.BindingSource = this.rolesBindingSource;
            this.rolesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rolesBindingNavigator.DeleteItem = null;
            this.rolesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.rolesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rolesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rolesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rolesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rolesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rolesBindingNavigator.Name = "rolesBindingNavigator";
            this.rolesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rolesBindingNavigator.Size = new System.Drawing.Size(876, 27);
            this.rolesBindingNavigator.TabIndex = 0;
            this.rolesBindingNavigator.Text = "bindingNavigator1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(23, 166);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(62, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 76;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(123, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 50);
            this.button2.TabIndex = 75;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // id_roleLabel1
            // 
            id_roleLabel1.AutoSize = true;
            id_roleLabel1.Location = new System.Drawing.Point(449, 397);
            id_roleLabel1.Name = "id_roleLabel1";
            id_roleLabel1.Size = new System.Drawing.Size(51, 17);
            id_roleLabel1.TabIndex = 76;
            id_roleLabel1.Text = "Id role:";
            // 
            // id_roleTextBox1
            // 
            this.id_roleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Id_role", true));
            this.id_roleTextBox1.Location = new System.Drawing.Point(520, 394);
            this.id_roleTextBox1.Name = "id_roleTextBox1";
            this.id_roleTextBox1.Size = new System.Drawing.Size(100, 22);
            this.id_roleTextBox1.TabIndex = 77;
            // 
            // id_seriesLabel1
            // 
            id_seriesLabel1.AutoSize = true;
            id_seriesLabel1.Location = new System.Drawing.Point(449, 425);
            id_seriesLabel1.Name = "id_seriesLabel1";
            id_seriesLabel1.Size = new System.Drawing.Size(65, 17);
            id_seriesLabel1.TabIndex = 78;
            id_seriesLabel1.Text = "Id series:";
            // 
            // id_seriesTextBox1
            // 
            this.id_seriesTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Id_series", true));
            this.id_seriesTextBox1.Location = new System.Drawing.Point(520, 422);
            this.id_seriesTextBox1.Name = "id_seriesTextBox1";
            this.id_seriesTextBox1.Size = new System.Drawing.Size(100, 22);
            this.id_seriesTextBox1.TabIndex = 79;
            // 
            // id_actorLabel1
            // 
            id_actorLabel1.AutoSize = true;
            id_actorLabel1.Location = new System.Drawing.Point(449, 453);
            id_actorLabel1.Name = "id_actorLabel1";
            id_actorLabel1.Size = new System.Drawing.Size(59, 17);
            id_actorLabel1.TabIndex = 80;
            id_actorLabel1.Text = "Id actor:";
            // 
            // id_actorTextBox1
            // 
            this.id_actorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Id_actor", true));
            this.id_actorTextBox1.Location = new System.Drawing.Point(520, 450);
            this.id_actorTextBox1.Name = "id_actorTextBox1";
            this.id_actorTextBox1.Size = new System.Drawing.Size(100, 22);
            this.id_actorTextBox1.TabIndex = 81;
            // 
            // roleLabel1
            // 
            roleLabel1.AutoSize = true;
            roleLabel1.Location = new System.Drawing.Point(449, 481);
            roleLabel1.Name = "roleLabel1";
            roleLabel1.Size = new System.Drawing.Size(41, 17);
            roleLabel1.TabIndex = 82;
            roleLabel1.Text = "Role:";
            // 
            // roleTextBox1
            // 
            this.roleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Role", true));
            this.roleTextBox1.Location = new System.Drawing.Point(520, 478);
            this.roleTextBox1.Name = "roleTextBox1";
            this.roleTextBox1.Size = new System.Drawing.Size(100, 22);
            this.roleTextBox1.TabIndex = 83;
            // 
            // ChangeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 596);
            this.Controls.Add(id_roleLabel1);
            this.Controls.Add(this.id_roleTextBox1);
            this.Controls.Add(id_seriesLabel1);
            this.Controls.Add(this.id_seriesTextBox1);
            this.Controls.Add(id_actorLabel1);
            this.Controls.Add(this.id_actorTextBox1);
            this.Controls.Add(roleLabel1);
            this.Controls.Add(this.roleTextBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(id_roleLabel);
            this.Controls.Add(this.id_roleTextBox);
            this.Controls.Add(id_seriesLabel);
            this.Controls.Add(this.id_seriesTextBox);
            this.Controls.Add(id_actorLabel);
            this.Controls.Add(this.id_actorTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.rolesBindingNavigator);
            this.Name = "ChangeRole";
            this.Text = "ChangeRole";
            this.Load += new System.EventHandler(this.ChangeRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).EndInit();
            this.rolesBindingNavigator.ResumeLayout(false);
            this.rolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private SeriesDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private SeriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_roleTextBox;
        private System.Windows.Forms.TextBox id_seriesTextBox;
        private System.Windows.Forms.TextBox id_actorTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator rolesBindingNavigator;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button2;
        private SeriesDataSetTableAdapters.RolesTableAdapter rolesTableAdapter1;
        private System.Windows.Forms.TextBox id_roleTextBox1;
        private System.Windows.Forms.TextBox id_seriesTextBox1;
        private System.Windows.Forms.TextBox id_actorTextBox1;
        private System.Windows.Forms.TextBox roleTextBox1;
    }
}