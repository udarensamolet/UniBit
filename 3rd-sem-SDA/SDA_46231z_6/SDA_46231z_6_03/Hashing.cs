using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_46231z_6_03
{
	class Hashing
	{
		public string[] hTable;
		public Hashing()
		{
			hTable = new string[1001];
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

		public string ShowDistrib()
		{
			string s = "";
			for (int i = 0; i < hTable.Length; i++)
			{
				if (hTable[i] != null)
				{
					s += i.ToString() + "\t" + hTable[i] + "\n";
				}
			}
			return s;
		}

		public int BetterHashing(string s)
		{
			long total = 0;
			char[] cname;
			cname = s.ToCharArray();
			for (int i = 0; i < cname.Length; i++)
			{
				total += 37 * total + (int)cname[i];
			}
			total = total % hTable.Length;
			if (total < 0)
			{
				total += hTable.Length;
			}
			return (int)total;
		}

		public bool ContainsValue(string s)
		{
			int hval = BetterHashing(s);
			if (hTable[hval] == s)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


	}
}
