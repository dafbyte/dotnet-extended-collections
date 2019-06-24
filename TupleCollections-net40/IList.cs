using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public interface IList<T1, T2> : IList<Tuple<T1, T2>>, ICollection<T1, T2>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2);
	}

	public interface IList<T1, T2, T3> : IList<Tuple<T1, T2, T3>>, ICollection<T1, T2, T3>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2, T3}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2, T3}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2, T3}"/>.</param>
		/// <param name="item3">The third component of the object to locate in the
		/// <see cref="IList{T1, T2, T3}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2, T3 item3);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2, T3}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2, T3}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2, T3}"/>.</param>
		/// <param name="item3">The value of the item's third component to insert into the
		/// <see cref="IList{T1, T2, T3}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2, T3}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2, T3}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2, T3 item3);
	}

	public interface IList<T1, T2, T3, T4> : IList<Tuple<T1, T2, T3, T4>>, ICollection<T1, T2, T3, T4>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2, T3, T4}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <param name="item3">The third component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <param name="item4">The fourth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2, T3, T4}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <param name="item3">The value of the item's third component to insert into the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <param name="item4">The value of the item's fourth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2, T3, T4}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2, T3, T4}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4);
	}

	public interface IList<T1, T2, T3, T4, T5> : IList<Tuple<T1, T2, T3, T4, T5>>, ICollection<T1, T2, T3, T4, T5>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2, T3, T4, T5}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item3">The third component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item4">The fourth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item5">The fifth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2, T3, T4, T5}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item3">The value of the item's third component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item4">The value of the item's fourth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <param name="item5">The value of the item's fifth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2, T3, T4, T5}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2, T3, T4, T5}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
	}

	public interface IList<T1, T2, T3, T4, T5, T6> : IList<Tuple<T1, T2, T3, T4, T5, T6>>,
		ICollection<T1, T2, T3, T4, T5, T6>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2, T3, T4, T5, T6}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item3">The third component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item4">The fourth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item5">The fifth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item6">The sixth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2, T3, T4, T5, T6}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item3">The value of the item's third component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item4">The value of the item's fourth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item5">The value of the item's fifth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <param name="item6">The value of the item's sixth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2, T3, T4, T5, T6}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2, T3, T4, T5, T6}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
	}

	public interface IList<T1, T2, T3, T4, T5, T6, T7> : IList<Tuple<T1, T2, T3, T4, T5, T6, T7>>,
		ICollection<T1, T2, T3, T4, T5, T6, T7>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item3">The third component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item4">The fourth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item5">The fifth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item6">The sixth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item7">The seventh component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item3">The value of the item's third component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item4">The value of the item's fourth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item5">The value of the item's fifth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item6">The value of the item's sixth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <param name="item7">The value of the item's seventh component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2, T3, T4, T5, T6, T7}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
	}

	public interface IList<T1, T2, T3, T4, T5, T6, T7, T8> : IList<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>,
		ICollection<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		/// <summary>
		/// Determines the index of a specific item in the <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>
		/// </summary>
		/// <param name="item1">The first component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item2">The second component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item3">The third component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item4">The fourth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item5">The fifth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item6">The sixth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item7">The seventh component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item8">The eighth component of the object to locate in the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <returns>The index of item if found in the list; otherwise, -1.</returns>
		int IndexOf(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);

		/// <summary>
		/// Inserts an item to the <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item1">The value of the item's first component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item2">The value of the item's second component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item3">The value of the item's third component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item4">The value of the item's fourth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item5">The value of the item's fifth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item6">The value of the item's sixth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item7">The value of the item's seventh component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <param name="item8">The value of the item's eighth component to insert into the
		/// <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <param name="index"></param> is not a valid index the  <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">The <see cref="IList{T1, T2, T3, T4, T5, T6, T7, T8}"/> is read-only.</exception>
		void Insert(int index, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);
	}
}
