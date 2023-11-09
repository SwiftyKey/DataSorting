using System.Data.SqlClient;

namespace DataSorting.Models.DB
{
	public class Coef
	{
		public int Id { get; set; }
		public double A0 { get; set; }
		public double A1 { get; set; }
		public double CoefCor {  get; set; }
		public double CoefDeterm { get; set; }
		public double CoefEl { get; set; }
		public double BetaCoef { get; set; }
		public double RecordId { get; set; }
	}
}
