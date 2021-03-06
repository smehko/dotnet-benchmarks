﻿//------------------------------------------------------------------------------
// <auto-generated>
//	This code was generated from the "MultipleReturnsIntBenchmarks.tt" T4 Text Template.
// </auto-generated>
//------------------------------------------------------------------------------

using BenchmarkDotNet.Attributes;
using System;
using System.Runtime.CompilerServices;

namespace MultipleReturnsTechniques
{
	public class MultipleReturnsIntBenchmarks
	{
		[Benchmark]
		public void return_int_1() => _ = return_int_1_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public int return_int_1_method()
		{
			return new int();
		}

		[Benchmark]
		public void out_int_1() => out_int_1_method(out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_1_method(out int _1)
		{
			_1 = new int();
		}

		[Benchmark]
		public void tuple_int_1() => _ = tuple_int_1_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int> tuple_int_1_method()
		{
			return new Tuple<int>(
				new int());
		}

		[Benchmark]
		public void valuetuple_int_1() => _ = valuetuple_int_1_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int> valuetuple_int_1_method()
		{
			return new ValueTuple<int>(
				new int());
		}

		[Benchmark]
		public void out_int_2() => out_int_2_method(out _, out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_2_method(out int _1, out int _2)
		{
			_1 = new int();
			_2 = new int();
		}

		[Benchmark]
		public void tuple_int_2() => _ = tuple_int_2_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int, int> tuple_int_2_method()
		{
			return new Tuple<int, int>(
				new int(),
				new int());
		}

		[Benchmark]
		public void valuetuple_int_2() => _ = valuetuple_int_2_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int, int> valuetuple_int_2_method()
		{
			return new ValueTuple<int, int>(
				new int(),
				new int());
		}

		[Benchmark]
		public void out_int_3() => out_int_3_method(out _, out _, out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_3_method(out int _1, out int _2, out int _3)
		{
			_1 = new int();
			_2 = new int();
			_3 = new int();
		}

		[Benchmark]
		public void tuple_int_3() => _ = tuple_int_3_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int, int, int> tuple_int_3_method()
		{
			return new Tuple<int, int, int>(
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void valuetuple_int_3() => _ = valuetuple_int_3_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int, int, int> valuetuple_int_3_method()
		{
			return new ValueTuple<int, int, int>(
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void out_int_4() => out_int_4_method(out _, out _, out _, out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_4_method(out int _1, out int _2, out int _3, out int _4)
		{
			_1 = new int();
			_2 = new int();
			_3 = new int();
			_4 = new int();
		}

		[Benchmark]
		public void tuple_int_4() => _ = tuple_int_4_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int, int, int, int> tuple_int_4_method()
		{
			return new Tuple<int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void valuetuple_int_4() => _ = valuetuple_int_4_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int, int, int, int> valuetuple_int_4_method()
		{
			return new ValueTuple<int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void out_int_5() => out_int_5_method(out _, out _, out _, out _, out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_5_method(out int _1, out int _2, out int _3, out int _4, out int _5)
		{
			_1 = new int();
			_2 = new int();
			_3 = new int();
			_4 = new int();
			_5 = new int();
		}

		[Benchmark]
		public void tuple_int_5() => _ = tuple_int_5_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int, int, int, int, int> tuple_int_5_method()
		{
			return new Tuple<int, int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void valuetuple_int_5() => _ = valuetuple_int_5_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int, int, int, int, int> valuetuple_int_5_method()
		{
			return new ValueTuple<int, int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void out_int_6() => out_int_6_method(out _, out _, out _, out _, out _, out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_6_method(out int _1, out int _2, out int _3, out int _4, out int _5, out int _6)
		{
			_1 = new int();
			_2 = new int();
			_3 = new int();
			_4 = new int();
			_5 = new int();
			_6 = new int();
		}

		[Benchmark]
		public void tuple_int_6() => _ = tuple_int_6_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int, int, int, int, int, int> tuple_int_6_method()
		{
			return new Tuple<int, int, int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void valuetuple_int_6() => _ = valuetuple_int_6_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int, int, int, int, int, int> valuetuple_int_6_method()
		{
			return new ValueTuple<int, int, int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void out_int_7() => out_int_7_method(out _, out _, out _, out _, out _, out _, out _);
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public void out_int_7_method(out int _1, out int _2, out int _3, out int _4, out int _5, out int _6, out int _7)
		{
			_1 = new int();
			_2 = new int();
			_3 = new int();
			_4 = new int();
			_5 = new int();
			_6 = new int();
			_7 = new int();
		}

		[Benchmark]
		public void tuple_int_7() => _ = tuple_int_7_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public Tuple<int, int, int, int, int, int, int> tuple_int_7_method()
		{
			return new Tuple<int, int, int, int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int(),
				new int(),
				new int(),
				new int());
		}

		[Benchmark]
		public void valuetuple_int_7() => _ = valuetuple_int_7_method();
		[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
		public ValueTuple<int, int, int, int, int, int, int> valuetuple_int_7_method()
		{
			return new ValueTuple<int, int, int, int, int, int, int>(
				new int(),
				new int(),
				new int(),
				new int(),
				new int(),
				new int(),
				new int());
		}
	}
}
