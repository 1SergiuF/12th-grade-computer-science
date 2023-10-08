namespace Teorie3
{
    partial class MainWindow
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnSearchByAge = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(13, 137);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(404, 303);
            this.listUsers.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(13, 42);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(84, 30);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(122, 42);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(97, 30);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnSearchByAge
            // 
            this.btnSearchByAge.Location = new System.Drawing.Point(13, 92);
            this.btnSearchByAge.Name = "btnSearchByAge";
            this.btnSearchByAge.Size = new System.Drawing.Size(84, 29);
            this.btnSearchByAge.TabIndex = 3;
            this.btnSearchByAge.Text = "Age";
            this.btnSearchByAge.UseVisualStyleBackColor = true;
            this.btnSearchByAge.Click += new System.EventHandler(this.btnSearchByAge_Click);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(122, 100);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 4;
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(424, 137);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(111, 20);
            this.tbSearchByName.TabIndex = 5;
            this.tbSearchByName.TextChanged += new System.EventHandler(this.tbSearchByName_TextChanged);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(424, 209);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 6;
            this.btnAsc.Text = "Crescator";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(423, 238);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(84, 23);
            this.btnDesc.TabIndex = 7;
            this.btnDesc.Text = "Descrescator";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(423, 290);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 52);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(542, 309);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(24, 20);
            this.tbIndex.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.tbSearchByName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.btnSearchByAge);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.listUsers);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnSearchByAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbIndex;
    }
}

