using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделкаИлиНе
{
    public partial class HighScores : Form
    {
        Dictionary<string, Player> players = new Dictionary<string, Player>();
        List<Player> allThePlayers = new List<Player>();

        public HighScores()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillCurrentPlayers()
        {
            string dest = Path.Combine("HighScore.txt");
            var lines = File.ReadAllLines(dest);

            List<string> output = new List<string>(lines);

            foreach (var line in lines)
            {
                string[] tokens = line.Split('-', (char)StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0].Trim();
                decimal prize = decimal.Parse(tokens[1]);
                Player currentPlayer = new Player(name, prize);

                if (players.ContainsKey(name))
                {
                    if (players[name].Prize < currentPlayer.Prize)
                    {
                        players[name].Prize = currentPlayer.Prize;
                    }
                }
                else
                {
                    players.Add(name, currentPlayer);
                }
                allThePlayers.Add(currentPlayer);
            }
        }
        private void HighScores_Load(object sender, EventArgs e)
        {
            FillCurrentPlayers();

            players = players.OrderByDescending(p => p.Value.Prize).ToDictionary(k => k.Key, v => v.Value);
            foreach (var player in players.OrderByDescending(p => p.Value.Prize))
            {

                lbHighScores.Items.Add(player.Value.ToString());
            }

            this.Width = 455;
            this.Height = 431;
        }
        private string FillingWholeHistory()
        {
            StringBuilder sb = new StringBuilder();
            lbHighScores.ClearSelected();
            foreach (var p in allThePlayers.OrderByDescending(p => p.Prize))
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }
        private void FillPlayerHistoryBySelectedIndex()
        {

            StringBuilder sb = new StringBuilder();

            int index = lbHighScores.SelectedIndex;
            if (index == -1)
            {
                rtbSelectedPlayerInfo.Text = string.Empty;

                rtbSelectedPlayerInfo.Text = FillingWholeHistory();
                return;
            }

            string selectedName = lbHighScores.Items[index].ToString();

            string currentPlayerName = selectedName.Split('-', (char)StringSplitOptions.RemoveEmptyEntries).FirstOrDefault().Trim();
            foreach (var p in allThePlayers.Where(x => x.Name == currentPlayerName).OrderByDescending(p => p.Prize))
            {
                sb.AppendLine(p.ToString());
            }

            rtbSelectedPlayerInfo.Text = sb.ToString();
        }


        private void HighScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Наистина ли искате да се върнете към менюто ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void lbHighScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbSelectedPlayerInfo.Text = string.Empty;
            FillPlayerHistoryBySelectedIndex();
            rtbSelectedPlayerInfo.Visible = true;
            btnHistory.Visible = true;
            this.Width = 693;
            this.Height = 609;
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            lbHighScores.ClearSelected();
            FillPlayerHistoryBySelectedIndex();
            rtbSelectedPlayerInfo.Visible = true;
            btnHistory.Visible = true;
            this.Width = 693;
            this.Height = 609;
        }

        private void btnCloseHistory_Click(object sender, EventArgs e)
        {
            rtbSelectedPlayerInfo.Visible = false;

            this.Width = 455;
            this.Height = 431;
        }

        private void HighScores_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Наистина ли искате да се върнете към менюто ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
