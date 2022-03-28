using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            flowLayoutPanel1.BackColor = Properties.Settings.Default.Header;
            sessionTable.BackgroundColor = Properties.Settings.Default.GridBackground;
            tableLayoutPanel1.BackColor = Properties.Settings.Default.Menu;
        }
        private AddingForm addingForm;
        private EditingForm editingForm;
        private SearchForm searchForm;
        private OtherTables tablesForm;
        public DataSet data;
        public DataGridViewRow selectedRow;
        private readonly string connectionString = Properties.Settings.Default.BaseConnectionString;
        private readonly string selector_session = "selector_session";
        private void FormHome_Load(object sender, EventArgs e)
        {
            this.filmsTableAdapter.Fill(this.filmsDS.Films);
            LoadTable();
            searchForm = new SearchForm(this);
            searchForm.FormBorderStyle = FormBorderStyle.None;
            searchForm.TopLevel = false;
            searchForm.TopMost = true;
            SplitContainer.Panel2.Controls.Add(searchForm);
            searchForm.Show();
        }
        public void LoadTable()
        {
            data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(selector_session, connectionString);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(data);
            sessionTable.DataSource = data.Tables[0];
        }
        private void AddingButton_Click(object sender, EventArgs e)
        {
            int id = sessionTable.Rows.Count + 1;
            addingForm = new AddingForm(this, id);
            addingForm.Owner = this;
            addingForm.ShowDialog();
        }
        private void EditingButton_Click(object sender, EventArgs e)
        {
            if (sessionTable.SelectedRows is null)
                MessageBox.Show("Error!");
            else
            {
                selectedRow = sessionTable.SelectedRows[0];
                editingForm = new EditingForm(this);
                editingForm.Owner = this;
                editingForm.ShowDialog();
            }
        }
        private void RemovingButton_Click(object sender, EventArgs e)
        {
            selectedRow = sessionTable.SelectedRows[0];
            int id;
            if (selectedRow is null)
            {
                MessageBox.Show(text: "Вы не выбрали строку для удаления!", 
                                caption: "Удаление", 
                                buttons: MessageBoxButtons.OK, 
                                icon: MessageBoxIcon.Stop);
                return;
            }
            id = (int)selectedRow.Cells[0].Value;
            RemoveRow(id);
        }

        public void AddRow(DateTime date, int filmID, int occupancy, int roomID)
        {
            string requestString = @"INSERT INTO [dbo].[Session] ([FilmID], [Occupancy], [Date], [RoomID])" +
                                   @"VALUES (@film, @occ, @date, @room)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand addingCommand = new SqlCommand(requestString, connection);
                addingCommand.Parameters.Add("@film", SqlDbType.Int).Value = filmID;
                addingCommand.Parameters.Add("@occ", SqlDbType.Int).Value = occupancy;
                addingCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;
                addingCommand.Parameters.Add("@room", SqlDbType.Int).Value = roomID;
                addingCommand.Transaction = transaction;
                try
                {
                    addingCommand.ExecuteNonQuery();
                    transaction.Commit();
                    if (Properties.Settings.Default.ShowNotification)
                        MessageBox.Show("Данные добавлены в базу данных", caption: "Транзакция");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(text:ex.Message, 
                                    caption: "Ошибка", 
                                    buttons:MessageBoxButtons.OK, 
                                    icon:MessageBoxIcon.Error, 
                                    MessageBoxDefaultButton.Button1);
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public void EditRow(DateTime date, int filmID, int occupancy, int roomID)
        {
            string requestString = @"UPDATE Session SET FilmID = @film, Occupancy = @occ, Date = @date, RoomID = @room WHERE Id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand(requestString, connection);
                sqlCommand.Parameters.Add("@film", SqlDbType.Int).Value = filmID;
                sqlCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;
                sqlCommand.Parameters.Add("@room", SqlDbType.Int).Value = roomID;
                sqlCommand.Parameters.Add("@occ", SqlDbType.Int).Value = occupancy;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = (int)selectedRow.Cells[0].Value;
                sqlCommand.Transaction = transaction;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    transaction.Commit();
                    if (Properties.Settings.Default.ShowNotification)
                        MessageBox.Show("Данные изменены", caption: "Транзакция");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(text:ex.Message, 
                                    caption: "Ошибка", 
                                    buttons:MessageBoxButtons.OK, 
                                    icon:MessageBoxIcon.Error, 
                                    MessageBoxDefaultButton.Button1);
                    transaction.Rollback();
                    throw;
                }
            }
        }
        private void RemoveRow(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                string requestString = "DELETE FROM Session WHERE Id = @id";
                SqlCommand sqlCommand = new SqlCommand(requestString, connection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlCommand.Transaction = transaction;
                try
                {
                    DialogResult result = MessageBox.Show(
                                    text: $"Вы действительно хотите удалить строку под номером {id}?",
                                    caption: "Удаление строки",
                                    buttons: MessageBoxButtons.YesNo,
                                    icon: MessageBoxIcon.Warning
                                    );
                    if (result == DialogResult.Yes)
                    {
                        sqlCommand.ExecuteNonQuery();
                        transaction.Commit();
                        if (Properties.Settings.Default.ShowNotification)
                            MessageBox.Show("Данные изменены", caption: "Транзакция");
                        LoadTable();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(text: ex.Message, 
                                    caption: "Ошибка", 
                                    buttons: MessageBoxButtons.OK, 
                                    icon: MessageBoxIcon.Error, 
                                    MessageBoxDefaultButton.Button1);
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void SubtableButton_Click(object sender, EventArgs e)
        {
            tablesForm = new OtherTables(this);
            tablesForm.Owner = this;
            tablesForm.ShowDialog();
        }
    }
}
