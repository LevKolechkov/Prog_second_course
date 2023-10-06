namespace Дихотомия
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      menuStrip1 = new MenuStrip();
      расToolStripMenuItem = new ToolStripMenuItem();
      очиститьToolStripMenuItem = new ToolStripMenuItem();
      mainFormula = new Label();
      lblIntervalA = new Label();
      textBoxIntervalA = new TextBox();
      textBoxIntervalB = new TextBox();
      lblIntervalB = new Label();
      textBoxAccuracy = new TextBox();
      lblAccuracy = new Label();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { расToolStripMenuItem, очиститьToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(800, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // расToolStripMenuItem
      // 
      расToolStripMenuItem.Name = "расToolStripMenuItem";
      расToolStripMenuItem.Size = new Size(80, 20);
      расToolStripMenuItem.Text = "Рассчитать";
      расToolStripMenuItem.Click += расToolStripMenuItem_Click;
      // 
      // очиститьToolStripMenuItem
      // 
      очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      очиститьToolStripMenuItem.Size = new Size(71, 20);
      очиститьToolStripMenuItem.Text = "Очистить";
      // 
      // mainFormula
      // 
      mainFormula.AutoSize = true;
      mainFormula.Location = new Point(31, 41);
      mainFormula.Name = "mainFormula";
      mainFormula.Size = new Size(171, 30);
      mainFormula.TabIndex = 1;
      mainFormula.Text = "Формула: \r\ny = (27 - 18x + 2x^2) * e^(-x/3)";
      // 
      // lblIntervalA
      // 
      lblIntervalA.AutoSize = true;
      lblIntervalA.Location = new Point(31, 96);
      lblIntervalA.Name = "lblIntervalA";
      lblIntervalA.Size = new Size(71, 15);
      lblIntervalA.TabIndex = 2;
      lblIntervalA.Text = "Интервал А";
      // 
      // textBoxIntervalA
      // 
      textBoxIntervalA.Location = new Point(31, 114);
      textBoxIntervalA.Name = "textBoxIntervalA";
      textBoxIntervalA.Size = new Size(171, 23);
      textBoxIntervalA.TabIndex = 3;
      // 
      // textBoxIntervalB
      // 
      textBoxIntervalB.Location = new Point(31, 167);
      textBoxIntervalB.Name = "textBoxIntervalB";
      textBoxIntervalB.Size = new Size(171, 23);
      textBoxIntervalB.TabIndex = 5;
      // 
      // lblIntervalB
      // 
      lblIntervalB.AutoSize = true;
      lblIntervalB.Location = new Point(31, 149);
      lblIntervalB.Name = "lblIntervalB";
      lblIntervalB.Size = new Size(70, 15);
      lblIntervalB.TabIndex = 4;
      lblIntervalB.Text = "Интервал Б";
      // 
      // textBoxAccuracy
      // 
      textBoxAccuracy.Location = new Point(31, 222);
      textBoxAccuracy.Name = "textBoxAccuracy";
      textBoxAccuracy.Size = new Size(171, 23);
      textBoxAccuracy.TabIndex = 7;
      // 
      // lblAccuracy
      // 
      lblAccuracy.AutoSize = true;
      lblAccuracy.Location = new Point(31, 204);
      lblAccuracy.Name = "lblAccuracy";
      lblAccuracy.Size = new Size(58, 15);
      lblAccuracy.TabIndex = 6;
      lblAccuracy.Text = "Точность";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(textBoxAccuracy);
      Controls.Add(lblAccuracy);
      Controls.Add(textBoxIntervalB);
      Controls.Add(lblIntervalB);
      Controls.Add(textBoxIntervalA);
      Controls.Add(lblIntervalA);
      Controls.Add(mainFormula);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "Form1";
      Text = "Form1";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem расToolStripMenuItem;
    private ToolStripMenuItem очиститьToolStripMenuItem;
    private Label mainFormula;
    private Label lblIntervalA;
    private TextBox textBoxIntervalA;
    private TextBox textBoxIntervalB;
    private Label lblIntervalB;
    private TextBox textBoxAccuracy;
    private Label lblAccuracy;
  }
}