using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace OnlineExam_MsPro.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationManager _organizationManager = new OrganizationManager();

        [HttpGet]
        public ActionResult Entry()
        {  
            ModelState.AddModelError("","There is an unknown error occured");
            return View();
        }
        [HttpPost]
        public ActionResult Entry(Organization organization)
        
        {
            //if (!string.IsNullOrEmpty(organization.Name) && organization.ContactNo > 0)
            if (ModelState.IsValid)
            {
               bool isAdded =  _organizationManager.Add(organization);
                if (isAdded)
                {
                    //ViewData["Organization"] = organization;
                    ViewBag.Organization = organization;
                   // return RedirectToAction("Information");
                    return View("information");
                }
            }
            return View();
        }

        public ActionResult Information()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
	}
}