using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46231z_5_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		class TreeNode<T>
		{
			public T Element { get; set; }
			public TreeNode<T> Left {get; set;}
			public TreeNode<T> Right { get; set; }
			public TreeNode(T element)
			{
				this.Element = element;
			}
			public override string ToString()
			{
				string nodeString = "[" + this.Element + " ";
				if (this.Left == null && this.Right == null)
				{
					nodeString += " (Листо) ";
				}
				if (this.Left != null)
				{
					nodeString += "Ляв: " + this.Left.ToString();
				}
				if (this.Right != null)
				{
					nodeString += "Десен: " + this.Right.ToString();
				}
				nodeString += "] ";
				return nodeString;
			}

		}

		class BinarySearchTree<T>
		{
			public TreeNode<T> Root { get; set; }
			public BinarySearchTree()
			{
				this.Root = null;
			}
			public void Insert(T x)
			{
				this.Root = Insert(x, this.Root);
			}
			public void Remove(T x)
			{
				this.Root = Remove(x, this.Root);
			}
			public void RemoveMin()
			{
				this.Root = RemoveMin(this.Root);
			}
			public void RemoveMax()
			{
				this.Root = RemoveMax(this.Root);
			}
			public T FindMin()
			{
				return ElementAt(FindMin(this.Root));
			}
			public T FindMax()
			{
				return ElementAt(FindMax(this.Root));
			}
			public T Find(T x)
			{
				return ElementAt(Find(x, this.Root));
			}
			public void MakeEmpty()
			{
				this.Root = null;
			}
			public bool IsEmpty()
			{
				return this.Root == null;
			}
			private T ElementAt(TreeNode<T> t)
			{
				return t == null ? default(T) : t.Element;
			}
			private TreeNode<T> Find(T x, TreeNode<T> t)
			{
				while (t != null)
				{
					if ((x as IComparable).CompareTo(t.Element) < 0)
					{
						t = t.Left;
					}
					else if ((x as IComparable).CompareTo(t.Element) > 0)
					{
						t = t.Right;
					}
					else
					{
						return t;
					}
				}
				return null;
			}
			private TreeNode<T> FindMin(TreeNode<T> t)
			{
				if (t != null)
				{
					while (t.Left != null)
					{
						t = t.Left;
					}
				}
				return t;
			}
			private TreeNode<T> FindMax(TreeNode<T> t)
			{
				if (t != null)
				{
					while (t.Right != null)
					{
						t = t.Right;
					}
				}
				return t;
			}
			protected TreeNode<T> Insert(T x, TreeNode<T> t)
			{
				if (t == null)
				{
					t = new TreeNode<T>(x);
				}
				else if ((x as IComparable).CompareTo(t.Element) < 0)
				{
					t.Left = Insert(x, t.Left);
				}
				else if ((x as IComparable).CompareTo(t.Element) > 0)
				{
					t.Right = Insert(x, t.Right);
				}
				else
				{
					throw new Exception("");
				}
				return t;
			}

			protected TreeNode<T> RemoveMin(TreeNode<T> t)
			{
				if (t == null)
				{
					throw new Exception("Елементът не е намерен.");
				}
				else if (t.Left != null)
				{
					t.Left = RemoveMin(t.Left);
					return t;
				}
				else
				{
					return t.Right;
				}
			}
			protected TreeNode<T> RemoveMax(TreeNode<T> t)
			{
				if (t == null)
				{
					throw new Exception("Елементът не е намерен.");
				}
				else if (t.Right != null)
				{
					t.Right = RemoveMax(t.Right);
					return t;
				}
				else
				{
					return t.Left;
				}
			}
			protected TreeNode<T> Remove(T x, TreeNode<T> t)
			{
				if (t == null)
				{
					throw new Exception("Елементът не е намерен.");
				}
				else if ((x as IComparable).CompareTo(t.Element) < 0)
				{
					t.Left = Remove(x, t.Left);
				}
				else if ((x as IComparable).CompareTo(t.Element) > 0)
				{
					t.Element = FindMin(t.Right).Element;
					t.Right = RemoveMin(t.Right);
				}
				else
				{
					t = (t.Left != null) ? t.Left : t.Right;
				}
				return t;
			}
			public override string ToString()
			{
				return this.Root.ToString();
			}
		}
		BinarySearchTree<int> intTree = new BinarySearchTree<int>();
		

		private void btnInsert_Click(object sender, EventArgs e)
		{
			int Value;
			if (int.TryParse(txtValue.Text, out Value))
			{
				intTree.Insert(Value);
				richTextBox1.Text += String.Format($"Въведен елемент: {Value}\n");
			}
			else MessageBox.Show("Невалидна стойност.");
			txtValue.Text = "";
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			Random r = new Random(DateTime.Now.Millisecond);
			string s = "";
			intTree.MakeEmpty();
			for (int i = 0; i < 8; i++)
			{
				int randomInt = r.Next(1, 500);
				intTree.Insert(randomInt);
				s += randomInt + " ";
			}
			richTextBox1.Text += String.Format($"Най-големият елемент е: {intTree.FindMax()}\n");
			richTextBox1.Text += String.Format($"Най-малкият елемент е: {intTree.FindMin()}\n");
			richTextBox1.Text += String.Format($"Коренът е: {intTree.Root.Element}\n");
			richTextBox1.Text += String.Format($"Въведените елементи са: {s}\n");
			richTextBox1.Text += String.Format($"Дърво: {intTree}\n");
		}

		private void btnTree_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				richTextBox1.Text += String.Format($"Дърво: {intTree}\n");
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.\n"); 
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			int Value, findValue;
			if (int.TryParse(txtValue.Text, out Value))
			{
				findValue = intTree.Find(Value);
				if (findValue != 0)
				{
					richTextBox1.Text += String.Format($"Има елемент със стойност: {findValue}\n");
				}
				else
				{
					richTextBox1.Text += String.Format($"Няма елемент със стойност: {findValue}\n");
				}
			}
			else
			{
				MessageBox.Show("Невалидна стойност");
				txtValue.Text = "";
			}
		}

		private void btnFindMin_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				richTextBox1.Text += String.Format($"Най-малкият елемент е: {intTree.FindMin()}\n");
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.");
			}
		}

		private void btnFindMax_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				richTextBox1.Text += String.Format($"Най-големият елемент е: {intTree.FindMax()}\n");
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.");
			}
		}

		private void btnRoot_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				richTextBox1.Text += String.Format($"Коренът е: {intTree.Root.Element}\n");
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.");
			}
		}

		private void btnRemoveMin_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				intTree.RemoveMin();
				btnTree_Click(sender, e);
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.");
			}
		}

		private void btnRemoveMax_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				intTree.RemoveMax();
				btnTree_Click(sender, e);
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.");
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (!intTree.IsEmpty())
			{
				int Value;
				if (int.TryParse(txtValue.Text, out Value))
				{
					intTree.Remove(Value);
				}
				btnTree_Click(sender, e);
			}
			else
			{
				richTextBox1.Text += String.Format("Дървото е празно.");
			}
		}

		private void btnMakeEmpty_Click(object sender, EventArgs e)
		{
			intTree.MakeEmpty();
			btnTree_Click(sender, e);
		}
	}
}
