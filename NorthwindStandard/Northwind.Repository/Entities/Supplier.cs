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

    // Suppliers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class Supplier
    {
        public int SupplierId { get; set; } // SupplierID (Primary key)
        public string CompanyName { get; set; } // CompanyName (length: 40)
        public string ContactName { get; set; } // ContactName (length: 30)
        public string ContactTitle { get; set; } // ContactTitle (length: 30)
        public string Address { get; set; } // Address (length: 60)
        public string City { get; set; } // City (length: 15)
        public string Region { get; set; } // Region (length: 15)
        public string PostalCode { get; set; } // PostalCode (length: 10)
        public string Country { get; set; } // Country (length: 15)
        public string Phone { get; set; } // Phone (length: 24)
        public string Fax { get; set; } // Fax (length: 24)
        public string HomePage { get; set; } // HomePage (length: 1073741823)

        // Reverse navigation

        /// <summary>
        /// Child Products where [Products].[SupplierID] point to this entity (FK_Products_Suppliers)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Product> Products { get; set; } // Products.FK_Products_Suppliers

        public Supplier()
        {
            Products = new System.Collections.Generic.List<Product>();
        }
    }

}
// </auto-generated>
