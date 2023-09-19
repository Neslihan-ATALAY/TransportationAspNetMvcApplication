using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TransportationMvc2Project.Models;

//
// Neslihan ATALAY
namespace TransportationMvc2Project.Controllers
{
    public class CompanyController : Controller
    {
        public CompanyService CompanyService { get; set; }
        public TransportService TransportService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (CompanyService == null)
            {
                CompanyService = new CompanyService();
            }
            if (TransportService == null)
            {
                TransportService = new TransportService();
            }
            base.Initialize(requestContext);
        }

        //
        // GET: /Company/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Company/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Company/Create

        public ActionResult CreateCompany()
        {
            CompanyModel CompanyFormModel = new CompanyModel();
            CompanyFormModel.Address = new AddressModel();
            ViewData["CityList"] = TransportService.GetCityList();
            return View(CompanyFormModel);
        }

        //
        // POST: /Company/Create

        [HttpPost]
        public ActionResult CreateCompany(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CompanyModel CompanyFormModel = new CompanyModel();
                    CompanyFormModel.Address = new AddressModel();
                    ViewData["CityList"] = TransportService.GetCityList();
                    try
                    {
                        CompanyFormModel.Name = collection.Get("Name");
                        CompanyFormModel.Owner = collection.Get("Owner");
                        CompanyFormModel.Telephone = collection.Get("Telephone");
                        CompanyFormModel.Fax = collection.Get("Fax");
                        CompanyFormModel.Email = collection.Get("Email");
                        CompanyFormModel.Address = new AddressModel();
                        CompanyFormModel.Address.City = new CityModel();
                        CompanyFormModel.Address.City.Id = Convert.ToInt32(collection.Get(5));
                        CompanyFormModel.Address.CityId = Convert.ToInt32(collection.Get(5));
                        CompanyFormModel.Address.Town = collection.Get("Address.Town");
                        CompanyFormModel.Address.Neighbourhood = collection.Get("Address.Neighbourhood");
                        CompanyFormModel.Address.Street = collection.Get("Address.Street");
                        CompanyFormModel.Address.HomeStreet = collection.Get("Address.HomeStreet");
                        CompanyFormModel.Address.BuildingNo = Convert.ToInt32(collection.Get("Address.BuildingNo"));
                        CompanyFormModel.Address.InnerDoorNo = Convert.ToInt32(collection.Get("Address.InnerDoorNo"));
                        CompanyFormModel.EstablishmentDate = Convert.ToDateTime(collection.Get("EstablishmentDate"));
                        CompanyService.AddCompany(CompanyFormModel);
                        return RedirectToAction("CreateCompany", "Company");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(CompanyFormModel);
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        
        //
        // GET: /Company/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Company/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Company/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Company/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
