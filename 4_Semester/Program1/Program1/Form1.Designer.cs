
namespace Program1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PoiskKorneyButton = new System.Windows.Forms.Button();
            this.KorniVivod = new System.Windows.Forms.TextBox();
            this.ProverkaKorneyButton = new System.Windows.Forms.Button();
            this.textBoxX5 = new System.Windows.Forms.TextBox();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelX5 = new System.Windows.Forms.Label();
            this.labelX4 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelEnd0 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxIntervalY2 = new System.Windows.Forms.TextBox();
            this.textBoxIntervalY1 = new System.Windows.Forms.TextBox();
            this.textBoxIntervalX1 = new System.Windows.Forms.TextBox();
            this.textBoxIntervalX2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnalitMetod = new System.Windows.Forms.RadioButton();
            this.ChislenMetod = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите степень уравнения :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(173, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PoiskKorneyButton
            // 
            this.PoiskKorneyButton.Location = new System.Drawing.Point(429, 115);
            this.PoiskKorneyButton.Name = "PoiskKorneyButton";
            this.PoiskKorneyButton.Size = new System.Drawing.Size(242, 23);
            this.PoiskKorneyButton.TabIndex = 2;
            this.PoiskKorneyButton.Text = "Найти корни";
            this.PoiskKorneyButton.UseVisualStyleBackColor = true;
            this.PoiskKorneyButton.Click += new System.EventHandler(this.PoiskKorneyButton_Click);
            // 
            // KorniVivod
            // 
            this.KorniVivod.Location = new System.Drawing.Point(429, 144);
            this.KorniVivod.Multiline = true;
            this.KorniVivod.Name = "KorniVivod";
            this.KorniVivod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KorniVivod.Size = new System.Drawing.Size(242, 225);
            this.KorniVivod.TabIndex = 3;
            // 
            // ProverkaKorneyButton
            // 
            this.ProverkaKorneyButton.Location = new System.Drawing.Point(429, 375);
            this.ProverkaKorneyButton.Name = "ProverkaKorneyButton";
            this.ProverkaKorneyButton.Size = new System.Drawing.Size(242, 23);
            this.ProverkaKorneyButton.TabIndex = 4;
            this.ProverkaKorneyButton.Text = "Проверка";
            this.ProverkaKorneyButton.UseVisualStyleBackColor = true;
            this.ProverkaKorneyButton.Click += new System.EventHandler(this.ProverkaKorneyButton_Click);
            // 
            // textBoxX5
            // 
            this.textBoxX5.Location = new System.Drawing.Point(16, 40);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.Size = new System.Drawing.Size(21, 20);
            this.textBoxX5.TabIndex = 7;
            // 
            // textBoxX4
            // 
            this.textBoxX4.Location = new System.Drawing.Point(74, 40);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(21, 20);
            this.textBoxX4.TabIndex = 8;
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(132, 40);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(21, 20);
            this.textBoxX3.TabIndex = 9;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(189, 40);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(21, 20);
            this.textBoxX2.TabIndex = 10;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(246, 40);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(21, 20);
            this.textBoxX1.TabIndex = 11;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(43, 43);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(25, 13);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "x⁵ +";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(101, 43);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(25, 13);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "x⁴ +";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(159, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(24, 13);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "x³ +";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(216, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(24, 13);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "x² +";
            // 
            // labelEnd0
            // 
            this.labelEnd0.AutoSize = true;
            this.labelEnd0.Location = new System.Drawing.Point(327, 43);
            this.labelEnd0.Name = "labelEnd0";
            this.labelEnd0.Size = new System.Drawing.Size(22, 13);
            this.labelEnd0.TabIndex = 16;
            this.labelEnd0.Text = "= 0";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(273, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(21, 13);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "x +";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(300, 40);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(21, 20);
            this.textBoxX0.TabIndex = 22;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(46, 66);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Black;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(377, 303);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // textBoxIntervalY2
            // 
            this.textBoxIntervalY2.Location = new System.Drawing.Point(16, 66);
            this.textBoxIntervalY2.Name = "textBoxIntervalY2";
            this.textBoxIntervalY2.Size = new System.Drawing.Size(21, 20);
            this.textBoxIntervalY2.TabIndex = 25;
            this.textBoxIntervalY2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.YMax);
            // 
            // textBoxIntervalY1
            // 
            this.textBoxIntervalY1.Location = new System.Drawing.Point(19, 349);
            this.textBoxIntervalY1.Name = "textBoxIntervalY1";
            this.textBoxIntervalY1.Size = new System.Drawing.Size(21, 20);
            this.textBoxIntervalY1.TabIndex = 26;
            this.textBoxIntervalY1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.YMin);
            // 
            // textBoxIntervalX1
            // 
            this.textBoxIntervalX1.Location = new System.Drawing.Point(46, 375);
            this.textBoxIntervalX1.Name = "textBoxIntervalX1";
            this.textBoxIntervalX1.Size = new System.Drawing.Size(21, 20);
            this.textBoxIntervalX1.TabIndex = 27;
            this.textBoxIntervalX1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.XMin);
            // 
            // textBoxIntervalX2
            // 
            this.textBoxIntervalX2.Location = new System.Drawing.Point(402, 375);
            this.textBoxIntervalX2.Name = "textBoxIntervalX2";
            this.textBoxIntervalX2.Size = new System.Drawing.Size(21, 20);
            this.textBoxIntervalX2.TabIndex = 28;
            this.textBoxIntervalX2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.XMax);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChislenMetod);
            this.groupBox1.Controls.Add(this.AnalitMetod);
            this.groupBox1.Location = new System.Drawing.Point(429, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 69);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод решения";
            // 
            // AnalitMetod
            // 
            this.AnalitMetod.AutoSize = true;
            this.AnalitMetod.Location = new System.Drawing.Point(6, 19);
            this.AnalitMetod.Name = "AnalitMetod";
            this.AnalitMetod.Size = new System.Drawing.Size(183, 17);
            this.AnalitMetod.TabIndex = 0;
            this.AnalitMetod.TabStop = true;
            this.AnalitMetod.Text = "Аналитический метод решения";
            this.AnalitMetod.UseVisualStyleBackColor = true;
            this.AnalitMetod.CheckedChanged += new System.EventHandler(this.AnalitMetod_CheckedChanged);
            // 
            // ChislenMetod
            // 
            this.ChislenMetod.AutoSize = true;
            this.ChislenMetod.Location = new System.Drawing.Point(6, 42);
            this.ChislenMetod.Name = "ChislenMetod";
            this.ChislenMetod.Size = new System.Drawing.Size(164, 17);
            this.ChislenMetod.TabIndex = 1;
            this.ChislenMetod.TabStop = true;
            this.ChislenMetod.Text = "Численный метод решения";
            this.ChislenMetod.UseVisualStyleBackColor = true;
            this.ChislenMetod.CheckedChanged += new System.EventHandler(this.ChislenMetod_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxIntervalX2);
            this.Controls.Add(this.textBoxIntervalX1);
            this.Controls.Add(this.textBoxIntervalY1);
            this.Controls.Add(this.textBoxIntervalY2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelEnd0);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxX5);
            this.Controls.Add(this.ProverkaKorneyButton);
            this.Controls.Add(this.KorniVivod);
            this.Controls.Add(this.PoiskKorneyButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Решение уравнений";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button PoiskKorneyButton;
        private System.Windows.Forms.TextBox KorniVivod;
        private System.Windows.Forms.Button ProverkaKorneyButton;
        private System.Windows.Forms.TextBox textBoxX5;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelX5;
        private System.Windows.Forms.Label labelX4;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelEnd0;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxIntervalY2;
        private System.Windows.Forms.TextBox textBoxIntervalY1;
        private System.Windows.Forms.TextBox textBoxIntervalX1;
        private System.Windows.Forms.TextBox textBoxIntervalX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ChislenMetod;
        private System.Windows.Forms.RadioButton AnalitMetod;
    }
}

