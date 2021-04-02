namespace SDA_46231z_9_01
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
			this.btnAddVertex = new System.Windows.Forms.Button();
			this.tbLabelVertex = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbDeleteVertex = new System.Windows.Forms.ComboBox();
			this.btnDeleteVertex = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDeleteEdge = new System.Windows.Forms.Button();
			this.btnAddEdge = new System.Windows.Forms.Button();
			this.listVertex2 = new System.Windows.Forms.ListBox();
			this.listVertex1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnCreateGraph1 = new System.Windows.Forms.Button();
			this.btnCreateGraph2 = new System.Windows.Forms.Button();
			this.btnCreateGraph3 = new System.Windows.Forms.Button();
			this.btnCreateGraph4 = new System.Windows.Forms.Button();
			this.btnCreateGraph5 = new System.Windows.Forms.Button();
			this.btnClearGraph = new System.Windows.Forms.Button();
			this.btnShowMatrix = new System.Windows.Forms.Button();
			this.btnTS = new System.Windows.Forms.Button();
			this.btnDFS = new System.Windows.Forms.Button();
			this.btnBFS = new System.Windows.Forms.Button();
			this.btnMST = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddVertex);
			this.groupBox1.Controls.Add(this.tbLabelVertex);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(21, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 111);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Въвеждане на връх";
			// 
			// btnAddVertex
			// 
			this.btnAddVertex.Location = new System.Drawing.Point(133, 81);
			this.btnAddVertex.Name = "btnAddVertex";
			this.btnAddVertex.Size = new System.Drawing.Size(125, 23);
			this.btnAddVertex.TabIndex = 2;
			this.btnAddVertex.Text = "Добави връх";
			this.btnAddVertex.UseVisualStyleBackColor = true;
			this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
			// 
			// tbLabelVertex
			// 
			this.tbLabelVertex.Location = new System.Drawing.Point(9, 53);
			this.tbLabelVertex.Name = "tbLabelVertex";
			this.tbLabelVertex.Size = new System.Drawing.Size(249, 22);
			this.tbLabelVertex.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Име на върха";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbDeleteVertex);
			this.groupBox2.Controls.Add(this.btnDeleteVertex);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(304, 22);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 111);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Изтриване на връх";
			// 
			// cbDeleteVertex
			// 
			this.cbDeleteVertex.FormattingEnabled = true;
			this.cbDeleteVertex.Location = new System.Drawing.Point(6, 51);
			this.cbDeleteVertex.Name = "cbDeleteVertex";
			this.cbDeleteVertex.Size = new System.Drawing.Size(249, 24);
			this.cbDeleteVertex.TabIndex = 19;
			// 
			// btnDeleteVertex
			// 
			this.btnDeleteVertex.Location = new System.Drawing.Point(146, 82);
			this.btnDeleteVertex.Name = "btnDeleteVertex";
			this.btnDeleteVertex.Size = new System.Drawing.Size(109, 23);
			this.btnDeleteVertex.TabIndex = 2;
			this.btnDeleteVertex.Text = "Изтрий връх";
			this.btnDeleteVertex.UseVisualStyleBackColor = true;
			this.btnDeleteVertex.Click += new System.EventHandler(this.btnDeleteVertex_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Име на върха";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDeleteEdge);
			this.groupBox3.Controls.Add(this.btnAddEdge);
			this.groupBox3.Controls.Add(this.listVertex2);
			this.groupBox3.Controls.Add(this.listVertex1);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(21, 145);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(264, 293);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ребро между два върха";
			// 
			// btnDeleteEdge
			// 
			this.btnDeleteEdge.Location = new System.Drawing.Point(142, 235);
			this.btnDeleteEdge.Name = "btnDeleteEdge";
			this.btnDeleteEdge.Size = new System.Drawing.Size(107, 42);
			this.btnDeleteEdge.TabIndex = 5;
			this.btnDeleteEdge.Text = "Изтрий ребро";
			this.btnDeleteEdge.UseVisualStyleBackColor = true;
			this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
			// 
			// btnAddEdge
			// 
			this.btnAddEdge.Location = new System.Drawing.Point(12, 235);
			this.btnAddEdge.Name = "btnAddEdge";
			this.btnAddEdge.Size = new System.Drawing.Size(107, 42);
			this.btnAddEdge.TabIndex = 4;
			this.btnAddEdge.Text = "Добави ребро";
			this.btnAddEdge.UseVisualStyleBackColor = true;
			this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
			// 
			// listVertex2
			// 
			this.listVertex2.FormattingEnabled = true;
			this.listVertex2.ItemHeight = 16;
			this.listVertex2.Location = new System.Drawing.Point(142, 65);
			this.listVertex2.Name = "listVertex2";
			this.listVertex2.Size = new System.Drawing.Size(107, 164);
			this.listVertex2.TabIndex = 3;
			// 
			// listVertex1
			// 
			this.listVertex1.FormattingEnabled = true;
			this.listVertex1.ItemHeight = 16;
			this.listVertex1.Location = new System.Drawing.Point(12, 65);
			this.listVertex1.Name = "listVertex1";
			this.listVertex1.Size = new System.Drawing.Size(107, 164);
			this.listVertex1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(139, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Краен връх";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Начален връх";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.richTextBox1);
			this.groupBox4.Location = new System.Drawing.Point(304, 145);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(264, 293);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Матрица на съседството";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(6, 21);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(252, 256);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnCreateGraph1
			// 
			this.btnCreateGraph1.Location = new System.Drawing.Point(595, 12);
			this.btnCreateGraph1.Name = "btnCreateGraph1";
			this.btnCreateGraph1.Size = new System.Drawing.Size(147, 23);
			this.btnCreateGraph1.TabIndex = 6;
			this.btnCreateGraph1.Text = "Създай граф 1";
			this.btnCreateGraph1.UseVisualStyleBackColor = true;
			this.btnCreateGraph1.Click += new System.EventHandler(this.btnCreateGraph1_Click);
			// 
			// btnCreateGraph2
			// 
			this.btnCreateGraph2.Location = new System.Drawing.Point(595, 41);
			this.btnCreateGraph2.Name = "btnCreateGraph2";
			this.btnCreateGraph2.Size = new System.Drawing.Size(147, 23);
			this.btnCreateGraph2.TabIndex = 7;
			this.btnCreateGraph2.Text = "Създай граф 2";
			this.btnCreateGraph2.UseVisualStyleBackColor = true;
			this.btnCreateGraph2.Click += new System.EventHandler(this.btnCreateGraph2_Click);
			// 
			// btnCreateGraph3
			// 
			this.btnCreateGraph3.Location = new System.Drawing.Point(595, 70);
			this.btnCreateGraph3.Name = "btnCreateGraph3";
			this.btnCreateGraph3.Size = new System.Drawing.Size(147, 23);
			this.btnCreateGraph3.TabIndex = 8;
			this.btnCreateGraph3.Text = "Създай граф 3";
			this.btnCreateGraph3.UseVisualStyleBackColor = true;
			this.btnCreateGraph3.Click += new System.EventHandler(this.btnCreateGraph3_Click);
			// 
			// btnCreateGraph4
			// 
			this.btnCreateGraph4.Location = new System.Drawing.Point(595, 99);
			this.btnCreateGraph4.Name = "btnCreateGraph4";
			this.btnCreateGraph4.Size = new System.Drawing.Size(147, 23);
			this.btnCreateGraph4.TabIndex = 9;
			this.btnCreateGraph4.Text = "Създай граф 4";
			this.btnCreateGraph4.UseVisualStyleBackColor = true;
			// 
			// btnCreateGraph5
			// 
			this.btnCreateGraph5.Location = new System.Drawing.Point(595, 128);
			this.btnCreateGraph5.Name = "btnCreateGraph5";
			this.btnCreateGraph5.Size = new System.Drawing.Size(147, 23);
			this.btnCreateGraph5.TabIndex = 10;
			this.btnCreateGraph5.Text = "Създай граф 5";
			this.btnCreateGraph5.UseVisualStyleBackColor = true;
			// 
			// btnClearGraph
			// 
			this.btnClearGraph.Location = new System.Drawing.Point(595, 157);
			this.btnClearGraph.Name = "btnClearGraph";
			this.btnClearGraph.Size = new System.Drawing.Size(147, 23);
			this.btnClearGraph.TabIndex = 11;
			this.btnClearGraph.Text = "Изтрий граф";
			this.btnClearGraph.UseVisualStyleBackColor = true;
			this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
			// 
			// btnShowMatrix
			// 
			this.btnShowMatrix.Location = new System.Drawing.Point(595, 186);
			this.btnShowMatrix.Name = "btnShowMatrix";
			this.btnShowMatrix.Size = new System.Drawing.Size(147, 23);
			this.btnShowMatrix.TabIndex = 12;
			this.btnShowMatrix.Text = "Покажи матрицата";
			this.btnShowMatrix.UseVisualStyleBackColor = true;
			this.btnShowMatrix.Click += new System.EventHandler(this.btnShowMatrix_Click);
			// 
			// btnTS
			// 
			this.btnTS.Location = new System.Drawing.Point(595, 256);
			this.btnTS.Name = "btnTS";
			this.btnTS.Size = new System.Drawing.Size(147, 23);
			this.btnTS.TabIndex = 14;
			this.btnTS.Text = "TS";
			this.btnTS.UseVisualStyleBackColor = true;
			this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
			// 
			// btnDFS
			// 
			this.btnDFS.Location = new System.Drawing.Point(595, 285);
			this.btnDFS.Name = "btnDFS";
			this.btnDFS.Size = new System.Drawing.Size(147, 23);
			this.btnDFS.TabIndex = 15;
			this.btnDFS.Text = "DFS";
			this.btnDFS.UseVisualStyleBackColor = true;
			this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
			// 
			// btnBFS
			// 
			this.btnBFS.Location = new System.Drawing.Point(595, 314);
			this.btnBFS.Name = "btnBFS";
			this.btnBFS.Size = new System.Drawing.Size(147, 23);
			this.btnBFS.TabIndex = 16;
			this.btnBFS.Text = "BFS";
			this.btnBFS.UseVisualStyleBackColor = true;
			this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
			// 
			// btnMST
			// 
			this.btnMST.Location = new System.Drawing.Point(595, 343);
			this.btnMST.Name = "btnMST";
			this.btnMST.Size = new System.Drawing.Size(147, 23);
			this.btnMST.TabIndex = 17;
			this.btnMST.Text = "MST";
			this.btnMST.UseVisualStyleBackColor = true;
			this.btnMST.Click += new System.EventHandler(this.btnMST_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(595, 415);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(147, 23);
			this.btnClose.TabIndex = 18;
			this.btnClose.Text = "Затвори";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 450);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnMST);
			this.Controls.Add(this.btnBFS);
			this.Controls.Add(this.btnDFS);
			this.Controls.Add(this.btnTS);
			this.Controls.Add(this.btnShowMatrix);
			this.Controls.Add(this.btnClearGraph);
			this.Controls.Add(this.btnCreateGraph5);
			this.Controls.Add(this.btnCreateGraph4);
			this.Controls.Add(this.btnCreateGraph3);
			this.Controls.Add(this.btnCreateGraph2);
			this.Controls.Add(this.btnCreateGraph1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddVertex;
		private System.Windows.Forms.TextBox tbLabelVertex;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbDeleteVertex;
		private System.Windows.Forms.Button btnDeleteVertex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnDeleteEdge;
		private System.Windows.Forms.Button btnAddEdge;
		private System.Windows.Forms.ListBox listVertex2;
		private System.Windows.Forms.ListBox listVertex1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnCreateGraph1;
		private System.Windows.Forms.Button btnCreateGraph2;
		private System.Windows.Forms.Button btnCreateGraph3;
		private System.Windows.Forms.Button btnCreateGraph4;
		private System.Windows.Forms.Button btnCreateGraph5;
		private System.Windows.Forms.Button btnClearGraph;
		private System.Windows.Forms.Button btnShowMatrix;
		private System.Windows.Forms.Button btnTS;
		private System.Windows.Forms.Button btnDFS;
		private System.Windows.Forms.Button btnBFS;
		private System.Windows.Forms.Button btnMST;
		private System.Windows.Forms.Button btnClose;
	}
}

