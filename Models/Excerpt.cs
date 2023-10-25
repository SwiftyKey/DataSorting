using DataSorting.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSorting.Models
{
	public class Excerpt
	{
		private PDLController pdlController;
		private SortController sortController;

		public int[,] Arr { get; set; }
		public double[][] Equations { get; set; }
		public double A0 { get; set; }
		public double A1 { get; set; }
		public double CoefCor {  get; set; }
		public double CoefDeterm {  get; set; }
		public double CoefEl { get; set; }
		public double BetaCoef { get; set; }

		public Excerpt(int m, PDLController pdlController, SortController sortController)
		{
			Arr = new int[m, 4];
			Equations = new double[2][];
			this.pdlController = pdlController;
			this.sortController = sortController;
		}

		public void Calculate() {
			Random rnd = new Random();

			Equations[0][0] = Arr.Length;
			Equations[0] = new double[3];
			Equations[1] = new double[3];

			for (int i = 0; i < Arr.Length; i++)
			{
				pdlController.PDL.n = rnd.Next(9000, 50000);
				pdlController.PDL.FillArr();
				sortController.Sort.Sort(pdlController.PDL.arr);

				Arr[i, 0] = (int)sortController.Sort.Indicators.Item3;
				Arr[i, 1] = pdlController.PDL.n;
				Arr[i, 2] = Arr[i, 1] * Arr[i, 1];
				Arr[i, 3] = Arr[i, 0] * Arr[i, 1];

				Equations[0][1] += Arr[i, 1];
				Equations[0][2] += Arr[i, 0];

				Equations[1][0] += Arr[i, 1];
				Equations[1][1] += Arr[i, 2];
				Equations[1][2] += Arr[i, 3];
			}

			double[] result = Gauss(Equations);
			A0 = result[0];
			A1 = result[1];
		}

		private double[] Gauss(double[][] rows)
		{
			int length = 3;
			for (int j = 0; j < 2; j++)
			{
				double[] d = new double[length];
				for (int x = 0; x < length; x++)
				{
					d[x] = rows[j][x];
					if (rows[j][0] != 0)
						d[x] = d[x] / rows[j][0];
				}
				rows[j] = d;
			}

			double[] f = new double[length];
			for (int g = 0; g < length; g++)
			{
				f[g] = rows[1][g];
				if (rows[1][0] != 0)
					f[g] = f[g] - rows[0][g];
			}
			rows[1] = f;

			return CalculateResult(rows);
		}

		private double[] CalculateResult(double[][] rows)
		{
			double[] result = new double[2];

			for (int i = 1; i >= 0; i--)
			{
				double val = rows[i][2];
				for (int x = 1; x > i - 1; x--)
					val -= rows[i][x] * result[x];
				result[i] = val / rows[i][i];
			}
			return result;
		}
	}
}
