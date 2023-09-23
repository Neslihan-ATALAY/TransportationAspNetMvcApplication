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
    public class VehicleController : Controller
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
        // GET: /Vehicle/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Vehicle/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vehicle/Create

        [Authorize(Roles = "ŞİRKET")]
        public ActionResult CreateVehicle()
        {
            VehicleModel VehicleFormModel = new VehicleModel();
            VehicleFormModel.VehicleType = new VehicleTypeModel();
            VehicleFormModel.Company = new CompanyModel();
            ViewData["TransportTypeList"] = CompanyService.GetTransportTypeList();
            ViewData["VehicleTypeList"] = CompanyService.GetVehicleTypeList();
            ViewData["CompanyList"] = CompanyService.GetCompanyList();
            return View(VehicleFormModel);
        }

        //
        // POST: /Vehicle/Create

        [HttpPost]
        [Authorize(Roles = "ŞİRKET")]
        public ActionResult CreateVehicle(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    VehicleModel VehicleFormModel = new VehicleModel();
                    VehicleFormModel.VehicleType = new VehicleTypeModel();
                    VehicleFormModel.Company = new CompanyModel();
                    ViewData["TransportTypeList"] = CompanyService.GetTransportTypeList();
                    ViewData["VehicleTypeList"] = CompanyService.GetVehicleTypeList();
                    ViewData["CompanyList"] = CompanyService.GetCompanyList();
                    try
                    {
                        VehicleFormModel.PlateNumber = collection.Get("PlateNumber");
                        VehicleFormModel.TransportType = new TransportTypeModel();
                        VehicleFormModel.TransportType.Id = Convert.ToInt32(collection.Get(1));
                        VehicleFormModel.TransportTypeId = Convert.ToInt32(collection.Get(1));
                        VehicleFormModel.VehicleType = new VehicleTypeModel();
                        VehicleFormModel.VehicleType.Id = Convert.ToInt32(collection.Get(2));
                        VehicleFormModel.VehicleTypeId = Convert.ToInt32(collection.Get(2));
                        VehicleFormModel.Company = new CompanyModel();
                        VehicleFormModel.Company.Id = Convert.ToInt32(collection.Get(3));
                        VehicleFormModel.CompanyId = Convert.ToInt32(collection.Get(3));
                        VehicleFormModel.WeightCapacity = Convert.ToDecimal(collection.Get("WeightCapacity"));
                        VehicleFormModel.UnitPrice = Convert.ToDecimal(collection.Get("UnitPrice"));
                        CompanyService.AddVehicle(VehicleFormModel);
                        return RedirectToAction("CreateVehicle", "Vehicle");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(VehicleFormModel);
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        
        //
        // GET: /Vehicle/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vehicle/Edit/5

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
        // GET: /Vehicle/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vehicle/Delete/5

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
