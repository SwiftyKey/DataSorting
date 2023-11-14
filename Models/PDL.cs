using System;
using System.Collections.Generic;

namespace DataSorting.Models
{
	public abstract class APDL
	{
		public abstract int n { get; set; }
		public abstract double[] arr { get; set; }
		public abstract int randMax { get; set; }
		public abstract Random rnd { get; set; }
		public Dictionary<string, double> parameters { get; set; }
		public abstract double GenValue();
		public abstract void FillArr();
	}

	public class Fisk : APDL
	{
		public override int n { get; set; }
		public override double[] arr { get; set; }
		public override int randMax { get; set; }
		public override Random rnd { get; set; }

		public double A { get; set; }

		double b;
		public double B
		{
			get { return b; }
			set
			{
				if (value <= 0)
					throw new ArgumentException(nameof(b) + " должно быть > 0", nameof(b));
				b = value;
			}
		}

		double c;
		public double C
		{
			get { return c; }
			set
			{
				if ((value <= 0) || (value > 100))
					throw new ArgumentException(nameof(c) + " должно быть > 0 и <= 100", nameof(c));
				c = value;
			}
		}

		public Fisk()
		{
			randMax = 32767;
			rnd = new Random();
			parameters = new Dictionary<string, double>();
		}

		public override double GenValue()
		{
			double randomNumber = (double)rnd.Next(randMax) / randMax;
			double fiskValue = A + B / (double)Math.Pow(1.0 / randomNumber - 1, 1.0 / C);
			return fiskValue;
		}

		public override void FillArr()
		{
			A = parameters[nameof(A)];
			B = parameters[nameof(B)];
			C = parameters[nameof(C)];
			arr = new double[n];
			for (int i = 0; i < n; i++)
				arr[i] = GenValue();
		}
	}
}
