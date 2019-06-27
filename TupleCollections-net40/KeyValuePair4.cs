using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public struct KeyValuePair<TKey1, TKey2, TKey3, TKey4, TValue>
	{
		public KeyValuePair(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TValue value) : this()
		{
			Key = new Tuple<TKey1, TKey2, TKey3, TKey4>(key1, key2, key3, key4);
			Value = value;
		}
		/// <summary>Gets the first component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey1"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TValue}"/>.
		/// </returns>
		public TKey1 Key1 => Key.Item1;

		/// <summary>Gets the second component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey2"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TValue}"/>.
		/// </returns>
		public TKey2 Key2 => Key.Item2;
		/// <summary>Gets the third component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey3"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TValue}"/>.
		/// </returns>
		public TKey3 Key3 => Key.Item3;
		/// <summary>Gets the fourth component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey4"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TValue}"/>.
		/// </returns>
		public TKey4 Key4 => Key.Item4;
		/// <summary>Gets the complete key in the key/value pair.</summary>
		/// <returns>
		/// A <see cref="Tuple{TKey1,TKey2,TKey3,TKey4}"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TValue}"/>.
		/// </returns>
		public Tuple<TKey1, TKey2, TKey3, TKey4> Key { get; }
		/// <summary>
		/// Gets the value in the key/value pair.
		/// </summary>
		/// <returns>
		/// A TValue that is the value of the <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TValue}"/>.
		/// </returns>
		public TValue Value { get; set; }

		public override string ToString()
		{
			throw new NotImplementedException();
		}

		public static implicit operator KeyValuePair<Tuple<TKey1, TKey2, TKey3, TKey4>, TValue>(
			KeyValuePair<TKey1, TKey2, TKey3, TKey4, TValue> src)
		{
			var key = new Tuple<TKey1, TKey2, TKey3, TKey4>(src.Key1, src.Key2, src.Key3, src.Key4);
			return new KeyValuePair<Tuple<TKey1, TKey2, TKey3, TKey4>, TValue>(key, src.Value);
		}
	}
}
