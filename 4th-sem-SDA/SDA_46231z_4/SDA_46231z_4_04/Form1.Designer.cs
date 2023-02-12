namespace SDA_46231z_4_04
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
			this.btnRemove = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnAddAfter = new System.Windows.Forms.Button();
			this.btnAddLast = new System.Windows.Forms.Button();
			this.btnAddFirst = new System.Windows.Forms.Button();
			this.textCurrent = new System.Windows.Forms.TextBox();
			this.textValue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(280, 209);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 38;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(23, 291);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(332, 252);
			this.richTextBox1.TabIndex = 37;
			this.richTextBox1.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(280, 159);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(75, 23);
			this.btnFind.TabIndex = 36;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnAddAfter
			// 
			this.btnAddAfter.Location = new System.Drawing.Point(280, 115);
			this.btnAddAfter.Name = "btnAddAfter";
			this.btnAddAfter.Size = new System.Drawing.Size(75, 23);
			this.btnAddAfter.TabIndex = 35;
			this.btnAddAfter.Text = "AddAfter";
			this.btnAddAfter.UseVisualStyleBackColor = true;
			this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
			// 
			// btnAddLast
			// 
			this.btnAddLast.Location = new System.Drawing.Point(280, 74);
			this.btnAddLast.Name = "btnAddLast";
			this.btnAddLast.Size = new System.Drawing.Size(75, 23);
			this.btnAddLast.TabIndex = 34;
			this.btnAddLast.Text = "AddLast";
			this.btnAddLast.UseVisualStyleBackColor = true;
			this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
			// 
			// btnAddFirst
			// 
			this.btnAddFirst.Location = new System.Drawing.Point(280, 34);
			this.btnAddFirst.Name = "btnAddFirst";
			this.btnAddFirst.Size = new System.Drawing.Size(75, 23);
			this.btnAddFirst.TabIndex = 33;
			this.btnAddFirst.Text = "AddFirst";
			this.btnAddFirst.UseVisualStyleBackColor = true;
			this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
			// 
			// textCurrent
			// 
			this.textCurrent.Location = new System.Drawing.Point(24, 160);
			this.textCurrent.Name = "textCurrent";
			this.textCurrent.Size = new System.Drawing.Size(158, 22);
			this.textCurrent.TabIndex = 32;
			// 
			// textValue
			// 
			this.textValue.Location = new System.Drawing.Point(23, 52);
			this.textValue.Name = "textValue";
			this.textValue.Size = new System.Drawing.Size(159, 22);
			this.textValue.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 17);
			this.label2.TabIndex = 30;
			this.label2.Text = "Текущ възел:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 29;
			this.label1.Text = "Стойност:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 573);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnAddAfter);
			this.Controls.Add(this.btnAddLast);
			this.Controls.Add(this.btnAddFirst);
			this.Controls.Add(this.textCurrent);
			this.Controls.Add(this.textValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnAddAfter;
		private System.Windows.Forms.Button btnAddLast;
		private System.Windows.Forms.Button btnAddFirst;
		private System.Windows.Forms.TextBox textCurrent;
		private System.Windows.Forms.TextBox textValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

