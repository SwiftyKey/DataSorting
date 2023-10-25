using System;
using System.Collections.Generic;

namespace DataSorting.Models
{
	public abstract class APDL
	{
		public abstract int n { get; set; }
		public abstract float[] arr { get; set; }
		public abstract int randMax { get; set; }
		public abstract Random rnd { get; set; }
		public Dictionary<string, float> parameters { get; set; }
		public abstract float GenValue();
		public abstract void FillArr();
	}

	public class Fisk : APDL
	{
		public override int n { get; set; }
		public override float[] arr { get; set; }
		public override int randMax { get; set; }
		public override Random rnd { get; set; }

		public float A { get; set; }

		float b;
		public float B
		{
			get { return b; }
			set
			{
				if (value <= 0)
					throw new ArgumentException(nameof(b) + " должно быть > 0", nameof(b));
				b = value;
			}
		}

		float c;
		public float C
		{
			get { return c; }
			set
			{
				if ((value <= 0) || (value > 100))
					throw new ArgumentException(nameof(c) + " должно быть > 0 и <= 100", nameof(c));
				c = value;
			}
		}

		public Fisk() {
			randMax = 32767;
			rnd = new Random();
			parameters = new Dictionary<string, float>();
		}

		public override float GenValue()
		{
			float randomNumber = (float)rnd.Next(randMax) / randMax;
			float fiskValue = A + B / (float)Math.Pow(1.0 / randomNumber - 1, 1.0 / C);
			return fiskValue;
		}

		public override void FillArr()
		{
			A = parameters[nameof(A)];
			B = parameters[nameof(B)];
			C = parameters[nameof(C)];
			arr = new float[n];
			for (int i = 0; i < n; i++)
				arr[i] = GenValue();
		}
	}
}
