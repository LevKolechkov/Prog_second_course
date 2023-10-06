namespace Дихотомия
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
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.расToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxIntervalA = new System.Windows.Forms.TextBox();
      this.lblIntervalA = new System.Windows.Forms.Label();
      this.lblIntervalB = new System.Windows.Forms.Label();
      this.textBoxIntervalB = new System.Windows.Forms.TextBox();
      this.textBoxAccuracy = new System.Windows.Forms.TextBox();
      this.lblAccuracy = new System.Windows.Forms.Label();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // расToolStripMenuItem
      // 
      this.расToolStripMenuItem.Name = "расToolStripMenuItem";
      this.расToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
      this.расToolStripMenuItem.Text = "Рассчитать";
      this.расToolStripMenuItem.Click += new System.EventHandler(this.расToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(150, 26);
      this.label1.TabIndex = 1;
      this.label1.Text = "Формула: \r\ny = (27 - 18x + 2x^2) * e^(-x/3)";
      // 
      // textBoxIntervalA
      // 
      this.textBoxIntervalA.Location = new System.Drawing.Point(35, 106);
      this.textBoxIntervalA.Name = "textBoxIntervalA";
      this.textBoxIntervalA.Size = new System.Drawing.Size(147, 20);
      this.textBoxIntervalA.TabIndex = 2;
      // 
      // lblIntervalA
      // 
      this.lblIntervalA.Location = new System.Drawing.Point(32, 85);
      this.lblIntervalA.Name = "lblIntervalA";
      this.lblIntervalA.Size = new System.Drawing.Size(71, 18);
      this.lblIntervalA.TabIndex = 0;
      this.lblIntervalA.Text = "Интервал A";
      // 
      // lblIntervalB
      // 
      this.lblIntervalB.Location = new System.Drawing.Point(35, 139);
      this.lblIntervalB.Name = "lblIntervalB";
      this.lblIntervalB.Size = new System.Drawing.Size(68, 14);
      this.lblIntervalB.TabIndex = 3;
      this.lblIntervalB.Text = "Интервал Б";
      // 
      // textBoxIntervalB
      // 
      this.textBoxIntervalB.Location = new System.Drawing.Point(35, 159);
      this.textBoxIntervalB.Name = "textBoxIntervalB";
      this.textBoxIntervalB.Size = new System.Drawing.Size(147, 20);
      this.textBoxIntervalB.TabIndex = 4;
      // 
      // textBoxAccuracy
      // 
      this.textBoxAccuracy.Location = new System.Drawing.Point(35, 213);
      this.textBoxAccuracy.Name = "textBoxAccuracy";
      this.textBoxAccuracy.Size = new System.Drawing.Size(147, 20);
      this.textBoxAccuracy.TabIndex = 6;
      // 
      // lblAccuracy
      // 
      this.lblAccuracy.Location = new System.Drawing.Point(35, 193);
      this.lblAccuracy.Name = "lblAccuracy";
      this.lblAccuracy.Size = new System.Drawing.Size(68, 14);
      this.lblAccuracy.TabIndex = 5;
      this.lblAccuracy.Text = "Точность";
      // 
      // chart
      // 
      chartArea2.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart.Legends.Add(legend2);
      this.chart.Location = new System.Drawing.Point(266, 37);
      this.chart.Name = "chart";
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.IsVisibleInLegend = false;
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart.Series.Add(series2);
      this.chart.Size = new System.Drawing.Size(442, 326);
      this.chart.TabIndex = 7;
      this.chart.Text = "chart";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.lblAccuracy);
      this.Controls.Add(this.textBoxAccuracy);
      this.Controls.Add(this.lblIntervalB);
      this.Controls.Add(this.textBoxIntervalB);
      this.Controls.Add(this.lblIntervalA);
      this.Controls.Add(this.textBoxIntervalA);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem расToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxIntervalA;
    private System.Windows.Forms.Label lblIntervalA;
    private System.Windows.Forms.Label lblIntervalB;
    private System.Windows.Forms.TextBox textBoxIntervalB;
    private System.Windows.Forms.TextBox textBoxAccuracy;
    private System.Windows.Forms.Label lblAccuracy;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
  }
}

