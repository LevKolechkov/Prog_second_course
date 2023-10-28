namespace Метод_Ньютона
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxIntervalA = new System.Windows.Forms.TextBox();
      this.textBoxIntervalB = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxAccuracy = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.chartOfNewton = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBoxFunction = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartOfNewton)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 46);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(129, 32);
      this.label1.TabIndex = 1;
      this.label1.Text = "Введите функцию \r\n\r\n";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(36, 192);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Интервал А";
      // 
      // textBoxIntervalA
      // 
      this.textBoxIntervalA.Location = new System.Drawing.Point(40, 225);
      this.textBoxIntervalA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBoxIntervalA.Name = "textBoxIntervalA";
      this.textBoxIntervalA.Size = new System.Drawing.Size(195, 22);
      this.textBoxIntervalA.TabIndex = 3;
      // 
      // textBoxIntervalB
      // 
      this.textBoxIntervalB.Location = new System.Drawing.Point(40, 311);
      this.textBoxIntervalB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBoxIntervalB.Name = "textBoxIntervalB";
      this.textBoxIntervalB.Size = new System.Drawing.Size(195, 22);
      this.textBoxIntervalB.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(36, 278);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(84, 16);
      this.label3.TabIndex = 4;
      this.label3.Text = "Интервал Б";
      // 
      // textBoxAccuracy
      // 
      this.textBoxAccuracy.Location = new System.Drawing.Point(40, 405);
      this.textBoxAccuracy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBoxAccuracy.Name = "textBoxAccuracy";
      this.textBoxAccuracy.Size = new System.Drawing.Size(195, 22);
      this.textBoxAccuracy.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 371);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(69, 16);
      this.label4.TabIndex = 6;
      this.label4.Text = "Точность";
      // 
      // chartOfNewton
      // 
      chartArea2.Name = "ChartArea1";
      this.chartOfNewton.ChartAreas.Add(chartArea2);
      this.chartOfNewton.Location = new System.Drawing.Point(411, 46);
      this.chartOfNewton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.chartOfNewton.Name = "chartOfNewton";
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.Name = "Series1";
      this.chartOfNewton.Series.Add(series2);
      this.chartOfNewton.Size = new System.Drawing.Size(528, 393);
      this.chartOfNewton.TabIndex = 8;
      this.chartOfNewton.Text = "chart1";
      // 
      // textBoxFunction
      // 
      this.textBoxFunction.Location = new System.Drawing.Point(40, 91);
      this.textBoxFunction.Multiline = true;
      this.textBoxFunction.Name = "textBoxFunction";
      this.textBoxFunction.Size = new System.Drawing.Size(195, 87);
      this.textBoxFunction.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.textBoxFunction);
      this.Controls.Add(this.chartOfNewton);
      this.Controls.Add(this.textBoxAccuracy);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxIntervalB);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxIntervalA);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartOfNewton)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxIntervalA;
    private System.Windows.Forms.TextBox textBoxIntervalB;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxAccuracy;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartOfNewton;
    private System.Windows.Forms.TextBox textBoxFunction;
  }
}

