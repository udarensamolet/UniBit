using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_9_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Vertex
		{
			public bool wasVisited;
			public string label;
			public Vertex(string label)
			{
				this.label = label;
				wasVisited = false;
			}
		}

		public class Graph
		{
			private const int NUM_VERTICES = 15;
			private Vertex[] vertices;
			private int[,] adjMatrix;
			private int numVerts;

			public Graph()
			{
				vertices = new Vertex[NUM_VERTICES];
				adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
				numVerts = 0;
				for (int j = 0; j < NUM_VERTICES; j++)
				{
					for (int k = 0; k < NUM_VERTICES; k++)
					{
						adjMatrix[j, k] = 0;
					}
				}
			}

			public bool AddVertex(string label)
			{
				try
				{
					vertices[numVerts] = new Vertex(label);
					numVerts++;
					return true;
				}
				catch
				{
					MessageBox.Show("***ERR01*** Препълване на заявения размер на масива.");
					return false;
				}
			}

			public void AddEdge(int start, int end)
			{
				try
				{
					adjMatrix[start, end] = 1;
				}
				catch
				{
					MessageBox.Show("***ERR02*** Препълване на заявения размер на масива.");
				}
			}

			public bool HasEdge(int start, int end)
			{
				if (adjMatrix[start, end] == 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}

			public string ShowVertex(int v)
			{
				return (vertices[v].label);
			}

			public string ShowMatrix()
			{
				if (numVerts == 0)
				{
					return "";
				}
				string s = "   |";
				for (int i = 0; i < numVerts; i++)
				{
					s += String.Format($" {ShowVertex(i)} |");
				}
				s += "\n";
				for (int i = 0; i < numVerts; i++)
				{
					s += "===|";
				}
				s += "\n";
				for (int j = 0; j < numVerts; j++)
				{
					s += String.Format($" {ShowVertex(j)} | ");
					for (int k = 0; k < numVerts; k++)
					{
						if (HasEdge(j, k))
						{
							s += " 1 | ";
						}
						else
						{
							s += " 0 | ";
						}
					}
					return s += "\n";
				}
				return s;

			}

			public void ClearGraph()
			{
				for (int i = 0; i < NUM_VERTICES; i++)
				{
					vertices[i] = null;
				}
				numVerts = 0;
				for (int j = 0; j < NUM_VERTICES; j++)
				{
					for (int k = 0; k < NUM_VERTICES; k++)
					{
						adjMatrix[j, k] = 0;
					}
				}
			}

			public void DelEdge(int start, int end)
			{
				try
				{
					adjMatrix[start, end] = 0;
				}
				catch
				{
					MessageBox.Show("***ERR03*** Опит за работа с индекси извън диапазона на масива.");
				}
			}

			public int NoSuccessors()
			{
				bool isEdge;
				for (int row = 0; row < numVerts; row++)
				{
					isEdge = false;
					for (int col = 0; col < numVerts; col++)
					{
						if (adjMatrix[row, col] > 0)
						{
							isEdge = true;
							break;
						}
					}
					if (!(isEdge))
					{
						return row;
					}
				}
				return -1;
			}

			private void MoveRow(int row, int length)
			{
				for (int col = 0; col < length; col++)
				{
					adjMatrix[row, col] = adjMatrix[row + 1, col];
				}
			}

			private void MoveCol(int col, int length)
			{
				for (int row = 0; row < length; row++)
				{
					adjMatrix[row, col] = adjMatrix[row, col + 1];
				}
			}

			public bool DelVertex(int vert)
			{
				try
				{
					if (numVerts == 0)
					{
						return true;
					}
					if (vert != numVerts - 1)
					{
						for (int j = vert; j < numVerts - 1; j++)
						{
							vertices[j] = vertices[j + 1];
						}
						for (int row = vert; row < numVerts - 1; row++)
						{
							MoveRow(row, numVerts);
						}
						for (int col = vert; col < numVerts - 1; col++)
						{
							MoveRow(col, numVerts - 1);
						}
					}
					numVerts--;
					return true;
				}
				catch
				{
					MessageBox.Show("***ERR04*** Опит за работа с индекси извън диапазона на масива.");
					return false;
				}

			}

			public int Count()
			{
				return numVerts;
			}

			public void TopSort()
			{
				if (Count() <= 0)
				{
					MessageBox.Show("TS - Графът е празен.");
					return;
				}
				Stack gStack = new Stack();
				while (Count() > 0)
				{
					int currVertex = NoSuccessors();
					if (currVertex == -1)
					{
						MessageBox.Show("TS - Графът има цикли.");
						return;
					}
					gStack.Push(vertices[currVertex].label);
					if (DelVertex(currVertex) == false)
					{
						MessageBox.Show("***ERR04*** Грешка при изтриване на връх.");
						return;
					}
				}
				string s = "Топологично сортиране: \n";
				while (gStack.Count > 0)
				{
					if (gStack.Count > 1)
					{
						s += (gStack.Pop()) + " -> ";
					}
					else
					{
						s += (gStack.Pop());
					}
				}
				MessageBox.Show(s);
			}

			private int GetUnvisitedVertex(int v)
			{
				for (int j = 0; j < numVerts; j++)
				{
					if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
					{
						return j;
					}
				}
				return -1;
			}

			public string DepthFirstSearch()
			{
				vertices[0].wasVisited = true;
				string s = ShowVertex(0) + " -> ";
				Stack gStack = new Stack();
				gStack.Push(0);
				int v;
				while (gStack.Count > 0)
				{
					v = GetUnvisitedVertex((int)gStack.Peek());
					if (v == -1)
					{
						gStack.Pop();
					}
					else
					{
						vertices[v].wasVisited = true;
						s += ShowVertex(v) + " -> ";
						gStack.Push(v);
					}
				}
				for (int j = 0; j < numVerts; j++)
				{
					vertices[j].wasVisited = false;
				}
				return s;
			}

			public string BreadthFirstSearch()
			{
				Queue gQueue = new Queue();
				vertices[0].wasVisited = true;
				string s = ShowVertex(0) + " -> ";
				gQueue.Enqueue(0);
				int vParent, vChild;
				while (gQueue.Count > 0)
				{
					vParent = (int)gQueue.Dequeue();
					vChild = GetUnvisitedVertex(vParent);
					while (vChild != -1)
					{
						vertices[vChild].wasVisited = true;
						s += ShowVertex(vChild) + " -> ";
						gQueue.Enqueue(vChild);
						vChild = GetUnvisitedVertex(vParent);
					}
				}
				for (int i = 0; i < numVerts; i++)
				{
					vertices[i].wasVisited = false;
				}
				return s;
			}

			public string MinimumSpanningTree()
			{
				vertices[0].wasVisited = true;
				Stack gStack = new Stack();
				gStack.Push(0);
				int currVertex, v;
				string s = "";
				while (gStack.Count > 0)
				{
					currVertex = (int)gStack.Peek();
					v = GetUnvisitedVertex(currVertex);
					if (v == -1)
					{
						gStack.Pop();
					}
					else
					{
						vertices[v].wasVisited = true;
						gStack.Push(v);
						s += ShowVertex(currVertex) + " => ";
						s += ShowVertex(v) + "  ";
					}
				}
				for (int j = 0; j < numVerts; j++)
				{
					vertices[j].wasVisited = false;
				}
				return s;
			}
		}

		Graph g = new Graph();
		private void CreateGraph(string[] items)
		{
			g.ClearGraph();

			listVertex1.Items.Clear();
			listVertex1.Items.AddRange(items);
			listVertex1.SelectedIndex = 0;

			listVertex2.Items.Clear();
			listVertex2.Items.AddRange(items);
			listVertex2.SelectedIndex = 0;

			cbDeleteVertex.Items.Clear();
			cbDeleteVertex.Items.AddRange(items);
			cbDeleteVertex.SelectedIndex = 0;

			foreach (string element in items)
			{
				g.AddVertex(element);
			}
		}

		private void btnCreateGraph1_Click(object sender, EventArgs e)
		{
			string[] items = new string[] { "A", "B", "C", "D", "E", "F" };
			CreateGraph(items);
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(1, 3);
			g.AddEdge(2, 3);
			g.AddEdge(3, 4);
			g.AddEdge(4, 5);
			g.AddEdge(1, 5);
			richTextBox1.Text += g.ShowMatrix();
		}

		private void btnAddVertex_Click(object sender, EventArgs e)
		{
			string labelVertex = tbLabelVertex.Text;
			if (labelVertex.Length > 0)
			{
				listVertex1.Items.Add(labelVertex);
				listVertex1.Items.Add(labelVertex);
				cbDeleteVertex.Items.Add(labelVertex);
				tbLabelVertex.Text = "";
				richTextBox1.Text = g.ShowMatrix();
			}
			else
			{
				MessageBox.Show("Въведете данни в полето 'Име на върха'");
			}

		}

		private void btnDeleteVertex_Click(object sender, EventArgs e)
		{
			if (g.Count() == 0)
			{
				int row = Int32.Parse(cbDeleteVertex.SelectedIndex.ToString());
				if (row > -1 && g.DelVertex(row))
				{
					cbDeleteVertex.Items.Remove(cbDeleteVertex.SelectedItem.ToString());
				}
				int count = cbDeleteVertex.Items.Count;
				string[] items = new string[count];
				for (int i = 0; i < count; i++)
				{
					items[i] = cbDeleteVertex.Items[i].ToString();
				}

				listVertex1.Items.Clear();
				listVertex1.Items.AddRange(items);
				listVertex2.Items.Clear();
				listVertex2.Items.AddRange(items);
				cbDeleteVertex.Text = "";
				richTextBox1.Text = g.ShowMatrix();
				if (g.Count() > 0)
				{
					listVertex1.SelectedIndex = 0;
					listVertex2.SelectedIndex = 0;
					cbDeleteVertex.SelectedIndex = 0;
				}
			}
		}

		private void btnAddEdge_Click(object sender, EventArgs e)
		{
			int row = Int32.Parse(listVertex1.SelectedIndex.ToString());
			int col = Int32.Parse(listVertex2.SelectedIndex.ToString());
			g.AddEdge(row, col);
			richTextBox1.Text = g.ShowMatrix();
		}

		private void btnDeleteEdge_Click(object sender, EventArgs e)
		{
			int row = Int32.Parse(listVertex1.SelectedIndex.ToString());
			int col = Int32.Parse(listVertex2.SelectedIndex.ToString());
			g.DelEdge(row, col);
			richTextBox1.Text = g.ShowMatrix();
		}

		private void btnShowMatrix_Click(object sender, EventArgs e)
		{
			if (g.Count() == 0)
			{
				MessageBox.Show("Графът е празен.");
			}
			richTextBox1.Text = g.ShowMatrix();
		}

		private void btnClearGraph_Click(object sender, EventArgs e)
		{
			g.ClearGraph();
			listVertex1.Items.Clear();
			listVertex2.Items.Clear();
			cbDeleteVertex.Items.Clear();
			cbDeleteVertex.Text = "";
			richTextBox1.Text = "";
		}

		private void btnTS_Click(object sender, EventArgs e)
		{
			g.TopSort();
		}

		private void btnCreateGraph2_Click(object sender, EventArgs e)
		{
			string[] items = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
			CreateGraph(items);
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(1, 3);
			g.AddEdge(1, 4);
			g.AddEdge(3, 7);
			g.AddEdge(4, 8);
			g.AddEdge(4, 9);
			g.AddEdge(2, 5);
			g.AddEdge(2, 6);
			g.AddEdge(5, 10);
			richTextBox1.Text = g.ShowMatrix();

		}

		private void btnDFS_Click(object sender, EventArgs e)
		{
			MessageBox.Show("DFS: \n" + g.DepthFirstSearch());
		}

		private void btnBFS_Click(object sender, EventArgs e)
		{
			MessageBox.Show("BFS: \n" + g.BreadthFirstSearch());
		}

		private void btnMST_Click(object sender, EventArgs e)
		{
			MessageBox.Show("MST:\n" + g.MinimumSpanningTree());
		}

		private void btnCreateGraph3_Click(object sender, EventArgs e)
		{
			string[] items = new string[] { "A", "B", "C", "D", "E", "F", "G" };
			CreateGraph(items);
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(0, 3);
			g.AddEdge(1, 3);
			g.AddEdge(1, 4);
			g.AddEdge(2, 5);
			g.AddEdge(3, 2);
			g.AddEdge(3, 4);
			g.AddEdge(3, 5);
			g.AddEdge(3, 6);
			g.AddEdge(4, 6);
			g.AddEdge(5, 6);

			g.AddEdge(1, 0);
			g.AddEdge(2, 0);
			g.AddEdge(3, 0);
			g.AddEdge(3, 1);
			g.AddEdge(4, 1);
			g.AddEdge(5, 2);
			g.AddEdge(2, 3);
			g.AddEdge(4, 3);
			g.AddEdge(5, 3);
			g.AddEdge(6, 3);
			g.AddEdge(6, 4);
			g.AddEdge(6, 5);
			richTextBox1.Text = g.ShowMatrix();
		}
	}
}