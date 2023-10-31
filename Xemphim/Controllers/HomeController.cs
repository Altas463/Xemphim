using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xemphim.Models;

namespace Xemphim.Controllers
{
    public class HomeController : Controller
    {
        XemPhimEntities databse = new XemPhimEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Trailer()
        {

            return View();
        }
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult TrangChu(int? page)
        {
            using (var dbContext = new XemPhimEntities())
            {
                var items = dbContext.Phims.OrderBy(p => p.IdPhim);
                int pageSize = 4;
                int pageNumber = (page ?? 1);
                return View(items.ToPagedList(pageNumber, pageSize));
            }
        }
        public ActionResult NewMovie()
        {
            return View();

        }
        public ActionResult DangNhap()
        {
            return View();

        }
        public ActionResult ChiTietPhim(int Id)
        {
            var Phim = databse.Phims.FirstOrDefault(s => s.IdPhim == Id);
            return View(Phim);
        }
        public ActionResult XemPhim(int Id)
        {
            var Phim = databse.Phims.FirstOrDefault(s => s.IdPhim == Id);
            return View(Phim);
        }
        [HttpPost]
        public ActionResult TimKiemTheLoai(string theLoai, int? page)
        {
            var phimTheoTheLoai = databse.Phims.Where(p => p.TheLoai == theLoai).OrderBy(p => p.IdPhim);
            int pageSize = 4;
            int pageNumber = (page ?? 1);
            return View("TrangChu", phimTheoTheLoai.ToPagedList(pageNumber, pageSize));
        }
    }
}