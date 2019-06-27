using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public struct KeyValuePair<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>
	{
		public KeyValuePair(TKey1 key1, TKey2 key2, TKey3 key3, TKey4 key4, TKey5 key5, TKey6 key6, TKey7 key7, TValue value) : this()
		{
			Key = new Tuple<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7>(key1, key2, key3, key4, key5, key6, key7);
			Value = value;
		}

		/// <summary>Gets the first component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey1"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey1 Key1 => Key.Item1;

		/// <summary>Gets the second component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey2"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey2 Key2 => Key.Item2;
		/// <summary>Gets the third component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey3"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey3 Key3 => Key.Item3;
		/// <summary>Gets the fourth component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey4"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey4 Key4 => Key.Item4;
		/// <summary>Gets the fifth component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey5"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey5 Key5 => Key.Item5;
		/// <summary>Gets the sixth component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey6"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey6 Key6 => Key.Item6;
		/// <summary>Gets the seventh component of the key in the key/value pair.</summary>
		/// <returns>
		/// A <typeparamref name="TKey7"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TKey7 Key7 => Key.Item7;
		/// <summary>Gets the complete key in the key/value pair.</summary>
		/// <returns>
		/// A <see cref="Tuple{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7}"/> that is the key of the
		/// <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public Tuple<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7> Key { get; }
		/// <summary>
		/// Gets the value in the key/value pair.
		/// </summary>
		/// <returns>
		/// A TValue that is the value of the <see cref="KeyValuePair{TKey1,TKey2,TKey3,TKey4,TKey5,TKey6,TKey7,TValue}"/>.
		/// </returns>
		public TValue Value { get; set; }

		public override string ToString()
		{
			throw new NotImplementedException();
		}

		public static implicit operator KeyValuePair<Tuple<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7>, TValue>(
			KeyValuePair<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue> src)
		{
			var key = new Tuple<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7>(src.Key1,
																				 src.Key2,
																				 src.Key3,
																				 src.Key4,
																				 src.Key5,
																				 src.Key6,
																				 src.Key7);
			return new KeyValuePair<Tuple<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7>, TValue>(key, src.Value);
		}
	}
}
