namespace МНК
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
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.dataGridViewOfArray = new System.Windows.Forms.DataGridView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.точекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonChooseFile = new System.Windows.Forms.Button();
      this.buttonLoadExcel = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBoxWayToFile = new System.Windows.Forms.TextBox();
      this.textBoxNameOfSheet = new System.Windows.Forms.TextBox();
      this.linFuncLabel = new System.Windows.Forms.Label();
      this.doubleFuncLabel = new System.Windows.Forms.Label();
      this.linFuncTextBox = new System.Windows.Forms.TextBox();
      this.squareFuncTextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfArray)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewOfArray
      // 
      this.dataGridViewOfArray.AllowUserToAddRows = false;
      this.dataGridViewOfArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOfArray.Location = new System.Drawing.Point(12, 27);
      this.dataGridViewOfArray.Name = "dataGridViewOfArray";
      this.dataGridViewOfArray.Size = new System.Drawing.Size(193, 538);
      this.dataGridViewOfArray.TabIndex = 0;
      this.dataGridViewOfArray.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOfArray_CellContentClick);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(940, 24);
      this.menuStrip1.TabIndex = 1;
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
      // сгенерироватьToolStripMenuItem
      // 
      this.сгенерироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точекToolStripMenuItem});
      this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
      this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
      this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
      // 
      // точекToolStripMenuItem
      // 
      this.точекToolStripMenuItem.Name = "точекToolStripMenuItem";
      this.точекToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
      this.точекToolStripMenuItem.Text = "10 точек";
      // 
      // buttonChooseFile
      // 
      this.buttonChooseFile.Location = new System.Drawing.Point(211, 27);
      this.buttonChooseFile.Name = "buttonChooseFile";
      this.buttonChooseFile.Size = new System.Drawing.Size(138, 59);
      this.buttonChooseFile.TabIndex = 2;
      this.buttonChooseFile.Text = "Выбрать файл";
      this.buttonChooseFile.UseVisualStyleBackColor = true;
      this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
      // 
      // buttonLoadExcel
      // 
      this.buttonLoadExcel.Location = new System.Drawing.Point(211, 92);
      this.buttonLoadExcel.Name = "buttonLoadExcel";
      this.buttonLoadExcel.Size = new System.Drawing.Size(138, 59);
      this.buttonLoadExcel.TabIndex = 3;
      this.buttonLoadExcel.Text = "Загрузить данные Excel";
      this.buttonLoadExcel.UseVisualStyleBackColor = true;
      this.buttonLoadExcel.Click += new System.EventHandler(this.buttonLoadExcel_Click);
      // 
      // chart1
      // 
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      this.chart1.Location = new System.Drawing.Point(221, 236);
      this.chart1.Name = "chart1";
      series7.BorderWidth = 3;
      series7.ChartArea = "ChartArea1";
      series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series7.Name = "Точки";
      series7.YValuesPerPoint = 2;
      series8.BorderWidth = 3;
      series8.ChartArea = "ChartArea1";
      series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series8.Name = "Линейный график";
      series9.BorderWidth = 3;
      series9.ChartArea = "ChartArea1";
      series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series9.Name = "Нелинейный график";
      this.chart1.Series.Add(series7);
      this.chart1.Series.Add(series8);
      this.chart1.Series.Add(series9);
      this.chart1.Size = new System.Drawing.Size(707, 329);
      this.chart1.TabIndex = 4;
      this.chart1.Text = "chart1";
      // 
      // textBoxWayToFile
      // 
      this.textBoxWayToFile.Location = new System.Drawing.Point(356, 49);
      this.textBoxWayToFile.Name = "textBoxWayToFile";
      this.textBoxWayToFile.Size = new System.Drawing.Size(572, 20);
      this.textBoxWayToFile.TabIndex = 5;
      // 
      // textBoxNameOfSheet
      // 
      this.textBoxNameOfSheet.Location = new System.Drawing.Point(355, 103);
      this.textBoxNameOfSheet.Name = "textBoxNameOfSheet";
      this.textBoxNameOfSheet.Size = new System.Drawing.Size(572, 20);
      this.textBoxNameOfSheet.TabIndex = 6;
      this.textBoxNameOfSheet.Text = "Лист1";
      // 
      // linFuncLabel
      // 
      this.linFuncLabel.AutoSize = true;
      this.linFuncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.linFuncLabel.Location = new System.Drawing.Point(350, 154);
      this.linFuncLabel.Name = "linFuncLabel";
      this.linFuncLabel.Size = new System.Drawing.Size(106, 25);
      this.linFuncLabel.TabIndex = 7;
      this.linFuncLabel.Text = "y = ax + b";
      // 
      // doubleFuncLabel
      // 
      this.doubleFuncLabel.AutoSize = true;
      this.doubleFuncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.doubleFuncLabel.Location = new System.Drawing.Point(654, 154);
      this.doubleFuncLabel.Name = "doubleFuncLabel";
      this.doubleFuncLabel.Size = new System.Drawing.Size(174, 25);
      this.doubleFuncLabel.TabIndex = 8;
      this.doubleFuncLabel.Text = "y = ax^2 + bx + c";
      // 
      // linFuncTextBox
      // 
      this.linFuncTextBox.Location = new System.Drawing.Point(248, 194);
      this.linFuncTextBox.Name = "linFuncTextBox";
      this.linFuncTextBox.Size = new System.Drawing.Size(322, 20);
      this.linFuncTextBox.TabIndex = 9;
      this.linFuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // squareFuncTextBox
      // 
      this.squareFuncTextBox.Location = new System.Drawing.Point(595, 194);
      this.squareFuncTextBox.Name = "squareFuncTextBox";
      this.squareFuncTextBox.Size = new System.Drawing.Size(318, 20);
      this.squareFuncTextBox.TabIndex = 10;
      this.squareFuncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(940, 577);
      this.Controls.Add(this.squareFuncTextBox);
      this.Controls.Add(this.linFuncTextBox);
      this.Controls.Add(this.doubleFuncLabel);
      this.Controls.Add(this.linFuncLabel);
      this.Controls.Add(this.textBoxNameOfSheet);
      this.Controls.Add(this.textBoxWayToFile);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.buttonLoadExcel);
      this.Controls.Add(this.buttonChooseFile);
      this.Controls.Add(this.dataGridViewOfArray);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfArray)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewOfArray;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.Button buttonChooseFile;
    private System.Windows.Forms.Button buttonLoadExcel;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.TextBox textBoxWayToFile;
    private System.Windows.Forms.TextBox textBoxNameOfSheet;
    private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem точекToolStripMenuItem;
    private System.Windows.Forms.Label linFuncLabel;
    private System.Windows.Forms.Label doubleFuncLabel;
    private System.Windows.Forms.TextBox linFuncTextBox;
    private System.Windows.Forms.TextBox squareFuncTextBox;
  }
}

