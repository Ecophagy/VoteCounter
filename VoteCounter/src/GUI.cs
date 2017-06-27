using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteCounter
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            this.listPlayers.Rows.Add();
        }
        
        private static string URL = "http://www.mtgsalvation.com/forums/forum-games/mafia/762585-unreliable-cops-mafia-game-over-mafia-victory";

        

        private void btnGenerateVoteCount_Click(object sender, EventArgs e)
        {
            string url = txtGameUrl.Text;
            int startingPostNumber;
            int endingPostNumber;

            if (Int32.TryParse(txtStartingPost.Text, out startingPostNumber) && Int32.TryParse(txtEndingPost.Text, out endingPostNumber))
            {
                var players = createPlayerList();

                PostList postList = new PostList(url, startingPostNumber, endingPostNumber);

                //For each post, search the text for votes
                var voteCount = new VoteCount(players);
                voteCount.FindVotes(postList.ListOfPosts);

                StringBuilder voteline = new StringBuilder();

                //Print out the votecount!
                foreach (KeyValuePair<string, List<string>> kvp in voteCount.createVotecount())
                {
                    voteline.Append(kvp.Key + " - " + kvp.Value.Count + " (");

                    foreach (string voter in kvp.Value)
                    {
                        voteline.Append(voter);
                        if (kvp.Value.IndexOf(voter) != kvp.Value.Count - 1)
                        {
                            voteline.Append(", ");
                        }
                    }
                    voteline.AppendLine(")");
                }

                txtVoteCount.Text = voteline.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Post Numbers!", "VoteCounter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<Player> createPlayerList()
        {
            List<Player> players = new List<Player>();

            //Populate the player list from the listPlayers table
            foreach (DataGridViewRow row in listPlayers.Rows)
            {
                Player newPlayer = new Player("");

                if (row.Cells["Names"].Value != null)
                {
                    newPlayer.mainName = row.Cells["Names"].Value.ToString();

                    if (row.Cells["Nicknames"].Value != null)
                    {
                        var nicknames = row.Cells["Nicknames"].Value.ToString().Split(',');
                        foreach (string nickname in nicknames)
                        {
                            if (nickname != "" && nickname != " ")
                            {
                                newPlayer.nicknameList.Add(nickname);
                            }
                        }
                    }

                players.Add(newPlayer);    
                }
            }

            return players;
        }

        private void txtGameUrl_Enter(object sender, EventArgs e)
        {
            txtGameUrl.Clear();
        }

        private void txtStartingPost_Enter(object sender, EventArgs e)
        {
            txtStartingPost.Clear();
        }

        private void txtEndingPost_Enter(object sender, EventArgs e)
        {
            txtEndingPost.Clear();
        }

        private void listPlayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //If we're at the end of the list, add the row to the end
                if (listPlayers.CurrentRow.Index+1 == listPlayers.RowCount)
                {
                    listPlayers.Rows.Add();
                }
                //Else add the new row beneath the current cell
                else
                {
                    listPlayers.Rows.Insert(listPlayers.CurrentRow.Index);
                }
            }
        }

        private void listPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cast to DVG
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                //if it's in the button column and it's not returning a negative row# for some reason
                && e.RowIndex >= 0
                //and there's more than one row
                && senderGrid.Rows.Count > 1)
            {
                //remove that row
                listPlayers.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
