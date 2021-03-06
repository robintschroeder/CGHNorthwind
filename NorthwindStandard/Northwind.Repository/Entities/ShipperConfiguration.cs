// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Northwind.Repository.Entities
{

    // Shippers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class ShipperConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shipper>
    {
        public ShipperConfiguration()
            : this("dbo")
        {
        }

        public ShipperConfiguration(string schema)
        {
            ToTable("Shippers", schema);
            HasKey(x => x.ShipperId);

            Property(x => x.ShipperId).HasColumnName(@"ShipperID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(24);
        }
    }

}
// </auto-generated>
