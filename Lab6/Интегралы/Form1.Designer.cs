namespace Интегралы
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
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.textBoxFunction = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxIntervalA = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxIntervalB = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxAccuracy = new System.Windows.Forms.TextBox();
      this.chartOfIntegrals = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.квадратовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.трапецииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.симпсонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxRectangleValue = new System.Windows.Forms.TextBox();
      this.textBoxTrapezoidValue = new System.Windows.Forms.TextBox();
      this.textBoxSimpsonValue = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.chartOfIntegrals)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxFunction
      // 
      this.textBoxFunction.Location = new System.Drawing.Point(31, 70);
      this.textBoxFunction.Name = "textBoxFunction";
      this.textBoxFunction.Size = new System.Drawing.Size(166, 20);
      this.textBoxFunction.TabIndex = 0;
      this.textBoxFunction.Text = "1/(1+e^(-0.6*(x-10)))+0.2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 51);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Введите функцию";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(31, 126);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Интервал А\r\n";
      // 
      // textBoxIntervalA
      // 
      this.textBoxIntervalA.Location = new System.Drawing.Point(31, 142);
      this.textBoxIntervalA.Name = "textBoxIntervalA";
      this.textBoxIntervalA.Size = new System.Drawing.Size(166, 20);
      this.textBoxIntervalA.TabIndex = 2;
      this.textBoxIntervalA.Text = "5";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(31, 201);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Интервал Б";
      // 
      // textBoxIntervalB
      // 
      this.textBoxIntervalB.Location = new System.Drawing.Point(31, 217);
      this.textBoxIntervalB.Name = "textBoxIntervalB";
      this.textBoxIntervalB.Size = new System.Drawing.Size(166, 20);
      this.textBoxIntervalB.TabIndex = 4;
      this.textBoxIntervalB.Text = "15";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(31, 272);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Шаг разбиения";
      // 
      // textBoxAccuracy
      // 
      this.textBoxAccuracy.Location = new System.Drawing.Point(31, 288);
      this.textBoxAccuracy.Name = "textBoxAccuracy";
      this.textBoxAccuracy.Size = new System.Drawing.Size(166, 20);
      this.textBoxAccuracy.TabIndex = 6;
      this.textBoxAccuracy.Text = "1";
      // 
      // chartOfIntegrals
      // 
      chartArea1.Name = "ChartArea1";
      this.chartOfIntegrals.ChartAreas.Add(chartArea1);
      legend1.Enabled = false;
      legend1.Name = "Legend1";
      this.chartOfIntegrals.Legends.Add(legend1);
      this.chartOfIntegrals.Location = new System.Drawing.Point(303, 51);
      this.chartOfIntegrals.Name = "chartOfIntegrals";
      series1.BorderWidth = 3;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Legend = "Legend1";
      series1.Name = "SeriesFunc";
      series2.BorderColor = System.Drawing.Color.Black;
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.Color = System.Drawing.Color.DimGray;
      series2.LabelBackColor = System.Drawing.Color.Black;
      series2.LabelBorderColor = System.Drawing.Color.Black;
      series2.Legend = "Legend1";
      series2.Name = "SeriesRectangles";
      series3.BorderColor = System.Drawing.Color.Black;
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
      series3.Color = System.Drawing.Color.DarkGray;
      series3.Legend = "Legend1";
      series3.Name = "SeriesTrapeze";
      series4.ChartArea = "ChartArea1";
      series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
      series4.Color = System.Drawing.Color.Red;
      series4.Legend = "Legend1";
      series4.Name = "Series4";
      this.chartOfIntegrals.Series.Add(series1);
      this.chartOfIntegrals.Series.Add(series2);
      this.chartOfIntegrals.Series.Add(series3);
      this.chartOfIntegrals.Series.Add(series4);
      this.chartOfIntegrals.Size = new System.Drawing.Size(401, 301);
      this.chartOfIntegrals.TabIndex = 8;
      this.chartOfIntegrals.Text = "chart1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 9;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратовToolStripMenuItem,
            this.трапецииToolStripMenuItem,
            this.симпсонаToolStripMenuItem});
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      // 
      // квадратовToolStripMenuItem
      // 
      this.квадратовToolStripMenuItem.Name = "квадратовToolStripMenuItem";
      this.квадратовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.квадратовToolStripMenuItem.Text = "Прямоугольники";
      this.квадратовToolStripMenuItem.Click += new System.EventHandler(this.квадратовToolStripMenuItem_Click);
      // 
      // трапецииToolStripMenuItem
      // 
      this.трапецииToolStripMenuItem.Name = "трапецииToolStripMenuItem";
      this.трапецииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.трапецииToolStripMenuItem.Text = "Трапеции";
      this.трапецииToolStripMenuItem.Click += new System.EventHandler(this.трапецииToolStripMenuItem_Click);
      // 
      // симпсонаToolStripMenuItem
      // 
      this.симпсонаToolStripMenuItem.Name = "симпсонаToolStripMenuItem";
      this.симпсонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.симпсонаToolStripMenuItem.Text = "Симпсона";
      this.симпсонаToolStripMenuItem.Click += new System.EventHandler(this.симпсонаToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      // 
      // textBoxRectangleValue
      // 
      this.textBoxRectangleValue.Location = new System.Drawing.Point(34, 404);
      this.textBoxRectangleValue.Name = "textBoxRectangleValue";
      this.textBoxRectangleValue.Size = new System.Drawing.Size(163, 20);
      this.textBoxRectangleValue.TabIndex = 10;
      this.textBoxRectangleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBoxTrapezoidValue
      // 
      this.textBoxTrapezoidValue.Location = new System.Drawing.Point(290, 404);
      this.textBoxTrapezoidValue.Name = "textBoxTrapezoidValue";
      this.textBoxTrapezoidValue.Size = new System.Drawing.Size(163, 20);
      this.textBoxTrapezoidValue.TabIndex = 11;
      this.textBoxTrapezoidValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBoxSimpsonValue
      // 
      this.textBoxSimpsonValue.Location = new System.Drawing.Point(541, 404);
      this.textBoxSimpsonValue.Name = "textBoxSimpsonValue";
      this.textBoxSimpsonValue.Size = new System.Drawing.Size(163, 20);
      this.textBoxSimpsonValue.TabIndex = 12;
      this.textBoxSimpsonValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(34, 385);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "Прямоугольников";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(287, 385);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(56, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Трапеций";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(538, 385);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(58, 13);
      this.label7.TabIndex = 15;
      this.label7.Text = "Симпсона";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxSimpsonValue);
      this.Controls.Add(this.textBoxTrapezoidValue);
      this.Controls.Add(this.textBoxRectangleValue);
      this.Controls.Add(this.chartOfIntegrals);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxAccuracy);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxIntervalB);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxIntervalA);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxFunction);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.chartOfIntegrals)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxFunction;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxIntervalA;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxIntervalB;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxAccuracy;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartOfIntegrals;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem квадратовToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem трапецииToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem симпсонаToolStripMenuItem;
    private System.Windows.Forms.TextBox textBoxRectangleValue;
    private System.Windows.Forms.TextBox textBoxTrapezoidValue;
    private System.Windows.Forms.TextBox textBoxSimpsonValue;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

