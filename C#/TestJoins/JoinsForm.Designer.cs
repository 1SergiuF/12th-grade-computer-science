namespace TestJoins
{
    partial class JoinsForm
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
            this.dgvJoins = new System.Windows.Forms.DataGridView();
            this.btnInnerJoin = new System.Windows.Forms.Button();
            this.btnFullJoin = new System.Windows.Forms.Button();
            this.btnRightJoin = new System.Windows.Forms.Button();
            this.btnLeftJoin = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJoins
            // 
            this.dgvJoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJoins.Location = new System.Drawing.Point(12, 38);
            this.dgvJoins.Name = "dgvJoins";
            this.dgvJoins.Size = new System.Drawing.Size(532, 296);
            this.dgvJoins.TabIndex = 0;
            // 
            // btnInnerJoin
            // 
            this.btnInnerJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInnerJoin.Location = new System.Drawing.Point(551, 12);
            this.btnInnerJoin.Name = "btnInnerJoin";
            this.btnInnerJoin.Size = new System.Drawing.Size(237, 85);
            this.btnInnerJoin.TabIndex = 1;
            this.btnInnerJoin.Text = "Inner Join";
            this.btnInnerJoin.UseVisualStyleBackColor = true;
            this.btnInnerJoin.Click += new System.EventHandler(this.btnInnerJoin_Click);
            // 
            // btnFullJoin
            // 
            this.btnFullJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullJoin.Location = new System.Drawing.Point(551, 285);
            this.btnFullJoin.Name = "btnFullJoin";
            this.btnFullJoin.Size = new System.Drawing.Size(237, 85);
            this.btnFullJoin.TabIndex = 2;
            this.btnFullJoin.Text = "Full Join";
            this.btnFullJoin.UseVisualStyleBackColor = true;
            this.btnFullJoin.Click += new System.EventHandler(this.btnFullJoin_Click);
            // 
            // btnRightJoin
            // 
            this.btnRightJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightJoin.Location = new System.Drawing.Point(551, 194);
            this.btnRightJoin.Name = "btnRightJoin";
            this.btnRightJoin.Size = new System.Drawing.Size(237, 85);
            this.btnRightJoin.TabIndex = 3;
            this.btnRightJoin.Text = "Right Join";
            this.btnRightJoin.UseVisualStyleBackColor = true;
            this.btnRightJoin.Click += new System.EventHandler(this.btnRightJoin_Click);
            // 
            // btnLeftJoin
            // 
            this.btnLeftJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftJoin.Location = new System.Drawing.Point(551, 103);
            this.btnLeftJoin.Name = "btnLeftJoin";
            this.btnLeftJoin.Size = new System.Drawing.Size(237, 85);
            this.btnLeftJoin.TabIndex = 4;
            this.btnLeftJoin.Text = "Left Join";
            this.btnLeftJoin.UseVisualStyleBackColor = true;
            this.btnLeftJoin.Click += new System.EventHandler(this.btnLeftJoin_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(13, 385);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(532, 266);
            this.dgvCustomers.TabIndex = 5;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(581, 385);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(532, 266);
            this.dgvOrders.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Join Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Orders";
            // 
            // JoinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 654);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnLeftJoin);
            this.Controls.Add(this.btnRightJoin);
            this.Controls.Add(this.btnFullJoin);
            this.Controls.Add(this.btnInnerJoin);
            this.Controls.Add(this.dgvJoins);
            this.Name = "JoinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joins";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJoins;
        private System.Windows.Forms.Button btnInnerJoin;
        private System.Windows.Forms.Button btnFullJoin;
        private System.Windows.Forms.Button btnRightJoin;
        private System.Windows.Forms.Button btnLeftJoin;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

