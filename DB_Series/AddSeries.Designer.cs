namespace DB_Series
{
    partial class AddSeries
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
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label id_producerLabel;
            System.Windows.Forms.Label id_studioLabel;
            System.Windows.Forms.Label episode_durationLabel;
            System.Windows.Forms.Label number_of_seasonsLabel;
            System.Windows.Forms.Label number_of_episodesLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSeries));
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Title = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Slogan = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.NumericUpDown();
            this.Producer = new System.Windows.Forms.ComboBox();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producersTableAdapter = new DB_Series.SeriesDataSetTableAdapters.ProducersTableAdapter();
            this.Studio = new System.Windows.Forms.ComboBox();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studiosTableAdapter = new DB_Series.SeriesDataSetTableAdapters.StudiosTableAdapter();
            this.studiosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seasons = new System.Windows.Forms.TextBox();
            this.Episodes = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter1 = new DB_Series.SeriesDataSetTableAdapters.SeriesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producersDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            sloganLabel = new System.Windows.Forms.Label();
            release_dateLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            id_producerLabel = new System.Windows.Forms.Label();
            id_studioLabel = new System.Windows.Forms.Label();
            episode_durationLabel = new System.Windows.Forms.Label();
            number_of_seasonsLabel = new System.Windows.Forms.Label();
            number_of_episodesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(28, 27);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(28, 55);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(52, 17);
            genreLabel.TabIndex = 5;
            genreLabel.Text = "Genre:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(28, 83);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 7;
            countryLabel.Text = "Country:";
            // 
            // sloganLabel
            // 
            sloganLabel.AutoSize = true;
            sloganLabel.Location = new System.Drawing.Point(28, 111);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new System.Drawing.Size(56, 17);
            sloganLabel.TabIndex = 9;
            sloganLabel.Text = "Slogan:";
            // 
            // release_dateLabel
            // 
            release_dateLabel.AutoSize = true;
            release_dateLabel.Location = new System.Drawing.Point(28, 140);
            release_dateLabel.Name = "release_dateLabel";
            release_dateLabel.Size = new System.Drawing.Size(96, 17);
            release_dateLabel.TabIndex = 11;
            release_dateLabel.Text = "Release date:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(28, 194);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(53, 17);
            ratingLabel.TabIndex = 13;
            ratingLabel.Text = "Rating:";
            // 
            // id_producerLabel
            // 
            id_producerLabel.AutoSize = true;
            id_producerLabel.Location = new System.Drawing.Point(28, 222);
            id_producerLabel.Name = "id_producerLabel";
            id_producerLabel.Size = new System.Drawing.Size(70, 17);
            id_producerLabel.TabIndex = 15;
            id_producerLabel.Text = "Producer:";
            // 
            // id_studioLabel
            // 
            id_studioLabel.AutoSize = true;
            id_studioLabel.Location = new System.Drawing.Point(28, 250);
            id_studioLabel.Name = "id_studioLabel";
            id_studioLabel.Size = new System.Drawing.Size(52, 17);
            id_studioLabel.TabIndex = 17;
            id_studioLabel.Text = "Studio:";
            // 
            // episode_durationLabel
            // 
            episode_durationLabel.AutoSize = true;
            episode_durationLabel.Location = new System.Drawing.Point(28, 277);
            episode_durationLabel.Name = "episode_durationLabel";
            episode_durationLabel.Size = new System.Drawing.Size(119, 17);
            episode_durationLabel.TabIndex = 19;
            episode_durationLabel.Text = "Episode duration:";
            // 
            // number_of_seasonsLabel
            // 
            number_of_seasonsLabel.AutoSize = true;
            number_of_seasonsLabel.Location = new System.Drawing.Point(28, 307);
            number_of_seasonsLabel.Name = "number_of_seasonsLabel";
            number_of_seasonsLabel.Size = new System.Drawing.Size(135, 17);
            number_of_seasonsLabel.TabIndex = 21;
            number_of_seasonsLabel.Text = "Number of seasons:";
            // 
            // number_of_episodesLabel
            // 
            number_of_episodesLabel.AutoSize = true;
            number_of_episodesLabel.Location = new System.Drawing.Point(28, 337);
            number_of_episodesLabel.Name = "number_of_episodesLabel";
            number_of_episodesLabel.Size = new System.Drawing.Size(139, 17);
            number_of_episodesLabel.TabIndex = 23;
            number_of_episodesLabel.Text = "Number of episodes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 17);
            label1.TabIndex = 75;
            label1.Text = "Completion date:";
            // 
            // seriesDataSet
            // 
            this.seriesDataSet.DataSetName = "SeriesDataSet";
            this.seriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(173, 135);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(173, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 22);
            this.Title.TabIndex = 28;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "боевик",
            "детектив",
            "драма",
            "комедия",
            "криминал",
            "мелодрама",
            "мультсериал",
            "приключения",
            "триллер",
            "ужасы",
            "фантастика",
            "фэнтези"});
            this.Genre.Location = new System.Drawing.Point(173, 48);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(200, 24);
            this.Genre.TabIndex = 29;
            this.Genre.Text = "комедия";
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
            this.Country.Location = new System.Drawing.Point(173, 76);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(200, 24);
            this.Country.TabIndex = 30;
            this.Country.Text = "США";
            // 
            // Slogan
            // 
            this.Slogan.Location = new System.Drawing.Point(173, 106);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(200, 22);
            this.Slogan.TabIndex = 31;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(173, 272);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(200, 22);
            this.Duration.TabIndex = 32;
            // 
            // Rating
            // 
            this.Rating.DecimalPlaces = 1;
            this.Rating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Rating.Location = new System.Drawing.Point(173, 189);
            this.Rating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(200, 22);
            this.Rating.TabIndex = 35;
            this.Rating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Producer
            // 
            this.Producer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.producersBindingSource, "Id_producer", true));
            this.Producer.DataSource = this.producersBindingSource;
            this.Producer.DisplayMember = "Name";
            this.Producer.FormattingEnabled = true;
            this.Producer.Location = new System.Drawing.Point(173, 215);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(200, 24);
            this.Producer.TabIndex = 36;
            this.Producer.ValueMember = "Id_producer";
            this.Producer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // Studio
            // 
            this.Studio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studiosBindingSource, "Id_studio", true));
            this.Studio.DataSource = this.studiosBindingSource;
            this.Studio.DisplayMember = "Name";
            this.Studio.FormattingEnabled = true;
            this.Studio.Location = new System.Drawing.Point(173, 243);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(200, 24);
            this.Studio.TabIndex = 37;
            this.Studio.ValueMember = "Id_studio";
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
            // studiosDataGridView
            // 
            this.studiosDataGridView.AllowUserToAddRows = false;
            this.studiosDataGridView.AllowUserToDeleteRows = false;
            this.studiosDataGridView.AutoGenerateColumns = false;
            this.studiosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studiosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studiosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.studiosDataGridView.DataSource = this.studiosBindingSource;
            this.studiosDataGridView.Location = new System.Drawing.Point(453, 276);
            this.studiosDataGridView.Name = "studiosDataGridView";
            this.studiosDataGridView.RowTemplate.Height = 24;
            this.studiosDataGridView.Size = new System.Drawing.Size(519, 217);
            this.studiosDataGridView.TabIndex = 37;
            this.studiosDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_studio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_studio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn9.HeaderText = "Country";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Slogan";
            this.dataGridViewTextBoxColumn10.HeaderText = "Slogan";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Founder";
            this.dataGridViewTextBoxColumn11.HeaderText = "Founder";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Seasons
            // 
            this.Seasons.Location = new System.Drawing.Point(173, 302);
            this.Seasons.Name = "Seasons";
            this.Seasons.Size = new System.Drawing.Size(200, 22);
            this.Seasons.TabIndex = 38;
            // 
            // Episodes
            // 
            this.Episodes.Location = new System.Drawing.Point(173, 332);
            this.Episodes.Name = "Episodes";
            this.Episodes.Size = new System.Drawing.Size(200, 22);
            this.Episodes.TabIndex = 39;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Teal;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(173, 380);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 50);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "ДОБАВИТЬ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.seriesDataSet;
            // 
            // seriesTableAdapter1
            // 
            this.seriesTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(603, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 48);
            this.button2.TabIndex = 42;
            this.button2.Text = "Добавить режиссера";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(620, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 48);
            this.button3.TabIndex = 43;
            this.button3.Text = "Добавить студию";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(31, 382);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 48);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 74;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(173, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 77;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(379, 210);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(31, 27);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 115;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Citizenship";
            this.dataGridViewTextBoxColumn6.HeaderText = "Citizenship";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date of Birth";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date of Birth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Second name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Second name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_producer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_producer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // producersDataGridView
            // 
            this.producersDataGridView.AllowUserToAddRows = false;
            this.producersDataGridView.AllowUserToDeleteRows = false;
            this.producersDataGridView.AutoGenerateColumns = false;
            this.producersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.producersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.producersDataGridView.DataSource = this.producersBindingSource;
            this.producersDataGridView.Location = new System.Drawing.Point(426, 12);
            this.producersDataGridView.Name = "producersDataGridView";
            this.producersDataGridView.ReadOnly = true;
            this.producersDataGridView.RowTemplate.Height = 24;
            this.producersDataGridView.Size = new System.Drawing.Size(546, 203);
            this.producersDataGridView.TabIndex = 36;
            this.producersDataGridView.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Episodes);
            this.Controls.Add(this.Seasons);
            this.Controls.Add(this.studiosDataGridView);
            this.Controls.Add(this.Studio);
            this.Controls.Add(this.producersDataGridView);
            this.Controls.Add(this.Producer);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Date);
            this.Controls.Add(titleLabel);
            this.Controls.Add(genreLabel);
            this.Controls.Add(countryLabel);
            this.Controls.Add(sloganLabel);
            this.Controls.Add(release_dateLabel);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(id_producerLabel);
            this.Controls.Add(id_studioLabel);
            this.Controls.Add(episode_durationLabel);
            this.Controls.Add(number_of_seasonsLabel);
            this.Controls.Add(number_of_episodesLabel);
            this.Name = "AddSeries";
            this.Text = "AddSeries";
            this.Load += new System.EventHandler(this.AddSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.TextBox Slogan;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.NumericUpDown Rating;
        private SeriesDataSetTableAdapters.ProducersTableAdapter producersTableAdapter;
        private System.Windows.Forms.ComboBox Producer;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private SeriesDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private System.Windows.Forms.ComboBox Studio;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private System.Windows.Forms.DataGridView studiosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox Seasons;
        private System.Windows.Forms.TextBox Episodes;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private SeriesDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView producersDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}