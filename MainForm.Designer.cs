namespace LPLS_2
{
 partial class MainForm
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
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
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.toolStrip1 = new System.Windows.Forms.ToolStrip();
   this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
   this.button1 = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
   this.toolStrip1.SuspendLayout();
   this.SuspendLayout();
   // 
   // toolStrip1
   // 
   this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
   this.toolStrip1.Location = new System.Drawing.Point(0, 75);
   this.toolStrip1.Name = "toolStrip1";
   this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
   this.toolStrip1.Size = new System.Drawing.Size(320, 25);
   this.toolStrip1.TabIndex = 6;
   this.toolStrip1.Text = "toolStrip1";
   // 
   // toolStripLabel1
   // 
   this.toolStripLabel1.Name = "toolStripLabel1";
   this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
   this.toolStripLabel1.Text = "Loaded. ";
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(235, 51);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(75, 23);
   this.button1.TabIndex = 5;
   this.button1.Text = "Start";
   this.button1.UseVisualStyleBackColor = true;
   this.button1.Click += new System.EventHandler(this.button1_Click);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 9);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(226, 13);
   this.label2.TabIndex = 9;
   this.label2.Text = "Insert local IP address to lag in the form below:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 48);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(194, 13);
   this.label1.TabIndex = 8;
   this.label1.Text = "This program is meant for LAN use only.";
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(12, 25);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(298, 20);
   this.textBox1.TabIndex = 7;
   // 
   // backgroundWorker1
   // 
   this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
   // 
   // MainForm
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(320, 100);
   this.Controls.Add(this.toolStrip1);
   this.Controls.Add(this.button1);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.textBox1);
   this.Name = "MainForm";
   this.Text = "Lag Switch";
   this.toolStrip1.ResumeLayout(false);
   this.toolStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.ToolStrip toolStrip1;
  private System.Windows.Forms.ToolStripLabel toolStripLabel1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox textBox1;
  private System.ComponentModel.BackgroundWorker backgroundWorker1;
 }
}

