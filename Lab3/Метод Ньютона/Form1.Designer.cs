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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartOfNewton)).BeginInit();
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
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(150, 26);
      this.label1.TabIndex = 1;
      this.label1.Text = "Формула: \r\ny = (27 - 18x + 2x^2) * e^(-x/3)\r\n";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Интервал А";
      // 
      // textBoxIntervalA
      // 
      this.textBoxIntervalA.Location = new System.Drawing.Point(30, 117);
      this.textBoxIntervalA.Name = "textBoxIntervalA";
      this.textBoxIntervalA.Size = new System.Drawing.Size(147, 20);
      this.textBoxIntervalA.TabIndex = 3;
      // 
      // textBoxIntervalB
      // 
      this.textBoxIntervalB.Location = new System.Drawing.Point(30, 187);
      this.textBoxIntervalB.Name = "textBoxIntervalB";
      this.textBoxIntervalB.Size = new System.Drawing.Size(147, 20);
      this.textBoxIntervalB.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 160);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Интервал Б";
      // 
      // textBoxAccuracy
      // 
      this.textBoxAccuracy.Location = new System.Drawing.Point(30, 263);
      this.textBoxAccuracy.Name = "textBoxAccuracy";
      this.textBoxAccuracy.Size = new System.Drawing.Size(147, 20);
      this.textBoxAccuracy.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(27, 236);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Точность";
      // 
      // chartOfNewton
      // 
      chartArea1.Name = "ChartArea1";
      this.chartOfNewton.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chartOfNewton.Legends.Add(legend1);
      this.chartOfNewton.Location = new System.Drawing.Point(308, 37);
      this.chartOfNewton.Name = "chartOfNewton";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chartOfNewton.Series.Add(series1);
      this.chartOfNewton.Size = new System.Drawing.Size(396, 319);
      this.chartOfNewton.TabIndex = 8;
      this.chartOfNewton.Text = "chart1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
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
  }
}

