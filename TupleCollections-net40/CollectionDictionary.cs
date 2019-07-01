using System.Collections.Generic;


namespace TupleCollections
{
	public class CollectionDictionary<TKey, TCollection, TItem> : Dictionary<TKey, TCollection>,
		ICollectionDictionary<TKey, TCollection, TItem>
		where TCollection : ICollection<TItem>, new()
	{
		public void Add(TKey key, TItem value)
		{
			if (!TryGetValue(key, out var collection) || collection == null)
				this[key] = new TCollection { value };
			else
				collection.Add(value);
		}
	}
}
