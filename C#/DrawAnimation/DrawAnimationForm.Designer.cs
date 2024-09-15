namespace DrawAnimation
{
    partial class DrawAnimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawAnimationForm));
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.btnDeseneaza = new System.Windows.Forms.Button();
            this.btnReseteaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.Color.Transparent;
            this.pbDraw.Location = new System.Drawing.Point(144, 12);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(644, 426);
            this.pbDraw.TabIndex = 0;
            this.pbDraw.TabStop = false;
            this.pbDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDraw_Paint);
            // 
            // btnDeseneaza
            // 
            this.btnDeseneaza.Location = new System.Drawing.Point(12, 12);
            this.btnDeseneaza.Name = "btnDeseneaza";
            this.btnDeseneaza.Size = new System.Drawing.Size(126, 150);
            this.btnDeseneaza.TabIndex = 1;
            this.btnDeseneaza.Text = "Deseneaza";
            this.btnDeseneaza.UseVisualStyleBackColor = true;
            this.btnDeseneaza.Click += new System.EventHandler(this.btnDeseneaza_Click);
            // 
            // btnReseteaza
            // 
            this.btnReseteaza.Location = new System.Drawing.Point(12, 168);
            this.btnReseteaza.Name = "btnReseteaza";
            this.btnReseteaza.Size = new System.Drawing.Size(126, 150);
            this.btnReseteaza.TabIndex = 2;
            this.btnReseteaza.Text = "Reseteaza";
            this.btnReseteaza.UseVisualStyleBackColor = true;
            this.btnReseteaza.Click += new System.EventHandler(this.btnReseteaza_Click);
            // 
            // DrawAnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReseteaza);
            this.Controls.Add(this.btnDeseneaza);
            this.Controls.Add(this.pbDraw);
            this.Name = "DrawAnimationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw Animation";
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.Button btnDeseneaza;
        private System.Windows.Forms.Button btnReseteaza;
    }
}

