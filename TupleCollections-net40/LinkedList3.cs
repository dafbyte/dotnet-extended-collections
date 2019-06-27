using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public class LinkedList<T1, T2, T3> : LinkedList<Tuple<T1, T2, T3>>,
		ICollection<T1, T2, T3>
	{
		public void Add(T1 item1, T2 item2, T3 item3)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			(this as ICollection<Tuple<T1, T2, T3>>).Add(item);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			return (this as ICollection<Tuple<T1, T2, T3>>).Remove(item);
		}
	}
}
