namespace SDA_46231z_7_02
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
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnItem = new System.Windows.Forms.Button();
			this.btnShowDictionary = new System.Windows.Forms.Button();
			this.btnCount = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbBulStat = new System.Windows.Forms.TextBox();
			this.tbCompanyName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(74, 148);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(655, 282);
			this.richTextBox1.TabIndex = 32;
			this.richTextBox1.Text = "";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(654, 64);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 31;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(563, 64);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 30;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnItem
			// 
			this.btnItem.Location = new System.Drawing.Point(473, 64);
			this.btnItem.Name = "btnItem";
			this.btnItem.Size = new System.Drawing.Size(75, 23);
			this.btnItem.TabIndex = 29;
			this.btnItem.Text = "Item";
			this.btnItem.UseVisualStyleBackColor = true;
			this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
			// 
			// btnShowDictionary
			// 
			this.btnShowDictionary.Location = new System.Drawing.Point(654, 21);
			this.btnShowDictionary.Name = "btnShowDictionary";
			this.btnShowDictionary.Size = new System.Drawing.Size(75, 23);
			this.btnShowDictionary.TabIndex = 28;
			this.btnShowDictionary.Text = "Show";
			this.btnShowDictionary.UseVisualStyleBackColor = true;
			this.btnShowDictionary.Click += new System.EventHandler(this.btnShowDictionary_Click);
			// 
			// btnCount
			// 
			this.btnCount.Location = new System.Drawing.Point(563, 20);
			this.btnCount.Name = "btnCount";
			this.btnCount.Size = new System.Drawing.Size(75, 23);
			this.btnCount.TabIndex = 27;
			this.btnCount.Text = "Count";
			this.btnCount.UseVisualStyleBackColor = true;
			this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(473, 20);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 26;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbBulStat
			// 
			this.tbBulStat.Location = new System.Drawing.Point(179, 64);
			this.tbBulStat.Name = "tbBulStat";
			this.tbBulStat.Size = new System.Drawing.Size(256, 22);
			this.tbBulStat.TabIndex = 25;
			// 
			// tbCompanyName
			// 
			this.tbCompanyName.Location = new System.Drawing.Point(179, 21);
			this.tbCompanyName.Name = "tbCompanyName";
			this.tbCompanyName.Size = new System.Drawing.Size(256, 22);
			this.tbCompanyName.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 23;
			this.label2.Text = "Булстат";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 22;
			this.label1.Text = "Фирма";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnItem);
			this.Controls.Add(this.btnShowDictionary);
			this.Controls.Add(this.btnCount);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tbBulStat);
			this.Controls.Add(this.tbCompanyName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnItem;
		private System.Windows.Forms.Button btnShowDictionary;
		private System.Windows.Forms.Button btnCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbBulStat;
		private System.Windows.Forms.TextBox tbCompanyName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

