namespace S24
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegizor = new System.Windows.Forms.TextBox();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnAp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtTitluModifica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anApDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDBDataSet = new S24.CinemaDBDataSet();
            this.filmeTableAdapter = new S24.CinemaDBDataSetTableAdapters.FilmeTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtRegizorAfisare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.regizorDataGridViewTextBoxColumn,
            this.anApDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.durataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.txtAnAp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTitlu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDurata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRegizor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(563, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga film";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regizor";
            // 
            // txtRegizor
            // 
            this.txtRegizor.Location = new System.Drawing.Point(49, 38);
            this.txtRegizor.Name = "txtRegizor";
            this.txtRegizor.Size = new System.Drawing.Size(205, 20);
            this.txtRegizor.TabIndex = 1;
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(49, 172);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(205, 20);
            this.txtDurata.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Durata";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(49, 126);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(205, 20);
            this.txtTitlu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titlu";
            // 
            // txtAnAp
            // 
            this.txtAnAp.Location = new System.Drawing.Point(49, 82);
            this.txtAnAp.Name = "txtAnAp";
            this.txtAnAp.Size = new System.Drawing.Size(205, 20);
            this.txtAnAp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AnAp";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(49, 211);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(205, 42);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga film";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitluModifica);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnModifica);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifica titlu";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(57, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 20);
            this.txtId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(57, 96);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(105, 48);
            this.btnModifica.TabIndex = 11;
            this.btnModifica.Text = "Modifica titlu";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtTitluModifica
            // 
            this.txtTitluModifica.Location = new System.Drawing.Point(57, 70);
            this.txtTitluModifica.Name = "txtTitluModifica";
            this.txtTitluModifica.Size = new System.Drawing.Size(205, 20);
            this.txtTitluModifica.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Titlu";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regizorDataGridViewTextBoxColumn
            // 
            this.regizorDataGridViewTextBoxColumn.DataPropertyName = "Regizor";
            this.regizorDataGridViewTextBoxColumn.HeaderText = "Regizor";
            this.regizorDataGridViewTextBoxColumn.Name = "regizorDataGridViewTextBoxColumn";
            // 
            // anApDataGridViewTextBoxColumn
            // 
            this.anApDataGridViewTextBoxColumn.DataPropertyName = "AnAp";
            this.anApDataGridViewTextBoxColumn.HeaderText = "AnAp";
            this.anApDataGridViewTextBoxColumn.Name = "anApDataGridViewTextBoxColumn";
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "Durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "Durata";
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.cinemaDBDataSet;
            // 
            // cinemaDBDataSet
            // 
            this.cinemaDBDataSet.DataSetName = "CinemaDBDataSet";
            this.cinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAfiseaza);
            this.groupBox3.Controls.Add(this.txtRegizorAfisare);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(300, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 150);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Afisare";
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(57, 70);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(140, 51);
            this.btnAfiseaza.TabIndex = 11;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtRegizorAfisare
            // 
            this.txtRegizorAfisare.Location = new System.Drawing.Point(57, 41);
            this.txtRegizorAfisare.Name = "txtRegizorAfisare";
            this.txtRegizorAfisare.Size = new System.Drawing.Size(205, 20);
            this.txtRegizorAfisare.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Regizor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CinemaDBDataSet cinemaDBDataSet;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private CinemaDBDataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anApDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox txtAnAp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegizor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTitluModifica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtRegizorAfisare;
        private System.Windows.Forms.Label label8;
    }
}

