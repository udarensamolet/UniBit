using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_46231z_6_04
{
	class ChainingHash
	{
		private const int SIZE = 11;
		ArrayList[] data;

		public ChainingHash()
		{
			data = new ArrayList[SIZE];
			for (int i = 0; i < SIZE; i++)
			{
				data[i] = new ArrayList(1);
			}
		}
		public int Hash(string s)
		{
			long total = 0;
			char[] charray;
			charray = s.ToCharArray();
			for (int i = 0; i < s.Length; i++)
			{
				total += 37 * total + (int)charray[i];
			}
			total = total % data.Length;
			if (total < 0)
			{
				total += data.Length;
			}
			return (int)total;
		}
		public void Add(string item)
		{
			int hash_value;
			hash_value = Hash(item);
			if (!data[hash_value].Contains(item))
			{
				data[hash_value].Add(item);
			}
		}
		public void Remove(string item)
		{
			int hash_value;
			hash_value = Hash(item);
			if (data[hash_value].Contains(item))
			{
				data[hash_value].Remove(item);
			}
		}
		public bool ContainsValue(string item)
		{
			int hash_value;
			hash_value = Hash(item);
			if (data[hash_value].Contains(item))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public string ShowDistrib()
		{
			string s = "";
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] != null)
				{
					foreach (object element in data[i])
					{
						s += i.ToString() + "\t" + element.ToString() + "\n";
					}
				}
			}
			return s;
		}
	}
}
