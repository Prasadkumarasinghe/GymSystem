using SolidProject.Service.DTO;
using SolidProject.Service.Implementation;
using SolidProject.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolidProject.Controllers
{
    public class MembersController : Controller
    {
        IMembersService _IMembersService;

        public MembersController()
        {
            _IMembersService = new MembersService();
        }

        // GET: Members
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SaveMember(MembersDTO membersModel)
        {
            _IMembersService.NewMember(membersModel);
            return Json("Successs", JsonRequestBehavior.AllowGet);

        }
    }
}