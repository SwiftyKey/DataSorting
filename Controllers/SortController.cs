using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataSorting.Models;

namespace DataSorting.Controllers
{
	public static class SortController
	{
		public static Sort sort = new Sort();

		public static float[] MergeSort(float[] arr) => sort.MergeSort(arr);
	}
}
