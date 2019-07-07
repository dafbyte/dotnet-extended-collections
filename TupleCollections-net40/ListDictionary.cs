using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace TupleCollections
{
	public class ListDictionary<TKey, TValue> : Dictionary<TKey, List<TValue>>,
		IListDictionary<TKey, List<TValue>, TValue>
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ListDictionary{TKey,TValue}"/> class that is empty, has the
		/// default initial capacity, and uses the default equality comparer for the key type.
		/// </summary>
		public ListDictionary()
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ListDictionary{TKey,TValue}"/> class that is empty, has the
		/// specified initial capacity, and uses the default equality comparer for the key type.
		/// </summary>
		/// <param name="capacity">
		/// The initial number of elements that the <see cref="ListDictionary{TKey,TValue}"/> can contain.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
		public ListDictionary(int capacity) : base(capacity)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ListDictionary{TKey,TValue}"/> class that is empty, has the
		/// default initial capacity, and uses the specified <see cref="IEqualityComparer{TKey}"/>.
		/// </summary>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{TKey}"/> implementation to use when comparing keys, or null to use the
		/// default <see cref="EqualityComparer{TKey}"/> for the type of the key.
		/// </param>
		public ListDictionary(IEqualityComparer<TKey> comparer) : base(comparer)
		{
		}

		/// <inheritdoc />
		public ListDictionary(IDictionary<TKey, TValue> dictionary)
		{
			Init(dictionary);
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ListDictionary{TKey,TValue}"/> class that is empty, has the
		/// specified initial capacity, and uses the specified <see cref="IEqualityComparer{TKey}"/>.
		/// </summary>
		/// <param name="capacity">
		/// The initial number of elements that the <see cref="ListDictionary{TKey,TValue}"/> can contain.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{TKey}"/> implementation to use when comparing keys, or null to use the
		/// default <see cref="EqualityComparer{TKey}"/> for the type of the key.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">capacity is less than 0.</exception>
		public ListDictionary(int capacity, IEqualityComparer<TKey> comparer) : base(capacity, comparer)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ListDictionary{TKey,TValue}"/> class that contains elements
		/// copied from the specified <see cref="IDictionary{TKey,TValue}"/> and uses the specified
		/// <see cref="IEqualityComparer{TKey}"/>.
		/// </summary>
		/// <param name="dictionary">
		/// The <see cref="IDictionary{TKey,TValue}"/> whose elements are copied to the new
		/// <see cref="ListDictionary{TKey,TValue}"/>.
		/// </param>
		/// <param name="comparer">The <see cref="IEqualityComparer{TKey}"/> implementation to use when comparing keys,
		/// or null to use the default <see cref="EqualityComparer{TKey}"/> for the type of the key.</param>
		public ListDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : base(comparer)
		{
			Init(dictionary);
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ListDictionary{TKey,TValue}"/> class with serialized data.
		/// </summary>
		/// <param name="info">
		/// A <see cref="SerializationInfo"/> object containing the information required to serialize the
		/// <see cref="ListDictionary{TKey,TValue}"/>.
		/// </param>
		/// <param name="context">
		/// A <see cref="StreamingContext"/> structure containing the source and destination of the serialized stream
		/// associated with the <see cref="ListDictionary{TKey,TValue}"/>.
		/// </param>
		protected ListDictionary(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public void Add(TKey key, TValue value)
		{
			if (!TryGetValue(key, out var list))
			{
				list = new List<TValue>();
				Add(key, list);
			}
			list.Add(value);
		}

		private void Init(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
				throw new ArgumentNullException(nameof(dictionary), "Argument must contain a value.");

			foreach (var pair in dictionary)
				Add(pair.Key, pair.Value == null ? new List<TValue>() : new List<TValue> { pair.Value });
		}
	}
}
