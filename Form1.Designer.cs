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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.field = new System.Windows.Forms.RichTextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.SwitchButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(553, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(97, 24);
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SwitchButton
            // 
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(74, 24);
            this.SwitchButton.Text = "Анализ";
            this.SwitchButton.Click += new System.EventHandler(this.Switch_Click);
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
            this.numbersCount.Location = new System.Drawing.Point(371, 31);
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
            this.numbersCount.Size = new System.Drawing.Size(166, 22);
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
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество генерируемых чисел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Диапозон с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(319, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "по";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(371, 62);
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
            this.maxValue.Size = new System.Drawing.Size(166, 22);
            this.maxValue.TabIndex = 2;
            this.maxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(138, 62);
            this.minValue.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(166, 22);
            this.minValue.TabIndex = 2;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(12, 405);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(525, 45);
            this.start.TabIndex = 5;
            this.start.Text = "Сгенирировать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(12, 95);
            this.field.Name = "field";
            this.field.ReadOnly = true;
            this.field.Size = new System.Drawing.Size(525, 304);
            this.field.TabIndex = 6;
            this.field.Text = "";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(12, 95);
            this.chart.Name = "chart";
            this.chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(525, 304);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart";
            this.chart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 462);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.field);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.numbersCount);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(571, 509);
            this.MinimumSize = new System.Drawing.Size(571, 509);
            this.Name = "Form1";
            this.Text = "Рандомайзер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.NumericUpDown numbersCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxValue;
        private System.Windows.Forms.NumericUpDown minValue;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ToolStripMenuItem SwitchButton;
        private System.Windows.Forms.RichTextBox field;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

