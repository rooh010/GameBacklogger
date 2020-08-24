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
        DataConnection loadGames = new DataConnection();

        public Menu()
        {
            InitializeComponent();
            RefreshGrid();
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            GameDetails gd = new GameDetails(SelectedGameId, SelectedGameName, SelectedGenre, SelectedProgress);
            gd.FormClosing += new FormClosingEventHandler(this.Menu_FormClosing);
            gd.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGrid();
            //bug this runs when you close the main form too
        }
    }
}
