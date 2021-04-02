namespace SDA_46231z_8_02
{
	partial class Form1
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.tbB = new System.Windows.Forms.TextBox();
			this.tbA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(25, 129);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(251, 290);
			this.richTextBox1.TabIndex = 11;
			this.richTextBox1.Text = "";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(201, 37);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 42);
			this.btnRun.TabIndex = 10;
			this.btnRun.Text = "Изпълни";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// tbB
			// 
			this.tbB.Location = new System.Drawing.Point(66, 79);
			this.tbB.Name = "tbB";
			this.tbB.Size = new System.Drawing.Size(100, 22);
			this.tbB.TabIndex = 9;
			// 
			// tbA
			// 
			this.tbA.Location = new System.Drawing.Point(66, 15);
			this.tbA.Name = "tbA";
			this.tbA.Size = new System.Drawing.Size(100, 22);
			this.tbA.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "A";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.tbB);
			this.Controls.Add(this.tbA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.TextBox tbB;
		private System.Windows.Forms.TextBox tbA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

