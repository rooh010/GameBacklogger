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

        int gameId;
        int genreId;

        public GameDetails(string selectedGameId, string SelectedGameName, string SelectedGenre, string SelectedProgress)
        {
            InitializeComponent();

            try
            {
                comboGenre.DataSource = GetGenres();
                comboGenre.DisplayMember = "Genre";
                comboGenre.ValueMember = "Genre_ID";
                comboGenre.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                textName.Text = SelectedGameName;
                comboGenre.Text = SelectedGenre;
                textProgress.Text = SelectedProgress;

                int i = 0;
                try
                {
                    i = System.Convert.ToInt32(selectedGameId);
                    gameId = i;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                int io = 0;
                try
                {
                    io = System.Convert.ToInt32(selectedGameId);
                    genreId = io;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(comboGenre.ValueMember);
            DataClass UpDateGameDetails = new DataClass();
            UpDateGameDetails.selectQuery(Queries.updateDetails(textName.Text, gameId));
            MessageBox.Show("Sucessfully updated.");
            this.Close();
        }
    }
}
