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
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.dataGridViewOfArray = new System.Windows.Forms.DataGridView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonChooseFile = new System.Windows.Forms.Button();
      this.buttonLoadExcel = new System.Windows.Forms.Button();
      this.textBoxWayToFile = new System.Windows.Forms.TextBox();
      this.textBoxNameOfSheet = new System.Windows.Forms.TextBox();
      this.chartOfSort = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.checkBoxBubble = new System.Windows.Forms.CheckBox();
      this.checkBoxInsert = new System.Windows.Forms.CheckBox();
      this.checkBoxShaker = new System.Windows.Forms.CheckBox();
      this.checkBoxFast = new System.Windows.Forms.CheckBox();
      this.checkBoxBOGO = new System.Windows.Forms.CheckBox();
      this.sortedArrayTextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfArray)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartOfSort)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewOfArray
      // 
      this.dataGridViewOfArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOfArray.Location = new System.Drawing.Point(12, 38);
      this.dataGridViewOfArray.Name = "dataGridViewOfArray";
      this.dataGridViewOfArray.ReadOnly = true;
      this.dataGridViewOfArray.Size = new System.Drawing.Size(140, 505);
      this.dataGridViewOfArray.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(808, 24);
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
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // buttonChooseFile
      // 
      this.buttonChooseFile.Location = new System.Drawing.Point(158, 38);
      this.buttonChooseFile.Name = "buttonChooseFile";
      this.buttonChooseFile.Size = new System.Drawing.Size(120, 48);
      this.buttonChooseFile.TabIndex = 2;
      this.buttonChooseFile.Text = "Выбрать файл";
      this.buttonChooseFile.UseVisualStyleBackColor = true;
      this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
      // 
      // buttonLoadExcel
      // 
      this.buttonLoadExcel.Location = new System.Drawing.Point(158, 88);
      this.buttonLoadExcel.Name = "buttonLoadExcel";
      this.buttonLoadExcel.Size = new System.Drawing.Size(120, 45);
      this.buttonLoadExcel.TabIndex = 3;
      this.buttonLoadExcel.Text = "Загрузить данные Excel";
      this.buttonLoadExcel.UseVisualStyleBackColor = true;
      this.buttonLoadExcel.Click += new System.EventHandler(this.buttonLoadExcel_Click);
      // 
      // textBoxWayToFile
      // 
      this.textBoxWayToFile.Location = new System.Drawing.Point(284, 53);
      this.textBoxWayToFile.Name = "textBoxWayToFile";
      this.textBoxWayToFile.Size = new System.Drawing.Size(512, 20);
      this.textBoxWayToFile.TabIndex = 4;
      // 
      // textBoxNameOfSheet
      // 
      this.textBoxNameOfSheet.Location = new System.Drawing.Point(284, 101);
      this.textBoxNameOfSheet.Name = "textBoxNameOfSheet";
      this.textBoxNameOfSheet.Size = new System.Drawing.Size(512, 20);
      this.textBoxNameOfSheet.TabIndex = 5;
      // 
      // chartOfSort
      // 
      chartArea1.Name = "ChartArea1";
      this.chartOfSort.ChartAreas.Add(chartArea1);
      this.chartOfSort.Location = new System.Drawing.Point(173, 251);
      this.chartOfSort.Name = "chartOfSort";
      series1.ChartArea = "ChartArea1";
      series1.Name = "Series1";
      this.chartOfSort.Series.Add(series1);
      this.chartOfSort.Size = new System.Drawing.Size(623, 281);
      this.chartOfSort.TabIndex = 6;
      this.chartOfSort.Text = "chart1";
      // 
      // checkBoxBubble
      // 
      this.checkBoxBubble.AutoSize = true;
      this.checkBoxBubble.Location = new System.Drawing.Point(198, 147);
      this.checkBoxBubble.Name = "checkBoxBubble";
      this.checkBoxBubble.Size = new System.Drawing.Size(77, 17);
      this.checkBoxBubble.TabIndex = 7;
      this.checkBoxBubble.Text = "Пузырька";
      this.checkBoxBubble.UseVisualStyleBackColor = true;
      // 
      // checkBoxInsert
      // 
      this.checkBoxInsert.AutoSize = true;
      this.checkBoxInsert.Location = new System.Drawing.Point(320, 147);
      this.checkBoxInsert.Name = "checkBoxInsert";
      this.checkBoxInsert.Size = new System.Drawing.Size(82, 17);
      this.checkBoxInsert.TabIndex = 8;
      this.checkBoxInsert.Text = "Вставками";
      this.checkBoxInsert.UseVisualStyleBackColor = true;
      // 
      // checkBoxShaker
      // 
      this.checkBoxShaker.AutoSize = true;
      this.checkBoxShaker.Location = new System.Drawing.Point(455, 147);
      this.checkBoxShaker.Name = "checkBoxShaker";
      this.checkBoxShaker.Size = new System.Drawing.Size(65, 17);
      this.checkBoxShaker.TabIndex = 9;
      this.checkBoxShaker.Text = "Шейкер";
      this.checkBoxShaker.UseVisualStyleBackColor = true;
      // 
      // checkBoxFast
      // 
      this.checkBoxFast.AutoSize = true;
      this.checkBoxFast.Location = new System.Drawing.Point(572, 147);
      this.checkBoxFast.Name = "checkBoxFast";
      this.checkBoxFast.Size = new System.Drawing.Size(70, 17);
      this.checkBoxFast.TabIndex = 10;
      this.checkBoxFast.Text = "Быстрая";
      this.checkBoxFast.UseVisualStyleBackColor = true;
      // 
      // checkBoxBOGO
      // 
      this.checkBoxBOGO.AutoSize = true;
      this.checkBoxBOGO.Location = new System.Drawing.Point(690, 147);
      this.checkBoxBOGO.Name = "checkBoxBOGO";
      this.checkBoxBOGO.Size = new System.Drawing.Size(57, 17);
      this.checkBoxBOGO.TabIndex = 11;
      this.checkBoxBOGO.Text = "BOGO";
      this.checkBoxBOGO.UseVisualStyleBackColor = true;
      // 
      // sortedArrayTextBox
      // 
      this.sortedArrayTextBox.Location = new System.Drawing.Point(173, 181);
      this.sortedArrayTextBox.Multiline = true;
      this.sortedArrayTextBox.Name = "sortedArrayTextBox";
      this.sortedArrayTextBox.ReadOnly = true;
      this.sortedArrayTextBox.Size = new System.Drawing.Size(623, 54);
      this.sortedArrayTextBox.TabIndex = 12;
      this.sortedArrayTextBox.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(808, 555);
      this.Controls.Add(this.sortedArrayTextBox);
      this.Controls.Add(this.checkBoxBOGO);
      this.Controls.Add(this.checkBoxFast);
      this.Controls.Add(this.checkBoxShaker);
      this.Controls.Add(this.checkBoxInsert);
      this.Controls.Add(this.checkBoxBubble);
      this.Controls.Add(this.chartOfSort);
      this.Controls.Add(this.textBoxNameOfSheet);
      this.Controls.Add(this.textBoxWayToFile);
      this.Controls.Add(this.buttonLoadExcel);
      this.Controls.Add(this.buttonChooseFile);
      this.Controls.Add(this.dataGridViewOfArray);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfArray)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartOfSort)).EndInit();
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
    private System.Windows.Forms.DataVisualization.Charting.Chart chartOfSort;
    private System.Windows.Forms.CheckBox checkBoxBubble;
    private System.Windows.Forms.CheckBox checkBoxInsert;
    private System.Windows.Forms.CheckBox checkBoxShaker;
    private System.Windows.Forms.CheckBox checkBoxFast;
    private System.Windows.Forms.CheckBox checkBoxBOGO;
    private System.Windows.Forms.TextBox sortedArrayTextBox;
  }
}

