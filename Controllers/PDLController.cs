using System.Collections.Generic;

using DataSorting.Models;

namespace DataSorting.Controllers
{
	public class PDLController
	{
		public APDL PDL { get; set; }

		public PDLController(object pdl, Dictionary<string, double> kwargs, int n)
		{
			PDL = (APDL)pdl;
			PDL.n = n;
			foreach (var key in kwargs.Keys) 
				PDL.parameters[key] = kwargs[key];
			PDL.FillArr();
		}

		public PDLController(object pdl)
		{
			PDL = (APDL)pdl;
			PDL.parameters["A"] = PDL.rnd.NextDouble() * 100;
			PDL.parameters["B"] = PDL.rnd.NextDouble() * 100;
			PDL.parameters["C"] = PDL.rnd.NextDouble() * 100;
		}
	}
}
