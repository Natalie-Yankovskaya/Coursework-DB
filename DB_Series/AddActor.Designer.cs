namespace DB_Series
{
    partial class AddActor
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label sloganLabel;
            System.Windows.Forms.Label release_dateLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.seriesDataSet1 = new DB_Series.SeriesDataSet();
            this.actorsTableAdapter1 = new DB_Series.SeriesDataSetTableAdapters.ActorsTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            sloganLabel = new System.Windows.Forms.Label();
            release_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(49, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "ЗАКРЫТЬ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Teal;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(198, 187);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(114, 40);
            this.Delete.TabIndex = 53;
            this.Delete.Text = "ДОБАВИТЬ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
            this.Country.Location = new System.Drawing.Point(130, 148);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(200, 24);
            this.Country.TabIndex = 52;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(130, 119);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 51;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(130, 91);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(200, 22);
            this.Surname.TabIndex = 50;
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(130, 63);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(200, 22);
            this.Second.TabIndex = 49;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(130, 35);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(200, 22);
            this.Name1.TabIndex = 48;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(28, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(49, 17);
            titleLabel.TabIndex = 43;
            titleLabel.Text = "Name:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(28, 63);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(99, 17);
            genreLabel.TabIndex = 44;
            genreLabel.Text = "Second name:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(28, 91);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(69, 17);
            countryLabel.TabIndex = 45;
            countryLabel.Text = "Surname:";
            // 
            // sloganLabel
            // 
            sloganLabel.AutoSize = true;
            sloganLabel.Location = new System.Drawing.Point(28, 119);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new System.Drawing.Size(90, 17);
            sloganLabel.TabIndex = 46;
            sloganLabel.Text = "Date of birth:";
            // 
            // release_dateLabel
            // 
            release_dateLabel.AutoSize = true;
            release_dateLabel.Location = new System.Drawing.Point(28, 148);
            release_dateLabel.Name = "release_dateLabel";
            release_dateLabel.Size = new System.Drawing.Size(76, 17);
            release_dateLabel.TabIndex = 47;
            release_dateLabel.Text = "Citizenship";
            // 
            // seriesDataSet1
            // 
            this.seriesDataSet1.DataSetName = "SeriesDataSet";
            this.seriesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actorsTableAdapter1
            // 
            this.actorsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 264);
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
            this.Name = "AddActor";
            this.Text = "AddActor";
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.TextBox Name1;
        private SeriesDataSet seriesDataSet1;
        private SeriesDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter1;
    }
}