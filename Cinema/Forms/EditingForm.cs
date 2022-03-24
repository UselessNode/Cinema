using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class EditingForm : Form
    {
        FormHome formHome;
        public EditingForm(FormHome home)
        {
            formHome = home;
            InitializeComponent();
        }
        DateTime date;
        string filmName;
        int occupancy;
        int roomID;
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            formHome.EditRow(
                dateTimePicker.Value,
                filmsComboBox.SelectedIndex + 1, 
                (int)occupancyNumeric.Value,
                roomsComboBox.SelectedIndex + 1);
            formHome.LoadTable();
            Hide();
        }
        private void EditingForm_Load(object sender, EventArgs e)
        {
            roomID = (int)formHome.selectedRow.Cells[4].Value - 1;
            labelId.Text = formHome.selectedRow.Cells[0].Value.ToString();
            roomsTableAdapter.Fill(romsBaseDataSet.Rooms);
            filmsTableAdapter.Fill(filmsDataSet.Films);
            occupancy = (int)formHome.selectedRow.Cells[2].Value;
            date = (DateTime)formHome.selectedRow.Cells[3].Value;
            filmName = formHome.selectedRow.Cells[1].Value.ToString();

            roomsComboBox.SelectedIndex = roomID;
            occupancyNumeric.Value = occupancy;
            dateTimePicker.Value = date;
            filmsComboBox.SelectedIndex = filmsComboBox.FindString(filmName);
        }
        private void CancelButton_Click(object sender, EventArgs e) => Hide();
    }
}
