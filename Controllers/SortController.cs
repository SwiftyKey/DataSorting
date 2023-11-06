using DataSorting.Models;

namespace DataSorting.Controllers
{
	public class SortController
	{
		public ASort Sort {  get; set; }

		public SortController(object sort) => Sort = (ASort)sort;
	}
}
