namespace Timezones
{
    partial class TimeForm
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
            this.pbClock = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.icobtnLeave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClock
            // 
            this.pbClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pbClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbClock.Location = new System.Drawing.Point(0, 0);
            this.pbClock.Name = "pbClock";
            this.pbClock.Size = new System.Drawing.Size(509, 290);
            this.pbClock.TabIndex = 0;
            this.pbClock.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Cyan;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(509, 290);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Coral;
            this.lblDate.Location = new System.Drawing.Point(0, 249);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(509, 41);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Coral;
            this.lblDay.Location = new System.Drawing.Point(0, 216);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(509, 33);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "label1";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(509, 56);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "label1";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icobtnLeave
            // 
            this.icobtnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icobtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icobtnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icobtnLeave.ForeColor = System.Drawing.Color.Black;
            this.icobtnLeave.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icobtnLeave.IconColor = System.Drawing.Color.Black;
            this.icobtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icobtnLeave.IconSize = 20;
            this.icobtnLeave.Location = new System.Drawing.Point(458, 12);
            this.icobtnLeave.Name = "icobtnLeave";
            this.icobtnLeave.Size = new System.Drawing.Size(39, 28);
            this.icobtnLeave.TabIndex = 8;
            this.icobtnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icobtnLeave.UseVisualStyleBackColor = false;
            this.icobtnLeave.Click += new System.EventHandler(this.icobtnLeave_Click);
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(509, 290);
            this.Controls.Add(this.icobtnLeave);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblUsername;
        private FontAwesome.Sharp.IconButton icobtnLeave;
    }
}

