
namespace Cinema
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.defaultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.roomFilterPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateFilterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roomRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.NotificationCheckBox = new System.Windows.Forms.CheckBox();
            this.roomFilterPanel.SuspendLayout();
            this.dateFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(12, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(360, 27);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // defaultButton
            // 
            this.defaultButton.AutoSize = true;
            this.defaultButton.BackColor = System.Drawing.SystemColors.Control;
            this.defaultButton.Location = new System.Drawing.Point(309, 176);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(63, 32);
            this.defaultButton.TabIndex = 1;
            this.defaultButton.Text = "Сброс";
            this.defaultButton.UseVisualStyleBackColor = false;
            this.defaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(0, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "";
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RoomsRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(42, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "";
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RoomsRadioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(84, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 23);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "";
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RoomsRadioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(126, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 23);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "";
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RoomsRadioButton_CheckedChanged);
            // 
            // roomFilterPanel
            // 
            this.roomFilterPanel.AutoSize = true;
            this.roomFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.roomFilterPanel.Controls.Add(this.radioButton1);
            this.roomFilterPanel.Controls.Add(this.radioButton2);
            this.roomFilterPanel.Controls.Add(this.radioButton3);
            this.roomFilterPanel.Controls.Add(this.radioButton4);
            this.roomFilterPanel.Location = new System.Drawing.Point(207, 61);
            this.roomFilterPanel.Name = "roomFilterPanel";
            this.roomFilterPanel.Size = new System.Drawing.Size(165, 29);
            this.roomFilterPanel.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(44, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 27);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateFilterPanel
            // 
            this.dateFilterPanel.AutoSize = true;
            this.dateFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dateFilterPanel.Controls.Add(this.label3);
            this.dateFilterPanel.Controls.Add(this.label2);
            this.dateFilterPanel.Controls.Add(this.dateTimePicker1);
            this.dateFilterPanel.Controls.Add(this.dateTimePicker2);
            this.dateFilterPanel.Location = new System.Drawing.Point(207, 93);
            this.dateFilterPanel.Name = "dateFilterPanel";
            this.dateFilterPanel.Size = new System.Drawing.Size(166, 66);
            this.dateFilterPanel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "По:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "С:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // roomRadioButton
            // 
            this.roomRadioButton.AutoSize = true;
            this.roomRadioButton.ForeColor = System.Drawing.Color.White;
            this.roomRadioButton.Location = new System.Drawing.Point(12, 61);
            this.roomRadioButton.Name = "roomRadioButton";
            this.roomRadioButton.Size = new System.Drawing.Size(128, 23);
            this.roomRadioButton.TabIndex = 18;
            this.roomRadioButton.TabStop = true;
            this.roomRadioButton.Tag = "Room";
            this.roomRadioButton.Text = "По комнатам:";
            this.roomRadioButton.UseVisualStyleBackColor = true;
            this.roomRadioButton.CheckedChanged += new System.EventHandler(this.FiltersRadioButton_CheckedChanged);
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.ForeColor = System.Drawing.Color.White;
            this.dateRadioButton.Location = new System.Drawing.Point(12, 90);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(91, 23);
            this.dateRadioButton.TabIndex = 18;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Tag = "Date";
            this.dateRadioButton.Text = "По дате:";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            this.dateRadioButton.CheckedChanged += new System.EventHandler(this.FiltersRadioButton_CheckedChanged);
            // 
            // NotificationCheckBox
            // 
            this.NotificationCheckBox.AutoSize = true;
            this.NotificationCheckBox.Checked = true;
            this.NotificationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NotificationCheckBox.ForeColor = System.Drawing.Color.White;
            this.NotificationCheckBox.Location = new System.Drawing.Point(12, 119);
            this.NotificationCheckBox.Name = "NotificationCheckBox";
            this.NotificationCheckBox.Size = new System.Drawing.Size(134, 42);
            this.NotificationCheckBox.TabIndex = 19;
            this.NotificationCheckBox.Text = "Отображение \r\nуведомлений";
            this.NotificationCheckBox.UseVisualStyleBackColor = true;
            this.NotificationCheckBox.CheckedChanged += new System.EventHandler(this.NotificationCheckBox_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.NotificationCheckBox);
            this.Controls.Add(this.dateRadioButton);
            this.Controls.Add(this.roomRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomFilterPanel);
            this.Controls.Add(this.dateFilterPanel);
            this.Controls.Add(this.defaultButton);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "Поиск и фильтрация";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.roomFilterPanel.ResumeLayout(false);
            this.roomFilterPanel.PerformLayout();
            this.dateFilterPanel.ResumeLayout(false);
            this.dateFilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel roomFilterPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel dateFilterPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton roomRadioButton;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.CheckBox NotificationCheckBox;
    }
}