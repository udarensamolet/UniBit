using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_46231z_6_01
{
	class Hashing
	{
		public Hashing()
		{

		}

		public int SimpleHash(string s, string[] arr)
		{
			int total = 0;
			char[] cname;
			cname = s.ToCharArray();
			for (int i = 0; i < cname.Length; i++)
			{
				total += (int)cname[i];
			}
			return total % arr.Length;
		}

		public string ShowDistrib(string[] arr)
		{
			string s = "";
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] != null)
				{
					s += i.ToString() + "\t" + arr[i] + "\n";
				}
			}
			return s;
		}
	}
}
