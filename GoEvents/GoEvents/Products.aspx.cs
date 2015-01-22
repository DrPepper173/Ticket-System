using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoEvents.Models;
using System.Web.ModelBinding;

namespace GoEvents
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new GoEvents.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new GoEvents.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.ProductID == categoryId);
            }
         
            return query;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }


    }
}