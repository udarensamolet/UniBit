namespace VSP_46231z_7
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
			this.listBoxCities = new System.Windows.Forms.ListBox();
			this.textBoxCities = new System.Windows.Forms.TextBox();
			this.checkedListBoxCities = new System.Windows.Forms.CheckedListBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxCities
			// 
			this.listBoxCities.FormattingEnabled = true;
			this.listBoxCities.ItemHeight = 16;
			this.listBoxCities.Location = new System.Drawing.Point(387, 43);
			this.listBoxCities.Name = "listBoxCities";
			this.listBoxCities.Size = new System.Drawing.Size(225, 388);
			this.listBoxCities.TabIndex = 0;
			this.listBoxCities.Tag = "";
			// 
			// textBoxCities
			// 
			this.textBoxCities.Location = new System.Drawing.Point(12, 12);
			this.textBoxCities.Name = "textBoxCities";
			this.textBoxCities.Size = new System.Drawing.Size(225, 22);
			this.textBoxCities.TabIndex = 1;
			// 
			// checkedListBoxCities
			// 
			this.checkedListBoxCities.CheckOnClick = true;
			this.checkedListBoxCities.FormattingEnabled = true;
			this.checkedListBoxCities.Items.AddRange(new object[] {
            "Видин",
            "Лом",
            "Оряхово",
            "Свищов",
            "Русе"});
			this.checkedListBoxCities.Location = new System.Drawing.Point(12, 43);
			this.checkedListBoxCities.Name = "checkedListBoxCities";
			this.checkedListBoxCities.Size = new System.Drawing.Size(225, 395);
			this.checkedListBoxCities.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(258, 11);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(106, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Добави";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(258, 226);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(106, 23);
			this.buttonCopy.TabIndex = 4;
			this.buttonCopy.Text = "Копирай";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 450);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.checkedListBoxCities);
			this.Controls.Add(this.textBoxCities);
			this.Controls.Add(this.listBoxCities);
			this.MaximumSize = new System.Drawing.Size(652, 497);
			this.MinimumSize = new System.Drawing.Size(652, 497);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.ButtonCopy_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxCities;
		private System.Windows.Forms.TextBox textBoxCities;
		private System.Windows.Forms.CheckedListBox checkedListBoxCities;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCopy;
	}
}

