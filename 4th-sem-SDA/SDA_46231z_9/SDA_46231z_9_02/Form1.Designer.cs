namespace SDA_46231z_9_02
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
			this.btnCreateGraph1 = new System.Windows.Forms.Button();
			this.btnCreateGraph2 = new System.Windows.Forms.Button();
			this.btnCreateGraph3 = new System.Windows.Forms.Button();
			this.btnDijkstra = new System.Windows.Forms.Button();
			this.btnClearGraph = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Матрица на съседство";
			// 
			// btnCreateGraph1
			// 
			this.btnCreateGraph1.Location = new System.Drawing.Point(583, 66);
			this.btnCreateGraph1.Name = "btnCreateGraph1";
			this.btnCreateGraph1.Size = new System.Drawing.Size(148, 23);
			this.btnCreateGraph1.TabIndex = 1;
			this.btnCreateGraph1.Text = "Създай граф 1";
			this.btnCreateGraph1.UseVisualStyleBackColor = true;
			this.btnCreateGraph1.Click += new System.EventHandler(this.btnCreateGraph1_Click);
			// 
			// btnCreateGraph2
			// 
			this.btnCreateGraph2.Location = new System.Drawing.Point(583, 108);
			this.btnCreateGraph2.Name = "btnCreateGraph2";
			this.btnCreateGraph2.Size = new System.Drawing.Size(148, 23);
			this.btnCreateGraph2.TabIndex = 2;
			this.btnCreateGraph2.Text = "Създай граф 2";
			this.btnCreateGraph2.UseVisualStyleBackColor = true;
			this.btnCreateGraph2.Click += new System.EventHandler(this.btnCreateGraph2_Click);
			// 
			// btnCreateGraph3
			// 
			this.btnCreateGraph3.Location = new System.Drawing.Point(583, 148);
			this.btnCreateGraph3.Name = "btnCreateGraph3";
			this.btnCreateGraph3.Size = new System.Drawing.Size(148, 23);
			this.btnCreateGraph3.TabIndex = 3;
			this.btnCreateGraph3.Text = "Създай граф 3";
			this.btnCreateGraph3.UseVisualStyleBackColor = true;
			this.btnCreateGraph3.Click += new System.EventHandler(this.btnCreateGraph3_Click);
			// 
			// btnDijkstra
			// 
			this.btnDijkstra.Location = new System.Drawing.Point(583, 187);
			this.btnDijkstra.Name = "btnDijkstra";
			this.btnDijkstra.Size = new System.Drawing.Size(148, 23);
			this.btnDijkstra.TabIndex = 4;
			this.btnDijkstra.Text = "Дейкстра";
			this.btnDijkstra.UseVisualStyleBackColor = true;
			this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
			// 
			// btnClearGraph
			// 
			this.btnClearGraph.Location = new System.Drawing.Point(583, 226);
			this.btnClearGraph.Name = "btnClearGraph";
			this.btnClearGraph.Size = new System.Drawing.Size(148, 23);
			this.btnClearGraph.TabIndex = 5;
			this.btnClearGraph.Text = "Изтрий графа";
			this.btnClearGraph.UseVisualStyleBackColor = true;
			this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(583, 397);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(148, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Затвори";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(27, 66);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(522, 354);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnClearGraph);
			this.Controls.Add(this.btnDijkstra);
			this.Controls.Add(this.btnCreateGraph3);
			this.Controls.Add(this.btnCreateGraph2);
			this.Controls.Add(this.btnCreateGraph1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCreateGraph1;
		private System.Windows.Forms.Button btnCreateGraph2;
		private System.Windows.Forms.Button btnCreateGraph3;
		private System.Windows.Forms.Button btnDijkstra;
		private System.Windows.Forms.Button btnClearGraph;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

