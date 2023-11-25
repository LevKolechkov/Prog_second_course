namespace Метод_покоординатного_спуска
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelOfFunction = new System.Windows.Forms.Label();
      this.textBoxFunction = new System.Windows.Forms.TextBox();
      this.textBoxIntervalA = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxIntervalB = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxAccuracy = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBoxMin = new System.Windows.Forms.TextBox();
      this.textBoxMax = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      // 
      // labelOfFunction
      // 
      this.labelOfFunction.AutoSize = true;
      this.labelOfFunction.Location = new System.Drawing.Point(35, 35);
      this.labelOfFunction.Name = "labelOfFunction";
      this.labelOfFunction.Size = new System.Drawing.Size(168, 13);
      this.labelOfFunction.TabIndex = 1;
      this.labelOfFunction.Text = "Функция (с переменными x и y)";
      // 
      // textBoxFunction
      // 
      this.textBoxFunction.Location = new System.Drawing.Point(38, 51);
      this.textBoxFunction.Name = "textBoxFunction";
      this.textBoxFunction.Size = new System.Drawing.Size(153, 20);
      this.textBoxFunction.TabIndex = 2;
      this.textBoxFunction.Text = "3*x^2+2*y-4";
      // 
      // textBoxIntervalA
      // 
      this.textBoxIntervalA.Location = new System.Drawing.Point(38, 125);
      this.textBoxIntervalA.Name = "textBoxIntervalA";
      this.textBoxIntervalA.Size = new System.Drawing.Size(153, 20);
      this.textBoxIntervalA.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(35, 109);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Интервал А";
      // 
      // textBoxIntervalB
      // 
      this.textBoxIntervalB.Location = new System.Drawing.Point(38, 203);
      this.textBoxIntervalB.Name = "textBoxIntervalB";
      this.textBoxIntervalB.Size = new System.Drawing.Size(153, 20);
      this.textBoxIntervalB.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(35, 187);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Интервал Б";
      // 
      // textBoxAccuracy
      // 
      this.textBoxAccuracy.Location = new System.Drawing.Point(38, 280);
      this.textBoxAccuracy.Name = "textBoxAccuracy";
      this.textBoxAccuracy.Size = new System.Drawing.Size(153, 20);
      this.textBoxAccuracy.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(35, 264);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Точность";
      // 
      // chart
      // 
      chartArea2.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea2);
      this.chart.Location = new System.Drawing.Point(306, 35);
      this.chart.Name = "chart";
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.Name = "Series1";
      this.chart.Series.Add(series2);
      this.chart.Size = new System.Drawing.Size(397, 300);
      this.chart.TabIndex = 9;
      this.chart.Text = "chart1";
      // 
      // textBoxMin
      // 
      this.textBoxMin.Location = new System.Drawing.Point(306, 400);
      this.textBoxMin.Name = "textBoxMin";
      this.textBoxMin.Size = new System.Drawing.Size(185, 20);
      this.textBoxMin.TabIndex = 10;
      // 
      // textBoxMax
      // 
      this.textBoxMax.Location = new System.Drawing.Point(518, 400);
      this.textBoxMax.Name = "textBoxMax";
      this.textBoxMax.Size = new System.Drawing.Size(185, 20);
      this.textBoxMax.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(306, 381);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(120, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "F(x) в точке минимума";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(515, 381);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(126, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "F(x) в точке максимума";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxMax);
      this.Controls.Add(this.textBoxMin);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.textBoxAccuracy);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxIntervalB);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxIntervalA);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxFunction);
      this.Controls.Add(this.labelOfFunction);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.Label labelOfFunction;
    private System.Windows.Forms.TextBox textBoxFunction;
    private System.Windows.Forms.TextBox textBoxIntervalA;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxIntervalB;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxAccuracy;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.TextBox textBoxMin;
    private System.Windows.Forms.TextBox textBoxMax;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}

