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
            return View();
        }
        [HttpPost]
        public ActionResult Entry(Organization organization)
        
        {
            //if (!string.IsNullOrEmpty(organization.Name) && organization.ContactNo > 0)
            if (ModelState.IsValid)
            {
                _organizationManager.Add(organization);
            }
            return View();
        }
	}
}