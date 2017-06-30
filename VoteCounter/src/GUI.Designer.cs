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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
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
            this.RemoveRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nicknames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.listPlayers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGameUrl
            // 
            this.txtGameUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameUrl.Location = new System.Drawing.Point(16, 45);
            this.txtGameUrl.Name = "txtGameUrl";
            this.txtGameUrl.Size = new System.Drawing.Size(583, 20);
            this.txtGameUrl.TabIndex = 8;
            this.txtGameUrl.Tag = "";
            this.txtGameUrl.Text = "Put Link to Game Here...";
            this.txtGameUrl.Enter += new System.EventHandler(this.txtGameUrl_Enter);
            // 
            // txtStartingPost
            // 
            this.txtStartingPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStartingPost.Location = new System.Drawing.Point(176, 73);
            this.txtStartingPost.Name = "txtStartingPost";
            this.txtStartingPost.Size = new System.Drawing.Size(91, 20);
            this.txtStartingPost.TabIndex = 1;
            this.txtStartingPost.Text = "Starting post #";
            this.txtStartingPost.Enter += new System.EventHandler(this.txtStartingPost_Enter);
            // 
            // txtEndingPost
            // 
            this.txtEndingPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEndingPost.Location = new System.Drawing.Point(369, 73);
            this.txtEndingPost.Name = "txtEndingPost";
            this.txtEndingPost.Size = new System.Drawing.Size(92, 20);
            this.txtEndingPost.TabIndex = 2;
            this.txtEndingPost.Text = "Ending Post #";
            this.txtEndingPost.Enter += new System.EventHandler(this.txtEndingPost_Enter);
            // 
            // btnGenerateVoteCount
            // 
            this.btnGenerateVoteCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerateVoteCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerateVoteCount.Location = new System.Drawing.Point(19, 421);
            this.btnGenerateVoteCount.Name = "btnGenerateVoteCount";
            this.btnGenerateVoteCount.Size = new System.Drawing.Size(580, 73);
            this.btnGenerateVoteCount.TabIndex = 3;
            this.btnGenerateVoteCount.Text = "Generate Vote Count!";
            this.btnGenerateVoteCount.UseVisualStyleBackColor = false;
            this.btnGenerateVoteCount.Click += new System.EventHandler(this.btnGenerateVoteCount_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 702);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // txtVoteCount
            // 
            this.txtVoteCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVoteCount.Location = new System.Drawing.Point(19, 525);
            this.txtVoteCount.Multiline = true;
            this.txtVoteCount.Name = "txtVoteCount";
            this.txtVoteCount.ReadOnly = true;
            this.txtVoteCount.Size = new System.Drawing.Size(580, 191);
            this.txtVoteCount.TabIndex = 5;
            // 
            // lblGameUrl
            // 
            this.lblGameUrl.AutoSize = true;
            this.lblGameUrl.Location = new System.Drawing.Point(13, 30);
            this.lblGameUrl.Name = "lblGameUrl";
            this.lblGameUrl.Size = new System.Drawing.Size(60, 13);
            this.lblGameUrl.TabIndex = 7;
            this.lblGameUrl.Text = "Game URL";
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(19, 94);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(55, 13);
            this.lblPlayerList.TabIndex = 8;
            this.lblPlayerList.Text = "Player List";
            // 
            // lblStartPost
            // 
            this.lblStartPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStartPost.AutoSize = true;
            this.lblStartPost.Location = new System.Drawing.Point(107, 76);
            this.lblStartPost.Name = "lblStartPost";
            this.lblStartPost.Size = new System.Drawing.Size(63, 13);
            this.lblStartPost.TabIndex = 9;
            this.lblStartPost.Text = "Start Post #";
            // 
            // lblEndPost
            // 
            this.lblEndPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEndPost.AutoSize = true;
            this.lblEndPost.Location = new System.Drawing.Point(303, 76);
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
            this.lblVoteCount.Location = new System.Drawing.Point(13, 509);
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
            this.listPlayers.Location = new System.Drawing.Point(19, 110);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.RowHeadersVisible = false;
            this.listPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listPlayers.Size = new System.Drawing.Size(580, 292);
            this.listPlayers.TabIndex = 12;
            this.listPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPlayers_CellContentClick);
            this.listPlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listPlayers_KeyPress);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 726);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "GUI";
            ((System.ComponentModel.ISupportInitialize)(this.listPlayers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewButtonColumn RemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nicknames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}