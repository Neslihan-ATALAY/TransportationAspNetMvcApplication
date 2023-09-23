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
    public class TransportController : Controller
    {
        public TransportContext TransportContext { get; set; }
        public TransportService TransportService { get; set; }
        public CompanyService CompanyService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (TransportContext == null)
            {
                TransportContext = new TransportContext();
            }
            if (TransportService == null)
            {
                TransportService = new TransportService();
            }
            if (CompanyService == null)
            {
                CompanyService = new CompanyService();
            }
            base.Initialize(requestContext);
        }

        //
        // GET: /Transport/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Transport/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Transport/CreateTransport

        [Authorize(Roles = "KULLANICI")]
        public ActionResult CreateTransport()
        {
            ApplicationModel transportModel = new ApplicationModel();
            transportModel.User = new UserModel();
            transportModel.TransportType = new TransportTypeModel();
            ViewData["CityList"] = TransportService.GetCityList();
            ViewData["UserList"] = TransportService.GetUserList();
            ViewData["TransportTypeList"] = TransportService.GetTransportTypeList();
            ViewData["VehicleList"] = CompanyService.GetVehicleList();
            return View(transportModel);
        }

        //
        // POST: /Transport/CreateTransport

        [HttpPost]
        [Authorize(Roles = "KULLANICI")]
        public ActionResult CreateTransport(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ApplicationModel transportFormModel = new ApplicationModel();
                    ApplicationVehicleModel transportVehicleFormModel = new ApplicationVehicleModel();
                    ViewData["CityList"] = TransportService.GetCityList();
                    ViewData["UserList"] = TransportService.GetUserList();
                    ViewData["TransportTypeList"] = TransportService.GetTransportTypeList();
                    ViewData["VehicleList"] = CompanyService.GetVehicleList();
                    var result = 0;
                    try
                    {
                        transportFormModel.User = new UserModel();
                        transportFormModel.User.Id = Convert.ToInt32(collection.Get(0));
                        transportFormModel.UserId = Convert.ToInt32(collection.Get(0));
                        transportFormModel.TransportType = new TransportTypeModel();
                        transportFormModel.TransportType.Id = Convert.ToInt32(collection.Get(1));
                        transportFormModel.TransportTypeId = Convert.ToInt32(collection.Get(1));
                        transportFormModel.TransportDate = Convert.ToDateTime(collection.Get("TransportDate"));
                        transportFormModel.Weight = Convert.ToDecimal(collection.Get("Weight"));
                        transportFormModel.Distance = Convert.ToDecimal(collection.Get("Distance"));

                        transportFormModel.Departure = new AddressModel();
                        transportFormModel.Departure.City = new CityModel();
                        transportFormModel.Departure.City.Id = Convert.ToInt32(collection.Get(6));
                        transportFormModel.Departure.CityId = Convert.ToInt32(collection.Get(6));
                        transportFormModel.Departure.Town = collection.Get("Departure.Town");
                        transportFormModel.Departure.Neighbourhood = collection.Get("Departure.Neighbourhood");
                        transportFormModel.Departure.Street = collection.Get("Departure.Street");
                        transportFormModel.Departure.HomeStreet = collection.Get("Departure.HomeStreet");
                        transportFormModel.Departure.BuildingNo = Convert.ToInt32(collection.Get("Departure.BuildingNo"));
                        transportFormModel.Departure.InnerDoorNo = Convert.ToInt32(collection.Get("Departure.InnerDoorNo"));

                        transportFormModel.Destination = new AddressModel();
                        transportFormModel.Destination.City = new CityModel();
                        transportFormModel.Destination.City.Id = Convert.ToInt32(collection.Get(13));
                        transportFormModel.Destination.CityId = Convert.ToInt32(collection.Get(13));
                        transportFormModel.Destination.Town = collection.Get("Destination.Town");
                        transportFormModel.Destination.Neighbourhood = collection.Get("Destination.Neighbourhood");
                        transportFormModel.Destination.Street = collection.Get("Destination.Street");
                        transportFormModel.Destination.HomeStreet = collection.Get("Destination.HomeStreet");
                        transportFormModel.Destination.BuildingNo = Convert.ToInt32(collection.Get("Destination.BuildingNo"));
                        transportFormModel.Destination.InnerDoorNo = Convert.ToInt32(collection.Get("Destination.InnerDoorNo"));
                        transportFormModel = TransportService.AddTransport(transportFormModel);

                        transportVehicleFormModel.Application = transportFormModel;
                        transportVehicleFormModel.ApplicationId = transportFormModel.Id;
                        List<string> vehicles = collection.Get(2).Split(',').ToList();
                        foreach (string vehicle in vehicles)
                        {
                            transportVehicleFormModel.Vehicle = new VehicleModel();
                            transportVehicleFormModel.Vehicle.Id = Convert.ToInt32(vehicle);
                            transportVehicleFormModel.VehicleId = Convert.ToInt32(vehicle);
                            transportVehicleFormModel.Driver = new EmployeeModel();
                            result = TransportService.AddTransportVehicle(transportVehicleFormModel);
                        }
                        return RedirectToAction("CreateTransport", "Transport");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(transportFormModel);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.InnerException.Message);
                }
            }
            return View();
        }

        
        //
        // GET: /Transport/CreateAddress

        public ActionResult CreateAddress()
        {
            ViewData["CityList"] = TransportService.GetCityList();
            return View();
        }

        //
        // POST: /Transport/CreateAddress

        [HttpPost]
        public ActionResult CreateAddress(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ViewData["CityList"] = TransportService.GetCityList();
                    try
                    {
                        AddressModel AddressFormModel = new AddressModel();
                        AddressFormModel.CityId = Convert.ToInt32(collection.Get(0));
                        AddressFormModel.Town = collection.Get("Town");
                        AddressFormModel.Neighbourhood = collection.Get("Neighbourhood");
                        AddressFormModel.Street = collection.Get("Street");
                        AddressFormModel.HomeStreet = collection.Get("HomeStreet");
                        AddressFormModel.BuildingNo = Convert.ToInt32(collection.Get("BuildingNo"));
                        AddressFormModel.InnerDoorNo = Convert.ToInt32(collection.Get("InnerDoorNo"));
                        TransportService.AddAddress(AddressFormModel);
                        return View(AddressFormModel);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View();
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        
        //
        // GET: /Transport/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Transport/Edit/5

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
        // GET: /Transport/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Transport/Delete/5

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
