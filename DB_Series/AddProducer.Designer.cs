namespace DB_Series
{
    partial class AddProducer
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label sloganLabel;
            System.Windows.Forms.Label release_dateLabel;
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producersTableAdapter = new DB_Series.SeriesDataSetTableAdapters.ProducersTableAdapter();
            this.tableAdapterManager = new DB_Series.SeriesDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            sloganLabel = new System.Windows.Forms.Label();
            release_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(26, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(49, 17);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "Name:";
            titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(26, 53);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(99, 17);
            genreLabel.TabIndex = 17;
            genreLabel.Text = "Second name:";
            genreLabel.Click += new System.EventHandler(this.genreLabel_Click);
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(26, 81);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(69, 17);
            countryLabel.TabIndex = 18;
            countryLabel.Text = "Surname:";
            countryLabel.Click += new System.EventHandler(this.countryLabel_Click);
            // 
            // sloganLabel
            // 
            sloganLabel.AutoSize = true;
            sloganLabel.Location = new System.Drawing.Point(26, 109);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new System.Drawing.Size(90, 17);
            sloganLabel.TabIndex = 19;
            sloganLabel.Text = "Date of birth:";
            sloganLabel.Click += new System.EventHandler(this.sloganLabel_Click);
            // 
            // release_dateLabel
            // 
            release_dateLabel.AutoSize = true;
            release_dateLabel.Location = new System.Drawing.Point(26, 138);
            release_dateLabel.Name = "release_dateLabel";
            release_dateLabel.Size = new System.Drawing.Size(76, 17);
            release_dateLabel.TabIndex = 20;
            release_dateLabel.Text = "Citizenship";
            release_dateLabel.Click += new System.EventHandler(this.release_dateLabel_Click);
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(128, 25);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(200, 22);
            this.Name1.TabIndex = 29;
            this.Name1.TextChanged += new System.EventHandler(this.Name1_TextChanged);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(128, 53);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(200, 22);
            this.Second.TabIndex = 30;
            this.Second.TextChanged += new System.EventHandler(this.Second_TextChanged);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(128, 81);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(200, 22);
            this.Surname.TabIndex = 31;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(128, 109);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 32;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Австралия",
            "Великобритания",
            "Индия",
            "Испания",
            "Италия",
            "Канада",
            "Китай",
            "Корея",
            "Норвегия",
            "Россия",
            "США",
            "Турция",
            "Украина",
            "Франция"});
            this.Country.Location = new System.Drawing.Point(128, 138);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(200, 24);
            this.Country.TabIndex = 33;
            this.Country.SelectedIndexChanged += new System.EventHandler(this.Country_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Teal;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(196, 177);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(114, 40);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "ДОБАВИТЬ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
            this.tableAdapterManager.Users1TableAdapter = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(47, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 42;
            this.button1.Text = "ЗАКРЫТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Name1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(genreLabel);
            this.Controls.Add(countryLabel);
            this.Controls.Add(sloganLabel);
            this.Controls.Add(release_dateLabel);
            this.Name = "AddProducer";
            this.Text = "AddProducer";
            this.Load += new System.EventHandler(this.AddProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Button Delete;
        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private SeriesDataSetTableAdapters.ProducersTableAdapter producersTableAdapter;
        private SeriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
    }
}