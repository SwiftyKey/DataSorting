using System.Collections.Generic;

using DataSorting.Models;

namespace DataSorting.Controllers
{
	public class PDLController
	{
		public APDL PDL { get; set; }

		public PDLController(APDL pdl, Dictionary<string, float> kwargs, int n)
		{
			PDL = pdl;
			PDL.n = n;
			foreach (var key in kwargs.Keys) 
				PDL.parameters[key] = kwargs[key];
			PDL.FillArr();
		}
	}
}
