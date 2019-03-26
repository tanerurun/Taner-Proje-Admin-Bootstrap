using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace StartApp.Models
{
    public class AdminView
    {
        public ProductsDemo ProductDetails { get; set; }
        public List<ProductsDemo> Products { get; set; }

    }
}