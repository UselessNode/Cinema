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
    public partial class AddingForm : Form
    {
        FormHome formHome;
        public AddingForm(FormHome home, int id)
        {
            formHome = home;
            InitializeComponent();
            labelId.Text = id.ToString();
        }
        DateTime date;
        int filmID;
        int occupancy;
        int roomID;
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            filmID = filmsComboBox.SelectedIndex + 1;
            roomID = roomsComboBox.SelectedIndex + 1;
            occupancy = ((int)occupancyNumeric.Value);
            date = dateTimePicker.Value;
            formHome.AddRow(date, filmID, occupancy, roomID);
            formHome.LoadTable();
            Close();
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {
            roomsTableAdapter.Fill(romsBaseDataSet.Rooms);
            filmsTableAdapter.Fill(filmsDataSet.Films);
        }

        private void CancelButton_Click(object sender, EventArgs e) => Hide();
    }
}
