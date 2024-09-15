namespace S19
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.Angajat = new System.Windows.Forms.Label();
            this.txtNrAp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNrBloc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.chkAngajat = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAngajatModifica = new System.Windows.Forms.CheckBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeModifica = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrBlocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrApDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.locatarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatariDBDataSet = new S19.LocatariDBDataSet();
            this.locatarTableAdapter = new S19.LocatariDBDataSetTableAdapters.LocatarTableAdapter();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locatarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatariDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.nrBlocDataGridViewTextBoxColumn,
            this.nrApDataGridViewTextBoxColumn,
            this.angajatDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.locatarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAngajat);
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.txtNrBloc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNrAp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Angajat);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(566, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga locatar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(49, 37);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(194, 20);
            this.txtNume.TabIndex = 1;
            // 
            // Angajat
            // 
            this.Angajat.AutoSize = true;
            this.Angajat.Location = new System.Drawing.Point(7, 150);
            this.Angajat.Name = "Angajat";
            this.Angajat.Size = new System.Drawing.Size(43, 13);
            this.Angajat.TabIndex = 2;
            this.Angajat.Text = "Angajat";
            // 
            // txtNrAp
            // 
            this.txtNrAp.Location = new System.Drawing.Point(49, 108);
            this.txtNrAp.Name = "txtNrAp";
            this.txtNrAp.Size = new System.Drawing.Size(194, 20);
            this.txtNrAp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NrAp";
            // 
            // txtNrBloc
            // 
            this.txtNrBloc.Location = new System.Drawing.Point(49, 75);
            this.txtNrBloc.Name = "txtNrBloc";
            this.txtNrBloc.Size = new System.Drawing.Size(194, 20);
            this.txtNrBloc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NrBloc";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(125, 193);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(118, 57);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // chkAngajat
            // 
            this.chkAngajat.AutoSize = true;
            this.chkAngajat.Location = new System.Drawing.Point(56, 150);
            this.chkAngajat.Name = "chkAngajat";
            this.chkAngajat.Size = new System.Drawing.Size(15, 14);
            this.chkAngajat.TabIndex = 9;
            this.chkAngajat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAngajatModifica);
            this.groupBox2.Controls.Add(this.btnModifica);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNumeModifica);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 186);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifica locatar";
            // 
            // chkAngajatModifica
            // 
            this.chkAngajatModifica.AutoSize = true;
            this.chkAngajatModifica.Location = new System.Drawing.Point(56, 76);
            this.chkAngajatModifica.Name = "chkAngajatModifica";
            this.chkAngajatModifica.Size = new System.Drawing.Size(15, 14);
            this.chkAngajatModifica.TabIndex = 9;
            this.chkAngajatModifica.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(6, 112);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(118, 57);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Angajat";
            // 
            // txtNumeModifica
            // 
            this.txtNumeModifica.Location = new System.Drawing.Point(49, 37);
            this.txtNumeModifica.Name = "txtNumeModifica";
            this.txtNumeModifica.Size = new System.Drawing.Size(194, 20);
            this.txtNumeModifica.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // nrBlocDataGridViewTextBoxColumn
            // 
            this.nrBlocDataGridViewTextBoxColumn.DataPropertyName = "NrBloc";
            this.nrBlocDataGridViewTextBoxColumn.HeaderText = "NrBloc";
            this.nrBlocDataGridViewTextBoxColumn.Name = "nrBlocDataGridViewTextBoxColumn";
            // 
            // nrApDataGridViewTextBoxColumn
            // 
            this.nrApDataGridViewTextBoxColumn.DataPropertyName = "NrAp";
            this.nrApDataGridViewTextBoxColumn.HeaderText = "NrAp";
            this.nrApDataGridViewTextBoxColumn.Name = "nrApDataGridViewTextBoxColumn";
            // 
            // angajatDataGridViewCheckBoxColumn
            // 
            this.angajatDataGridViewCheckBoxColumn.DataPropertyName = "Angajat";
            this.angajatDataGridViewCheckBoxColumn.HeaderText = "Angajat";
            this.angajatDataGridViewCheckBoxColumn.Name = "angajatDataGridViewCheckBoxColumn";
            // 
            // locatarBindingSource
            // 
            this.locatarBindingSource.DataMember = "Locatar";
            this.locatarBindingSource.DataSource = this.locatariDBDataSet;
            // 
            // locatariDBDataSet
            // 
            this.locatariDBDataSet.DataSetName = "LocatariDBDataSet";
            this.locatariDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatarTableAdapter
            // 
            this.locatarTableAdapter.ClearBeforeFill = true;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(320, 320);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(239, 48);
            this.btnAfiseaza.TabIndex = 11;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 540);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatari";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locatarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatariDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LocatariDBDataSet locatariDBDataSet;
        private System.Windows.Forms.BindingSource locatarBindingSource;
        private LocatariDBDataSetTableAdapters.LocatarTableAdapter locatarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrBlocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrApDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn angajatDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAngajat;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox txtNrBloc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrAp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Angajat;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAngajatModifica;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeModifica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAfiseaza;
    }
}

