using System.Collections.Generic;

using DataSorting.Models;

namespace DataSorting.Controllers
{
	public class PDLController
	{
		public IPDL pdl { get; set; }

		public PDLController(IPDL pdl, Dictionary<string, int> kwargs, int n)
		{
			this.pdl = pdl;
			pdl.n = n;
			foreach (var key in kwargs.Keys) 
			{
				this.pdl.parameters[key] = kwargs[key];
			}
			pdl.FillArr();
		}
	}
}
