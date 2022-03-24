namespace Cinema
{
    partial class EditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.filmsComboBox = new System.Windows.Forms.ComboBox();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsDataSet = new Cinema.FilmsDataSet();
            this.occupancyNumeric = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomsComboBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.romsBaseDataSet = new Cinema.romsBaseDataSet();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.filmsTableAdapter = new Cinema.FilmsDataSetTableAdapters.FilmsTableAdapter();
            this.roomsTableAdapter = new Cinema.romsBaseDataSetTableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupancyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romsBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кинозал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Заполнение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Фильм";
            // 
            // labelId
            // 
            this.labelId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.labelId.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.ForeColor = System.Drawing.Color.Honeydew;
            this.labelId.Location = new System.Drawing.Point(0, 0);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Padding = new System.Windows.Forms.Padding(4);
            this.labelId.Size = new System.Drawing.Size(485, 27);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // filmsComboBox
            // 
            this.filmsComboBox.DataSource = this.filmsBindingSource;
            this.filmsComboBox.DisplayMember = "Name";
            this.filmsComboBox.FormattingEnabled = true;
            this.filmsComboBox.Location = new System.Drawing.Point(116, 52);
            this.filmsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.filmsComboBox.Name = "filmsComboBox";
            this.filmsComboBox.Size = new System.Drawing.Size(356, 27);
            this.filmsComboBox.TabIndex = 3;
            this.filmsComboBox.ValueMember = "Id";
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.filmsDataSet;
            // 
            // filmsDataSet
            // 
            this.filmsDataSet.DataSetName = "FilmsDataSet";
            this.filmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupancyNumeric
            // 
            this.occupancyNumeric.Location = new System.Drawing.Point(116, 86);
            this.occupancyNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.occupancyNumeric.Name = "occupancyNumeric";
            this.occupancyNumeric.Size = new System.Drawing.Size(81, 27);
            this.occupancyNumeric.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(263, 87);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker.TabIndex = 5;
            // 
            // roomsComboBox
            // 
            this.roomsComboBox.DataSource = this.roomsBindingSource;
            this.roomsComboBox.DisplayMember = "Name";
            this.roomsComboBox.FormattingEnabled = true;
            this.roomsComboBox.Location = new System.Drawing.Point(116, 121);
            this.roomsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomsComboBox.Name = "roomsComboBox";
            this.roomsComboBox.Size = new System.Drawing.Size(81, 27);
            this.roomsComboBox.TabIndex = 6;
            this.roomsComboBox.ValueMember = "Id";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.romsBaseDataSet;
            // 
            // romsBaseDataSet
            // 
            this.romsBaseDataSet.DataSetName = "romsBaseDataSet";
            this.romsBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ApplyButton
            // 
            this.ApplyButton.AutoSize = true;
            this.ApplyButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(17, 202);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(90, 30);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Ok";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(382, 203);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 30);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(485, 246);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.roomsComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.occupancyNumeric);
            this.Controls.Add(this.filmsComboBox);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сеанс - Изменение";
            this.Load += new System.EventHandler(this.EditingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupancyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romsBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ComboBox filmsComboBox;
        private System.Windows.Forms.NumericUpDown occupancyNumeric;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox roomsComboBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private FilmsDataSet filmsDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private FilmsDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private romsBaseDataSet romsBaseDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private romsBaseDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
    }
}