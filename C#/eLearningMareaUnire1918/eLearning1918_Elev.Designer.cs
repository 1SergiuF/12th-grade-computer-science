namespace eLearningMareaUnire1918
{
    partial class eLearning1918_Elev
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tabcMeniu = new System.Windows.Forms.TabControl();
            this.pageTeste = new System.Windows.Forms.TabPage();
            this.panelTest = new System.Windows.Forms.Panel();
            this.raspunsTb = new System.Windows.Forms.TextBox();
            this.btnUrmatorul = new System.Windows.Forms.Button();
            this.btnRaspuns = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.rtbEnunt = new System.Windows.Forms.RichTextBox();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.pageCarnet = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvCarnet = new System.Windows.Forms.DataGridView();
            this.lblNumePrenume = new System.Windows.Forms.Label();
            this.pageGrafic = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eLearning1918DataSet = new eLearningMareaUnire1918.eLearning1918DataSet();
            this.evaluariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluariTableAdapter = new eLearningMareaUnire1918.eLearning1918DataSetTableAdapters.EvaluariTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabcMeniu.SuspendLayout();
            this.pageTeste.SuspendLayout();
            this.panelTest.SuspendLayout();
            this.pageCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarnet)).BeginInit();
            this.pageGrafic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eLearning1918DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meniu elev";
            // 
            // tabcMeniu
            // 
            this.tabcMeniu.Controls.Add(this.pageTeste);
            this.tabcMeniu.Controls.Add(this.pageCarnet);
            this.tabcMeniu.Controls.Add(this.pageGrafic);
            this.tabcMeniu.Location = new System.Drawing.Point(13, 45);
            this.tabcMeniu.Name = "tabcMeniu";
            this.tabcMeniu.SelectedIndex = 0;
            this.tabcMeniu.Size = new System.Drawing.Size(859, 468);
            this.tabcMeniu.TabIndex = 1;
            this.tabcMeniu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabcMeniu_Selected);
            // 
            // pageTeste
            // 
            this.pageTeste.Controls.Add(this.panelTest);
            this.pageTeste.Controls.Add(this.lblPunctaj);
            this.pageTeste.Controls.Add(this.btnStartTest);
            this.pageTeste.Location = new System.Drawing.Point(4, 22);
            this.pageTeste.Name = "pageTeste";
            this.pageTeste.Padding = new System.Windows.Forms.Padding(3);
            this.pageTeste.Size = new System.Drawing.Size(851, 442);
            this.pageTeste.TabIndex = 0;
            this.pageTeste.Text = "Teste";
            this.pageTeste.UseVisualStyleBackColor = true;
            // 
            // panelTest
            // 
            this.panelTest.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTest.Controls.Add(this.raspunsTb);
            this.panelTest.Controls.Add(this.btnUrmatorul);
            this.panelTest.Controls.Add(this.btnRaspuns);
            this.panelTest.Controls.Add(this.lblItem);
            this.panelTest.Controls.Add(this.rtbEnunt);
            this.panelTest.Location = new System.Drawing.Point(164, 47);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(647, 378);
            this.panelTest.TabIndex = 3;
            // 
            // raspunsTb
            // 
            this.raspunsTb.Location = new System.Drawing.Point(226, 146);
            this.raspunsTb.Name = "raspunsTb";
            this.raspunsTb.Size = new System.Drawing.Size(324, 20);
            this.raspunsTb.TabIndex = 6;
            this.raspunsTb.Visible = false;
            // 
            // btnUrmatorul
            // 
            this.btnUrmatorul.Location = new System.Drawing.Point(133, 333);
            this.btnUrmatorul.Name = "btnUrmatorul";
            this.btnUrmatorul.Size = new System.Drawing.Size(134, 42);
            this.btnUrmatorul.TabIndex = 5;
            this.btnUrmatorul.Text = "Urmatorul";
            this.btnUrmatorul.UseVisualStyleBackColor = true;
            this.btnUrmatorul.Visible = false;
            this.btnUrmatorul.Click += new System.EventHandler(this.btnUrmatorul_Click);
            // 
            // btnRaspuns
            // 
            this.btnRaspuns.Location = new System.Drawing.Point(510, 333);
            this.btnRaspuns.Name = "btnRaspuns";
            this.btnRaspuns.Size = new System.Drawing.Size(134, 42);
            this.btnRaspuns.TabIndex = 4;
            this.btnRaspuns.Text = "Raspunde";
            this.btnRaspuns.UseVisualStyleBackColor = true;
            this.btnRaspuns.Visible = false;
            this.btnRaspuns.Click += new System.EventHandler(this.btnRaspuns_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(21, 61);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(42, 13);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item nr.";
            this.lblItem.Visible = false;
            // 
            // rtbEnunt
            // 
            this.rtbEnunt.Location = new System.Drawing.Point(133, 32);
            this.rtbEnunt.Name = "rtbEnunt";
            this.rtbEnunt.Size = new System.Drawing.Size(479, 96);
            this.rtbEnunt.TabIndex = 2;
            this.rtbEnunt.Text = "";
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Location = new System.Drawing.Point(161, 31);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(55, 13);
            this.lblPunctaj.TabIndex = 1;
            this.lblPunctaj.Text = "Punctaj=1";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(7, 19);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(93, 37);
            this.btnStartTest.TabIndex = 0;
            this.btnStartTest.Text = "Start test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // pageCarnet
            // 
            this.pageCarnet.Controls.Add(this.btnPrint);
            this.pageCarnet.Controls.Add(this.dgvCarnet);
            this.pageCarnet.Controls.Add(this.lblNumePrenume);
            this.pageCarnet.Location = new System.Drawing.Point(4, 22);
            this.pageCarnet.Name = "pageCarnet";
            this.pageCarnet.Padding = new System.Windows.Forms.Padding(3);
            this.pageCarnet.Size = new System.Drawing.Size(851, 442);
            this.pageCarnet.TabIndex = 1;
            this.pageCarnet.Text = "Carnet de note";
            this.pageCarnet.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(661, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 56);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvCarnet
            // 
            this.dgvCarnet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarnet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarnet.Location = new System.Drawing.Point(20, 69);
            this.dgvCarnet.Name = "dgvCarnet";
            this.dgvCarnet.Size = new System.Drawing.Size(635, 291);
            this.dgvCarnet.TabIndex = 1;
            // 
            // lblNumePrenume
            // 
            this.lblNumePrenume.AutoSize = true;
            this.lblNumePrenume.Location = new System.Drawing.Point(327, 34);
            this.lblNumePrenume.Name = "lblNumePrenume";
            this.lblNumePrenume.Size = new System.Drawing.Size(138, 13);
            this.lblNumePrenume.TabIndex = 0;
            this.lblNumePrenume.Text = "Carnetul de note al elevului ";
            // 
            // pageGrafic
            // 
            this.pageGrafic.Controls.Add(this.chart1);
            this.pageGrafic.Location = new System.Drawing.Point(4, 22);
            this.pageGrafic.Name = "pageGrafic";
            this.pageGrafic.Size = new System.Drawing.Size(851, 442);
            this.pageGrafic.TabIndex = 2;
            this.pageGrafic.Text = "Grafic note";
            this.pageGrafic.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eLearning1918DataSet
            // 
            this.eLearning1918DataSet.DataSetName = "eLearning1918DataSet";
            this.eLearning1918DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluariBindingSource
            // 
            this.evaluariBindingSource.DataMember = "Evaluari";
            this.evaluariBindingSource.DataSource = this.eLearning1918DataSet;
            // 
            // evaluariTableAdapter
            // 
            this.evaluariTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 24);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(819, 421);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // eLearning1918_Elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.tabcMeniu);
            this.Controls.Add(this.label1);
            this.Name = "eLearning1918_Elev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eLearning1918_Elev";
            this.Load += new System.EventHandler(this.eLearning1918_Elev_Load);
            this.tabcMeniu.ResumeLayout(false);
            this.pageTeste.ResumeLayout(false);
            this.pageTeste.PerformLayout();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.pageCarnet.ResumeLayout(false);
            this.pageCarnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarnet)).EndInit();
            this.pageGrafic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eLearning1918DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcMeniu;
        private System.Windows.Forms.TabPage pageTeste;
        private System.Windows.Forms.TabPage pageCarnet;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.TabPage pageGrafic;
        private System.Windows.Forms.Label lblPunctaj;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.RichTextBox rtbEnunt;
        private System.Windows.Forms.Button btnRaspuns;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnUrmatorul;
        private System.Windows.Forms.TextBox raspunsTb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblNumePrenume;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvCarnet;
        private eLearning1918DataSet eLearning1918DataSet;
        private System.Windows.Forms.BindingSource evaluariBindingSource;
        private eLearning1918DataSetTableAdapters.EvaluariTableAdapter evaluariTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}