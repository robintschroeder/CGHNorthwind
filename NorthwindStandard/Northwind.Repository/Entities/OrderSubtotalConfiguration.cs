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

    // Order Subtotals
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class OrderSubtotalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrderSubtotal>
    {
        public OrderSubtotalConfiguration()
            : this("dbo")
        {
        }

        public OrderSubtotalConfiguration(string schema)
        {
            ToTable("Order Subtotals", schema);
            HasKey(x => x.OrderId);

            Property(x => x.OrderId).HasColumnName(@"OrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Subtotal).HasColumnName(@"Subtotal").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
