namespace DB_Series
{
    partial class AddUser
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
            this.Slogan = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Series = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new DB_Series.SeriesDataSetTableAdapters.SeriesTableAdapter();
            this.Delete = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            sloganLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Slogan
            // 
            this.Slogan.Location = new System.Drawing.Point(163, 53);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(200, 22);
            this.Slogan.TabIndex = 93;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(163, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 22);
            this.Title.TabIndex = 90;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(25, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 78;
            titleLabel.Text = "Имя:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(25, 53);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(70, 17);
            genreLabel.TabIndex = 79;
            genreLabel.Text = "Фамилия";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(25, 81);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(53, 17);
            countryLabel.TabIndex = 80;
            countryLabel.Text = "Почта:";
            // 
            // sloganLabel
            // 
            sloganLabel.AutoSize = true;
            sloganLabel.Location = new System.Drawing.Point(25, 109);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new System.Drawing.Size(117, 17);
            sloganLabel.TabIndex = 81;
            sloganLabel.Text = "Текущий сериал";
            // 
            // Series
            // 
            this.Series.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.seriesBindingSource, "Id_series", true));
            this.Series.DataSource = this.seriesBindingSource;
            this.Series.DisplayMember = "Title";
            this.Series.FormattingEnabled = true;
            this.Series.Location = new System.Drawing.Point(163, 109);
            this.Series.Name = "Series";
            this.Series.Size = new System.Drawing.Size(200, 24);
            this.Series.TabIndex = 92;
            this.Series.ValueMember = "Id_series";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 94;
            // 
            // seriesDataSet
            // 
            this.seriesDataSet.DataSetName = "SeriesDataSet";
            this.seriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.seriesDataSet;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Teal;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(208, 154);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 50);
            this.Delete.TabIndex = 95;
            this.Delete.Text = "ДОБАВИТЬ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 256);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.Series);
            this.Controls.Add(this.Title);
            this.Controls.Add(titleLabel);
            this.Controls.Add(genreLabel);
            this.Controls.Add(countryLabel);
            this.Controls.Add(sloganLabel);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Slogan;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.ComboBox Series;
        private System.Windows.Forms.TextBox textBox1;
        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private SeriesDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.Button Delete;
    }
}