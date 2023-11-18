namespace Олимпиадные_сортировки
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
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.dataGridViewOfArray = new System.Windows.Forms.DataGridView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonChooseFile = new System.Windows.Forms.Button();
      this.buttonLoadExcel = new System.Windows.Forms.Button();
      this.textBoxWayToFile = new System.Windows.Forms.TextBox();
      this.textBoxNameOfSheet = new System.Windows.Forms.TextBox();
      this.checkBoxBubble = new System.Windows.Forms.CheckBox();
      this.checkBoxInsert = new System.Windows.Forms.CheckBox();
      this.checkBoxShaker = new System.Windows.Forms.CheckBox();
      this.checkBoxFast = new System.Windows.Forms.CheckBox();
      this.checkBoxBOGO = new System.Windows.Forms.CheckBox();
      this.sortedArrayTextBox = new System.Windows.Forms.TextBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBoxIterations = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfArray)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewOfArray
      // 
      this.dataGridViewOfArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOfArray.Location = new System.Drawing.Point(16, 47);
      this.dataGridViewOfArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridViewOfArray.Name = "dataGridViewOfArray";
      this.dataGridViewOfArray.ReadOnly = true;
      this.dataGridViewOfArray.RowHeadersWidth = 51;
      this.dataGridViewOfArray.Size = new System.Drawing.Size(187, 622);
      this.dataGridViewOfArray.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
      this.menuStrip1.TabIndex = 1;
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
      // buttonChooseFile
      // 
      this.buttonChooseFile.Location = new System.Drawing.Point(211, 47);
      this.buttonChooseFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonChooseFile.Name = "buttonChooseFile";
      this.buttonChooseFile.Size = new System.Drawing.Size(160, 59);
      this.buttonChooseFile.TabIndex = 2;
      this.buttonChooseFile.Text = "Выбрать файл";
      this.buttonChooseFile.UseVisualStyleBackColor = true;
      this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
      // 
      // buttonLoadExcel
      // 
      this.buttonLoadExcel.Location = new System.Drawing.Point(211, 108);
      this.buttonLoadExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonLoadExcel.Name = "buttonLoadExcel";
      this.buttonLoadExcel.Size = new System.Drawing.Size(160, 55);
      this.buttonLoadExcel.TabIndex = 3;
      this.buttonLoadExcel.Text = "Загрузить данные Excel";
      this.buttonLoadExcel.UseVisualStyleBackColor = true;
      this.buttonLoadExcel.Click += new System.EventHandler(this.buttonLoadExcel_Click);
      // 
      // textBoxWayToFile
      // 
      this.textBoxWayToFile.Location = new System.Drawing.Point(379, 65);
      this.textBoxWayToFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBoxWayToFile.Name = "textBoxWayToFile";
      this.textBoxWayToFile.Size = new System.Drawing.Size(681, 22);
      this.textBoxWayToFile.TabIndex = 4;
      // 
      // textBoxNameOfSheet
      // 
      this.textBoxNameOfSheet.Location = new System.Drawing.Point(379, 124);
      this.textBoxNameOfSheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBoxNameOfSheet.Name = "textBoxNameOfSheet";
      this.textBoxNameOfSheet.Size = new System.Drawing.Size(681, 22);
      this.textBoxNameOfSheet.TabIndex = 5;
      // 
      // checkBoxBubble
      // 
      this.checkBoxBubble.AutoSize = true;
      this.checkBoxBubble.Location = new System.Drawing.Point(264, 181);
      this.checkBoxBubble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxBubble.Name = "checkBoxBubble";
      this.checkBoxBubble.Size = new System.Drawing.Size(94, 20);
      this.checkBoxBubble.TabIndex = 7;
      this.checkBoxBubble.Text = "Пузырька";
      this.checkBoxBubble.UseVisualStyleBackColor = true;
      // 
      // checkBoxInsert
      // 
      this.checkBoxInsert.AutoSize = true;
      this.checkBoxInsert.Location = new System.Drawing.Point(427, 181);
      this.checkBoxInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxInsert.Name = "checkBoxInsert";
      this.checkBoxInsert.Size = new System.Drawing.Size(100, 20);
      this.checkBoxInsert.TabIndex = 8;
      this.checkBoxInsert.Text = "Вставками";
      this.checkBoxInsert.UseVisualStyleBackColor = true;
      // 
      // checkBoxShaker
      // 
      this.checkBoxShaker.AutoSize = true;
      this.checkBoxShaker.Location = new System.Drawing.Point(607, 181);
      this.checkBoxShaker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxShaker.Name = "checkBoxShaker";
      this.checkBoxShaker.Size = new System.Drawing.Size(79, 20);
      this.checkBoxShaker.TabIndex = 9;
      this.checkBoxShaker.Text = "Шейкер";
      this.checkBoxShaker.UseVisualStyleBackColor = true;
      // 
      // checkBoxFast
      // 
      this.checkBoxFast.AutoSize = true;
      this.checkBoxFast.Location = new System.Drawing.Point(763, 181);
      this.checkBoxFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxFast.Name = "checkBoxFast";
      this.checkBoxFast.Size = new System.Drawing.Size(84, 20);
      this.checkBoxFast.TabIndex = 10;
      this.checkBoxFast.Text = "Быстрая";
      this.checkBoxFast.UseVisualStyleBackColor = true;
      // 
      // checkBoxBOGO
      // 
      this.checkBoxBOGO.AutoSize = true;
      this.checkBoxBOGO.Location = new System.Drawing.Point(920, 181);
      this.checkBoxBOGO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxBOGO.Name = "checkBoxBOGO";
      this.checkBoxBOGO.Size = new System.Drawing.Size(68, 20);
      this.checkBoxBOGO.TabIndex = 11;
      this.checkBoxBOGO.Text = "BOGO";
      this.checkBoxBOGO.UseVisualStyleBackColor = true;
      // 
      // sortedArrayTextBox
      // 
      this.sortedArrayTextBox.Location = new System.Drawing.Point(231, 223);
      this.sortedArrayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.sortedArrayTextBox.Multiline = true;
      this.sortedArrayTextBox.Name = "sortedArrayTextBox";
      this.sortedArrayTextBox.ReadOnly = true;
      this.sortedArrayTextBox.Size = new System.Drawing.Size(829, 48);
      this.sortedArrayTextBox.TabIndex = 12;
      this.sortedArrayTextBox.Visible = false;
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(231, 325);
      this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Пузырьком";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Вставками";
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Быстрая";
      series4.ChartArea = "ChartArea1";
      series4.Legend = "Legend1";
      series4.Name = "Шейкер";
      series5.ChartArea = "ChartArea1";
      series5.Legend = "Legend1";
      series5.Name = "BOGO";
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Series.Add(series3);
      this.chart1.Series.Add(series4);
      this.chart1.Series.Add(series5);
      this.chart1.Size = new System.Drawing.Size(831, 343);
      this.chart1.TabIndex = 13;
      this.chart1.Text = "chart1";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(264, 312);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(94, 22);
      this.textBox1.TabIndex = 14;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(427, 312);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(94, 22);
      this.textBox2.TabIndex = 15;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(592, 312);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(94, 22);
      this.textBox3.TabIndex = 16;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(753, 312);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(94, 22);
      this.textBox4.TabIndex = 17;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(920, 312);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(94, 22);
      this.textBox5.TabIndex = 18;
      // 
      // textBoxIterations
      // 
      this.textBoxIterations.Location = new System.Drawing.Point(520, 284);
      this.textBoxIterations.Name = "textBoxIterations";
      this.textBoxIterations.Size = new System.Drawing.Size(249, 22);
      this.textBoxIterations.TabIndex = 19;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1077, 683);
      this.Controls.Add(this.textBoxIterations);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.sortedArrayTextBox);
      this.Controls.Add(this.checkBoxBOGO);
      this.Controls.Add(this.checkBoxFast);
      this.Controls.Add(this.checkBoxShaker);
      this.Controls.Add(this.checkBoxInsert);
      this.Controls.Add(this.checkBoxBubble);
      this.Controls.Add(this.textBoxNameOfSheet);
      this.Controls.Add(this.textBoxWayToFile);
      this.Controls.Add(this.buttonLoadExcel);
      this.Controls.Add(this.buttonChooseFile);
      this.Controls.Add(this.dataGridViewOfArray);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
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
    private System.Windows.Forms.TextBox textBoxWayToFile;
    private System.Windows.Forms.TextBox textBoxNameOfSheet;
    private System.Windows.Forms.CheckBox checkBoxBubble;
    private System.Windows.Forms.CheckBox checkBoxInsert;
    private System.Windows.Forms.CheckBox checkBoxShaker;
    private System.Windows.Forms.CheckBox checkBoxFast;
    private System.Windows.Forms.CheckBox checkBoxBOGO;
    private System.Windows.Forms.TextBox sortedArrayTextBox;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBoxIterations;
  }
}

