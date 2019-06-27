using System;
using System.Collections.Generic;

namespace TupleCollections
{
	/// <inheritdoc />
	/// <typeparam name="TKey1">The type of the first component of keys in the dictionary.</typeparam>
	/// <typeparam name="TKey2">The type of the second component of keys in the dictionary.</typeparam>
	/// <typeparam name="TKey3">The type of the third component of keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
	public interface IDictionary<TKey1, TKey2, TKey3, TValue> :
		//IDictionary<Tuple<TKey1, TKey2, TKey3>, TValue>,
		ICollection<KeyValuePair<TKey1, TKey2, TKey3, TValue>>
	{
		/// <summary>
		/// Gets or sets the element with the specified key.
		/// </summary>
		/// <param name="key1">The first component of the key of the element to get or set.</param>
		/// <param name="key2">The second component of the key of the element to get or set.</param>
		/// <param name="key3">The third component of the key of the element to get or set.</param>
		/// <returns>The element with the specified key components.</returns>
		/// <exception cref="KeyNotFoundException">The property is retrieved and key is not found.</exception>
		/// <exception cref="NotSupportedException">
		/// The property is set and the <see cref="IDictionary{TKey1, TKey2, TKey3, TValue}"/>
		/// is read-only.
		/// </exception>
		TValue this[TKey1 key1, TKey2 key2, TKey3 key3] { get; set; }

		/// <summary>
		/// Gets an <see cref="ICollection{TKey1,TKey2,TKey3}"/> containing the keys of
		/// the <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </summary>
		/// <returns>
		/// An <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/> containing the keys of
		/// the object that implements <see cref="ICollection{TKey1,TKey2,TKey3}"/>.
		/// </returns>
		new ICollection<TKey1, TKey2, TKey3> Keys { get; }

		/// <summary>
		/// Adds an element with the provided key and value to the
		/// <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </summary>
		/// <param name="key1">The first component of the object to use as the key of the element to add.</param>
		/// <param name="key2">The second component of the object to use as the key of the element to add.</param>
		/// <param name="key3">The third component of the object to use as the key of the element to add.</param>
		/// <param name="value">The object to use as the value of the element to add.</param>
		/// <exception cref="ArgumentException">
		/// An element with the same key already exists in the <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// The <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/> is read-only.
		/// </exception>
		void Add(TKey1 key1, TKey2 key2, TKey3 key3, TValue value);

		/// <summary>
		/// Determines whether the <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/> contains
		/// an element with the specified key.
		/// </summary>
		/// <param name="key1">
		/// The first component of the key to locate in the
		/// <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </param>
		/// <param name="key2">
		/// The second component of the key to locate in the
		/// <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </param>
		/// <param name="key3">
		/// The third component of the key to locate in the
		/// <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </param>
		/// <returns>
		/// true if the <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/> contains
		/// an element with the key; otherwise, false.
		/// </returns>
		bool ContainsKey(TKey1 key1, TKey2 key2, TKey3 key3);

		/// <summary>
		/// Removes the element with the specified key from the
		/// <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </summary>
		/// <param name="key1">The first component of the element to remove.</param>
		/// <param name="key2">The second component of the element to remove.</param>
		/// <param name="key3">The third component of the element to remove.</param>
		/// <returns>
		/// true if the element is successfully removed; otherwise, false. This method also returns false if key was not
		/// found in the original <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/>.
		/// </returns>
		/// <exception cref="NotSupportedException">
		/// The <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/> is read-only.
		/// </exception>
		bool Remove(TKey1 key1, TKey2 key2, TKey3 key3);

		/// <summary>
		/// Gets the value associated with the specified key.
		/// </summary>
		/// <param name="key1">The first component of the key whose value to get.</param>
		/// <param name="key2">The second component of the key whose value to get.</param>
		/// <param name="key3">The third component of the key whose value to get.</param>
		/// <param name="value">
		/// When this method returns, the value associated with the specified key, if the key is found; otherwise, the
		/// default value for the type of the value parameter. This parameter is passed uninitialized.
		/// </param>
		/// <returns>
		/// true if the object that implements
		/// <see cref="IDictionary{TKey1,TKey2,TKey3,TValue}"/> contains an element with
		/// the specified key; otherwise, false.
		/// </returns>
		bool TryGetValue(TKey1 key1, TKey2 key2, TKey3 key3, out TValue value);
	}
}