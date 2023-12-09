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
      this.dataGridViewOfArray = new System.Windows.Forms.DataGridView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonChooseFile = new System.Windows.Forms.Button();
      this.buttonLoadExcel = new System.Windows.Forms.Button();
      this.textBoxWayToFile = new System.Windows.Forms.TextBox();
      this.textBoxNameOfSheet = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfArray)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridViewOfArray
      // 
      this.dataGridViewOfArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOfArray.Location = new System.Drawing.Point(12, 38);
      this.dataGridViewOfArray.Name = "dataGridViewOfArray";
      this.dataGridViewOfArray.ReadOnly = true;
      this.dataGridViewOfArray.RowHeadersWidth = 51;
      this.dataGridViewOfArray.Size = new System.Drawing.Size(296, 505);
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
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
      this.menuStrip1.TabIndex = 1;
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
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // buttonChooseFile
      // 
      this.buttonChooseFile.Location = new System.Drawing.Point(334, 38);
      this.buttonChooseFile.Name = "buttonChooseFile";
      this.buttonChooseFile.Size = new System.Drawing.Size(120, 48);
      this.buttonChooseFile.TabIndex = 2;
      this.buttonChooseFile.Text = "Выбрать файл";
      this.buttonChooseFile.UseVisualStyleBackColor = true;
      this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
      // 
      // buttonLoadExcel
      // 
      this.buttonLoadExcel.Location = new System.Drawing.Point(334, 88);
      this.buttonLoadExcel.Name = "buttonLoadExcel";
      this.buttonLoadExcel.Size = new System.Drawing.Size(120, 45);
      this.buttonLoadExcel.TabIndex = 3;
      this.buttonLoadExcel.Text = "Загрузить данные Excel";
      this.buttonLoadExcel.UseVisualStyleBackColor = true;
      this.buttonLoadExcel.Click += new System.EventHandler(this.buttonLoadExcel_Click);
      // 
      // textBoxWayToFile
      // 
      this.textBoxWayToFile.Location = new System.Drawing.Point(460, 53);
      this.textBoxWayToFile.Name = "textBoxWayToFile";
      this.textBoxWayToFile.Size = new System.Drawing.Size(512, 20);
      this.textBoxWayToFile.TabIndex = 4;
      // 
      // textBoxNameOfSheet
      // 
      this.textBoxNameOfSheet.Location = new System.Drawing.Point(460, 101);
      this.textBoxNameOfSheet.Name = "textBoxNameOfSheet";
      this.textBoxNameOfSheet.Size = new System.Drawing.Size(512, 20);
      this.textBoxNameOfSheet.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(644, 157);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Или";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1021, 555);
      this.Controls.Add(this.label1);
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
    private System.Windows.Forms.Label label1;
  }
}

