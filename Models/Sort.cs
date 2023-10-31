using System;
using System.Diagnostics;
using System.Linq;

namespace DataSorting.Models
{
	public abstract class ASort
	{
		public abstract (int, int, long) Indicators { get; set; }
		public abstract double[] Sort(double[] arr);
	}

	public class MergeSort : ASort
	{
		public override (int, int, long) Indicators { get; set; }

		double[] Merge(double[] arr1, double[] arr2, ref int c, ref int p)
		{
			int ptr1 = 0, ptr2 = 0;
			double[] merged = new double[arr1.Length + arr2.Length];

			for (int i = 0; i < merged.Length; ++i)
			{
				if (ptr1 < arr1.Length && ptr2 < arr2.Length)
				{
					c++;
					if (arr1[ptr1] > arr2[ptr2])
					{
						merged[i] = arr2[ptr2++];
						p++;
					}
					else merged[i] = arr1[ptr1++];
				}
				else
				{
					if (ptr2 < arr2.Length)
					{
						merged[i] = arr2[ptr2++];
						p++;
					}
					else merged[i] = arr1[ptr1++];
				}
			}

			return merged;
		}

		double[] Sort(double[] arr, ref int c, ref int p)
		{
			if (arr.Length == 1)
				return arr;

			Int32 middle = arr.Length / 2;
			return Merge(Sort(arr.Take(middle).ToArray(), ref c, ref p),
						 Sort(arr.Skip(middle).ToArray(), ref c, ref p), ref c, ref p);
		}

		public override double[] Sort(double[] arr)
		{
			var watch = new Stopwatch();
			int comparisons = 0, permutations = 0;

			watch.Start();
			arr = Sort(arr, ref comparisons, ref permutations);
			watch.Stop();

			var countComparisons = arr.Length * (int)Math.Log(arr.Length, 2);
			Indicators = (permutations / 2, comparisons, watch.ElapsedMilliseconds);

			return arr;
		}
	}
}
