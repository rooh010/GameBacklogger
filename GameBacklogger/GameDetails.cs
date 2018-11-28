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
    public partial class GameDetails : Form
    {

        DataClass getGenres = new DataClass();

        public GameDetails(string selectedGameId, string SelectedGameName, string SelectedGenre, string SelectedProgress)
        {
            InitializeComponent();

            comboGenre.DataSource = GetGenres();
            comboGenre.DisplayMember = "Genre";
            comboGenre.ValueMember = "Genre_ID";
            comboGenre.Enabled = true;
            

            textName.Text = SelectedGameName;
            comboGenre.Text = SelectedGenre;
            textProgress.Text = SelectedProgress;




        }

        private DataTable GetGenres()
        {
            return getGenres.selectQuery(Queries.selectGenres);
        }

        private void GameDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
