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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2}"/>, if item is found; otherwise,
		/// a negative number that is the bitwise complement of the index of the next element that is larger than
		/// item or, if there is no larger element, the bitwise complement of <seealso cref="List{T1, T2}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer <see cref="Comparer{Tuple{T1, T2}}.Default"/>
		/// cannot find an implementation of the <see cref="IComparer{Tuple{T1, T2}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2}"/>.
		/// </exception>
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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2, T3}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item3">
		/// The third component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2, T3}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2, T3}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2, T3}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2, T3}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2, T3}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2, T3}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2, T3}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2, T3}"/>.
		/// </exception>
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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2, T3, T4}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item3">
		/// The third component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item4">
		/// The fourth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2, T3, T4}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2, T3, T4}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2, T3, T4}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2, T3, T4}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2, T3, T4}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2, T3, T4}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2, T3, T4}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2, T3, T4}"/>.
		/// </exception>
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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2, T3, T4, T5}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item3">
		/// The third component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item4">
		/// The fourth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item5">
		/// The fifth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2, T3, T4, T5}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2, T3, T4, T5}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2, T3, T4, T5}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2, T3, T4, T5}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2, T3, T4, T5}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2, T3, T4, T5}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2, T3, T4, T5}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2, T3, T4, T5}"/>.
		/// </exception>
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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2, T3, T4, T5, T6}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item3">
		/// The third component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item4">
		/// The fourth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item5">
		/// The fifth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item6">
		/// The sixth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2, T3, T4, T5, T6}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2, T3, T4, T5, T6}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2, T3, T4, T5, T6}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2, T3, T4, T5, T6}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2, T3, T4, T5, T6}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2, T3, T4, T5, T6}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2, T3, T4, T5, T6}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2, T3, T4, T5, T6}"/>.
		/// </exception>
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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2, T3, T4, T5, T6, T7}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item3">
		/// The third component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item4">
		/// The fourth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item5">
		/// The fifth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item6">
		/// The sixth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item7">
		/// The seventh component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2, T3, T4, T5, T6, T7}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2, T3, T4, T5, T6, T7}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2, T3, T4, T5, T6, T7}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2, T3, T4, T5, T6, T7}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2, T3, T4, T5, T6, T7}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2, T3, T4, T5, T6, T7}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2, T3, T4, T5, T6, T7}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2, T3, T4, T5, T6, T7}"/>.
		/// </exception>
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

		/// <summary>
		/// Searches a range of elements in the sorted <see cref="List{T1, T2, T3, T4, T5, T6, T7, T8}"/> for an element using the specified
		/// comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="index">The zero-based starting index of the range to search.</param>
		/// <param name="count">The length of the range to search.</param>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item3">
		/// The third component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item4">
		/// The fourth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item5">
		/// The fifth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item6">
		/// The sixth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item7">
		/// The seventh component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item8">
		/// The eighth component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2, T3, T4, T5, T6, T7, T8}}"/> implementation to use when comparing elements, or null to use the
		/// default comparer <see cref="Comparer{Tuple{T1, T2, T3, T4, T5, T6, T7, T8}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2, T3, T4, T5, T6, T7, T8}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2, T3, T4, T5, T6, T7, T8}.Count"/>.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="index"/> is less than 0.-or-count is less than 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// index and count do not denote a valid range in the  <see cref="List{T1, T2, T3, T4, T5, T6, T7, T8}"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2, T3, T4, T5, T6, T7, T8}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2, T3, T4, T5, T6, T7, T8}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2, T3, T4, T5, T6, T7, T8}"/>.
		/// </exception>
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
