using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public class List<T1, T2> : List<Tuple<T1, T2>>, IList<T1, T2>
	{
		public void Add(T1 item1, T2 item2)
		{
			Add(new Tuple<T1, T2>(item1, item2));
		}

		//TODO documentation
		public int BinarySearch(int index, int count, T1 item1, T2 item2, IComparer<Tuple<T1, T2>> comparer)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2,
								IComparer<Tuple<T1, T2>> comparer)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			Insert(index, item);
		}
	}


	public class List<T1, T2, T3> : List<Tuple<T1, T2, T3>>, IList<T1, T2, T3>
	{
		public void Add(T1 item1, T2 item2, T3 item3)
		{
			Add(new Tuple<T1, T2, T3>(item1, item2, item3));
		}

		//TODO documentation
		public int BinarySearch(int index, int count, T1 item1, T2 item2, T3 item3, IComparer<Tuple<T1, T2, T3>> comparer)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, IComparer<Tuple<T1, T2, T3>> comparer)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2, T3 item3)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2, T3 item3)
		{
			var item = new Tuple<T1, T2, T3>(item1, item2, item3);
			Insert(index, item);
		}
	}


	public class List<T1, T2, T3, T4> : List<Tuple<T1, T2, T3, T4>>, IList<T1, T2, T3, T4>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			Add(new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4));
		}

		//TODO documentation
		public int BinarySearch(int index, int count,
								T1 item1, T2 item2, T3 item3, T4 item4,
								IComparer<Tuple<T1, T2, T3, T4>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			var item = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4,
								IComparer<Tuple<T1, T2, T3, T4>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			var item = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			var item = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4)
		{
			var item = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
			Insert(index, item);
		}
	}


	public class List<T1, T2, T3, T4, T5> : List<Tuple<T1, T2, T3, T4, T5>>, IList<T1, T2, T3, T4, T5>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			Add(new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5));
		}

		//TODO documentation
		public int BinarySearch(int index, int count,
								T1 item1, T2 item2, T3 item3, T4 item4, T5 item5,
								IComparer<Tuple<T1, T2, T3, T4, T5>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5,
								IComparer<Tuple<T1, T2, T3, T4, T5>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			var item = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
			Insert(index, item);
		}
	}


	public class List<T1, T2, T3, T4, T5, T6> : List<Tuple<T1, T2, T3, T4, T5, T6>>, IList<T1, T2, T3, T4, T5, T6>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			Add(new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6));
		}

		//TODO documentation
		public int BinarySearch(int index, int count,
								T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6,
								IComparer<Tuple<T1, T2, T3, T4, T5, T6>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6,
								IComparer<Tuple<T1, T2, T3, T4, T5, T6>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
			Insert(index, item);
		}
	}


	public class List<T1, T2, T3, T4, T5, T6, T7> : List<Tuple<T1, T2, T3, T4, T5, T6, T7>>,
		IList<T1, T2, T3, T4, T5, T6, T7>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			Add(new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7));
		}

		//TODO documentation
		public int BinarySearch(int index, int count,
								T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7,
								IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7,
								IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
			Insert(index, item);
		}
	}


	public class List<T1, T2, T3, T4, T5, T6, T7, T8> : List<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>,
		IList<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		public void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			Add(item);
		}

		//TODO documentation
		public int BinarySearch(int index, int count,
								T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8,
								IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			return BinarySearch(index, count, item, comparer);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			return BinarySearch(item);
		}

		//TODO documentation
		public int BinarySearch(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8,
								IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>> comparer)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			return BinarySearch(item, comparer);
		}

		public bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			return Remove(item);
		}

		public int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			return IndexOf(item);
		}

		public void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			var item = new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
			Insert(index, item);
		}
	}
}
