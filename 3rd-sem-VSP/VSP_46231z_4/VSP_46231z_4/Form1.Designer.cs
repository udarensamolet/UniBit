namespace VSP_46231z_4
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
			this.labelName = new System.Windows.Forms.Label();
			this.labelAddress = new System.Windows.Forms.Label();
			this.labelOccupation = new System.Windows.Forms.Label();
			this.labelAge = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.textBoxOccupation = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxAge = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(21, 25);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 17);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Име";
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(21, 56);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(48, 17);
			this.labelAddress.TabIndex = 1;
			this.labelAddress.Text = "Адрес";
			// 
			// labelOccupation
			// 
			this.labelOccupation.AutoSize = true;
			this.labelOccupation.Location = new System.Drawing.Point(21, 223);
			this.labelOccupation.Name = "labelOccupation";
			this.labelOccupation.Size = new System.Drawing.Size(76, 17);
			this.labelOccupation.TabIndex = 2;
			this.labelOccupation.Text = "Професия";
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(21, 251);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(63, 17);
			this.labelAge.TabIndex = 3;
			this.labelAge.Text = "Възраст";
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(21, 279);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(77, 17);
			this.labelOutput.TabIndex = 4;
			this.labelOutput.Text = "Резултати";
			// 
			// textBoxOccupation
			// 
			this.textBoxOccupation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOccupation.Location = new System.Drawing.Point(152, 218);
			this.textBoxOccupation.Name = "textBoxOccupation";
			this.textBoxOccupation.Size = new System.Drawing.Size(485, 22);
			this.textBoxOccupation.TabIndex = 5;
			this.textBoxOccupation.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxOccupation_Validating);
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(152, 25);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(485, 22);
			this.textBoxName.TabIndex = 6;
			this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Location = new System.Drawing.Point(24, 299);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxOutput.Size = new System.Drawing.Size(613, 174);
			this.textBoxOutput.TabIndex = 7;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAddress.Location = new System.Drawing.Point(152, 53);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxAddress.Size = new System.Drawing.Size(485, 159);
			this.textBoxAddress.TabIndex = 8;
			this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// textBoxAge
			// 
			this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAge.Location = new System.Drawing.Point(152, 246);
			this.textBoxAge.Name = "textBoxAge";
			this.textBoxAge.Size = new System.Drawing.Size(485, 22);
			this.textBoxAge.TabIndex = 9;
			this.textBoxAge.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAge_KeyPress);
			this.textBoxAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAge_KeyUp);
			this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxAge_Validating);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(659, 25);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(111, 30);
			this.buttonOK.TabIndex = 10;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// buttonHelp
			// 
			this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonHelp.CausesValidation = false;
			this.buttonHelp.Location = new System.Drawing.Point(659, 61);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(111, 30);
			this.buttonHelp.TabIndex = 11;
			this.buttonHelp.Text = "Help";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 503);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBoxAge);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxOccupation);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelAge);
			this.Controls.Add(this.labelOccupation);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.labelName);
			this.MinimumSize = new System.Drawing.Size(466, 450);
			this.Name = "Form1";
			this.Text = "Въвеждане на лични данни";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.Label labelOccupation;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.TextBox textBoxOccupation;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.TextBox textBoxAge;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonHelp;
	}
}

