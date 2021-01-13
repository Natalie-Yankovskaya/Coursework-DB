namespace DB_Series
{
    partial class AddStudio
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
            System.Windows.Forms.Label release_dateLabel;
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Slogan = new System.Windows.Forms.TextBox();
            this.Founder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studiosTableAdapter = new DB_Series.SeriesDataSetTableAdapters.StudiosTableAdapter();
            this.tableAdapterManager = new DB_Series.SeriesDataSetTableAdapters.TableAdapterManager();
            titleLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            release_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(49, 17);
            titleLabel.TabIndex = 21;
            titleLabel.Text = "Name:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(23, 80);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(56, 17);
            genreLabel.TabIndex = 22;
            genreLabel.Text = "Slogan:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(23, 108);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(65, 17);
            countryLabel.TabIndex = 23;
            countryLabel.Text = "Founder:";
            // 
            // release_dateLabel
            // 
            release_dateLabel.AutoSize = true;
            release_dateLabel.Location = new System.Drawing.Point(23, 53);
            release_dateLabel.Name = "release_dateLabel";
            release_dateLabel.Size = new System.Drawing.Size(61, 17);
            release_dateLabel.TabIndex = 25;
            release_dateLabel.Text = "Country:";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(90, 22);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(200, 22);
            this.Name1.TabIndex = 30;
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
            this.Country.Location = new System.Drawing.Point(90, 50);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(200, 24);
            this.Country.TabIndex = 34;
            // 
            // Slogan
            // 
            this.Slogan.Location = new System.Drawing.Point(90, 80);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(200, 22);
            this.Slogan.TabIndex = 35;
            // 
            // Founder
            // 
            this.Founder.Location = new System.Drawing.Point(90, 108);
            this.Founder.Name = "Founder";
            this.Founder.Size = new System.Drawing.Size(200, 22);
            this.Founder.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "ЗАКРЫТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Teal;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(175, 150);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(114, 40);
            this.Delete.TabIndex = 43;
            this.Delete.Text = "ДОБАВИТЬ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // seriesDataSet
            // 
            this.seriesDataSet.DataSetName = "SeriesDataSet";
            this.seriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataMember = "Studios";
            this.studiosBindingSource.DataSource = this.seriesDataSet;
            // 
            // studiosTableAdapter
            // 
            this.studiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = this.studiosTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB_Series.SeriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Founder);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Name1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(genreLabel);
            this.Controls.Add(countryLabel);
            this.Controls.Add(release_dateLabel);
            this.Name = "AddStudio";
            this.Text = "AddStudio";
            this.Load += new System.EventHandler(this.AddStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.TextBox Slogan;
        private System.Windows.Forms.TextBox Founder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private SeriesDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private SeriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}