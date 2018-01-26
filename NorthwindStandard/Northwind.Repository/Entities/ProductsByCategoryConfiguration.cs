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

    // Products by Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class ProductsByCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductsByCategory>
    {
        public ProductsByCategoryConfiguration()
            : this("dbo")
        {
        }

        public ProductsByCategoryConfiguration(string schema)
        {
            ToTable("Products by Category", schema);
            HasKey(x => new { x.CategoryName, x.ProductName, x.Discontinued });

            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").HasColumnType("smallint").IsOptional();
            Property(x => x.Discontinued).HasColumnName(@"Discontinued").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
