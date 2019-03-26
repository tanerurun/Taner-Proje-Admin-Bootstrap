using StartApp.Business;
using StartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            AdminView Model = new AdminView();

            return View(Model);
        }
       
        public ActionResult ProductManage(string DelID)
        {

            cProducts Products = new cProducts();
            AdminView Model = new AdminView();

            int Status;
            if (!String.IsNullOrEmpty(DelID))
            {
                int ID = Convert.ToInt32(DelID);
                Status = Products.Delete(ID);
            }

            Model.Products = Products.AllList();
            return View(Model);
        }
        public ActionResult ProductAdd()
        {
            AdminView Model = new AdminView();
            return View(Model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ProductAdd(AdminView Model, HttpPostedFileBase file, string ckeditor, string ckeditorEng)
        {

            cProducts cProduct = new cProducts();

            Model.ProductDetails.Details = ckeditor;
            Model.ProductDetails.DetailsEng = ckeditorEng;
            Model.ProductDetails.CategoryTitle = "Burayı Güncelle";
            Model.ProductDetails.Status = 1;
            int Status = cProduct.Add(Model.ProductDetails);
            if (Status == 1)
            {
                ViewBag.Result = "Başarıyla Eklend!";
                ViewBag.Status = "success";
            }
            else
            {
                ViewBag.Result = "Ekleme Başarısız!";
                ViewBag.Status = "error";
            }

            return View();
        }
        public ActionResult ProductUpdate(string ProductID)
        {
            AdminView Model = new AdminView();
            cProducts Product = new cProducts();
            if (!String.IsNullOrEmpty(ProductID))
            {
                int ProductIDs = Convert.ToInt32(ProductID);
                Model.ProductDetails = Product.Details(ProductIDs);
            }
            else
            {
                Response.Redirect("~/Admin/");
            }

            return View(Model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ProductUpdate(AdminView Model, string ckeditor)
        {

            cProducts Product = new cProducts();
            int Result = Product.Update(Model.ProductDetails);
            if (Result > 0)
            {
                ViewBag.Result = "Başarıyla Güncellendi!";
                ViewBag.Status = "success";
            }
            else
            {
                ViewBag.Result = "Güncelleme Başarısız!";
                ViewBag.Status = "error";
            }
            return View(Model);
        }


    }
}