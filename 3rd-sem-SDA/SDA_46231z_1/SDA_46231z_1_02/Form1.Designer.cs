namespace SDA_46231z_1_02
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.labelfirstName = new System.Windows.Forms.Label();
			this.textBoxMiddleName = new System.Windows.Forms.TextBox();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonOK);
			this.groupBox1.Controls.Add(this.textBoxLastName);
			this.groupBox1.Controls.Add(this.labelfirstName);
			this.groupBox1.Controls.Add(this.textBoxMiddleName);
			this.groupBox1.Controls.Add(this.labelMiddleName);
			this.groupBox1.Controls.Add(this.textBoxFirstName);
			this.groupBox1.Controls.Add(this.labelLastName);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(477, 171);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Данни за служителя";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(375, 76);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(96, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(170, 111);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(176, 22);
			this.textBoxLastName.TabIndex = 7;
			// 
			// labelfirstName
			// 
			this.labelfirstName.AutoSize = true;
			this.labelfirstName.Location = new System.Drawing.Point(6, 33);
			this.labelfirstName.Name = "labelfirstName";
			this.labelfirstName.Size = new System.Drawing.Size(35, 17);
			this.labelfirstName.TabIndex = 2;
			this.labelfirstName.Text = "Име";
			// 
			// textBoxMiddleName
			// 
			this.textBoxMiddleName.Location = new System.Drawing.Point(170, 71);
			this.textBoxMiddleName.Name = "textBoxMiddleName";
			this.textBoxMiddleName.Size = new System.Drawing.Size(176, 22);
			this.textBoxMiddleName.TabIndex = 6;
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(6, 76);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(66, 17);
			this.labelMiddleName.TabIndex = 3;
			this.labelMiddleName.Text = "Презиме";
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(170, 28);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(176, 22);
			this.textBoxFirstName.TabIndex = 5;
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(6, 114);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(70, 17);
			this.labelLastName.TabIndex = 4;
			this.labelLastName.Text = "Фамилия";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 189);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(477, 96);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 301);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label labelfirstName;
		private System.Windows.Forms.TextBox textBoxMiddleName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

