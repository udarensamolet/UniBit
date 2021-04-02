using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA_46231z_3_06
{
	class PriorityQueue<T>
	{
		List<T> Values = new List<T>();
		List<int> Priorities = new List<int>();

		public int NumItems
		{
			get
			{
				return Values.Count;
			}
		}

		public void Enqueue(T new_value, int new_priority)
		{
			Values.Add(new_value);
			Priorities.Add(new_priority);
		}

		public void Dequeue(out T top_value, out int top_priority)
		{
			int best_index = 0;
			int best_priority = Priorities[0];
			for (int i = 1; i < Priorities.Count; i++)
			{
				if (best_priority > Priorities[i])
				{
					best_priority = Priorities[i];
					best_index = i;
				}
			}
			top_value = Values[best_index];
			top_priority = best_priority;
			Values.RemoveAt(best_index);
			Priorities.RemoveAt(best_index);
		}
	}
}
