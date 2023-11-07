namespace HangmanDB
{
    partial class HangmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanForm));
            this.panelWord = new System.Windows.Forms.Panel();
            this.panelAlfabet = new System.Windows.Forms.Panel();
            this.pbHangman = new System.Windows.Forms.PictureBox();
            this.lblPunctaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWord
            // 
            this.panelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelWord.Location = new System.Drawing.Point(13, 280);
            this.panelWord.Name = "panelWord";
            this.panelWord.Size = new System.Drawing.Size(408, 30);
            this.panelWord.TabIndex = 0;
            // 
            // panelAlfabet
            // 
            this.panelAlfabet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAlfabet.Location = new System.Drawing.Point(13, 316);
            this.panelAlfabet.Name = "panelAlfabet";
            this.panelAlfabet.Size = new System.Drawing.Size(408, 175);
            this.panelAlfabet.TabIndex = 1;
            // 
            // pbHangman
            // 
            this.pbHangman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbHangman.Image = ((System.Drawing.Image)(resources.GetObject("pbHangman.Image")));
            this.pbHangman.Location = new System.Drawing.Point(459, 12);
            this.pbHangman.Name = "pbHangman";
            this.pbHangman.Size = new System.Drawing.Size(194, 317);
            this.pbHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHangman.TabIndex = 2;
            this.pbHangman.TabStop = false;
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Location = new System.Drawing.Point(13, 25);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(46, 13);
            this.lblPunctaj.TabIndex = 3;
            this.lblPunctaj.Text = "Punctaj:";
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(665, 503);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.pbHangman);
            this.Controls.Add(this.panelAlfabet);
            this.Controls.Add(this.panelWord);
            this.Name = "HangmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWord;
        private System.Windows.Forms.Panel panelAlfabet;
        private System.Windows.Forms.PictureBox pbHangman;
        private System.Windows.Forms.Label lblPunctaj;
    }
}