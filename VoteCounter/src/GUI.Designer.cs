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
            this.listPlayers = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtVoteCount = new System.Windows.Forms.TextBox();
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
            this.txtGameUrl.TabIndex = 0;
            this.txtGameUrl.Tag = "";
            this.txtGameUrl.Text = "Put Link to Game Here...";
            // 
            // txtStartingPost
            // 
            this.txtStartingPost.Location = new System.Drawing.Point(283, 91);
            this.txtStartingPost.Name = "txtStartingPost";
            this.txtStartingPost.Size = new System.Drawing.Size(100, 20);
            this.txtStartingPost.TabIndex = 1;
            this.txtStartingPost.Text = "Starting post #";
            // 
            // txtEndingPost
            // 
            this.txtEndingPost.Location = new System.Drawing.Point(421, 91);
            this.txtEndingPost.Name = "txtEndingPost";
            this.txtEndingPost.Size = new System.Drawing.Size(100, 20);
            this.txtEndingPost.TabIndex = 2;
            this.txtEndingPost.Text = "Ending Post #";
            // 
            // btnGenerateVoteCount
            // 
            this.btnGenerateVoteCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerateVoteCount.Location = new System.Drawing.Point(260, 156);
            this.btnGenerateVoteCount.Name = "btnGenerateVoteCount";
            this.btnGenerateVoteCount.Size = new System.Drawing.Size(297, 77);
            this.btnGenerateVoteCount.TabIndex = 3;
            this.btnGenerateVoteCount.Text = "Generate Vote Count!";
            this.btnGenerateVoteCount.UseVisualStyleBackColor = false;
            this.btnGenerateVoteCount.Click += new System.EventHandler(this.btnGenerateVoteCount_Click);
            // 
            // listPlayers
            // 
            this.listPlayers.Location = new System.Drawing.Point(68, 67);
            this.listPlayers.Multiline = true;
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(165, 166);
            this.listPlayers.TabIndex = 4;
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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 544);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtVoteCount);
            this.Controls.Add(this.listPlayers);
            this.Controls.Add(this.btnGenerateVoteCount);
            this.Controls.Add(this.txtEndingPost);
            this.Controls.Add(this.txtStartingPost);
            this.Controls.Add(this.txtGameUrl);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameUrl;
        private System.Windows.Forms.TextBox txtStartingPost;
        private System.Windows.Forms.TextBox txtEndingPost;
        private System.Windows.Forms.Button btnGenerateVoteCount;
        private System.Windows.Forms.TextBox listPlayers;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtVoteCount;
    }
}