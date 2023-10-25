using DataSorting.Models;

namespace DataSorting.Controllers
{
	public class SortController
	{
		public ASort Sort {  get; set; }

		public SortController(ASort sort) => Sort = sort;
	}
}
