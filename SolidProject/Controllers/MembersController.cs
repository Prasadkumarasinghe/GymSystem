using AutoMapper;
using SolidProject.Entities.Models;
using SolidProject.Service.DTO;
using SolidProject.Service.Implementation;
using SolidProject.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SolidProject.Controllers
{
    public class MembersController : Controller
    {
        IMembersService _IMembersService;

        public MembersController(IMembersService _IMembersService)
        {
            this._IMembersService = _IMembersService;

        }

        // GET: Members
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SaveMember(MembersDTO memberModel)
        {
            try
            {
                var (isSaved, message) = _IMembersService.NewMember(memberModel);
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("Failed :" + ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        public async Task<JsonResult> GetMembersList()
        {
            var membersList = await _IMembersService.ListoFMembersAsync();
            return Json(membersList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteMember(int id)
        {
            (bool isDeleted, string message) = _IMembersService.DeleteMember(id);
            return Json(message, JsonRequestBehavior.AllowGet);

        }
    }
}