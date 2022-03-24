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
    public partial class OtherTables : Form
    {
        FormHome formHome;
        public OtherTables(FormHome home)
        {
            InitializeComponent();
            formHome = home;
        }

        private void OtherTables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomsDS.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.roomsDS.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "genresDS.Genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.genresDS.Genres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmsDS.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.filmsDS.Films);

        }
    }
}
