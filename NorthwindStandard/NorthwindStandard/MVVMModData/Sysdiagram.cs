// <auto-generated>
using SQLite;
using NorWnd.Xam.ModelData;

namespace NorWnd.Xam.ModelData.NW
{
	[Table("sysdiagrams")]
	public partial class Sysdiagram
	{
		public byte[] definition { get; set; }

		[PrimaryKey]
		public int diagram_id { get; set; }

		public string name { get; set; }
		public int principal_id { get; set; }
		public int? version { get; set; }
	}
}
