namespace Atestat2021S11
{
    partial class Form1
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
            this.dgvParlament = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbJudet = new System.Windows.Forms.TextBox();
            this.tbPartid = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPartidCauta = new System.Windows.Forms.Label();
            this.tbPartidCautare = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parlamentarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parlamentDataSet = new Atestat2021S11.ParlamentDataSet();
            this.parlamentarTableAdapter = new Atestat2021S11.ParlamentDataSetTableAdapters.ParlamentarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParlament)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parlamentarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parlamentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParlament
            // 
            this.dgvParlament.AutoGenerateColumns = false;
            this.dgvParlament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParlament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeleDataGridViewTextBoxColumn,
            this.partidDataGridViewTextBoxColumn,
            this.judetDataGridViewTextBoxColumn});
            this.dgvParlament.DataSource = this.parlamentarBindingSource;
            this.dgvParlament.Location = new System.Drawing.Point(13, 12);
            this.dgvParlament.Name = "dgvParlament";
            this.dgvParlament.Size = new System.Drawing.Size(444, 414);
            this.dgvParlament.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.tbPartid);
            this.groupBox1.Controls.Add(this.tbJudet);
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga Parlamentari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partid:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(47, 36);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(216, 20);
            this.tbNume.TabIndex = 3;
            // 
            // tbJudet
            // 
            this.tbJudet.Location = new System.Drawing.Point(47, 112);
            this.tbJudet.Name = "tbJudet";
            this.tbJudet.Size = new System.Drawing.Size(216, 20);
            this.tbJudet.TabIndex = 4;
            // 
            // tbPartid
            // 
            this.tbPartid.Location = new System.Drawing.Point(47, 76);
            this.tbPartid.Name = "tbPartid";
            this.tbPartid.Size = new System.Drawing.Size(216, 20);
            this.tbPartid.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(149, 138);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(114, 40);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCauta);
            this.groupBox2.Controls.Add(this.tbPartidCautare);
            this.groupBox2.Controls.Add(this.lblPartidCauta);
            this.groupBox2.Location = new System.Drawing.Point(464, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cauta parlamentari";
            // 
            // lblPartidCauta
            // 
            this.lblPartidCauta.AutoSize = true;
            this.lblPartidCauta.Location = new System.Drawing.Point(7, 35);
            this.lblPartidCauta.Name = "lblPartidCauta";
            this.lblPartidCauta.Size = new System.Drawing.Size(37, 13);
            this.lblPartidCauta.TabIndex = 0;
            this.lblPartidCauta.Text = "Partid:";
            // 
            // tbPartidCautare
            // 
            this.tbPartidCautare.Location = new System.Drawing.Point(51, 35);
            this.tbPartidCautare.Name = "tbPartidCautare";
            this.tbPartidCautare.Size = new System.Drawing.Size(135, 20);
            this.tbPartidCautare.TabIndex = 1;
            this.tbPartidCautare.TextChanged += new System.EventHandler(this.tbPartidCautare_TextChanged);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(192, 31);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(101, 24);
            this.btnCauta.TabIndex = 7;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeleDataGridViewTextBoxColumn
            // 
            this.numeleDataGridViewTextBoxColumn.DataPropertyName = "Numele";
            this.numeleDataGridViewTextBoxColumn.HeaderText = "Numele";
            this.numeleDataGridViewTextBoxColumn.Name = "numeleDataGridViewTextBoxColumn";
            // 
            // partidDataGridViewTextBoxColumn
            // 
            this.partidDataGridViewTextBoxColumn.DataPropertyName = "Partid";
            this.partidDataGridViewTextBoxColumn.HeaderText = "Partid";
            this.partidDataGridViewTextBoxColumn.Name = "partidDataGridViewTextBoxColumn";
            // 
            // judetDataGridViewTextBoxColumn
            // 
            this.judetDataGridViewTextBoxColumn.DataPropertyName = "Judet";
            this.judetDataGridViewTextBoxColumn.HeaderText = "Judet";
            this.judetDataGridViewTextBoxColumn.Name = "judetDataGridViewTextBoxColumn";
            // 
            // parlamentarBindingSource
            // 
            this.parlamentarBindingSource.DataMember = "Parlamentar";
            this.parlamentarBindingSource.DataSource = this.parlamentDataSet;
            // 
            // parlamentDataSet
            // 
            this.parlamentDataSet.DataSetName = "ParlamentDataSet";
            this.parlamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parlamentarTableAdapter
            // 
            this.parlamentarTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvParlament);
            this.Name = "Form1";
            this.Text = "Parlament";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParlament)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parlamentarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parlamentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParlament;
        private ParlamentDataSet parlamentDataSet;
        private System.Windows.Forms.BindingSource parlamentarBindingSource;
        private ParlamentDataSetTableAdapters.ParlamentarTableAdapter parlamentarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judetDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbPartid;
        private System.Windows.Forms.TextBox tbJudet;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.TextBox tbPartidCautare;
        private System.Windows.Forms.Label lblPartidCauta;
    }
}

