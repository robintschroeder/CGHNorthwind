// <auto-generated>
using GalaSoft.MvvmLight;
using NorWnd.Xam.ModelObj;

namespace NorWnd.Xam.ModelObj.NW
{
	public partial class Region : ObservableObject
	{
		private string _regionDescription;
		private int _regionID;


		public string RegionDescription
		{
			get { return _regionDescription; }
			set { Set<string>(() => RegionDescription, ref _regionDescription, value); }
		}

		public int RegionID
		{
			get { return _regionID; }
			set { Set<int>(() => RegionID, ref _regionID, value); }
		}

		public virtual System.Collections.Generic.ICollection<Territories> Territories { get; set; } // Many to many mapping
		public Region()
		{
			Territories = new System.Collections.Generic.List<Territories>();

			InitializePartial();
		}

		partial void InitializePartial();
	}
}