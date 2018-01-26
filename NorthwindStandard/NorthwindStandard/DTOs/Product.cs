// <auto-generated>
namespace NorWnd.DTO.NW
{
	public partial class Product
	{

		public int ProductID { get; set; } // Primary key
		public string ProductName { get; set; }
		public int? SupplierID { get; set; }
		public int? CategoryID { get; set; }
		public string QuantityPerUnit { get; set; }
		public Unknown money? UnitPrice { get; set; }
		public short? UnitsInStock { get; set; }
		public short? UnitsOnOrder { get; set; }
		public short? ReorderLevel { get; set; }
		public bool Discontinued { get; set; }

	}
}