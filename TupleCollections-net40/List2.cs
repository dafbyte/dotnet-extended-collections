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

		/// <summary>
		/// Searches the entire sorted <see cref="List{T1, T2}"/> for an element using the
		/// default comparer and returns the zero-based index of the element.
		/// </summary>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2}"/>, if item is
		/// found; otherwise, a negative number that is the bitwise complement of the index of the next element that is
		/// larger than item or, if there is no larger element, the bitwise complement of
		/// <see cref="List{T1, T2}.Count"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The default comparer <see cref="Comparer{T}.Default"/> cannot find an implementation of the
		/// <see cref="IComparable{T}"/> generic interface or the <see cref="IComparable"/> interface for type
		/// <see cref="Tuple{T1, T2}"/>.
		/// </exception>
		public int BinarySearch(T1 item1, T2 item2)
		{
			var item = new Tuple<T1, T2>(item1, item2);
			return BinarySearch(item);
		}

		/// <summary>
		/// Searches the entire sorted <see cref="List{T1, T2, T3}"/> for an element using the specified comparer
		/// and returns the zero-based index of the element.
		/// </summary>
		/// <param name="item1">
		/// The first component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="item2">
		/// The second component of the object to locate. The value can be null for reference types.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IComparer{Tuple{T1, T2}}"/> implementation to use when comparing elements.
		/// -or- null to use the default comparer <see cref="Comparer{Tuple{T1, T2}}.Default"/>.
		/// </param>
		/// <returns>
		/// The zero-based index of item in the sorted <see cref="List{T1, T2}"/>,
		/// if item is found; otherwise, a negative number that is the bitwise complement of the index of the next
		/// element that is larger than item or, if there is no larger element, the bitwise complement of
		/// <seealso cref="List{T1, T2}.Count"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="comparer"/> is null, and the default comparer
		/// <see cref="Comparer{Tuple{T1, T2}}.Default"/> cannot find an implementation of the
		/// <see cref="IComparer{Tuple{T1, T2}}"/> generic interface or the
		///  <see cref="IComparable"/> interface for type <see cref="Tuple{T1, T2}"/>.
		/// </exception>
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
}
