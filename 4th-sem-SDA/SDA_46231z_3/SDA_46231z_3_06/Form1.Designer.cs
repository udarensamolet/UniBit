namespace SDA_46231z_3_06
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
			this.txtValue = new System.Windows.Forms.TextBox();
			this.txtPriority = new System.Windows.Forms.TextBox();
			this.btnEnqueue = new System.Windows.Forms.Button();
			this.btnDequeue = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(24, 34);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(100, 22);
			this.txtValue.TabIndex = 0;
			// 
			// txtPriority
			// 
			this.txtPriority.Location = new System.Drawing.Point(24, 92);
			this.txtPriority.Name = "txtPriority";
			this.txtPriority.Size = new System.Drawing.Size(100, 22);
			this.txtPriority.TabIndex = 1;
			// 
			// btnEnqueue
			// 
			this.btnEnqueue.Location = new System.Drawing.Point(187, 34);
			this.btnEnqueue.Name = "btnEnqueue";
			this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
			this.btnEnqueue.TabIndex = 2;
			this.btnEnqueue.Text = "Enqueue";
			this.btnEnqueue.UseVisualStyleBackColor = true;
			this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
			// 
			// btnDequeue
			// 
			this.btnDequeue.Location = new System.Drawing.Point(187, 91);
			this.btnDequeue.Name = "btnDequeue";
			this.btnDequeue.Size = new System.Drawing.Size(75, 23);
			this.btnDequeue.TabIndex = 3;
			this.btnDequeue.Text = "Dequeue";
			this.btnDequeue.UseVisualStyleBackColor = true;
			this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(24, 138);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(238, 176);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Процес";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Приоритет";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 336);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnDequeue);
			this.Controls.Add(this.btnEnqueue);
			this.Controls.Add(this.txtPriority);
			this.Controls.Add(this.txtValue);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.TextBox txtPriority;
		private System.Windows.Forms.Button btnEnqueue;
		private System.Windows.Forms.Button btnDequeue;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

