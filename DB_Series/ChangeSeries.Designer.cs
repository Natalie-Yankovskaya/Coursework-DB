namespace DB_Series
{
    partial class ChangeSeries
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
            System.Windows.Forms.Label id_seriesLabel;
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
            System.Windows.Forms.Label total_durationLabel;
            System.Windows.Forms.Label сompletion_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSeries));
            this.seriesDataSet = new DB_Series.SeriesDataSet();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesTableAdapter = new DB_Series.SeriesDataSetTableAdapters.SeriesTableAdapter();
            this.tableAdapterManager = new DB_Series.SeriesDataSetTableAdapters.TableAdapterManager();
            this.seriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button2 = new System.Windows.Forms.Button();
            this.id_seriesTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.sloganTextBox = new System.Windows.Forms.TextBox();
            this.release_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.id_producerTextBox = new System.Windows.Forms.TextBox();
            this.id_studioTextBox = new System.Windows.Forms.TextBox();
            this.episode_durationTextBox = new System.Windows.Forms.TextBox();
            this.number_of_seasonsTextBox = new System.Windows.Forms.TextBox();
            this.number_of_episodesTextBox = new System.Windows.Forms.TextBox();
            this.total_durationTextBox = new System.Windows.Forms.TextBox();
            this.сompletion_dateTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            id_seriesLabel = new System.Windows.Forms.Label();
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
            total_durationLabel = new System.Windows.Forms.Label();
            сompletion_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).BeginInit();
            this.seriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // id_seriesLabel
            // 
            id_seriesLabel.AutoSize = true;
            id_seriesLabel.Location = new System.Drawing.Point(12, 43);
            id_seriesLabel.Name = "id_seriesLabel";
            id_seriesLabel.Size = new System.Drawing.Size(65, 17);
            id_seriesLabel.TabIndex = 43;
            id_seriesLabel.Text = "Id series:";
            id_seriesLabel.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 71);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 45;
            titleLabel.Text = "Title:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(12, 99);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(52, 17);
            genreLabel.TabIndex = 47;
            genreLabel.Text = "Genre:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(12, 127);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 49;
            countryLabel.Text = "Country:";
            // 
            // sloganLabel
            // 
            sloganLabel.AutoSize = true;
            sloganLabel.Location = new System.Drawing.Point(12, 155);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new System.Drawing.Size(56, 17);
            sloganLabel.TabIndex = 51;
            sloganLabel.Text = "Slogan:";
            // 
            // release_dateLabel
            // 
            release_dateLabel.AutoSize = true;
            release_dateLabel.Location = new System.Drawing.Point(12, 184);
            release_dateLabel.Name = "release_dateLabel";
            release_dateLabel.Size = new System.Drawing.Size(96, 17);
            release_dateLabel.TabIndex = 53;
            release_dateLabel.Text = "Release date:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(12, 238);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(53, 17);
            ratingLabel.TabIndex = 55;
            ratingLabel.Text = "Rating:";
            // 
            // id_producerLabel
            // 
            id_producerLabel.AutoSize = true;
            id_producerLabel.Location = new System.Drawing.Point(12, 266);
            id_producerLabel.Name = "id_producerLabel";
            id_producerLabel.Size = new System.Drawing.Size(84, 17);
            id_producerLabel.TabIndex = 57;
            id_producerLabel.Text = "Id producer:";
            // 
            // id_studioLabel
            // 
            id_studioLabel.AutoSize = true;
            id_studioLabel.Location = new System.Drawing.Point(12, 294);
            id_studioLabel.Name = "id_studioLabel";
            id_studioLabel.Size = new System.Drawing.Size(65, 17);
            id_studioLabel.TabIndex = 59;
            id_studioLabel.Text = "Id studio:";
            // 
            // episode_durationLabel
            // 
            episode_durationLabel.AutoSize = true;
            episode_durationLabel.Location = new System.Drawing.Point(12, 322);
            episode_durationLabel.Name = "episode_durationLabel";
            episode_durationLabel.Size = new System.Drawing.Size(119, 17);
            episode_durationLabel.TabIndex = 61;
            episode_durationLabel.Text = "Episode duration:";
            // 
            // number_of_seasonsLabel
            // 
            number_of_seasonsLabel.AutoSize = true;
            number_of_seasonsLabel.Location = new System.Drawing.Point(12, 350);
            number_of_seasonsLabel.Name = "number_of_seasonsLabel";
            number_of_seasonsLabel.Size = new System.Drawing.Size(135, 17);
            number_of_seasonsLabel.TabIndex = 63;
            number_of_seasonsLabel.Text = "Number of seasons:";
            // 
            // number_of_episodesLabel
            // 
            number_of_episodesLabel.AutoSize = true;
            number_of_episodesLabel.Location = new System.Drawing.Point(12, 378);
            number_of_episodesLabel.Name = "number_of_episodesLabel";
            number_of_episodesLabel.Size = new System.Drawing.Size(139, 17);
            number_of_episodesLabel.TabIndex = 65;
            number_of_episodesLabel.Text = "Number of episodes:";
            // 
            // total_durationLabel
            // 
            total_durationLabel.AutoSize = true;
            total_durationLabel.Location = new System.Drawing.Point(12, 406);
            total_durationLabel.Name = "total_durationLabel";
            total_durationLabel.Size = new System.Drawing.Size(100, 17);
            total_durationLabel.TabIndex = 67;
            total_durationLabel.Text = "Total duration:";
            total_durationLabel.Visible = false;
            // 
            // сompletion_dateLabel
            // 
            сompletion_dateLabel.AutoSize = true;
            сompletion_dateLabel.Location = new System.Drawing.Point(12, 211);
            сompletion_dateLabel.Name = "сompletion_dateLabel";
            сompletion_dateLabel.Size = new System.Drawing.Size(114, 17);
            сompletion_dateLabel.TabIndex = 69;
            сompletion_dateLabel.Text = "Сompletion date:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SeriesTableAdapter = this.seriesTableAdapter;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Series.SeriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users1TableAdapter = null;
            // 
            // seriesBindingNavigator
            // 
            this.seriesBindingNavigator.AddNewItem = null;
            this.seriesBindingNavigator.BindingSource = this.seriesBindingSource;
            this.seriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seriesBindingNavigator.DeleteItem = null;
            this.seriesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.seriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.seriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seriesBindingNavigator.Name = "seriesBindingNavigator";
            this.seriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seriesBindingNavigator.Size = new System.Drawing.Size(382, 27);
            this.seriesBindingNavigator.TabIndex = 0;
            this.seriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(115, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 50);
            this.button2.TabIndex = 43;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_seriesTextBox
            // 
            this.id_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Id_series", true));
            this.id_seriesTextBox.Location = new System.Drawing.Point(157, 40);
            this.id_seriesTextBox.Name = "id_seriesTextBox";
            this.id_seriesTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_seriesTextBox.TabIndex = 44;
            this.id_seriesTextBox.Visible = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(157, 68);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 22);
            this.titleTextBox.TabIndex = 46;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(157, 96);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(200, 22);
            this.genreTextBox.TabIndex = 48;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(157, 124);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 22);
            this.countryTextBox.TabIndex = 50;
            // 
            // sloganTextBox
            // 
            this.sloganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Slogan", true));
            this.sloganTextBox.Location = new System.Drawing.Point(157, 152);
            this.sloganTextBox.Name = "sloganTextBox";
            this.sloganTextBox.Size = new System.Drawing.Size(200, 22);
            this.sloganTextBox.TabIndex = 52;
            // 
            // release_dateDateTimePicker
            // 
            this.release_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seriesBindingSource, "Release date", true));
            this.release_dateDateTimePicker.Location = new System.Drawing.Point(157, 180);
            this.release_dateDateTimePicker.Name = "release_dateDateTimePicker";
            this.release_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.release_dateDateTimePicker.TabIndex = 54;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(157, 235);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 22);
            this.ratingTextBox.TabIndex = 56;
            // 
            // id_producerTextBox
            // 
            this.id_producerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Id_producer", true));
            this.id_producerTextBox.Location = new System.Drawing.Point(157, 263);
            this.id_producerTextBox.Name = "id_producerTextBox";
            this.id_producerTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_producerTextBox.TabIndex = 58;
            // 
            // id_studioTextBox
            // 
            this.id_studioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Id_studio", true));
            this.id_studioTextBox.Location = new System.Drawing.Point(157, 291);
            this.id_studioTextBox.Name = "id_studioTextBox";
            this.id_studioTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_studioTextBox.TabIndex = 60;
            // 
            // episode_durationTextBox
            // 
            this.episode_durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Episode duration", true));
            this.episode_durationTextBox.Location = new System.Drawing.Point(157, 319);
            this.episode_durationTextBox.Name = "episode_durationTextBox";
            this.episode_durationTextBox.Size = new System.Drawing.Size(200, 22);
            this.episode_durationTextBox.TabIndex = 62;
            // 
            // number_of_seasonsTextBox
            // 
            this.number_of_seasonsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Number of seasons", true));
            this.number_of_seasonsTextBox.Location = new System.Drawing.Point(157, 347);
            this.number_of_seasonsTextBox.Name = "number_of_seasonsTextBox";
            this.number_of_seasonsTextBox.Size = new System.Drawing.Size(200, 22);
            this.number_of_seasonsTextBox.TabIndex = 64;
            // 
            // number_of_episodesTextBox
            // 
            this.number_of_episodesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Number of episodes", true));
            this.number_of_episodesTextBox.Location = new System.Drawing.Point(157, 375);
            this.number_of_episodesTextBox.Name = "number_of_episodesTextBox";
            this.number_of_episodesTextBox.Size = new System.Drawing.Size(200, 22);
            this.number_of_episodesTextBox.TabIndex = 66;
            // 
            // total_durationTextBox
            // 
            this.total_durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Total duration", true));
            this.total_durationTextBox.Location = new System.Drawing.Point(157, 403);
            this.total_durationTextBox.Name = "total_durationTextBox";
            this.total_durationTextBox.Size = new System.Drawing.Size(200, 22);
            this.total_durationTextBox.TabIndex = 68;
            this.total_durationTextBox.Visible = false;
            // 
            // сompletion_dateTextBox
            // 
            this.сompletion_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seriesBindingSource, "Сompletion date", true));
            this.сompletion_dateTextBox.Location = new System.Drawing.Point(157, 208);
            this.сompletion_dateTextBox.Name = "сompletion_dateTextBox";
            this.сompletion_dateTextBox.Size = new System.Drawing.Size(200, 22);
            this.сompletion_dateTextBox.TabIndex = 70;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(15, 443);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(62, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 74;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // ChangeSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 500);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(id_seriesLabel);
            this.Controls.Add(this.id_seriesTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(sloganLabel);
            this.Controls.Add(this.sloganTextBox);
            this.Controls.Add(release_dateLabel);
            this.Controls.Add(this.release_dateDateTimePicker);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(id_producerLabel);
            this.Controls.Add(this.id_producerTextBox);
            this.Controls.Add(id_studioLabel);
            this.Controls.Add(this.id_studioTextBox);
            this.Controls.Add(episode_durationLabel);
            this.Controls.Add(this.episode_durationTextBox);
            this.Controls.Add(number_of_seasonsLabel);
            this.Controls.Add(this.number_of_seasonsTextBox);
            this.Controls.Add(number_of_episodesLabel);
            this.Controls.Add(this.number_of_episodesTextBox);
            this.Controls.Add(total_durationLabel);
            this.Controls.Add(this.total_durationTextBox);
            this.Controls.Add(сompletion_dateLabel);
            this.Controls.Add(this.сompletion_dateTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seriesBindingNavigator);
            this.Name = "ChangeSeries";
            this.Text = "ChangeSeries";
            this.Load += new System.EventHandler(this.ChangeSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingNavigator)).EndInit();
            this.seriesBindingNavigator.ResumeLayout(false);
            this.seriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeriesDataSet seriesDataSet;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private SeriesDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private SeriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator seriesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox id_seriesTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox sloganTextBox;
        private System.Windows.Forms.DateTimePicker release_dateDateTimePicker;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox id_producerTextBox;
        private System.Windows.Forms.TextBox id_studioTextBox;
        private System.Windows.Forms.TextBox episode_durationTextBox;
        private System.Windows.Forms.TextBox number_of_seasonsTextBox;
        private System.Windows.Forms.TextBox number_of_episodesTextBox;
        private System.Windows.Forms.TextBox total_durationTextBox;
        private System.Windows.Forms.TextBox сompletion_dateTextBox;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}