using DataSorting.Models;

namespace DataSorting.Controllers
{
	public class ExcerptController
	{
		public Excerpt Excerpt { get; set; }

		public ExcerptController(int m, PDLController pdlc, SortController sc) => Excerpt = new Excerpt(m, pdlc, sc);
	}
}
