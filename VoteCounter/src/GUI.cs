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
        }

        private static string URL = "http://www.mtgsalvation.com/forums/forum-games/mafia/762585-unreliable-cops-mafia-game-over-mafia-victory";

        private void btnGenerateVoteCount_Click(object sender, EventArgs e)
        {
            string url = txtGameUrl.Text;
            int startingPostNumber;
            int endingPostNumber;

            if (Int32.TryParse(txtStartingPost.Text, out startingPostNumber) && Int32.TryParse(txtEndingPost.Text, out endingPostNumber))
            {
                PostList postList = new PostList(url, startingPostNumber, endingPostNumber);

                //make a List
                List<Player> players = new List<Player>();

                //set the players
                foreach (DataGridViewRow row in listPlayers.Rows)
                {
                    List<string> nicks = new List<string>();
                    string name = "";
                    for (int i = 0; i < listPlayers.Columns.Count; i++)
                    {
                        //if under column Names
                        if (listPlayers.Columns[i].Name.Equals("Name")
                            && row.Cells[i].Value != null)
                            name = row.Cells[i].Value.ToString();

                        //if under column Nicknames
                        if (listPlayers.Columns[i].Name.Equals("Nicknames")
                            && row.Cells[i].Value != null)
                        {
                            if (row.Cells[i].Value.ToString().Length > 0)
                            {
                                //parse the string, seperate each name, then put it in the List
                                string[] words = row.Cells[i].Value.ToString().Split(',');
                                //then add them
                                foreach (string s in words)
                                {
                                    nicks.Add(s);
                                }
                                //its adding a blank to the end, so I'll just remove that manually
                                if (nicks.Contains(""))
                                {
                                    nicks.Remove("");
                                }
                            }
                        }
                    }
                   // if (nicks.Count > 0)
                        players.Add(new Player(name, nicks));
                   // else
                       // players.Add(new Player(name));
                }

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
    }
}
