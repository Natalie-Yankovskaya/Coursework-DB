namespace DB_Series
{
    partial class AddRole
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
            System.Windows.Forms.Label id_producerLabel;
            System.Windows.Forms.Label id_studioLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRole));
            this.Studio = new System.Windows.Forms.ComboBox();
            this.Producer = new System.Windows.Forms.ComboBox();
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new DB_Series.SeriesDataSetTableAdapters.SeriesTableAdapter();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new DB_Series.SeriesDataSetTableAdapters.ActorsTableAdapter();
            this.Role = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            id_producerLabel = new System.Windows.Forms.Label();
            id_studioLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // Studio
            // 
            this.Studio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.actorsBindingSource, "Id_actor", true));
            this.Studio.DataSource = this.actorsBindingSource;
            this.Studio.DisplayMember = "Name";
            this.Studio.FormattingEnabled = true;
            this.Studio.Location = new System.Drawing.Point(128, 64);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(129, 24);
            this.Studio.TabIndex = 41;
            this.Studio.ValueMember = "Id_actor";
            // 
            // Producer
            // 
            this.Producer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.seriesBindingSource, "Id_series", true));
            this.Producer.DataSource = this.seriesBindingSource;
            this.Producer.DisplayMember = "Title";
            this.Producer.FormattingEnabled = true;
            this.Producer.Location = new System.Drawing.Point(128, 36);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(129, 24);
            this.Producer.TabIndex = 40;
            this.Producer.ValueMember = "Id_series";
            // 
            // id_producerLabel
            // 
            id_producerLabel.AutoSize = true;
            id_producerLabel.Location = new System.Drawing.Point(41, 39);
            id_producerLabel.Name = "id_producerLabel";
            id_producerLabel.Size = new System.Drawing.Size(52, 17);
            id_producerLabel.TabIndex = 38;
            id_producerLabel.Text = "Series:";
            // 
            // id_studioLabel
            // 
            id_studioLabel.AutoSize = true;
            id_studioLabel.Location = new System.Drawing.Point(41, 67);
            id_studioLabel.Name = "id_studioLabel";
            id_studioLabel.Size = new System.Drawing.Size(45, 17);
            id_studioLabel.TabIndex = 39;
            id_studioLabel.Text = "Actor:";
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
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.seriesDataSet;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // Role
            // 
            this.Role.Location = new System.Drawing.Point(128, 94);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(129, 22);
            this.Role.TabIndex = 43;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(41, 97);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(41, 17);
            titleLabel.TabIndex = 42;
            titleLabel.Text = "Role:";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Teal;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(140, 134);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 45);
            this.Delete.TabIndex = 44;
            this.Delete.Text = "ДОБАВИТЬ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(33, 136);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(60, 43);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 78;
            this.pictureBox9.TabStop = false;
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 219);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Role);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.Studio);
            this.Controls.Add(this.Producer);
            this.Controls.Add(id_producerLabel);
            this.Controls.Add(id_studioLabel);
            this.Name = "AddRole";
            this.Text = "AddRole";
            this.Load += new System.EventHandler(this.AddRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Studio;
        private System.Windows.Forms.ComboBox Producer;
        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private SeriesDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private SeriesDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.TextBox Role;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}