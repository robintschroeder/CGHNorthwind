// <auto-generated>
using GalaSoft.MvvmLight;
using NorWnd.Xam.ModelObj;

namespace NorWnd.Xam.ModelObj.NW
{
	public partial class Order : ObservableObject
	{
		private string _customerID;
		private int? _employeeID;
		private int _orderID;
		private string _shipAddress;
		private string _shipCity;
		private string _shipCountry;
		private string _shipName;
		private string _shipPostalCode;
		private string _shipRegion;
		private int? _shipVia;


		public string CustomerID
		{
			get { return _customerID; }
			set { Set<string>(() => CustomerID, ref _customerID, value); }
		}

		public int? EmployeeID
		{
			get { return _employeeID; }
			set { Set<int?>(() => EmployeeID, ref _employeeID, value); }
		}

		public int OrderID
		{
			get { return _orderID; }
			set { Set<int>(() => OrderID, ref _orderID, value); }
		}

		public string ShipAddress
		{
			get { return _shipAddress; }
			set { Set<string>(() => ShipAddress, ref _shipAddress, value); }
		}

		public string ShipCity
		{
			get { return _shipCity; }
			set { Set<string>(() => ShipCity, ref _shipCity, value); }
		}

		public string ShipCountry
		{
			get { return _shipCountry; }
			set { Set<string>(() => ShipCountry, ref _shipCountry, value); }
		}

		public string ShipName
		{
			get { return _shipName; }
			set { Set<string>(() => ShipName, ref _shipName, value); }
		}

		public string ShipPostalCode
		{
			get { return _shipPostalCode; }
			set { Set<string>(() => ShipPostalCode, ref _shipPostalCode, value); }
		}

		public string ShipRegion
		{
			get { return _shipRegion; }
			set { Set<string>(() => ShipRegion, ref _shipRegion, value); }
		}

		public int? ShipVia
		{
			get { return _shipVia; }
			set { Set<int?>(() => ShipVia, ref _shipVia, value); }
		}

		public virtual System.Collections.Generic.ICollection<Order Details> Order Details { get; set; } // Many to many mapping
		public virtual Customers Customers { get; set; } 
		public virtual Employees Employees { get; set; } 
		public virtual Shippers Shippers { get; set; } 
		public Order()
		{
			Order Details = new System.Collections.Generic.List<Order Details>();

			InitializePartial();
		}

		partial void InitializePartial();
	}
}