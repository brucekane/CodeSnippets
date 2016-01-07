﻿namespace Dixin.Linq.LinqToEntities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProductCategory
    {
        public ICollection<ProductSubcategory> ProductSubcategories { get; } = new HashSet<ProductSubcategory>();
    }

    public partial class ProductSubcategory
    {
        public int? ProductCategoryID { get; set; }

        public ProductCategory ProductCategory { get; set; }
    }

    public partial class ProductSubcategory
    {
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }

    public partial class Product
    {
        public ProductSubcategory ProductSubcategory { get; set; }

        public int? ProductSubcategoryID { get; set; }
    }

    [Table(nameof(ProductProductPhoto), Schema = AdventureWorksDbContext.Production)]
    public partial class ProductProductPhoto
    {
    }

    public partial class Product
    {
        public ICollection<ProductProductPhoto> ProductProductPhotos { get; } = new HashSet<ProductProductPhoto>();
    }

    public partial class ProductPhoto
    {
        public ICollection<ProductProductPhoto> ProductProductPhotos { get; } = new HashSet<ProductProductPhoto>();
    }

    public partial class ProductProductPhoto
    {
        public Product Product { get; set; }

        [Key]
        [Column(Order = 0)]
        public int ProductID { get; set; }

        public ProductPhoto ProductPhoto { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ProductPhotoID { get; set; }
    }
}