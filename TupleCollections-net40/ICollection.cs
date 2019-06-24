using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public interface ICollection<T1, T2> : ICollection<Tuple<T1, T2>>, IEnumerable<T1, T2>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2);
	}

	public interface ICollection<T1, T2, T3> : ICollection<Tuple<T1, T2, T3>>, IEnumerable<T1, T2, T3>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2, T3}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2, T3 item3);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2, T3}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2, T3}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2, T3}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2, T3 item3);
	}

	public interface ICollection<T1, T2, T3, T4> : ICollection<Tuple<T1, T2, T3, T4>>, IEnumerable<T1, T2, T3, T4>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2, T3, T4}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2, T3 item3, T4 item4);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2, T3, T4}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2, T3, T4}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2, T3, T4}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2, T3 item3, T4 item4);
	}

	public interface ICollection<T1, T2, T3, T4, T5> : ICollection<Tuple<T1, T2, T3, T4, T5>>,
		IEnumerable<T1, T2, T3, T4, T5>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2, T3, T4, T5}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2, T3, T4, T5}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2, T3, T4, T5}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2, T3, T4, T5}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
	}

	public interface ICollection<T1, T2, T3, T4, T5, T6> : ICollection<Tuple<T1, T2, T3, T4, T5, T6>>,
		IEnumerable<T1, T2, T3, T4, T5, T6>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <param name="item6">The value of the sixth component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5, T6}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2, T3, T4, T5, T6}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <param name="item6">The value of the sixth component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2, T3, T4, T5, T6}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2, T3, T4, T5, T6}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5, T6}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
	}

	public interface ICollection<T1, T2, T3, T4, T5, T6, T7> : ICollection<Tuple<T1, T2, T3, T4, T5, T6, T7>>,
		IEnumerable<T1, T2, T3, T4, T5, T6, T7>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <param name="item6">The value of the sixth component of the tuple.</param>
		/// <param name="item7">The value of the seventh component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <param name="item6">The value of the sixth component of the tuple.</param>
		/// <param name="item7">The value of the seventh component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
	}

	public interface ICollection<T1, T2, T3, T4, T5, T6, T7, T8> :
		ICollection<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>, IEnumerable<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		/// <summary>
		/// Adds an item to the <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7, T8}"/>.
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <param name="item6">The value of the sixth component of the tuple.</param>
		/// <param name="item7">The value of the seventh component of the tuple.</param>
		/// <param name="item8">The value of the eighth component of the tuple.</param>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7, T8}"/> is read-only.</exception>
		void Add(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7, T8}"/>
		/// </summary>
		/// <param name="item1">The value of the first component of the tuple.</param>
		/// <param name="item2">The value of the second component of the tuple.</param>
		/// <param name="item3">The value of the third component of the tuple.</param>
		/// <param name="item4">The value of the fourth component of the tuple.</param>
		/// <param name="item5">The value of the fifth component of the tuple.</param>
		/// <param name="item6">The value of the sixth component of the tuple.</param>
		/// <param name="item7">The value of the seventh component of the tuple.</param>
		/// <param name="item8">The value of the eighth component of the tuple.</param>
		/// <returns>
		/// <code>true</code> if item was successfully removed from the
		/// <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7, T8}"/>; otherwise, false. This method also returns false
		/// if item is not found in the original <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7, T8}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">The <see cref="ICollection{T1, T2, T3, T4, T5, T6, T7, T8}"/> is read-only.</exception>
		bool Remove(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);
	}
}
