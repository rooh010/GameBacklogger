using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBacklogger
{
    public partial class Menu : Form
    {
        DataClass loadGames = new DataClass();

        public Menu()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            dataGridView1.DataSource = loadGames.selectQuery(Queries.selectGames);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectedGameId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var SelectedGameName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            var SelectedGenre= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            var SelectedProgress= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            GameDetails td = new GameDetails(SelectedGameId, SelectedGameName, SelectedGenre, SelectedProgress);
            td.Show();
        }
    }
}
