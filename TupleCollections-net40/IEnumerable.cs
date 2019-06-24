using System;
using System.Collections.Generic;


namespace TupleCollections
{
	public interface IEnumerable<T1, T2> : IEnumerable<Tuple<T1, T2>>
	{
	}

	public interface IEnumerable<T1, T2, T3> : IEnumerable<Tuple<T1, T2, T3>>
	{
	}

	public interface IEnumerable<T1, T2, T3, T4> : IEnumerable<Tuple<T1, T2, T3, T4>>
	{
	}

	public interface IEnumerable<T1, T2, T3, T4, T5> : IEnumerable<Tuple<T1, T2, T3, T4, T5>>
	{
	}

	public interface IEnumerable<T1, T2, T3, T4, T5, T6> : IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>>
	{
	}

	public interface IEnumerable<T1, T2, T3, T4, T5, T6, T7> : IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>>
	{
	}

	public interface IEnumerable<T1, T2, T3, T4, T5, T6, T7, TRest> : IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>
	{
	}
}
