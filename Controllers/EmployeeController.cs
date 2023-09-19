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
    public class EmployeeController : Controller
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
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Employee/Create

        public ActionResult CreateEmployee()
        {
            EmployeeModel EmployeeFormModel = new EmployeeModel();
            EmployeeFormModel.Address = new AddressModel();
            EmployeeFormModel.Company = new CompanyModel();
            ViewData["CompanyList"] = CompanyService.GetCompanyList();
            ViewData["EmployeeTypeList"] = CompanyService.GetEmployeeTypeList();
            ViewData["CityList"] = TransportService.GetCityList();
            return View(EmployeeFormModel);
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult CreateEmployee(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeModel EmployeeFormModel = new EmployeeModel();
                    EmployeeFormModel.Address = new AddressModel();
                    EmployeeFormModel.Company = new CompanyModel();
                    ViewData["CompanyList"] = CompanyService.GetCompanyList();
                    ViewData["EmployeeTypeList"] = CompanyService.GetEmployeeTypeList();
                    ViewData["CityList"] = TransportService.GetCityList();
                    try
                    {
                        EmployeeFormModel.Name = collection.Get("Name");
                        EmployeeFormModel.Surname = collection.Get("Surname");
                        EmployeeFormModel.IdentityNumber = collection.Get("IdentityNumber");
                        EmployeeFormModel.Telephone = collection.Get("Telephone");
                        EmployeeFormModel.Email = collection.Get("Email");
                        EmployeeFormModel.Gender = Convert.ToChar(collection.Get("Gender"));
                        EmployeeFormModel.BirthDate = Convert.ToDateTime(collection.Get("BirthDate"));
                        EmployeeFormModel.Address = new AddressModel();
                        EmployeeFormModel.Address.City = new CityModel();
                        EmployeeFormModel.Address.City.Id = Convert.ToInt32(collection.Get(7));
                        EmployeeFormModel.Address.CityId = Convert.ToInt32(collection.Get(7));
                        EmployeeFormModel.Address.Town = collection.Get("Address.Town");
                        EmployeeFormModel.Address.Neighbourhood = collection.Get("Address.Neighbourhood");
                        EmployeeFormModel.Address.Street = collection.Get("Address.Street");
                        EmployeeFormModel.Address.HomeStreet = collection.Get("Address.HomeStreet");
                        EmployeeFormModel.Address.BuildingNo = Convert.ToInt32(collection.Get("Address.BuildingNo"));
                        EmployeeFormModel.Address.InnerDoorNo = Convert.ToInt32(collection.Get("Address.InnerDoorNo"));
                        EmployeeFormModel.Company = new CompanyModel();
                        EmployeeFormModel.Company.Id = Convert.ToInt32(collection.Get(14));
                        EmployeeFormModel.CompanyId = Convert.ToInt32(collection.Get(14));
                        EmployeeFormModel.EmployeeType = new EmployeeTypeModel();
                        EmployeeFormModel.EmployeeType.Id = Convert.ToInt32(collection.Get(15));
                        EmployeeFormModel.EmployeeTypeId = Convert.ToInt32(collection.Get(15));
                        EmployeeFormModel.DriverLicenseGroup = collection.Get("DriverLicenseGroup");
                        EmployeeFormModel.DriverLicenseNumber = collection.Get("DriverLicenseNumber");
                        CompanyService.AddEmployee(EmployeeFormModel);
                        return RedirectToAction("CreateEmployee", "Employee");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(EmployeeFormModel);
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        //
        // GET: /Employee/VehicleEmployee

        public ActionResult VehicleEmployee()
        {
            VehicleEmployeeModel VehicleEmployeeFormModel = new VehicleEmployeeModel();
            VehicleEmployeeFormModel.Vehicle = new VehicleModel();
            VehicleEmployeeFormModel.Vehicle.VehicleType = new VehicleTypeModel();
            VehicleEmployeeFormModel.Employee = new EmployeeModel();
            VehicleEmployeeFormModel.Employee.EmployeeType = new EmployeeTypeModel();
            VehicleEmployeeFormModel.Employee.Company = new CompanyModel();
            ViewData["VehicleList"] = CompanyService.GetVehicleList();
            ViewData["EmployeeList"] = new List<SelectListItem>();
            ViewData["EmployeeList"] = CompanyService.GetEmployeeList(false);
            return View(VehicleEmployeeFormModel);
        }

        //
        // POST: /Employee/VehicleEmployee

        [HttpPost]
        public ActionResult VehicleEmployee(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    VehicleEmployeeModel VehicleEmployeeFormModel = new VehicleEmployeeModel();
                    ViewData["VehicleList"] = CompanyService.GetVehicleList();
                    ViewData["EmployeeList"] = new List<SelectListItem>();
                    ViewData["EmployeeList"] = CompanyService.GetEmployeeList(false);
                    try
                    {
                        string vehicleId = collection.Get(0);
                        List<string> employeeList = collection.Get(1).Split(',').ToList();
                        foreach(string item in employeeList)
                        {
                            VehicleEmployeeFormModel = new VehicleEmployeeModel();
                            VehicleEmployeeFormModel.Vehicle = new VehicleModel();
                            VehicleEmployeeFormModel.Vehicle.VehicleType = new VehicleTypeModel();
                            VehicleEmployeeFormModel.Vehicle.Id = Convert.ToInt32(vehicleId);
                            VehicleEmployeeFormModel.VehicleId = Convert.ToInt32(vehicleId);
                            VehicleEmployeeFormModel.Employee = new EmployeeModel();
                            VehicleEmployeeFormModel.Employee.EmployeeType = new EmployeeTypeModel();
                            VehicleEmployeeFormModel.Employee.Company = new CompanyModel();
                            VehicleEmployeeFormModel.Employee.Id = Convert.ToInt32(item);
                            VehicleEmployeeFormModel.EmployeeId = Convert.ToInt32(item);
                            CompanyService.AddVehicleEmployee(VehicleEmployeeFormModel);
                        }
                        return RedirectToAction("VehicleEmployee", "Employee");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(VehicleEmployeeFormModel);
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        
        //
        // GET: /Employee/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Edit/5

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
        // GET: /Employee/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Delete/5

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
