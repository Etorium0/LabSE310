using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext("Data Source=DESKTOP-A613PHH;Initial Catalog=QuanLySanPham;User ID=sa;Password=123;Trust Server Certificate=True");
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}