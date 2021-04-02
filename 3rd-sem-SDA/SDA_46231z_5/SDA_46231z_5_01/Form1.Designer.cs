namespace SDA_46231z_5_01
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnTree = new System.Windows.Forms.Button();
			this.btnFindMin = new System.Windows.Forms.Button();
			this.btnRemoveMin = new System.Windows.Forms.Button();
			this.btnRandom = new System.Windows.Forms.Button();
			this.btnFindMax = new System.Windows.Forms.Button();
			this.btnRemoveMax = new System.Windows.Forms.Button();
			this.btnRoot = new System.Windows.Forms.Button();
			this.btnMakeEmpty = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Стойност";
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(18, 54);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(235, 22);
			this.txtValue.TabIndex = 1;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(446, 22);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(99, 23);
			this.btnInsert.TabIndex = 2;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(551, 22);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(99, 23);
			this.btnFind.TabIndex = 3;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(656, 22);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(99, 23);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnTree
			// 
			this.btnTree.Location = new System.Drawing.Point(446, 53);
			this.btnTree.Name = "btnTree";
			this.btnTree.Size = new System.Drawing.Size(99, 23);
			this.btnTree.TabIndex = 5;
			this.btnTree.Text = "Tree";
			this.btnTree.UseVisualStyleBackColor = true;
			this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
			// 
			// btnFindMin
			// 
			this.btnFindMin.Location = new System.Drawing.Point(551, 53);
			this.btnFindMin.Name = "btnFindMin";
			this.btnFindMin.Size = new System.Drawing.Size(99, 23);
			this.btnFindMin.TabIndex = 6;
			this.btnFindMin.Text = "FindMin";
			this.btnFindMin.UseVisualStyleBackColor = true;
			this.btnFindMin.Click += new System.EventHandler(this.btnFindMin_Click);
			// 
			// btnRemoveMin
			// 
			this.btnRemoveMin.Location = new System.Drawing.Point(656, 53);
			this.btnRemoveMin.Name = "btnRemoveMin";
			this.btnRemoveMin.Size = new System.Drawing.Size(99, 23);
			this.btnRemoveMin.TabIndex = 7;
			this.btnRemoveMin.Text = "RemoveMin";
			this.btnRemoveMin.UseVisualStyleBackColor = true;
			this.btnRemoveMin.Click += new System.EventHandler(this.btnRemoveMin_Click);
			// 
			// btnRandom
			// 
			this.btnRandom.Location = new System.Drawing.Point(446, 82);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(99, 23);
			this.btnRandom.TabIndex = 8;
			this.btnRandom.Text = "Random";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
			// 
			// btnFindMax
			// 
			this.btnFindMax.Location = new System.Drawing.Point(551, 82);
			this.btnFindMax.Name = "btnFindMax";
			this.btnFindMax.Size = new System.Drawing.Size(99, 23);
			this.btnFindMax.TabIndex = 9;
			this.btnFindMax.Text = "FindMax";
			this.btnFindMax.UseVisualStyleBackColor = true;
			this.btnFindMax.Click += new System.EventHandler(this.btnFindMax_Click);
			// 
			// btnRemoveMax
			// 
			this.btnRemoveMax.Location = new System.Drawing.Point(656, 82);
			this.btnRemoveMax.Name = "btnRemoveMax";
			this.btnRemoveMax.Size = new System.Drawing.Size(99, 23);
			this.btnRemoveMax.TabIndex = 10;
			this.btnRemoveMax.Text = "RemoveMax";
			this.btnRemoveMax.UseVisualStyleBackColor = true;
			this.btnRemoveMax.Click += new System.EventHandler(this.btnRemoveMax_Click);
			// 
			// btnRoot
			// 
			this.btnRoot.Location = new System.Drawing.Point(551, 111);
			this.btnRoot.Name = "btnRoot";
			this.btnRoot.Size = new System.Drawing.Size(99, 23);
			this.btnRoot.TabIndex = 11;
			this.btnRoot.Text = "Root";
			this.btnRoot.UseVisualStyleBackColor = true;
			this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
			// 
			// btnMakeEmpty
			// 
			this.btnMakeEmpty.Location = new System.Drawing.Point(656, 111);
			this.btnMakeEmpty.Name = "btnMakeEmpty";
			this.btnMakeEmpty.Size = new System.Drawing.Size(99, 23);
			this.btnMakeEmpty.TabIndex = 12;
			this.btnMakeEmpty.Text = "MakeEmpty";
			this.btnMakeEmpty.UseVisualStyleBackColor = true;
			this.btnMakeEmpty.Click += new System.EventHandler(this.btnMakeEmpty_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(18, 162);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(737, 276);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnMakeEmpty);
			this.Controls.Add(this.btnRoot);
			this.Controls.Add(this.btnRemoveMax);
			this.Controls.Add(this.btnFindMax);
			this.Controls.Add(this.btnRandom);
			this.Controls.Add(this.btnRemoveMin);
			this.Controls.Add(this.btnFindMin);
			this.Controls.Add(this.btnTree);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnTree;
		private System.Windows.Forms.Button btnFindMin;
		private System.Windows.Forms.Button btnRemoveMin;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Button btnFindMax;
		private System.Windows.Forms.Button btnRemoveMax;
		private System.Windows.Forms.Button btnRoot;
		private System.Windows.Forms.Button btnMakeEmpty;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

