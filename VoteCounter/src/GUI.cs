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
            int startingPostNumber = Convert.ToInt32(txtStartingPost.Text);
            int endingPostNumber = Convert.ToInt32(txtEndingPost.Text);

            PostList postList = new PostList(url, startingPostNumber, endingPostNumber);

            //For each post, search the text for votes
            var voteCount = new VoteCount();
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
    }
}
