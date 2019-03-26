using StartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartApp.Business
{
    public class cSlider
    {
        public List<Sliders> List()
        {
            using (var cnn = new startAppDBsEntities())
            {
                List<Sliders> sList = cnn.Sliders.Where(x => x.Status == 1).ToList();
                return sList;
            }
        }
        public Sliders Details(int ID)
        {
            using (var cnn = new startAppDBsEntities())
            {
                Sliders Details = cnn.Sliders.Where(x => x.ID == 1).FirstOrDefault();
                return Details;
            }
        }
        public int Update(Sliders Model)
        {
            using (var cnn = new startAppDBsEntities())
            {
                Sliders Update = cnn.Sliders.Where(x => x.ID == Model.ID).FirstOrDefault();
                Update.Description = Model.Description;
                Update.Image = Model.Image;
                Update.Status = Model.Status;
                Update.Title = Model.Title;
                Update.Url = Model.Url;
                return cnn.SaveChanges();
            }
        }
        public int Delete(int ID)
        {
            using (var cnn = new startAppDBsEntities())
            {
                Sliders DeleteItem = cnn.Sliders.Where(x => x.ID == ID).FirstOrDefault();
                cnn.Sliders.Remove(DeleteItem);
                return cnn.SaveChanges();
            }
        }
    }
}