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
            ViewData["RoleList"] = TransportService.GetRoleList("KULLANICI");
            return View(UserModel);
        }

        //
        // POST: /User/Create

        [HttpPost]
        [Authorize(Roles = "KULLANICI")]
        public ActionResult CreateUser(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserModel userFormModel = new UserModel();
                    userFormModel.Address = new AddressModel();
                    ViewData["CityList"] = TransportService.GetCityList();
                    ViewData["RoleList"] = TransportService.GetRoleList("KULLANICI");
                    try
                    {
                        userFormModel.Name = collection.Get("Name");
                        userFormModel.Surname = collection.Get("Surname");
                        userFormModel.IdentityNumber = collection.Get("IdentityNumber");
                        userFormModel.UserName = collection.Get("UserName");
                        userFormModel.PassWord = TransportService.EncryptPasswordBase64(collection.Get("PassWord"));
                        userFormModel.Role = new RoleModel();
                        userFormModel.Role.Id = Convert.ToInt32(collection.Get(5));
                        userFormModel.RoleId = Convert.ToInt32(collection.Get(5));
                        userFormModel.Email = collection.Get("Email");
                        userFormModel.Telephone = collection.Get("Telephone");
                        userFormModel.Gender = Convert.ToChar(collection.Get("Gender"));
                        userFormModel.BirthDate = Convert.ToDateTime(collection.Get("BirthDate"));
                        userFormModel.Address = new AddressModel();
                        userFormModel.Address.City = new CityModel();
                        userFormModel.Address.City.Id = Convert.ToInt32(collection.Get(10));
                        userFormModel.Address.CityId = Convert.ToInt32(collection.Get(10));
                        userFormModel.Address.Town = collection.Get("Address.Town");
                        userFormModel.Address.Neighbourhood = collection.Get("Address.Neighbourhood");
                        userFormModel.Address.Street = collection.Get("Address.Street");
                        userFormModel.Address.HomeStreet = collection.Get("Address.HomeStreet");
                        userFormModel.Address.BuildingNo = Convert.ToInt32(collection.Get("Address.BuildingNo"));
                        userFormModel.Address.InnerDoorNo = Convert.ToInt32(collection.Get("Address.InnerDoorNo"));
                        TransportService.AddUser(userFormModel);
                        return RedirectToAction("UserLogin", "User");
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
        // GET: /User/UserLogOn

        //[AllowAnonymous]
        public ActionResult UserLogOn()
        {
            LoginModel LoginModel = new LoginModel();
            ViewData["RoleList"] = TransportService.GetRoleList();
            return View(LoginModel);
        }

        //
        // POST: /User/UserLogOn

        [HttpPost]
        public ActionResult UserLogOn(FormCollection collection)
        {            
            if (ModelState.IsValid)
            {
                try
                {
                    LoginModel LoginFormModel = new LoginModel();
                    ViewData["RoleList"] = TransportService.GetRoleList();
                    try
                    {
                        ViewData["UserName"] = null; ViewData["PassWord"] = null;
                        if (collection.Get("UserName") != null && collection.Get("UserName") != ""
                            && collection.Get("PassWord") != null && collection.Get("PassWord") != ""
                            && collection.Get(2) != null && Convert.ToInt32(collection.Get(2)) != 0)
                        {
                            LoginFormModel.UserName = collection.Get("UserName");
                            LoginFormModel.PassWord = collection.Get("PassWord");
                            LoginFormModel.Role = new RoleModel();
                            LoginFormModel.RoleId = Convert.ToInt32(collection.Get(2));
                            LoginFormModel.Role.Id = Convert.ToInt32(collection.Get(2));
                            if (TransportService.LogOn(LoginFormModel) == 1)
                            {
//int rememberMe = true;FormsAuthentication.SetAuthCookie(userLogOnFormModel.UserName, rememberMe, "D:\\Cookies");
                                FormsAuthentication.SetAuthCookie(LoginFormModel.UserName, false);
                                //KULLANICI GİRİŞİ
                                if (LoginFormModel.RoleId == 1)
                                {
                                    return RedirectToAction("CreateTransport", "Transport");
                                }
                                //ŞİRKET GİRİŞİ
                                else if (LoginFormModel.RoleId == 2)
                                {
                                    return RedirectToAction("CreateVehicle", "Vehicle");
                                }
                                //ADMIN GİRİŞİ
                                else if (LoginFormModel.RoleId == 3)
                                {
                                    return RedirectToAction("", "");
                                }
                            }
                            else
                            {
                                ViewData["UserLogOnMessage"] 
                                    = "Geçersiz Kullanıcı. Kullanıcı Adı veya Kullanıcı Şifresi Hatalı! Lütfen Tekrar Deneyiniz.";
                            }
                        }
                        else
                        {
                            ViewData["UserLogOnMessage"] = 
                                "Kullanıcı Adı ve Şifre Alanları Doldurulmalıdır, Kullanıcı Tipi Seçilmelidir";
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.InnerException.Message);
                    }
                    return View(LoginFormModel);
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
        // GET: /User/UserLogOff

        public ActionResult UserLogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("UserLogOn", "User");
        }

        //
        // POST: /User/UserLogOff

        [HttpPost]
        public ActionResult UserLogOff(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    try
                    {
                        FormsAuthentication.SignOut();
                        return RedirectToAction("UserLogOn", "User");
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
