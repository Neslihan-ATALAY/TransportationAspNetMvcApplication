using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TransportationMvc2Project.Models;


//
// Neslihan ATALAY
namespace TransportationMvc2Project.Controllers
{
    public class UserController : Controller
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
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /User/Create

        public ActionResult CreateUser()
        {
            UserModel UserModel = new UserModel();
            UserModel.Address = new AddressModel();
            ViewData["CityList"] = TransportService.GetCityList();
            return View(UserModel);
        }

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult CreateUser(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserModel userFormModel = new UserModel();
                    userFormModel.Address = new AddressModel();
                    ViewData["CityList"] = TransportService.GetCityList();
                    try
                    {
                        userFormModel.Name = collection.Get("Name");
                        userFormModel.Surname = collection.Get("Surname");
                        userFormModel.IdentityNumber = collection.Get("IdentityNumber");
                        userFormModel.UserName = collection.Get("UserName");
                        userFormModel.PassWord = TransportService.EncryptPasswordBase64(collection.Get("PassWord")); ;
                        userFormModel.Email = collection.Get("Email");
                        userFormModel.Telephone = collection.Get("Telephone");
                        userFormModel.Gender = Convert.ToChar(collection.Get("Gender"));
                        userFormModel.BirthDate = Convert.ToDateTime(collection.Get("BirthDate"));
                        userFormModel.Address = new AddressModel();
                        userFormModel.Address.City = new CityModel();
                        userFormModel.Address.City.Id = Convert.ToInt32(collection.Get(9));
                        userFormModel.Address.CityId = Convert.ToInt32(collection.Get(9));
                        userFormModel.Address.Town = collection.Get("Address.Town");
                        userFormModel.Address.Neighbourhood = collection.Get("Address.Neighbourhood");
                        userFormModel.Address.Street = collection.Get("Address.Street");
                        userFormModel.Address.HomeStreet = collection.Get("Address.HomeStreet");
                        userFormModel.Address.BuildingNo = Convert.ToInt32(collection.Get("Address.BuildingNo"));
                        userFormModel.Address.InnerDoorNo = Convert.ToInt32(collection.Get("Address.InnerDoorNo"));
                        TransportService.AddUser(userFormModel);
                        return RedirectToAction("CreateUser", "User");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(userFormModel);
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        
        //
        // GET: /User/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /User/Edit/5

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
        // GET: /User/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5

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
