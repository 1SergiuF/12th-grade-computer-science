namespace HangmanDB
{
    partial class MenuForm
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
            this.dgvTopHangman = new System.Windows.Forms.DataGridView();
            this.colPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHighscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.lblHighscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopHangman)).BeginInit();
            this.gbStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTopHangman
            // 
            this.dgvTopHangman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTopHangman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopHangman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlace,
            this.colUsername,
            this.colHighscore});
            this.dgvTopHangman.Location = new System.Drawing.Point(13, 71);
            this.dgvTopHangman.Name = "dgvTopHangman";
            this.dgvTopHangman.Size = new System.Drawing.Size(343, 403);
            this.dgvTopHangman.TabIndex = 0;
            // 
            // colPlace
            // 
            this.colPlace.HeaderText = "Place";
            this.colPlace.Name = "colPlace";
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            // 
            // colHighscore
            // 
            this.colHighscore.HeaderText = "Highscore";
            this.colHighscore.Name = "colHighscore";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hangman Top Score";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.BackgroundImage = global::HangmanDB.Properties.Resources.desktop_wallpaper_bright_green_glow_background;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Khaki;
            this.btnPlay.Location = new System.Drawing.Point(362, 412);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(434, 61);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // gbStats
            // 
            this.gbStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbStats.BackColor = System.Drawing.Color.DimGray;
            this.gbStats.Controls.Add(this.lblHighscore);
            this.gbStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStats.ForeColor = System.Drawing.Color.Black;
            this.gbStats.Location = new System.Drawing.Point(363, 71);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(425, 107);
            this.gbStats.TabIndex = 3;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "groupBox1";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(7, 37);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(145, 31);
            this.lblHighscore.TabIndex = 0;
            this.lblHighscore.Text = "Highscore:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangmanDB.Properties.Resources.pngtree_blue_atmospheric_background_image_50584;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.gbStats);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvTopHangman);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopHangman)).EndInit();
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTopHangman;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHighscore;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.Label lblHighscore;
    }
}