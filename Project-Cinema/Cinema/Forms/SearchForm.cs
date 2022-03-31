using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinema
{
    public partial class SearchForm : Form
    {
        FormHome formHome;
        public SearchForm(FormHome home)
        {
            formHome = home;
            InitializeComponent();
            BackColor = Properties.Settings.Default.Menu;
        }
        string filterText = "";
        enum Filter {Room, Date, Both, None};
        Filter currientFulter = Filter.None;
        int room = 1;
        // При нажатии кнопки "Сброс"
        private void DefaultButton_Click(object sender, EventArgs e)
        {
            formHome.LoadTable();
            filterText = "";
            dateRadioButton.Checked = roomRadioButton.Checked = false;
            currientFulter = Filter.None;
            button1.Enabled = false;
        }
        // При нажатии кнопки "Выполнить"
        private void FilterButton_Click(object sender, EventArgs e)
        {
            filterText = "";
            DataSet set = new DataSet();
            switch (currientFulter)
            {
                case Filter.Room:
                    filterText = $"SELECT [Session].Id, " +
                        $"[Films].[Name] AS 'Название фильма'," +
                        $"[Session].Occupancy AS 'Заполненность', " +
                        $"[Session].[Date] AS 'Дата', " +
                        $"[Session].[RoomID] " +
                        $"FROM [Session] INNER JOIN [Films] ON [Films].[Id] = [Session].[FilmID] " +
                        $"WHERE [RoomID] = '{room}'";
                    set = Filtration(filterText);
                    formHome.sessionTable.DataSource = set.Tables[0];
                    if(Properties.Settings.Default.ShowNotification)
                        MessageBox.Show("Фильтрация по Комнате");
                    break;

                case Filter.Date:
                    filterText = $"SELECT [Session].Id, " +
                        $"[Films].[Name] AS 'Название фильма'," +
                        $"[Session].Occupancy AS 'Заполненность', " +
                        $"[Session].[Date] AS 'Дата', " +
                        $"[Session].[RoomID] " +
                        $"FROM [Session] INNER JOIN [Films] ON [Films].[Id] = [Session].[FilmID] " +
                        $"WHERE [Date] BETWEEN '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' " +
                        $"AND '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(filterText, Properties.Settings.Default.BaseConnectionString);
                    adapter.Fill(set);
                    formHome.sessionTable.DataSource = set.Tables[0];
                    if (Properties.Settings.Default.ShowNotification)
                        MessageBox.Show("Фильтрация по Дате");
                    break;

                case Filter.None:
                    break;
            }
        }
        
        // Метод для выполнения запроса фильтрации и поиска
        private static DataSet Filtration(string filterText)
        {
            DataSet set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(filterText,Properties.Settings.Default.BaseConnectionString);
            adapter.Fill(set);
            return set;
        }

        // Поиск по тексту
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            formHome.sessionTable.ClearSelection();
            int rows = formHome.sessionTable.RowCount;
            int columns = formHome.sessionTable.ColumnCount;
            string searchText = searchBox.Text;
            formHome.sessionTable.MultiSelect = true;

            if(!String.IsNullOrWhiteSpace(searchText))
            for (int i = 0; i < rows; i++)
            {
                formHome.sessionTable.Rows[i].Selected = false;
                for (int j = 0; j < columns; j++)
                {
                    if (formHome.sessionTable.Rows[i].Cells[j].Value != null)
                        if (formHome.sessionTable.Rows[i].Cells[j].Value.ToString().Contains(searchText))
                        {
                            formHome.sessionTable.Rows[i].Selected = true;
                            break;
                        }
                }
            }
            else
                formHome.sessionTable.MultiSelect = false;
        }

        // При выборе фильтрации по определённому залу
        private void RoomsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(currientFulter == Filter.Room || currientFulter  == Filter.Both)
                room = Convert.ToInt32((sender as RadioButton).Text);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            NotificationCheckBox.Checked = Properties.Settings.Default.ShowNotification;
            currientFulter = Filter.None;
        }

        // При выборе типа фильтрации
        private void FiltersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (dateRadioButton.Checked)
                currientFulter = Filter.Date;
            if(roomRadioButton.Checked)
                currientFulter = Filter.Room;
            button1.Enabled = true;
        }

        private void NotificationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if(Properties.Settings.Default.ShowNotification)
            if (NotificationCheckBox.Checked)
                Properties.Settings.Default.ShowNotification = true;
            else
                Properties.Settings.Default.ShowNotification = false;
            Properties.Settings.Default.Save();
        }
    }
}
