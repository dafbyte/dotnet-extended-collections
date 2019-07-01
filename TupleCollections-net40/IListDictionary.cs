using System.Collections.Generic;


namespace TupleCollections
{
	public interface IListDictionary<TKey, TList, TItem> : ICollectionDictionary<TKey, TList, TItem>
		where TList : IList<TItem>
	{
	}
}
