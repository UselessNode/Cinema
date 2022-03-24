
namespace Cinema
{
    partial class OtherTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherTables));
            this.filmTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsDS = new Cinema.FilmsDS();
            this.genresTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresDS = new Cinema.GenresDS();
            this.roomTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsDS = new Cinema.RoomsDS();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filmsTableAdapter = new Cinema.FilmsDSTableAdapters.FilmsTableAdapter();
            this.genresTableAdapter = new Cinema.GenresDSTableAdapters.GenresTableAdapter();
            this.roomsTableAdapter = new Cinema.RoomsDSTableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmTable
            // 
            this.filmTable.AllowUserToAddRows = false;
            this.filmTable.AllowUserToDeleteRows = false;
            this.filmTable.AllowUserToResizeColumns = false;
            this.filmTable.AllowUserToResizeRows = false;
            this.filmTable.AutoGenerateColumns = false;
            this.filmTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.filmTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.filmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.filmTable.DataSource = this.filmsBindingSource;
            this.filmTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.filmTable.Location = new System.Drawing.Point(0, 0);
            this.filmTable.Margin = new System.Windows.Forms.Padding(0);
            this.filmTable.MultiSelect = false;
            this.filmTable.Name = "filmTable";
            this.filmTable.ReadOnly = true;
            this.filmTable.Size = new System.Drawing.Size(792, 470);
            this.filmTable.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.filmsDS;
            // 
            // filmsDS
            // 
            this.filmsDS.DataSetName = "FilmsDS";
            this.filmsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresTable
            // 
            this.genresTable.AllowUserToAddRows = false;
            this.genresTable.AllowUserToDeleteRows = false;
            this.genresTable.AllowUserToResizeColumns = false;
            this.genresTable.AllowUserToResizeRows = false;
            this.genresTable.AutoGenerateColumns = false;
            this.genresTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genresTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.genresTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.genresTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn});
            this.genresTable.DataSource = this.genresBindingSource;
            this.genresTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genresTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.genresTable.Location = new System.Drawing.Point(0, 0);
            this.genresTable.MultiSelect = false;
            this.genresTable.Name = "genresTable";
            this.genresTable.ReadOnly = true;
            this.genresTable.Size = new System.Drawing.Size(792, 470);
            this.genresTable.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.genresDS;
            // 
            // genresDS
            // 
            this.genresDS.DataSetName = "GenresDS";
            this.genresDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTable
            // 
            this.roomTable.AllowUserToAddRows = false;
            this.roomTable.AllowUserToDeleteRows = false;
            this.roomTable.AllowUserToResizeColumns = false;
            this.roomTable.AllowUserToResizeRows = false;
            this.roomTable.AutoGenerateColumns = false;
            this.roomTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.roomTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.roomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.roomTable.DataSource = this.roomsBindingSource;
            this.roomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.roomTable.Location = new System.Drawing.Point(0, 0);
            this.roomTable.MultiSelect = false;
            this.roomTable.Name = "roomTable";
            this.roomTable.ReadOnly = true;
            this.roomTable.Size = new System.Drawing.Size(792, 470);
            this.roomTable.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomsDS;
            // 
            // roomsDS
            // 
            this.roomsDS.DataSetName = "RoomsDS";
            this.roomsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 502);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.filmTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильмы";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.genresTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Жанры";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.roomTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Комнаты";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 80);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pictureBox1.Image = global::Cinema.Properties.Resources.Cinema_logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подтаблицы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // OtherTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtherTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cinema - Подтаблицы";
            this.Load += new System.EventHandler(this.OtherTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView filmTable;
        private System.Windows.Forms.DataGridView genresTable;
        private System.Windows.Forms.DataGridView roomTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FilmsDS filmsDS;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private FilmsDSTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private GenresDS genresDS;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private GenresDSTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private RoomsDS roomsDS;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private RoomsDSTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}