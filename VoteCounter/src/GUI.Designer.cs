﻿namespace VoteCounter
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGameUrl = new System.Windows.Forms.TextBox();
            this.txtStartingPost = new System.Windows.Forms.TextBox();
            this.txtEndingPost = new System.Windows.Forms.TextBox();
            this.btnGenerateVoteCount = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtVoteCount = new System.Windows.Forms.TextBox();
            this.lblGameUrl = new System.Windows.Forms.Label();
            this.lblPlayerList = new System.Windows.Forms.Label();
            this.lblStartPost = new System.Windows.Forms.Label();
            this.lblEndPost = new System.Windows.Forms.Label();
            this.lblVoteCount = new System.Windows.Forms.Label();
            this.listPlayers = new System.Windows.Forms.DataGridView();
            this.AddRow = new System.Windows.Forms.Button();
            this.Gridgroup = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.RemoveRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nicknames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listPlayers)).BeginInit();
            this.Gridgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGameUrl
            // 
            this.txtGameUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameUrl.Location = new System.Drawing.Point(9, 24);
            this.txtGameUrl.Name = "txtGameUrl";
            this.txtGameUrl.Size = new System.Drawing.Size(595, 20);
            this.txtGameUrl.TabIndex = 8;
            this.txtGameUrl.Tag = "";
            this.txtGameUrl.Text = "Put Link to Game Here...";
            this.txtGameUrl.Enter += new System.EventHandler(this.txtGameUrl_Enter);
            // 
            // txtStartingPost
            // 
            this.txtStartingPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartingPost.Location = new System.Drawing.Point(404, 67);
            this.txtStartingPost.Name = "txtStartingPost";
            this.txtStartingPost.Size = new System.Drawing.Size(91, 20);
            this.txtStartingPost.TabIndex = 1;
            this.txtStartingPost.Text = "Starting post #";
            this.txtStartingPost.Enter += new System.EventHandler(this.txtStartingPost_Enter);
            // 
            // txtEndingPost
            // 
            this.txtEndingPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndingPost.Location = new System.Drawing.Point(512, 67);
            this.txtEndingPost.Name = "txtEndingPost";
            this.txtEndingPost.Size = new System.Drawing.Size(92, 20);
            this.txtEndingPost.TabIndex = 2;
            this.txtEndingPost.Text = "Ending Post #";
            this.txtEndingPost.Enter += new System.EventHandler(this.txtEndingPost_Enter);
            // 
            // btnGenerateVoteCount
            // 
            this.btnGenerateVoteCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateVoteCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerateVoteCount.Location = new System.Drawing.Point(398, 159);
            this.btnGenerateVoteCount.Name = "btnGenerateVoteCount";
            this.btnGenerateVoteCount.Size = new System.Drawing.Size(206, 192);
            this.btnGenerateVoteCount.TabIndex = 3;
            this.btnGenerateVoteCount.Text = "Generate Vote Count!";
            this.btnGenerateVoteCount.UseVisualStyleBackColor = false;
            this.btnGenerateVoteCount.Click += new System.EventHandler(this.btnGenerateVoteCount_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 544);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // txtVoteCount
            // 
            this.txtVoteCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVoteCount.Location = new System.Drawing.Point(12, 370);
            this.txtVoteCount.Multiline = true;
            this.txtVoteCount.Name = "txtVoteCount";
            this.txtVoteCount.ReadOnly = true;
            this.txtVoteCount.Size = new System.Drawing.Size(592, 162);
            this.txtVoteCount.TabIndex = 5;
            // 
            // lblGameUrl
            // 
            this.lblGameUrl.AutoSize = true;
            this.lblGameUrl.Location = new System.Drawing.Point(6, 9);
            this.lblGameUrl.Name = "lblGameUrl";
            this.lblGameUrl.Size = new System.Drawing.Size(60, 13);
            this.lblGameUrl.TabIndex = 7;
            this.lblGameUrl.Text = "Game URL";
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(12, 51);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(55, 13);
            this.lblPlayerList.TabIndex = 8;
            this.lblPlayerList.Text = "Player List";
            // 
            // lblStartPost
            // 
            this.lblStartPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartPost.AutoSize = true;
            this.lblStartPost.Location = new System.Drawing.Point(401, 51);
            this.lblStartPost.Name = "lblStartPost";
            this.lblStartPost.Size = new System.Drawing.Size(63, 13);
            this.lblStartPost.TabIndex = 9;
            this.lblStartPost.Text = "Start Post #";
            // 
            // lblEndPost
            // 
            this.lblEndPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndPost.AutoSize = true;
            this.lblEndPost.Location = new System.Drawing.Point(509, 51);
            this.lblEndPost.Name = "lblEndPost";
            this.lblEndPost.Size = new System.Drawing.Size(60, 13);
            this.lblEndPost.TabIndex = 10;
            this.lblEndPost.Text = "End Post #";
            // 
            // lblVoteCount
            // 
            this.lblVoteCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoteCount.AutoSize = true;
            this.lblVoteCount.Location = new System.Drawing.Point(6, 354);
            this.lblVoteCount.Name = "lblVoteCount";
            this.lblVoteCount.Size = new System.Drawing.Size(60, 13);
            this.lblVoteCount.TabIndex = 11;
            this.lblVoteCount.Text = "Vote Count";
            // 
            // listPlayers
            // 
            this.listPlayers.AllowUserToAddRows = false;
            this.listPlayers.AllowUserToResizeColumns = false;
            this.listPlayers.AllowUserToResizeRows = false;
            this.listPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemoveRow,
            this.Names,
            this.Nicknames});
            this.listPlayers.Location = new System.Drawing.Point(12, 67);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.RowHeadersVisible = false;
            this.listPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listPlayers.Size = new System.Drawing.Size(380, 284);
            this.listPlayers.TabIndex = 12;
            this.listPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPlayers_CellContentClick);
            this.listPlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listPlayers_KeyPress);
            // 
            // AddRow
            // 
            this.AddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddRow.Location = new System.Drawing.Point(6, 15);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(110, 39);
            this.AddRow.TabIndex = 13;
            this.AddRow.Text = "More Players!";
            this.AddRow.UseVisualStyleBackColor = false;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // Gridgroup
            // 
            this.Gridgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridgroup.Controls.Add(this.Clear);
            this.Gridgroup.Controls.Add(this.AddRow);
            this.Gridgroup.Location = new System.Drawing.Point(398, 93);
            this.Gridgroup.Name = "Gridgroup";
            this.Gridgroup.Size = new System.Drawing.Size(206, 60);
            this.Gridgroup.TabIndex = 14;
            this.Gridgroup.TabStop = false;
            this.Gridgroup.Text = "List Controls";
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(122, 15);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(78, 39);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RemoveRow
            // 
            this.RemoveRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RemoveRow.HeaderText = "";
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemoveRow.Text = "-";
            this.RemoveRow.UseColumnTextForButtonValue = true;
            this.RemoveRow.Width = 25;
            // 
            // Names
            // 
            this.Names.HeaderText = "Names";
            this.Names.Name = "Names";
            this.Names.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nicknames
            // 
            this.Nicknames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nicknames.HeaderText = "Nicknames";
            this.Nicknames.Name = "Nicknames";
            this.Nicknames.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nicknames.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 544);
            this.Controls.Add(this.Gridgroup);
            this.Controls.Add(this.listPlayers);
            this.Controls.Add(this.lblVoteCount);
            this.Controls.Add(this.lblEndPost);
            this.Controls.Add(this.lblStartPost);
            this.Controls.Add(this.lblPlayerList);
            this.Controls.Add(this.lblGameUrl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtVoteCount);
            this.Controls.Add(this.btnGenerateVoteCount);
            this.Controls.Add(this.txtEndingPost);
            this.Controls.Add(this.txtStartingPost);
            this.Controls.Add(this.txtGameUrl);
            this.Name = "GUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.listPlayers)).EndInit();
            this.Gridgroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameUrl;
        private System.Windows.Forms.TextBox txtStartingPost;
        private System.Windows.Forms.TextBox txtEndingPost;
        private System.Windows.Forms.Button btnGenerateVoteCount;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtVoteCount;
        private System.Windows.Forms.Label lblGameUrl;
        private System.Windows.Forms.Label lblPlayerList;
        private System.Windows.Forms.Label lblStartPost;
        private System.Windows.Forms.Label lblEndPost;
        private System.Windows.Forms.Label lblVoteCount;
        private System.Windows.Forms.DataGridView listPlayers;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.GroupBox Gridgroup;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nicknames;
    }
}