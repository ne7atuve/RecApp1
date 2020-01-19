namespace RecApp
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnExit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRachetdan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete_Graf = new System.Windows.Forms.Button();
            this.lblPover_Nagrev = new System.Windows.Forms.Label();
            this.lblKonech_Temp = new System.Windows.Forms.Label();
            this.btnTochech_Graf = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPostr_Graf = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnGraf = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRachetdan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(849, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnReport);
            this.splitContainer1.Panel2.Controls.Add(this.btnGraf);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Size = new System.Drawing.Size(995, 575);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 404);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(987, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Исходные данные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 3);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(973, 369);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            this.propertyGrid.Click += new System.EventHandler(this.propertyGrid_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRachetdan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчетные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRachetdan
            // 
            this.dgvRachetdan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRachetdan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvRachetdan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRachetdan.Location = new System.Drawing.Point(3, 3);
            this.dgvRachetdan.Name = "dgvRachetdan";
            this.dgvRachetdan.ReadOnly = true;
            this.dgvRachetdan.Size = new System.Drawing.Size(981, 372);
            this.dgvRachetdan.TabIndex = 0;
            this.dgvRachetdan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Расчетные данные";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 117;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Единица измерения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Значение";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Физический смысл";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete_Graf);
            this.tabPage3.Controls.Add(this.lblPover_Nagrev);
            this.tabPage3.Controls.Add(this.lblKonech_Temp);
            this.tabPage3.Controls.Add(this.btnTochech_Graf);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.btnPostr_Graf);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(987, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "График";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete_Graf
            // 
            this.btnDelete_Graf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete_Graf.Location = new System.Drawing.Point(712, 182);
            this.btnDelete_Graf.Name = "btnDelete_Graf";
            this.btnDelete_Graf.Size = new System.Drawing.Size(120, 32);
            this.btnDelete_Graf.TabIndex = 5;
            this.btnDelete_Graf.Text = "Удалить график";
            this.btnDelete_Graf.UseVisualStyleBackColor = true;
            this.btnDelete_Graf.Click += new System.EventHandler(this.btnDelete_Graf_Click);
            // 
            // lblPover_Nagrev
            // 
            this.lblPover_Nagrev.AutoSize = true;
            this.lblPover_Nagrev.BackColor = System.Drawing.Color.Transparent;
            this.lblPover_Nagrev.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPover_Nagrev.Location = new System.Drawing.Point(20, 103);
            this.lblPover_Nagrev.Name = "lblPover_Nagrev";
            this.lblPover_Nagrev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPover_Nagrev.Size = new System.Drawing.Size(137, 13);
            this.lblPover_Nagrev.TabIndex = 4;
            this.lblPover_Nagrev.Text = "Поверхность нагрева, м2";
            this.lblPover_Nagrev.Click += new System.EventHandler(this.lblPover_Nagrev_Click);
            // 
            // lblKonech_Temp
            // 
            this.lblKonech_Temp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblKonech_Temp.AutoSize = true;
            this.lblKonech_Temp.Location = new System.Drawing.Point(368, 287);
            this.lblKonech_Temp.Name = "lblKonech_Temp";
            this.lblKonech_Temp.Size = new System.Drawing.Size(140, 13);
            this.lblKonech_Temp.TabIndex = 3;
            this.lblKonech_Temp.Text = "Конечная температура, °C";
            this.lblKonech_Temp.Click += new System.EventHandler(this.lblKonech_Temp_Click);
            // 
            // btnTochech_Graf
            // 
            this.btnTochech_Graf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTochech_Graf.Location = new System.Drawing.Point(578, 326);
            this.btnTochech_Graf.Name = "btnTochech_Graf";
            this.btnTochech_Graf.Size = new System.Drawing.Size(210, 36);
            this.btnTochech_Graf.TabIndex = 2;
            this.btnTochech_Graf.Text = "Построить точечный график";
            this.btnTochech_Graf.UseVisualStyleBackColor = true;
            this.btnTochech_Graf.Click += new System.EventHandler(this.btnTochech_Graf_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(163, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Поверхность нагрева";
            series1.Name = "Поверхность нагрева";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Точечный график поверхности нагрева";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(748, 284);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "TitlePover_Nagr";
            title1.Text = "График параметра \"Поверхность нагрева\"";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnPostr_Graf
            // 
            this.btnPostr_Graf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPostr_Graf.Location = new System.Drawing.Point(112, 325);
            this.btnPostr_Graf.Name = "btnPostr_Graf";
            this.btnPostr_Graf.Size = new System.Drawing.Size(198, 37);
            this.btnPostr_Graf.TabIndex = 0;
            this.btnPostr_Graf.Text = "Построить график";
            this.btnPostr_Graf.UseVisualStyleBackColor = true;
            this.btnPostr_Graf.Click += new System.EventHandler(this.btnPostr_Graf_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(235, 90);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(124, 33);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnGraf
            // 
            this.btnGraf.Location = new System.Drawing.Point(105, 90);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(75, 23);
            this.btnGraf.TabIndex = 2;
            this.btnGraf.Text = "График";
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Visible = false;
            this.btnGraf.Click += new System.EventHandler(this.btnGraf_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(530, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Расчет";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 575);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Расчет керамического рекуператора";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRachetdan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.DataGridView dgvRachetdan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource frmMainBindingSource;
        private System.Windows.Forms.Button btnGraf;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnPostr_Graf;
        private System.Windows.Forms.Button btnTochech_Graf;
        private System.Windows.Forms.Label lblPover_Nagrev;
        private System.Windows.Forms.Label lblKonech_Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnDelete_Graf;
    }
}

