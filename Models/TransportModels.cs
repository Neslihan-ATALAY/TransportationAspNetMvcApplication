using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TransportationMvc2Project.Models;
using System.Web.Mvc;


//
// Neslihan ATALAY
namespace TransportationMvc2Project.Models
{
    #region Models
    
    public class UserModel
    {        
        private int _id;
        private string _name;
        private string _surname;
        private string _identityNumber;
        private string _username;
        private string _password;
        private string _email;
        private string _telephone;
        private Char _gender;
        private DateTime _birthDate;
        private int _addressId;
        private AddressModel _address;

        [Key]
        [Required]
        [DisplayName("KULLANICI ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("AD / İSİM")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DisplayName("SOYADI / SOYİSİM")]
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        [DisplayName("KULLANICI KİMLİK NUMARASI")]
        [StringLength(11)]
        public string IdentityNumber
        {
            get { return _identityNumber; }
            set { _identityNumber = value; }
        }
        [DisplayName("KULLANICI ADI")]
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        [DisplayName("KULLANICI PAROLASI / ŞİFRESİ")]
        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }
        [DisplayName("KULLANICI EPOSTA ADRESİ")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DisplayName("KULLANICI TELEFON NUMARASI")]
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        [DisplayName("KULLANICI CİNSİYETİ")]
        public Char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [DisplayName("KULLANICI DOĞUM TARİHİ (dd-mm-yy hh:MM:ss)")]
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public int AddressId
        {
            get { return _addressId; }
            set { _addressId = value; }
        }
        public AddressModel Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
    public class CityModel
    {        
        private int _id;        
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Key]
        [Required]
        [DisplayName("İL / ŞEHİR")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    public class DistrictModel
    {        
        private int _id;        
        private string _name;
        private int _cityId;
        private CityModel _city;

        [Key]
        [Required]
        [DisplayName("İLÇE ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("İLÇE ADI")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }
        public CityModel City
        {
            get { return _city; }
            set { _city = value; }
        }
    }
    public class AddressModel
    {        
        private int _id;
        private int _cityId;
        private CityModel _city;        
        private string _town;
        private int _districtId;
        private DistrictModel _district;        
        private string _neighbourhood;        
        private string _street;        
        private string _homeStreet;        
        private int _buildingNo;        
        private int _innerDoorNo;

        [Key]
        [Required]
        [DisplayName("ADRES ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }
        public CityModel City
        {
            get { return _city; }
            set { _city = value; }
        }
        [DisplayName("İLÇE / SEMT / MESKEN")]
        public string Town
        {
            get { return _town; }
            set { _town = value; }
        }
        public int DistrictId
        {
            get { return _districtId; }
            set { _districtId = value; }
        }
        public DistrictModel District
        {
            get { return _district; }
            set { _district = value; }
        }
        [DisplayName("MAHALLE")]
        public string Neighbourhood
        {
            get { return _neighbourhood; }
            set { _neighbourhood = value; }
        }
        [DisplayName("CADDE / BULVAR / ANA YOL")]
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        [DisplayName("SOKAK")]
        public string HomeStreet
        {
            get { return _homeStreet; }
            set { _homeStreet = value; }
        }
        [DisplayName("BİNA NUMARASI")]
        public int BuildingNo
        {
            get { return _buildingNo; }
            set { _buildingNo = value; }
        }
        [DisplayName("İÇ KAPI NUMARASI")]
        public int InnerDoorNo
        {
            get { return _innerDoorNo; }
            set { _innerDoorNo = value; }
        }
    }
    public class ApplicationModel
    {        
        private int _id;
        private int _userId;
        private UserModel _user;
        private int _transportTypeId;
        private TransportTypeModel _transportType;        
        private DateTime _transportDate;
        private int _departureId;
        private AddressModel _departure;
        private int _destinationId;
        private AddressModel _destination;
        private Decimal _weight;
        private Decimal _distance;
        private Decimal _price;

        [Key]
        [Required]
        [DisplayName("TAŞIMA TALEP ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public UserModel User
        {
            get { return _user; }
            set { _user = value; }
        }
        public int TransportTypeId
        {
            get { return _transportTypeId; }
            set { _transportTypeId = value; }
        }
        public TransportTypeModel TransportType
        {
            get { return _transportType; }
            set { _transportType = value; }
        }
        [DisplayName("TAŞIMA TARİHİ (dd-mm-yy hh:MM:ss)")]
        public DateTime TransportDate
        {
            get { return _transportDate; }
            set { _transportDate = value; }
        }
        public int DepartureId
        {
            get { return _departureId; }
            set { _departureId = value; }
        }
        public AddressModel Departure
        {
            get { return _departure; }
            set { _departure = value; }
        }
        public int DestinationId
        {
            get { return _destinationId; }
            set { _destinationId = value; }
        }
        public AddressModel Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
        [DisplayName("YAKLAŞIK AĞIRLIK (KİLOGRAM)")]
        public Decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        [DisplayName("YAKLAŞIK UZAKLIK (KİLOMETRE")]
        public Decimal Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
        [DisplayName("YAKLAŞIK FİYAT (TÜRK LİRASI)")]
        public Decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
    public class ApplicationVehicleModel
    {
        private int _id;
        private int _applicationId;
        private ApplicationModel _application;
        private int _vehicleId;
        private VehicleModel _vehicle;
        private int _driverId;
        private EmployeeModel _driver;

        [Key]
        [Required]
        [DisplayName("TAŞIMA TALEP - ARAÇ ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ApplicationId
        {
            get { return _applicationId; }
            set { _applicationId = value; }
        }
        public ApplicationModel Application
        {
            get { return _application; }
            set { _application = value; }
        }
        public int VehicleId
        {
            get { return _vehicleId; }
            set { _vehicleId = value; }
        }
        public VehicleModel Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }
        public int DriverId
        {
            get { return _driverId; }
            set { _driverId = value; }
        }
        public EmployeeModel Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
    }
    public class Comment
    {        
        private int _id;
        private int _userId;
        private UserModel _user;
        private int _applicationId;
        private ApplicationModel _application;        
        private string _userComment;

        [Key]
        [Required]
        [DisplayName("DEĞERLENDİRME ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public UserModel User
        {
            get { return _user; }
            set { _user = value; }
        }
        public int ApplicationId
        {
            get { return _applicationId; }
            set { _applicationId = value; }
        }
        public ApplicationModel Application
        {
            get { return _application; }
            set { _application = value; }
        }
        [DisplayName("DEĞERLENDİRME / YORUM")]
        public string UserComment
        {
            get { return _userComment; }
            set { _userComment = value; }
        }
    }

    #endregion
    
    #region Contexts

    public class TransportContext : DbContext
    {
        protected TransportationDatabaseEntities databaseEntities;
        public TransportationDatabaseEntities DatabaseEntities
        {
            get { return databaseEntities; }
            set { databaseEntities = value; }
        }
        private TransportService transportService;
        public TransportService TransportService
        {
            get { return transportService; }
            set { transportService = value; }
        }
        public TransportContext()
        {
            transportService = new TransportService();
            DatabaseEntities = new TransportationDatabaseEntities();
        }

        private ObjectSet<APPLICATION> _Applications;
        public ObjectSet<APPLICATION> Application
        {
            get { return DatabaseEntities.APPLICATIONs; }
            set { _Applications = value; }
        }        
    }

    #endregion
    
    /*
    #region Repositories

    public interface ITransportRepositoy<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        int Add(T entity);
        int AddRange(IEnumerable<T> entities);
        int Delete(T entity);
        int DeleteRange(IEnumerable<T> entities);
        int Update(T entity);
        int UpdateRange(IEnumerable<T> entities);
    }

    public class TransportRepository<T> : ITransportRepositoy<T> where T : class
    {
        protected TransportContext transportContext;
        public TransportRepository(TransportContext context)
        {
            transportContext = context;
        }
        public T GetById(int id)
        {
            return transportContext.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return transportContext.Set<T>().ToList();
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return transportContext.Set<T>().Where(expression);
        }
        public int Add(T entity)
        {
            transportContext.Set<T>().Add(entity);
            return transportContext.SaveChanges();
        }
        public int AddRange(IEnumerable<T> entities)
        {
            int result = 0;
            foreach (T entity in entities)
            {
                result = 0;
                transportContext.Set<T>().Add(entity);
                transportContext.SaveChanges();
                result = 1;
            }
            return result;
        }
        public int Delete(T entity)
        {
            transportContext.Set<T>().Remove(entity);
            return transportContext.SaveChanges();
        }
        public int DeleteRange(IEnumerable<T> entities)
        {
            int result = 0;
            foreach (T entity in entities)
            {
                result = 0;
                transportContext.Set<T>().Remove(entity);
                transportContext.SaveChanges();
                result = 1;
            }
            return result;
        }
        public int Update(T entity)
        {
            transportContext.Entry(entity).State = EntityState.Modified;
            return transportContext.SaveChanges();
        }
        public int UpdateRange(IEnumerable<T> entities)
        {
            int result = 0;
            foreach (T entity in entities)
            {
                result = 0;
                transportContext.Entry(entity).State = EntityState.Modified;
                transportContext.SaveChanges();
                result = 1;
            }
            return result;
        }
    }

    #endregion
     * */
    #region Services

    public interface ITransportService
    {
        int AddAddress(AddressModel AddressModel);
        int AddUser(UserModel UserModel);
        ApplicationModel AddTransport(ApplicationModel TransportModel);
        int AddTransportVehicle(ApplicationVehicleModel TransportVehicleModel);
        List<SelectListItem> GetCityList();
        List<SelectListItem> GetUserList();
        List<SelectListItem> GetTransportTypeList();
        //string EncryptPasswordBase64(string text);
        //string DecryptPasswordBase64(string base64EncodedData);
    }

    public class TransportService : ITransportService
    {
        public TransportService() { }

        public int AddAddress(AddressModel AddressModel)
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    var _CITY = new CITY();
                    if (AddressModel != null && AddressModel.CityId != 0
                        && (transportContext.DatabaseEntities.CITies.Where(c => c.ID == AddressModel.CityId).FirstOrDefault() != null))
                    {
                        _CITY = transportContext.DatabaseEntities.CITies.Where(c => c.ID == AddressModel.CityId).FirstOrDefault();
                    }
                    var _ADDRESS = new ADDRESS
                    {
                        CITY = _CITY,
                        CITYID = _CITY.ID,
                        TOWN = AddressModel.Town,
                        NEIGHBOURHOOD = AddressModel.Neighbourhood,
                        STREET = AddressModel.Street,
                        HOMESTREET = AddressModel.HomeStreet,
                        BUILDINGNO = AddressModel.BuildingNo,
                        INNERDOORNO = AddressModel.InnerDoorNo
                    };
                    transportContext.DatabaseEntities.ADDRESSes.AddObject(_ADDRESS);
                    var result = transportContext.DatabaseEntities.SaveChanges();
                    return result;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message.ToString());
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return 0;
        }

        public int AddUser(UserModel UserModel)
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0;
                    var _USER = new USER
                    {
                        NAME = UserModel.Name,
                        SURNAME = UserModel.Surname,
                        IDENTITYNUMBER = UserModel.IdentityNumber,
                        USERNAME = UserModel.UserName,
                        PASSWORD = UserModel.PassWord,
                        TELEPHONE = UserModel.Telephone,
                        EMAIL = UserModel.Email,
                        GENDER = Convert.ToString(UserModel.Gender),
                        BIRTHDATE = Convert.ToDateTime(UserModel.BirthDate)
                    };
                    {
                        if (UserModel != null
                            && (transportContext.DatabaseEntities.USERs.Where
                            (e => e.IDENTITYNUMBER == UserModel.IdentityNumber
                            && e.NAME == UserModel.Name && e.SURNAME == UserModel.Surname).FirstOrDefault() == null))
                        {
                            if (_USER.ID == 0)
                            {
                                if (transportContext.DatabaseEntities.USERs.ToList().Count != 0)
                                    _USER.ID = transportContext.DatabaseEntities.USERs.Max(e => e.ID) + 1;
                                else
                                    _USER.ID = 1;
                            }
                            if (_USER.ID != 0)
                            {
                                //Kullanıcı bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                transportContext.DatabaseEntities.USERs.AddObject(_USER);
                                result1 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                        if (_USER.ID != 0)
                        {
                            _USER = transportContext.DatabaseEntities.USERs.Where(e => e.ID == _USER.ID).FirstOrDefault();
                        }
                    }
                    {
                        _USER = transportContext.DatabaseEntities.USERs.Where
                            (e => e.IDENTITYNUMBER == UserModel.IdentityNumber
                            && e.NAME == UserModel.Name && e.SURNAME == UserModel.Surname).FirstOrDefault();
                        if (_USER.ID != 0)
                        {
                            UserModel.Id = _USER.ID;
                        }
                    }
                    {
                        //Personelin adresi kayıtlı ise adresi güncellenir.
                        UserModel.Address.City.Name = transportContext.DatabaseEntities.CITies
                            .Where(c => c.ID == UserModel.Address.CityId).FirstOrDefault().NAME;
                        //Şirketin adresi kayıtlı değilse yeni adres eklenir.
                        if (UserModel.Address != null
                            && (transportContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == UserModel.Address.CityId && a.TOWN == UserModel.Address.Town
                            && a.NEIGHBOURHOOD == UserModel.Address.Neighbourhood
                            && a.STREET == UserModel.Address.Street
                            && a.HOMESTREET == UserModel.Address.HomeStreet
                            && a.BUILDINGNO == UserModel.Address.BuildingNo
                            && a.INNERDOORNO == UserModel.Address.InnerDoorNo).FirstOrDefault() == null))
                        {
                            result2 = AddAddress(UserModel.Address);
                        }
                        //Şirketin adresi kayıtlı ise adresi güncellenir.
                        if (UserModel.Address != null
                            && (transportContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == UserModel.Address.CityId && a.TOWN == UserModel.Address.Town
                            && a.NEIGHBOURHOOD == UserModel.Address.Neighbourhood
                            && a.STREET == UserModel.Address.Street
                            && a.HOMESTREET == UserModel.Address.HomeStreet
                            && a.BUILDINGNO == UserModel.Address.BuildingNo
                            && a.INNERDOORNO == UserModel.Address.InnerDoorNo).FirstOrDefault() != null))
                        {
                            var _ADDRESS = transportContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.CITYID == UserModel.Address.CityId
                                && a.TOWN == UserModel.Address.Town
                                && a.NEIGHBOURHOOD == UserModel.Address.Neighbourhood
                                && a.STREET == UserModel.Address.Street
                                && a.HOMESTREET == UserModel.Address.HomeStreet
                                && a.BUILDINGNO == UserModel.Address.BuildingNo
                                && a.INNERDOORNO == UserModel.Address.InnerDoorNo)
                                .FirstOrDefault();
                            _USER.ADDRESSID = _ADDRESS.ID;
                            UserModel.AddressId = _ADDRESS.ID;
                            var _ADDRESSS = transportContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.ID == UserModel.AddressId).FirstOrDefault();
                            if (_USER != null && _USER.ADDRESSID != null)
                            {
                                result3 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    return result1 & result2 & result3;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message.ToString());
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return 0;
        }

        public ApplicationModel AddTransport(ApplicationModel TransportModel)
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0; var result4 = 0;
                    var _APPLICATION = new APPLICATION
                    {
                        TRANSPORTDATE = TransportModel.TransportDate,
                        WEIGHT = TransportModel.Weight,
                        DISTANCE = TransportModel.Distance
                    };
                    {
                        if (TransportModel != null
                            && (transportContext.DatabaseEntities.APPLICATIONs.Where
                            (a => a.TRANSPORTDATE == TransportModel.TransportDate
                            && a.WEIGHT == TransportModel.Weight
                            && a.DISTANCE == TransportModel.Distance).FirstOrDefault() == null))
                        {
                            if (_APPLICATION.ID == 0)
                            {
                                if (transportContext.DatabaseEntities.APPLICATIONs.ToList().Count != 0)
                                    _APPLICATION.ID = transportContext.DatabaseEntities.APPLICATIONs.Max(e => e.ID) + 1;
                                else
                                    _APPLICATION.ID = 1;
                            }
                            if (_APPLICATION.ID != 0)
                            {
                                //Taşıma talep bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                transportContext.DatabaseEntities.APPLICATIONs.AddObject(_APPLICATION);
                                result1 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                        if (_APPLICATION.ID != 0)
                        {
                            _APPLICATION = transportContext.DatabaseEntities.
                                APPLICATIONs.Where(a => a.ID == _APPLICATION.ID).FirstOrDefault();
                        }
                    }
                    {
                        _APPLICATION = transportContext.DatabaseEntities.APPLICATIONs.Where
                            (a => a.TRANSPORTDATE == TransportModel.TransportDate
                            && a.WEIGHT == TransportModel.Weight
                            && a.DISTANCE == TransportModel.Distance).FirstOrDefault();
                        if (_APPLICATION.ID != 0)
                        {
                            TransportModel.Id = _APPLICATION.ID;
                        }
                    }
                    {
                        //Personelin gidiş adresi kayıtlı ise adresi güncellenir.
                        TransportModel.Departure.City.Name = transportContext.DatabaseEntities.CITies
                            .Where(c => c.ID == TransportModel.Departure.CityId).FirstOrDefault().NAME;
                        //Talebin gidiş adresi kayıtlı değilse yeni adres eklenir.
                        if (TransportModel.Departure != null
                            && (transportContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == TransportModel.Departure.CityId && a.TOWN == TransportModel.Departure.Town
                            && a.NEIGHBOURHOOD == TransportModel.Departure.Neighbourhood
                            && a.STREET == TransportModel.Departure.Street
                            && a.HOMESTREET == TransportModel.Departure.HomeStreet
                            && a.BUILDINGNO == TransportModel.Departure.BuildingNo
                            && a.INNERDOORNO == TransportModel.Departure.InnerDoorNo).FirstOrDefault() == null))
                        {
                            result2 = AddAddress(TransportModel.Departure);
                        }
                        //Talebin gidiş adresi kayıtlı ise adresi güncellenir.
                        if (TransportModel.Departure != null
                            && (transportContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == TransportModel.Departure.CityId && a.TOWN == TransportModel.Departure.Town
                            && a.NEIGHBOURHOOD == TransportModel.Departure.Neighbourhood
                            && a.STREET == TransportModel.Departure.Street
                            && a.HOMESTREET == TransportModel.Departure.HomeStreet
                            && a.BUILDINGNO == TransportModel.Departure.BuildingNo
                            && a.INNERDOORNO == TransportModel.Departure.InnerDoorNo).FirstOrDefault() != null))
                        {
                            var _DEPARTURE = transportContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.CITYID == TransportModel.Departure.CityId
                                && a.TOWN == TransportModel.Departure.Town
                                && a.NEIGHBOURHOOD == TransportModel.Departure.Neighbourhood
                                && a.STREET == TransportModel.Departure.Street
                                && a.HOMESTREET == TransportModel.Departure.HomeStreet
                                && a.BUILDINGNO == TransportModel.Departure.BuildingNo
                                && a.INNERDOORNO == TransportModel.Departure.InnerDoorNo)
                                .FirstOrDefault();
                            _APPLICATION.DEPARTUREID = _DEPARTURE.ID;
                            TransportModel.DepartureId = _DEPARTURE.ID;
                            var _ADDRESSS = transportContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.ID == TransportModel.DepartureId).FirstOrDefault();
                            if (_APPLICATION != null)
                            {
                                result3 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        TransportModel.Destination.City.Name = transportContext.DatabaseEntities.CITies
                            .Where(c => c.ID == TransportModel.Destination.CityId).FirstOrDefault().NAME;
                        //Talebin varış adresi kayıtlı değilse yeni adres eklenir.
                        if (TransportModel.Destination != null
                            && (transportContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == TransportModel.Destination.CityId && a.TOWN == TransportModel.Destination.Town
                            && a.NEIGHBOURHOOD == TransportModel.Destination.Neighbourhood
                            && a.STREET == TransportModel.Destination.Street
                            && a.HOMESTREET == TransportModel.Destination.HomeStreet
                            && a.BUILDINGNO == TransportModel.Destination.BuildingNo
                            && a.INNERDOORNO == TransportModel.Destination.InnerDoorNo).FirstOrDefault() == null))
                        {
                            result2 = AddAddress(TransportModel.Destination);
                        }
                        //Talebin varış adresi kayıtlı ise adresi güncellenir.
                        if (TransportModel.Destination != null
                            && (transportContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == TransportModel.Destination.CityId && a.TOWN == TransportModel.Destination.Town
                            && a.NEIGHBOURHOOD == TransportModel.Destination.Neighbourhood
                            && a.STREET == TransportModel.Destination.Street
                            && a.HOMESTREET == TransportModel.Destination.HomeStreet
                            && a.BUILDINGNO == TransportModel.Destination.BuildingNo
                            && a.INNERDOORNO == TransportModel.Destination.InnerDoorNo).FirstOrDefault() != null))
                        {
                            var _DESTINATION = transportContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.CITYID == TransportModel.Destination.CityId
                                && a.TOWN == TransportModel.Destination.Town
                                && a.NEIGHBOURHOOD == TransportModel.Destination.Neighbourhood
                                && a.STREET == TransportModel.Destination.Street
                                && a.HOMESTREET == TransportModel.Destination.HomeStreet
                                && a.BUILDINGNO == TransportModel.Destination.BuildingNo
                                && a.INNERDOORNO == TransportModel.Destination.InnerDoorNo)
                                .FirstOrDefault();
                            _APPLICATION.DESTINATIONID = _DESTINATION.ID;
                            TransportModel.DestinationId = _DESTINATION.ID;
                            var _ADDRESSS = transportContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.ID == TransportModel.DestinationId).FirstOrDefault();
                            if (_APPLICATION != null)
                            {
                                result3 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Taşıma talebinin kullanıcısı kayıtlı değilse kullanıcı güncellenir.
                        if (TransportModel.User != null && TransportModel.UserId != 0)
                        {
                            _APPLICATION.USERID = TransportModel.UserId;
                            var _USER = transportContext.DatabaseEntities.USERs.Where
                                (u => u.ID == TransportModel.UserId).FirstOrDefault();
                            _APPLICATION.USER = _USER;
                            if (_USER != null)
                            {
                                result3 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Taşıma talebinin taşıma tipi kayıtlı değilse güncellenir.
                        if (TransportModel.TransportType != null && TransportModel.TransportTypeId != 0)
                        {
                            _APPLICATION.TRANSPORTTYPEID = TransportModel.TransportTypeId;
                            var _TRANSPORTTYPE = transportContext.DatabaseEntities.TRANSPORTTYPEs.Where
                                (tt => tt.ID == TransportModel.TransportTypeId).FirstOrDefault();
                            _APPLICATION.TRANSPORTTYPE = _TRANSPORTTYPE;
                            if (_TRANSPORTTYPE != null)
                            {
                                result4 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    //return result1 & result2 & result3 & result4;
                    return TransportModel;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message.ToString());
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public int AddTransportVehicle(ApplicationVehicleModel TransportVehicleModel)
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0; var result4 = 0;
                    var _APPLICATION_VEHICLE = new APPLICATION_VEHICLE
                    {
                    };
                    /*
                    int transportId = transportContext.DatabaseEntities.APPLICATIONs.Where
                        (a => a.USERID == TransportVehicleModel.Application.UserId
                        && a.TRANSPORTTYPEID == TransportVehicleModel.Application.TransportTypeId
                        && a.TRANSPORTDATE == TransportVehicleModel.Application.TransportDate
                        //&& a.DEPARTUREID == TransportVehicleModel.Application.DepartureId
                        //&& a.DESTINATIONID == TransportVehicleModel.Application.DestinationId
                        //&& a.WEIGHT == TransportVehicleModel.Application.Weight
                        //&& a.DISTANCE == TransportVehicleModel.Application.Distance
                        ).FirstOrDefault().ID;
                    TransportVehicleModel.ApplicationId = transportId;
                    TransportVehicleModel.Application.Id = transportId;
                    */
                    {
                        if (TransportVehicleModel != null && transportContext.DatabaseEntities.APPLICATION_VEHICLE.
                                Where(av => av.APPLICATIONID == TransportVehicleModel.ApplicationId
                                && av.VEHICLEID == TransportVehicleModel.VehicleId).FirstOrDefault() == null)
                        {
                            if (_APPLICATION_VEHICLE.ID == 0)
                            {
                                if (transportContext.DatabaseEntities.APPLICATION_VEHICLE.ToList().Count != 0)
                                    _APPLICATION_VEHICLE.ID = transportContext.DatabaseEntities.APPLICATION_VEHICLE.Max(e => e.ID) + 1;
                                else
                                    _APPLICATION_VEHICLE.ID = 1;
                            }
                            if (_APPLICATION_VEHICLE.ID != 0)
                            {
                                //Taşıma talep - araçlar bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                transportContext.DatabaseEntities.APPLICATION_VEHICLE.AddObject(_APPLICATION_VEHICLE);
                                result1 = transportContext.DatabaseEntities.SaveChanges();                                
                            }
                        }
                        if (_APPLICATION_VEHICLE.ID != 0)
                        {
                            _APPLICATION_VEHICLE = transportContext.DatabaseEntities.APPLICATION_VEHICLE.
                                    Where(av => av.ID == _APPLICATION_VEHICLE.ID).FirstOrDefault();
                        }
                        else
                        {
                            _APPLICATION_VEHICLE = transportContext.DatabaseEntities.APPLICATION_VEHICLE.
                                Where(a => a.APPLICATIONID == TransportVehicleModel.ApplicationId
                                && a.VEHICLEID == TransportVehicleModel.VehicleId).FirstOrDefault();
                        }
                    }
                    {
                        if (_APPLICATION_VEHICLE.ID != 0)
                        {
                            _APPLICATION_VEHICLE = transportContext.DatabaseEntities.APPLICATION_VEHICLE.
                                Where(av => av.ID == _APPLICATION_VEHICLE.ID).FirstOrDefault();
                            TransportVehicleModel.Id = _APPLICATION_VEHICLE.ID;
                        }
                    }
                    {
                        //Taşıma talebi kayıtlı değilse güncellenir.
                        if (TransportVehicleModel.Application != null &&
                            TransportVehicleModel.ApplicationId != null && TransportVehicleModel.ApplicationId != 0)
                        {
                            _APPLICATION_VEHICLE.APPLICATIONID = TransportVehicleModel.ApplicationId;
                            var _APPLICATION = transportContext.DatabaseEntities.APPLICATIONs.Where
                                (a => a.ID == TransportVehicleModel.ApplicationId).FirstOrDefault();
                            _APPLICATION_VEHICLE.APPLICATION = _APPLICATION;
                            if (_APPLICATION != null)
                            {
                                result3 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Araç kayıtlı değilse güncellenir.
                        if (TransportVehicleModel.Vehicle != null
                            && TransportVehicleModel.VehicleId != null && TransportVehicleModel.VehicleId != 0)
                        {
                            _APPLICATION_VEHICLE.VEHICLEID = TransportVehicleModel.VehicleId;
                            var _VEHICLE = transportContext.DatabaseEntities.VEHICLEs.Where
                                (v => v.ID == TransportVehicleModel.VehicleId).FirstOrDefault();
                            _APPLICATION_VEHICLE.VEHICLE = _VEHICLE;
                            if (_VEHICLE != null)
                            {
                                result4 = transportContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Sürücü kayıtlı değilse güncellenir.
                        if (TransportVehicleModel.Driver != null
                            && TransportVehicleModel.VehicleId != null && TransportVehicleModel.VehicleId != 0)
                        {
                            List<VEHICLE_EMPLOYEE> employeeList = transportContext.DatabaseEntities.VEHICLE_EMPLOYEE.Where
                                (ve => ve.VEHICLEID == TransportVehicleModel.VehicleId).ToList();
                            foreach (VEHICLE_EMPLOYEE employee in employeeList)
                            {
                                EMPLOYEE driver = transportContext.DatabaseEntities.EMPLOYEEs.Where
                                    (e => e.EMPLOYEETYPEID == 2 && e.ID == employee.EMPLOYEEID).FirstOrDefault();
                                if (driver != null && driver.ID != 0 && driver.EMPLOYEETYPEID == 2 && driver.ID == employee.EMPLOYEEID)
                                {
                                    _APPLICATION_VEHICLE.DRIVERID = driver.ID;
                                    TransportVehicleModel.DriverId = driver.ID;
                                    if (_APPLICATION_VEHICLE != null && _APPLICATION_VEHICLE.DRIVERID != null)
                                    {
                                        result4 = transportContext.DatabaseEntities.SaveChanges();
                                        if (result4 == 1) break;
                                    }
                                }
                            }
                        }
                    }
                    //result1 = transportContext.DatabaseEntities.SaveChanges();
                    return result1 & result2 & result3 & result4;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message.ToString());
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return 0;
        }

        public List<SelectListItem> GetCityList()
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    List<SelectListItem> CityList = new List<SelectListItem>();
                    var List = transportContext.DatabaseEntities.CITies.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        CityList.Add(new SelectListItem() { Text = "İLLER", Value = "0" });
                        //if (SelectedCity == 0)
                        //{
                        //    CityList[0].Selected = true;
                        //}
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            //if (SelectedCity == Item.ID)
                            //{
                            //    NewItem.Selected = true;
                            //}
                            NewItem.Text = Item.NAME.ToString();
                            NewItem.Value = Item.ID.ToString();
                            CityList.Add(NewItem);
                        }
                    }
                    return CityList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetUserList()
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    List<SelectListItem> UserList = new List<SelectListItem>();
                    var List = transportContext.DatabaseEntities.USERs.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        UserList.Add(new SelectListItem() { Text = "KULLANICILAR", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.IDENTITYNUMBER.ToString() + " - " +
                                Item.NAME.ToString() + " " + Item.SURNAME.ToString() + " - " + 
                                Item.USERNAME.ToString();
                            NewItem.Value = Item.ID.ToString();
                            UserList.Add(NewItem);
                        }
                    }
                    return UserList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetTransportTypeList()
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    List<SelectListItem> TransportTypeList = new List<SelectListItem>();
                    var List = transportContext.DatabaseEntities.TRANSPORTTYPEs.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        TransportTypeList.Add(new SelectListItem() { Text = "TAŞIMA TİPLERİ", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.TYPE.ToString();
                            NewItem.Value = Item.ID.ToString();
                            TransportTypeList.Add(NewItem);
                        }
                    }
                    return TransportTypeList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public static string EncryptPasswordBase64(string text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string DecryptPasswordBase64(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }

    #endregion   
}
