namespace Timezones
{
    partial class InsertPersonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.icobtnInsert = new FontAwesome.Sharp.IconButton();
            this.icobtnLeave = new FontAwesome.Sharp.IconButton();
            this.cmbIds = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(214, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // icobtnInsert
            // 
            this.icobtnInsert.BackColor = System.Drawing.Color.DarkOrange;
            this.icobtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icobtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icobtnInsert.ForeColor = System.Drawing.Color.Black;
            this.icobtnInsert.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.icobtnInsert.IconColor = System.Drawing.Color.Black;
            this.icobtnInsert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icobtnInsert.IconSize = 30;
            this.icobtnInsert.Location = new System.Drawing.Point(222, 160);
            this.icobtnInsert.Name = "icobtnInsert";
            this.icobtnInsert.Size = new System.Drawing.Size(112, 42);
            this.icobtnInsert.TabIndex = 6;
            this.icobtnInsert.Text = "Insert";
            this.icobtnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icobtnInsert.UseVisualStyleBackColor = false;
            this.icobtnInsert.Click += new System.EventHandler(this.icobtnInsert_Click);
            // 
            // icobtnLeave
            // 
            this.icobtnLeave.BackColor = System.Drawing.Color.SeaGreen;
            this.icobtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icobtnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icobtnLeave.ForeColor = System.Drawing.Color.Black;
            this.icobtnLeave.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.icobtnLeave.IconColor = System.Drawing.Color.Black;
            this.icobtnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icobtnLeave.IconSize = 40;
            this.icobtnLeave.Location = new System.Drawing.Point(158, 160);
            this.icobtnLeave.Name = "icobtnLeave";
            this.icobtnLeave.Size = new System.Drawing.Size(58, 42);
            this.icobtnLeave.TabIndex = 7;
            this.icobtnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icobtnLeave.UseVisualStyleBackColor = false;
            this.icobtnLeave.Click += new System.EventHandler(this.icobtnLeave_Click);
            // 
            // cmbIds
            // 
            this.cmbIds.FormattingEnabled = true;
            this.cmbIds.Location = new System.Drawing.Point(121, 118);
            this.cmbIds.Name = "cmbIds";
            this.cmbIds.Size = new System.Drawing.Size(213, 21);
            this.cmbIds.TabIndex = 8;
            this.cmbIds.SelectedIndexChanged += new System.EventHandler(this.cmbIds_SelectedIndexChanged);
            // 
            // InsertPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(418, 214);
            this.Controls.Add(this.cmbIds);
            this.Controls.Add(this.icobtnLeave);
            this.Controls.Add(this.icobtnInsert);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton icobtnInsert;
        private FontAwesome.Sharp.IconButton icobtnLeave;
        private System.Windows.Forms.ComboBox cmbIds;
    }
}