using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace VoteCounter
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            this.listPlayers.Rows.Add();
        }
        
        private void btnGenerateVoteCount_Click(object sender, EventArgs e)
        {
            string url = txtGameUrl.Text;
            int startingPostNumber;
            int endingPostNumber;

            if (isUrlValid(url))
            {
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
            else
            {
                MessageBox.Show("Invalid Game Link!", "VoteCounter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Player> createPlayerList()
        {
            List<Player> players = new List<Player>();

            //Populate the player list from the listPlayers table
            foreach (DataGridViewRow row in listPlayers.Rows)
            {
                if (row.Cells["Names"].Value != null)
                {
                    var newPlayer = new Player();
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

        private bool isUrlValid(string url)
        {
            return (url.Contains("mtgsalvation"));
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Game State";
            saveFileDialog.Filter = "Json|*.json";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the start and end post numbers, setting them to 0 if they are unset
                int StartPost;
                if (!Int32.TryParse(txtStartingPost.Text, out StartPost))
                {
                    StartPost = 0;
                }

                int EndPost;
                if (!Int32.TryParse(txtEndingPost.Text, out EndPost))
                {
                    EndPost = 0;
                }

                //Store the game state in an object
                var state = new GameState
                {
                    GameLink = txtGameUrl.Text,
                    StartPost = StartPost,
                    EndPost = EndPost,
                    PlayerList = createPlayerList()
                };


                var json = new JavaScriptSerializer().Serialize(state);

                var file = new System.IO.StreamWriter(saveFileDialog.FileName);

                file.Write(json);
                file.Close();

                MessageBox.Show("Game Saved!", "VoteCounter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load Game";
            openFileDialog.Filter = "Json|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = new System.IO.StreamReader(openFileDialog.FileName);

                var json = file.ReadToEnd();
                file.Close();

                var gameState = new JavaScriptSerializer().Deserialize<GameState>(json);

                txtGameUrl.Text = gameState.GameLink;
                txtStartingPost.Text = gameState.StartPost.ToString();
                txtEndingPost.Text = gameState.EndPost.ToString();

                listPlayers.Rows.Clear();

                //Repopulate the player list
                foreach (Player player in gameState.PlayerList)
                {
                    var index = listPlayers.Rows.Add();
                    listPlayers.Rows[index].Cells["Names"].Value = player.mainName;
                    var nicknames = new StringBuilder();

                    foreach(string nickname in player.nicknameList)
                    {
                        nicknames.Append(nickname);
                        if (player.nicknameList.IndexOf(nickname) != player.nicknameList.Count - 1)
                        {
                            nicknames.Append(",");
                        }
                    }

                    listPlayers.Rows[index].Cells["Nicknames"].Value = nicknames.ToString();
                }

                //Clear any vote count
                txtVoteCount.Clear();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear all data and make a new game?", "VoteCounter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                //Reset the game state
                txtGameUrl.Clear();
                txtStartingPost.Clear();
                txtEndingPost.Clear();
                listPlayers.Rows.Clear();
                listPlayers.Rows.Add();
                txtVoteCount.Clear();
            }
        }
    }
}
