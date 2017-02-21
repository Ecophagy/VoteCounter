namespace VoteCounter
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
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nicknames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGameUrl
            // 
            this.txtGameUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameUrl.Location = new System.Drawing.Point(68, 24);
            this.txtGameUrl.Name = "txtGameUrl";
            this.txtGameUrl.Size = new System.Drawing.Size(489, 20);
            this.txtGameUrl.TabIndex = 8;
            this.txtGameUrl.Tag = "";
            this.txtGameUrl.Text = "Put Link to Game Here...";
            this.txtGameUrl.Enter += new System.EventHandler(this.txtGameUrl_Enter);
            // 
            // txtStartingPost
            // 
            this.txtStartingPost.Location = new System.Drawing.Point(306, 91);
            this.txtStartingPost.Name = "txtStartingPost";
            this.txtStartingPost.Size = new System.Drawing.Size(100, 20);
            this.txtStartingPost.TabIndex = 1;
            this.txtStartingPost.Text = "Starting post #";
            this.txtStartingPost.Enter += new System.EventHandler(this.txtStartingPost_Enter);
            // 
            // txtEndingPost
            // 
            this.txtEndingPost.Location = new System.Drawing.Point(421, 91);
            this.txtEndingPost.Name = "txtEndingPost";
            this.txtEndingPost.Size = new System.Drawing.Size(100, 20);
            this.txtEndingPost.TabIndex = 2;
            this.txtEndingPost.Text = "Ending Post #";
            this.txtEndingPost.Enter += new System.EventHandler(this.txtEndingPost_Enter);
            // 
            // btnGenerateVoteCount
            // 
            this.btnGenerateVoteCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerateVoteCount.Location = new System.Drawing.Point(306, 156);
            this.btnGenerateVoteCount.Name = "btnGenerateVoteCount";
            this.btnGenerateVoteCount.Size = new System.Drawing.Size(251, 77);
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
            this.txtVoteCount.Location = new System.Drawing.Point(68, 269);
            this.txtVoteCount.Multiline = true;
            this.txtVoteCount.Name = "txtVoteCount";
            this.txtVoteCount.ReadOnly = true;
            this.txtVoteCount.Size = new System.Drawing.Size(489, 197);
            this.txtVoteCount.TabIndex = 5;
            // 
            // lblGameUrl
            // 
            this.lblGameUrl.AutoSize = true;
            this.lblGameUrl.Location = new System.Drawing.Point(65, 9);
            this.lblGameUrl.Name = "lblGameUrl";
            this.lblGameUrl.Size = new System.Drawing.Size(60, 13);
            this.lblGameUrl.TabIndex = 7;
            this.lblGameUrl.Text = "Game URL";
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(68, 51);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(55, 13);
            this.lblPlayerList.TabIndex = 8;
            this.lblPlayerList.Text = "Player List";
            // 
            // lblStartPost
            // 
            this.lblStartPost.AutoSize = true;
            this.lblStartPost.Location = new System.Drawing.Point(303, 77);
            this.lblStartPost.Name = "lblStartPost";
            this.lblStartPost.Size = new System.Drawing.Size(63, 13);
            this.lblStartPost.TabIndex = 9;
            this.lblStartPost.Text = "Start Post #";
            // 
            // lblEndPost
            // 
            this.lblEndPost.AutoSize = true;
            this.lblEndPost.Location = new System.Drawing.Point(421, 77);
            this.lblEndPost.Name = "lblEndPost";
            this.lblEndPost.Size = new System.Drawing.Size(60, 13);
            this.lblEndPost.TabIndex = 10;
            this.lblEndPost.Text = "End Post #";
            // 
            // lblVoteCount
            // 
            this.lblVoteCount.AutoSize = true;
            this.lblVoteCount.Location = new System.Drawing.Point(68, 253);
            this.lblVoteCount.Name = "lblVoteCount";
            this.lblVoteCount.Size = new System.Drawing.Size(60, 13);
            this.lblVoteCount.TabIndex = 11;
            this.lblVoteCount.Text = "Vote Count";
            // 
            // listPlayers
            // 
            this.listPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Nicknames});
            this.listPlayers.Location = new System.Drawing.Point(73, 77);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.RowHeadersVisible = false;
            this.listPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listPlayers.Size = new System.Drawing.Size(201, 155);
            this.listPlayers.TabIndex = 12;
            // 
            // Name
            // 
            this.Name.HeaderText = "Names";
            this.Name.Name = "Name";
            // 
            // Nicknames
            // 
            this.Nicknames.HeaderText = "Nicknames";
            this.Nicknames.Name = "Nicknames";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 544);
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
            //Name = "GUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.listPlayers)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nicknames;
    }
}