
namespace Cinema
{
    partial class FormHome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RemovingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SubTablesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.sessionTable = new System.Windows.Forms.DataGridView();
            this.filmsDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsDS = new Cinema.FilmsDS();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Cinema.FilmsDSTableAdapters.FilmsTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddingButton,
            this.EditingButton,
            this.RemovingButton,
            this.ReportingButton,
            this.SubTablesButton});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(195, 141);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddingButton
            // 
            this.AddingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddingButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AddingButton.ForeColor = System.Drawing.Color.White;
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(188, 27);
            this.AddingButton.Text = "Добавить строку";
            this.AddingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddingButton.Click += new System.EventHandler(this.AddingButton_Click);
            // 
            // EditingButton
            // 
            this.EditingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditingButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.EditingButton.ForeColor = System.Drawing.Color.White;
            this.EditingButton.Name = "EditingButton";
            this.EditingButton.Size = new System.Drawing.Size(188, 27);
            this.EditingButton.Text = "Изменить строку";
            this.EditingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditingButton.Click += new System.EventHandler(this.EditingButton_Click);
            // 
            // RemovingButton
            // 
            this.RemovingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemovingButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.RemovingButton.ForeColor = System.Drawing.Color.White;
            this.RemovingButton.Name = "RemovingButton";
            this.RemovingButton.Size = new System.Drawing.Size(188, 27);
            this.RemovingButton.Text = "Удалить строку";
            this.RemovingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemovingButton.Click += new System.EventHandler(this.RemovingButton_Click);
            // 
            // ReportingButton
            // 
            this.ReportingButton.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.ReportingButton.ForeColor = System.Drawing.Color.White;
            this.ReportingButton.Name = "ReportingButton";
            this.ReportingButton.Size = new System.Drawing.Size(188, 27);
            this.ReportingButton.Text = "Создать отчёт";
            this.ReportingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubTablesButton
            // 
            this.SubTablesButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.SubTablesButton.ForeColor = System.Drawing.Color.White;
            this.SubTablesButton.Name = "SubTablesButton";
            this.SubTablesButton.Size = new System.Drawing.Size(188, 27);
            this.SubTablesButton.Text = "Подтаблицы";
            this.SubTablesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubTablesButton.Click += new System.EventHandler(this.SubtableButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SplitContainer, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 645);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(245, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(701, 80);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Cinema.Properties.Resources.Cinema_logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer.IsSplitterFixed = true;
            this.SplitContainer.Location = new System.Drawing.Point(245, 80);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.sessionTable);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Tag = "";
            this.SplitContainer.Panel2MinSize = 340;
            this.SplitContainer.Size = new System.Drawing.Size(701, 565);
            this.SplitContainer.SplitterDistance = 306;
            this.SplitContainer.TabIndex = 6;
            // 
            // sessionTable
            // 
            this.sessionTable.AllowUserToAddRows = false;
            this.sessionTable.AllowUserToDeleteRows = false;
            this.sessionTable.AllowUserToResizeColumns = false;
            this.sessionTable.AllowUserToResizeRows = false;
            this.sessionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sessionTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sessionTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.sessionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sessionTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.sessionTable.Location = new System.Drawing.Point(0, 0);
            this.sessionTable.Margin = new System.Windows.Forms.Padding(0);
            this.sessionTable.MultiSelect = false;
            this.sessionTable.Name = "sessionTable";
            this.sessionTable.ReadOnly = true;
            this.sessionTable.RowHeadersVisible = false;
            this.sessionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionTable.ShowCellErrors = false;
            this.sessionTable.Size = new System.Drawing.Size(306, 565);
            this.sessionTable.TabIndex = 4;
            // 
            // filmsDSBindingSource
            // 
            this.filmsDSBindingSource.DataSource = this.filmsDS;
            this.filmsDSBindingSource.Position = 0;
            // 
            // filmsDS
            // 
            this.filmsDS.DataSetName = "FilmsDS";
            this.filmsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.filmsDSBindingSource;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema - Сессии";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddingButton;
        private System.Windows.Forms.ToolStripMenuItem EditingButton;
        private System.Windows.Forms.ToolStripMenuItem RemovingButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ReportingButton;
        private System.Windows.Forms.SplitContainer SplitContainer;
        public System.Windows.Forms.DataGridView sessionTable;
        private System.Windows.Forms.ToolStripMenuItem SubTablesButton;
        private System.Windows.Forms.BindingSource filmsDSBindingSource;
        private FilmsDS filmsDS;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private FilmsDSTableAdapters.FilmsTableAdapter filmsTableAdapter;
    }
}

