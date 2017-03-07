﻿using System;
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
                //make a List
                List<Player> players = new List<Player>();

                //set the players
                foreach (DataGridViewRow row in listPlayers.Rows)
                {
                    Player newPlayer = new Player("");

                    foreach (DataGridViewColumn column in listPlayers.Columns)
                    {
                        if (row.Cells[column.Index].Value != null)
                        {
                            //if under column Names
                            if (column.Name.Equals("Name"))
                            {
                                //if name is valid
                                if (row.Cells[column.Index].Value.ToString() != ""
                                    && row.Cells[column.Index].Value != null)
                                {
                                    newPlayer.mainName = row.Cells[column.Index].Value.ToString();
                                }
                            }
                            //if under column Nicknames
                            else if (column.Name.Equals("Nicknames"))
                            {
                                if (row.Cells[column.Index].Value.ToString().Length > 0)
                                {
                                    //parse the string, seperate each name, then put it in the List
                                    string[] collectedNicknames = row.Cells[column.Index].Value.ToString().Split(',');
                                    //then add them
                                    foreach (string s in collectedNicknames)
                                    {
                                        if (s != "")
                                            newPlayer.nicknameList.Add(s);
                                    }
                                }
                            }
                        }
                    }
                    if (newPlayer.mainName != "")
                    {
                        players.Add(newPlayer);
                    }
                }

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

        private void AddRow_Click(object sender, EventArgs e)
        {
            listPlayers.Rows.Add();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear everything?", "Caption?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in listPlayers.Rows)
                {
                    listPlayers.Rows.Clear();
                    listPlayers.Rows.Add();
                }
            }

        }
    }
}
