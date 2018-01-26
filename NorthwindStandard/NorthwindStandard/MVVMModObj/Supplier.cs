// <auto-generated>
using GalaSoft.MvvmLight;
using NorWnd.Xam.ModelObj;

namespace NorWnd.Xam.ModelObj.NW
{
	public partial class Supplier : ObservableObject
	{
		private string _address;
		private string _city;
		private string _companyName;
		private string _contactName;
		private string _contactTitle;
		private string _country;
		private string _fax;
		private string? _homePage;
		private string _phone;
		private string _postalCode;
		private string _region;
		private int _supplierID;


		public string Address
		{
			get { return _address; }
			set { Set<string>(() => Address, ref _address, value); }
		}

		public string City
		{
			get { return _city; }
			set { Set<string>(() => City, ref _city, value); }
		}

		public string CompanyName
		{
			get { return _companyName; }
			set { Set<string>(() => CompanyName, ref _companyName, value); }
		}

		public string ContactName
		{
			get { return _contactName; }
			set { Set<string>(() => ContactName, ref _contactName, value); }
		}

		public string ContactTitle
		{
			get { return _contactTitle; }
			set { Set<string>(() => ContactTitle, ref _contactTitle, value); }
		}

		public string Country
		{
			get { return _country; }
			set { Set<string>(() => Country, ref _country, value); }
		}

		public string Fax
		{
			get { return _fax; }
			set { Set<string>(() => Fax, ref _fax, value); }
		}

		public string? HomePage
		{
			get { return _homePage; }
			set { Set<string?>(() => HomePage, ref _homePage, value); }
		}

		public string Phone
		{
			get { return _phone; }
			set { Set<string>(() => Phone, ref _phone, value); }
		}

		public string PostalCode
		{
			get { return _postalCode; }
			set { Set<string>(() => PostalCode, ref _postalCode, value); }
		}

		public string Region
		{
			get { return _region; }
			set { Set<string>(() => Region, ref _region, value); }
		}

		public int SupplierID
		{
			get { return _supplierID; }
			set { Set<int>(() => SupplierID, ref _supplierID, value); }
		}

		public virtual System.Collections.Generic.ICollection<Products> Products { get; set; } // Many to many mapping
		public Supplier()
		{
			Products = new System.Collections.Generic.List<Products>();

			InitializePartial();
		}

		partial void InitializePartial();
	}
}
