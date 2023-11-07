namespace Atestat2021S14
{
    partial class Campionat
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gazdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oaspetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golGazdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golOaspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campionatDataSet = new Atestat2021S14.CampionatDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGazde = new System.Windows.Forms.TextBox();
            this.tbOaspeti = new System.Windows.Forms.TextBox();
            this.tbGolGazde = new System.Windows.Forms.TextBox();
            this.tbEtapa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.meciTableAdapter = new Atestat2021S14.CampionatDataSetTableAdapters.MeciTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbGolOaspeti = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionatDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.etapaDataGridViewTextBoxColumn,
            this.gazdeDataGridViewTextBoxColumn,
            this.oaspetiDataGridViewTextBoxColumn,
            this.golGazdDataGridViewTextBoxColumn,
            this.golOaspDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etapaDataGridViewTextBoxColumn
            // 
            this.etapaDataGridViewTextBoxColumn.DataPropertyName = "Etapa";
            this.etapaDataGridViewTextBoxColumn.HeaderText = "Etapa";
            this.etapaDataGridViewTextBoxColumn.Name = "etapaDataGridViewTextBoxColumn";
            // 
            // gazdeDataGridViewTextBoxColumn
            // 
            this.gazdeDataGridViewTextBoxColumn.DataPropertyName = "Gazde";
            this.gazdeDataGridViewTextBoxColumn.HeaderText = "Gazde";
            this.gazdeDataGridViewTextBoxColumn.Name = "gazdeDataGridViewTextBoxColumn";
            // 
            // oaspetiDataGridViewTextBoxColumn
            // 
            this.oaspetiDataGridViewTextBoxColumn.DataPropertyName = "Oaspeti";
            this.oaspetiDataGridViewTextBoxColumn.HeaderText = "Oaspeti";
            this.oaspetiDataGridViewTextBoxColumn.Name = "oaspetiDataGridViewTextBoxColumn";
            // 
            // golGazdDataGridViewTextBoxColumn
            // 
            this.golGazdDataGridViewTextBoxColumn.DataPropertyName = "Gol_Gazd";
            this.golGazdDataGridViewTextBoxColumn.HeaderText = "Gol_Gazd";
            this.golGazdDataGridViewTextBoxColumn.Name = "golGazdDataGridViewTextBoxColumn";
            // 
            // golOaspDataGridViewTextBoxColumn
            // 
            this.golOaspDataGridViewTextBoxColumn.DataPropertyName = "Gol_Oasp";
            this.golOaspDataGridViewTextBoxColumn.HeaderText = "Gol_Oasp";
            this.golOaspDataGridViewTextBoxColumn.Name = "golOaspDataGridViewTextBoxColumn";
            // 
            // meciBindingSource
            // 
            this.meciBindingSource.DataMember = "Meci";
            this.meciBindingSource.DataSource = this.campionatDataSet;
            // 
            // campionatDataSet
            // 
            this.campionatDataSet.DataSetName = "CampionatDataSet";
            this.campionatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.tbGolOaspeti);
            this.groupBox1.Controls.Add(this.tbGazde);
            this.groupBox1.Controls.Add(this.tbOaspeti);
            this.groupBox1.Controls.Add(this.tbGolGazde);
            this.groupBox1.Controls.Add(this.tbEtapa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(663, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aduga Meci";
            // 
            // tbGazde
            // 
            this.tbGazde.Location = new System.Drawing.Point(78, 71);
            this.tbGazde.Name = "tbGazde";
            this.tbGazde.Size = new System.Drawing.Size(197, 20);
            this.tbGazde.TabIndex = 8;
            // 
            // tbOaspeti
            // 
            this.tbOaspeti.Location = new System.Drawing.Point(78, 112);
            this.tbOaspeti.Name = "tbOaspeti";
            this.tbOaspeti.Size = new System.Drawing.Size(197, 20);
            this.tbOaspeti.TabIndex = 7;
            // 
            // tbGolGazde
            // 
            this.tbGolGazde.Location = new System.Drawing.Point(78, 154);
            this.tbGolGazde.Name = "tbGolGazde";
            this.tbGolGazde.Size = new System.Drawing.Size(197, 20);
            this.tbGolGazde.TabIndex = 6;
            // 
            // tbEtapa
            // 
            this.tbEtapa.Location = new System.Drawing.Point(78, 36);
            this.tbEtapa.Name = "tbEtapa";
            this.tbEtapa.Size = new System.Drawing.Size(197, 20);
            this.tbEtapa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gazde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oaspeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gol Gazde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gol Oaspeti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etapa:";
            // 
            // meciTableAdapter
            // 
            this.meciTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTop);
            this.groupBox2.Location = new System.Drawing.Point(663, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top Descrescator";
            // 
            // tbGolOaspeti
            // 
            this.tbGolOaspeti.Location = new System.Drawing.Point(78, 188);
            this.tbGolOaspeti.Name = "tbGolOaspeti";
            this.tbGolOaspeti.Size = new System.Drawing.Size(197, 20);
            this.tbGolOaspeti.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(154, 215);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(121, 44);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(10, 19);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(121, 44);
            this.btnTop.TabIndex = 11;
            this.btnTop.Text = "Genereaza Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // Campionat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Campionat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campionat";
            this.Load += new System.EventHandler(this.Campionat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campionatDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CampionatDataSet campionatDataSet;
        private System.Windows.Forms.BindingSource meciBindingSource;
        private CampionatDataSetTableAdapters.MeciTableAdapter meciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gazdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oaspetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golGazdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golOaspDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbGazde;
        private System.Windows.Forms.TextBox tbOaspeti;
        private System.Windows.Forms.TextBox tbGolGazde;
        private System.Windows.Forms.TextBox tbEtapa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbGolOaspeti;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnTop;
    }
}

