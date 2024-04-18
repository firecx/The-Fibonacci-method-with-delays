namespace The_Fibonacci_method_with_delays
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numbersCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.field = new System.Windows.Forms.RichTextBox();
            this.analysis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchMenu});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.сохранитьToolStripMenuItem.Text = "Меню";
            // 
            // switchMenu
            // 
            this.switchMenu.Name = "switchMenu";
            this.switchMenu.Size = new System.Drawing.Size(186, 26);
            this.switchMenu.Text = "Переключить";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(557, 152);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Числа";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(363, 247);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart";
            // 
            // numbersCount
            // 
            this.numbersCount.Location = new System.Drawing.Point(562, 68);
            this.numbersCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numbersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbersCount.Name = "numbersCount";
            this.numbersCount.Size = new System.Drawing.Size(358, 22);
            this.numbersCount.TabIndex = 2;
            this.numbersCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(557, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество генерируемых чисел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(557, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(557, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min:";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(619, 96);
            this.maxValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(301, 22);
            this.maxValue.TabIndex = 2;
            this.maxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(619, 124);
            this.minValue.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(301, 22);
            this.minValue.TabIndex = 2;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(730, 405);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(190, 36);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(0, 31);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(551, 410);
            this.field.TabIndex = 6;
            this.field.Text = "";
            // 
            // analysis
            // 
            this.analysis.Location = new System.Drawing.Point(562, 405);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(168, 36);
            this.analysis.TabIndex = 7;
            this.analysis.Text = "Анализ";
            this.analysis.UseVisualStyleBackColor = true;
            this.analysis.Click += new System.EventHandler(this.analysis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.analysis);
            this.Controls.Add(this.field);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.numbersCount);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown numbersCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxValue;
        private System.Windows.Forms.NumericUpDown minValue;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RichTextBox field;
        private System.Windows.Forms.ToolStripMenuItem switchMenu;
        private System.Windows.Forms.Button analysis;
    }
}

