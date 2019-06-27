using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public class LinkedList<T1, T2> : LinkedList<Tuple<T1, T2>>,
		ICollection<T1, T2>
	{
		public void Add(T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			(this as ICollection<Tuple<T1, T2>>).Add(item);
		}

		public bool Remove(T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return (this as ICollection<Tuple<T1, T2>>).Remove(item);
		}
	}
}
