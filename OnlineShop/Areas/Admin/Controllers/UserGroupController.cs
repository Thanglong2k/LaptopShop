using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class UserGroupController : Controller
    {
        // GET: Admin/UserGroup
        public ActionResult Index()
        {
            var dao = new UserGroupDao();
            var model = dao.ListAllPaging();
            return View(model);
        }
    }
}