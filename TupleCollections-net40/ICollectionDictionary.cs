using System.Collections.Generic;


namespace TupleCollections
{
	public interface ICollectionDictionary<TKey, TCollection, TItem> : IDictionary<TKey, TCollection>
		where TCollection : ICollection<TItem>
	{
		void Add(TKey key, TItem value);
	}
}
