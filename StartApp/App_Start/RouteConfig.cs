using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StartApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


           


            ////Searching
            //routes.MapRoute(
            //    name: "Arama",
            //    url: "arama",
            //    defaults: new { controller = "Home", action = "Searching" }
            //);

            ////Account
            //routes.MapRoute(
            //    name: "Account",
            //    url: "hesabim",
            //    defaults: new { controller = "Home", action = "Account" }
            //);

            ////CartList
            //routes.MapRoute(
            //    name: "Cart",
            //    url: "sepet",
            //    defaults: new { controller = "Home", action = "CartList" }
            //);

            ////CartList
            //routes.MapRoute(
            //    name: "Payment",
            //    url: "odeme",
            //    defaults: new { controller = "Home", action = "Payment" }
            //);

            ////Searching
            //routes.MapRoute(
            //    name: "AramaLang",
            //    url: "{language}/arama",
            //    defaults: new { controller = "Home", action = "Searching" }
            //);

            ////AllCategories
            //routes.MapRoute(
            //    name: "AllCategories",
            //    url: "tum-kategoriler",
            //    defaults: new { controller = "Home", action = "CategoryList" }
            //);
            ////AllCategories
            //routes.MapRoute(
            //    name: "AllCategoriesLang",
            //    url: "{language}/tum-kategoriler",
            //    defaults: new { controller = "Home", action = "CategoryList" }
            //);


            ////Confirm
            //routes.MapRoute(
            //    name: "KayitOnay",
            //    url: "kayit-onay",
            //    defaults: new { controller = "Home", action = "RegisterConfirm"}
            //);

            ////Confirm
            //routes.MapRoute(
            //    name: "KayitOnayLang",
            //    url: "{language}/kayit-onay",
            //    defaults: new { controller = "Home", action = "RegisterConfirm" }
            //);

            ////Blog Details
            //routes.MapRoute(
            //    name: "BlogDetails",
            //    url: "blog/{Details}-{ID}",
            //    defaults: new { controller = "Blog", action = "Details", ID = "" }
            //);

            ////Blog Category
            //routes.MapRoute(
            //    name: "BlogCategory",
            //    url: "blog/category/{Category}-{ID}",
            //    defaults: new { controller = "Blog", action = "Category", ID = "" }
            //);

            ////Page
            //routes.MapRoute(
            //    name: "Page",
            //    url: "sayfa/{SeoUrl}-{ID}",
            //    defaults: new { controller = "Home", action = "Page", SeoUrl = "", ID = "" }
            //);

            ////Login
            //routes.MapRoute(
            //    name: "login",
            //    url: "giris",
            //    defaults: new { controller = "Home", action = "Login"}
            //);

            ////About
            //routes.MapRoute(
            //    name: "AboutLang",
            //    url: "{language}/bilgilerimiz/{SeoUrl}-{PageID}",
            //    defaults: new { controller = "Home", action = "About", SeoUrl = "", PageID = "" }
            //);


            ////Category Details
            //routes.MapRoute(
            //    name: "Category",
            //    url: "category/{CategoryTitle}-{ID}",
            //    defaults: new { controller = "Home", action = "Categories", ID = "", CategoryTitle = "" }
            //);
            ////Product Details
            //routes.MapRoute(
            //    name: "ProductsDetails",
            //    url: "{CategoryTitle}/{SeoUrl}-{ID}",
            //    defaults: new { controller = "Home", action = "ProductDetails", SeoUrl = "", ID = "", CategoryTitle = "" }
            //);

            //General
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "ProductManage", id = UrlParameter.Optional }
            );

        }
    }
}
