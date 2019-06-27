using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public class LinkedList<T1, T2, T3, T4, T5> : LinkedList<Tuple<T1, T2, T3, T4, T5>>,
		ICollection<T1, T2, T3, T4, T5>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			(this as ICollection<Tuple<T1, T2, T3, T4, T5>>).Add(item);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			return (this as ICollection<Tuple<T1, T2, T3, T4, T5>>).Remove(item);
		}
	}
}
