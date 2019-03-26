using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StartApp.Models;
using PagedList;
using PagedList.Mvc;


namespace StartApp.Business
{
    public class cProducts
    {


        public List<ProductsDemo> AllList()
        {
            using (var cnn = new startAppDBsEntities())
            {
                List<ProductsDemo> pList = cnn.ProductsDemo.OrderByDescending(x => x.ID).ToList();
                return pList;
            }
        }

        public int Add(ProductsDemo Product)
        {

            using (var cnn = new startAppDBsEntities())
            {
                cnn.ProductsDemo.Add(Product);
                return cnn.SaveChanges();
            }
        }

        public int Update(ProductsDemo Product)
        {
            ProductsDemo UpdateItem = new ProductsDemo();
            int Status = 0;
            using (var cnn = new startAppDBsEntities())
            {
                UpdateItem = cnn.ProductsDemo.Where(x => x.ID == Product.ID).FirstOrDefault();
                if (UpdateItem != null)
                {
                    UpdateItem.BoxQuantity = Product.BoxQuantity;
                    UpdateItem.CategoryID = Product.CategoryID;
                    UpdateItem.CategoryTitle = Product.CategoryTitle;
                    UpdateItem.Description = Product.Description;
                    UpdateItem.Details = Product.Details;
                    UpdateItem.MainImage = Product.MainImage;
                    UpdateItem.Price = Product.Price;
                    UpdateItem.Status = Product.Status;
                    UpdateItem.StockCode = Product.StockCode;
                    UpdateItem.Title = Product.Title;
                    UpdateItem.Special = Product.Special;
                    UpdateItem.Discount = Product.Discount;
                    UpdateItem.CostPrice = Product.CostPrice;
                    UpdateItem.Percentage = Product.Percentage;
                    UpdateItem.MinOrder = Product.MinOrder;
                    UpdateItem.SeoUrl = "0";
                    UpdateItem.ListNumber = Product.ListNumber;
                    UpdateItem.ManufacturerName = Product.ManufacturerName;
                    cnn.SaveChanges();
                    Status = 1;
                }

            }
            return Status;
        }
        public int Delete(int ID)
        {
            int Status = 0;
            using (var cnn = new startAppDBsEntities())
            {
                ProductsDemo DeleteItem = new ProductsDemo();
                DeleteItem = cnn.ProductsDemo.Where(x => x.ID == ID).FirstOrDefault();
                if (DeleteItem != null)
                {
                    cnn.ProductsDemo.Remove(DeleteItem);
                    Status = cnn.SaveChanges();
                }
                return Status;
            }
        }

        public ProductsDemo Details(int ID)
        {
            using (var cnn = new startAppDBsEntities())
            {
                ProductsDemo pDetails = cnn.ProductsDemo.Where(x => x.ID == ID).FirstOrDefault();
                return pDetails;
            }
        }
    }

}
