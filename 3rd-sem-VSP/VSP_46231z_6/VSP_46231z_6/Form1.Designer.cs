namespace VSP_46231z_6
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonBold = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.richTextBoxText = new System.Windows.Forms.RichTextBox();
			this.buttonUnderline = new System.Windows.Forms.Button();
			this.buttonItalic = new System.Windows.Forms.Button();
			this.buttonCenter = new System.Windows.Forms.Button();
			this.labelSize = new System.Windows.Forms.Label();
			this.textBoxSize = new System.Windows.Forms.TextBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.buttonBold);
			this.panel1.Location = new System.Drawing.Point(39, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(709, 40);
			this.panel1.TabIndex = 0;
			// 
			// buttonBold
			// 
			this.buttonBold.Location = new System.Drawing.Point(8, 8);
			this.buttonBold.Name = "buttonBold";
			this.buttonBold.Size = new System.Drawing.Size(85, 23);
			this.buttonBold.TabIndex = 2;
			this.buttonBold.Text = "Bold";
			this.buttonBold.UseVisualStyleBackColor = true;
			this.buttonBold.Click += new System.EventHandler(this.ButtonBold_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.richTextBoxText);
			this.panel2.Location = new System.Drawing.Point(39, 58);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(709, 380);
			this.panel2.TabIndex = 1;
			// 
			// richTextBoxText
			// 
			this.richTextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxText.Location = new System.Drawing.Point(0, 0);
			this.richTextBoxText.Name = "richTextBoxText";
			this.richTextBoxText.Size = new System.Drawing.Size(709, 380);
			this.richTextBoxText.TabIndex = 0;
			this.richTextBoxText.Text = "";
			this.richTextBoxText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBox_LinkClicked);
			// 
			// buttonUnderline
			// 
			this.buttonUnderline.Location = new System.Drawing.Point(143, 20);
			this.buttonUnderline.Name = "buttonUnderline";
			this.buttonUnderline.Size = new System.Drawing.Size(85, 23);
			this.buttonUnderline.TabIndex = 2;
			this.buttonUnderline.Text = "Underline";
			this.buttonUnderline.UseVisualStyleBackColor = true;
			this.buttonUnderline.Click += new System.EventHandler(this.ButtonUnderline_Click);
			// 
			// buttonItalic
			// 
			this.buttonItalic.Location = new System.Drawing.Point(238, 20);
			this.buttonItalic.Name = "buttonItalic";
			this.buttonItalic.Size = new System.Drawing.Size(85, 23);
			this.buttonItalic.TabIndex = 3;
			this.buttonItalic.Text = "Italic";
			this.buttonItalic.UseVisualStyleBackColor = true;
			this.buttonItalic.Click += new System.EventHandler(this.ButtonItalic_Click);
			// 
			// buttonCenter
			// 
			this.buttonCenter.Location = new System.Drawing.Point(333, 20);
			this.buttonCenter.Name = "buttonCenter";
			this.buttonCenter.Size = new System.Drawing.Size(85, 23);
			this.buttonCenter.TabIndex = 4;
			this.buttonCenter.Text = "Center";
			this.buttonCenter.UseVisualStyleBackColor = true;
			this.buttonCenter.Click += new System.EventHandler(this.ButtonCenter_Click);
			// 
			// labelSize
			// 
			this.labelSize.AutoSize = true;
			this.labelSize.Location = new System.Drawing.Point(427, 22);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(35, 17);
			this.labelSize.TabIndex = 5;
			this.labelSize.Text = "Size";
			// 
			// textBoxSize
			// 
			this.textBoxSize.Location = new System.Drawing.Point(462, 20);
			this.textBoxSize.Name = "textBoxSize";
			this.textBoxSize.Size = new System.Drawing.Size(75, 22);
			this.textBoxSize.TabIndex = 6;
			this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSize_KeyPress);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(555, 20);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(85, 23);
			this.buttonLoad.TabIndex = 7;
			this.buttonLoad.Text = "Отвори";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(652, 20);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(85, 23);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Text = "Запиши";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.textBoxSize);
			this.Controls.Add(this.labelSize);
			this.Controls.Add(this.buttonCenter);
			this.Controls.Add(this.buttonItalic);
			this.Controls.Add(this.buttonUnderline);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(818, 497);
			this.Name = "Form1";
			this.Text = " ";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonBold;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonUnderline;
		private System.Windows.Forms.Button buttonItalic;
		private System.Windows.Forms.Button buttonCenter;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.TextBox textBoxSize;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.RichTextBox richTextBoxText;
		const string MyFile = "Test.rtf";
	}
}

