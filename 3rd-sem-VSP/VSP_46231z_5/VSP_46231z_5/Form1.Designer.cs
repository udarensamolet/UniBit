namespace VSP_46231z_5
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
			this.labelAge = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxAge = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.checkBoxProgrammer = new System.Windows.Forms.CheckBox();
			this.groupBoxSex = new System.Windows.Forms.GroupBox();
			this.radioButtonWoman = new System.Windows.Forms.RadioButton();
			this.radioButtonMan = new System.Windows.Forms.RadioButton();
			this.groupBoxSex.SuspendLayout();
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
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(21, 336);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(63, 17);
			this.labelAge.TabIndex = 3;
			this.labelAge.Text = "Възраст";
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(21, 403);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(77, 17);
			this.labelOutput.TabIndex = 4;
			this.labelOutput.Text = "Резултати";
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
			this.textBoxOutput.Location = new System.Drawing.Point(24, 423);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxOutput.Size = new System.Drawing.Size(613, 300);
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
			this.textBoxAge.Location = new System.Drawing.Point(152, 339);
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
			// checkBoxProgrammer
			// 
			this.checkBoxProgrammer.AutoSize = true;
			this.checkBoxProgrammer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxProgrammer.Checked = true;
			this.checkBoxProgrammer.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxProgrammer.Location = new System.Drawing.Point(24, 218);
			this.checkBoxProgrammer.Name = "checkBoxProgrammer";
			this.checkBoxProgrammer.Size = new System.Drawing.Size(108, 21);
			this.checkBoxProgrammer.TabIndex = 12;
			this.checkBoxProgrammer.Text = "Програмист";
			this.checkBoxProgrammer.UseVisualStyleBackColor = true;
			// 
			// groupBoxSex
			// 
			this.groupBoxSex.Controls.Add(this.radioButtonWoman);
			this.groupBoxSex.Controls.Add(this.radioButtonMan);
			this.groupBoxSex.Location = new System.Drawing.Point(24, 245);
			this.groupBoxSex.Name = "groupBoxSex";
			this.groupBoxSex.Size = new System.Drawing.Size(132, 88);
			this.groupBoxSex.TabIndex = 13;
			this.groupBoxSex.TabStop = false;
			this.groupBoxSex.Text = "Пол";
			// 
			// radioButtonWoman
			// 
			this.radioButtonWoman.AutoSize = true;
			this.radioButtonWoman.Location = new System.Drawing.Point(6, 48);
			this.radioButtonWoman.Name = "radioButtonWoman";
			this.radioButtonWoman.Size = new System.Drawing.Size(66, 21);
			this.radioButtonWoman.TabIndex = 15;
			this.radioButtonWoman.TabStop = true;
			this.radioButtonWoman.Text = "Жена";
			this.radioButtonWoman.UseVisualStyleBackColor = true;
			// 
			// radioButtonMan
			// 
			this.radioButtonMan.AutoSize = true;
			this.radioButtonMan.Checked = true;
			this.radioButtonMan.Location = new System.Drawing.Point(6, 21);
			this.radioButtonMan.Name = "radioButtonMan";
			this.radioButtonMan.Size = new System.Drawing.Size(58, 21);
			this.radioButtonMan.TabIndex = 14;
			this.radioButtonMan.TabStop = true;
			this.radioButtonMan.Text = "Мъж";
			this.radioButtonMan.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 731);
			this.Controls.Add(this.groupBoxSex);
			this.Controls.Add(this.checkBoxProgrammer);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBoxAge);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelAge);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.labelName);
			this.MinimumSize = new System.Drawing.Size(466, 450);
			this.Name = "Form1";
			this.Text = "Въвеждане на лични данни";
			this.groupBoxSex.ResumeLayout(false);
			this.groupBoxSex.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.TextBox textBoxAge;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.CheckBox checkBoxProgrammer;
		private System.Windows.Forms.GroupBox groupBoxSex;
		private System.Windows.Forms.RadioButton radioButtonWoman;
		private System.Windows.Forms.RadioButton radioButtonMan;
	}
}

