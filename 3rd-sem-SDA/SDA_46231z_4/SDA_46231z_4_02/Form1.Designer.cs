namespace SDA_46231z_4_02
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
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnInsertAfter = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.textAter = new System.Windows.Forms.TextBox();
			this.textValue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPrintRev = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(14, 280);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(332, 252);
			this.richTextBox1.TabIndex = 17;
			this.richTextBox1.Text = "";
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(271, 148);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 16;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(271, 104);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 15;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnInsertAfter
			// 
			this.btnInsertAfter.Location = new System.Drawing.Point(271, 63);
			this.btnInsertAfter.Name = "btnInsertAfter";
			this.btnInsertAfter.Size = new System.Drawing.Size(75, 23);
			this.btnInsertAfter.TabIndex = 14;
			this.btnInsertAfter.Text = "Insert/After";
			this.btnInsertAfter.UseVisualStyleBackColor = true;
			this.btnInsertAfter.Click += new System.EventHandler(this.btnInsertAfter_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(271, 23);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(75, 23);
			this.btnInsert.TabIndex = 13;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// textAter
			// 
			this.textAter.Location = new System.Drawing.Point(15, 149);
			this.textAter.Name = "textAter";
			this.textAter.Size = new System.Drawing.Size(158, 22);
			this.textAter.TabIndex = 12;
			// 
			// textValue
			// 
			this.textValue.Location = new System.Drawing.Point(14, 41);
			this.textValue.Name = "textValue";
			this.textValue.Size = new System.Drawing.Size(159, 22);
			this.textValue.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Добави след стойност:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Стойност:";
			// 
			// btnPrintRev
			// 
			this.btnPrintRev.Location = new System.Drawing.Point(271, 198);
			this.btnPrintRev.Name = "btnPrintRev";
			this.btnPrintRev.Size = new System.Drawing.Size(75, 23);
			this.btnPrintRev.TabIndex = 18;
			this.btnPrintRev.Text = "PrintRev";
			this.btnPrintRev.UseVisualStyleBackColor = true;
			this.btnPrintRev.Click += new System.EventHandler(this.btnPrintRev_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 544);
			this.Controls.Add(this.btnPrintRev);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnInsertAfter);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.textAter);
			this.Controls.Add(this.textValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnInsertAfter;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox textAter;
		private System.Windows.Forms.TextBox textValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPrintRev;
	}
}

