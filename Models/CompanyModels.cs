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
using System.Web.Mvc;


//
// Neslihan ATALAY
namespace TransportationMvc2Project.Models
{
    #region Models

    public class CompanyModel
    {        
        private int _id;
        private string _name;
        private string _owner;
        private string _telephone;
        private string _fax;
        private string _email;
        private int _addressId;
        private AddressModel _address;
        private DateTime _establishmentDate;

        [Key]
        [Required]
        [DisplayName("ŞİRKET ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("ŞİRKET ADI")]                
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DisplayName("ŞİRKET SAHİBİ ADI")]                
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        [DisplayName("ŞİRKET TELEFON NUMARASI")]                
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        [DisplayName("ŞİRKET FAKS NUMARASI")]                
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        [DisplayName("ŞİRKET EPOSTA ADRESİ")]        
        public string Email
        {
            get { return _email; }
            set { _email = value; }
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
        [DisplayName("ŞİRKET KURULUŞ TARİHİ (dd-mm-yy hh:MM:ss)")]        
        public DateTime EstablishmentDate
        {
            get { return _establishmentDate; }
            set { _establishmentDate = value; }
        }
    }
    public class EmployeeModel
    {        
        private int _id;        
        private string _name;        
        private string _surname;        
        private string _identityNumber;        
        private string _telephone;        
        private string _email;        
        private Char _gender;
        private DateTime _birthDate;
        private int _addressId;
        private AddressModel _address;
        private int _companyId;
        private CompanyModel _company;
        private int _employeeTypeId;
        private EmployeeTypeModel _employeeType;
        private string _driverLicenseGroup;        
        private string _driverLicenseNumber;

        [Key]
        [Required]
        [DisplayName("PERSONEL ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("PERSONEL ADI")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DisplayName("PERSONEL SOYADI")]
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        [DisplayName("PERSONEL KİMLİK NUMARASI")]
        [StringLength(11)]
        public string IdentityNumber
        {
            get { return _identityNumber; }
            set { _identityNumber = value; }
        }
        [DisplayName("PERSONEL TELEFON NUMARASI")]
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        [DisplayName("PERSONEL EPOSTA ADRESİ")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DisplayName("PERSONEL CİNSİYETİ")]
        public Char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [DisplayName("PERSONEL DOĞUM TARİHİ (dd-mm-yy hh:MM:ss)")]
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
        public int CompanyId
        {
            get { return _companyId; }
            set { _companyId = value; }
        }
        public CompanyModel Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public int EmployeeTypeId
        {
            get { return _employeeTypeId; }
            set { _employeeTypeId = value; }
        }
        public EmployeeTypeModel EmployeeType
        {
            get { return _employeeType; }
            set { _employeeType = value; }
        }
        [DisplayName("PERSONEL EHLİYET SINIFI (SÜRÜCÜ İSE)")]
        public string DriverLicenseGroup
        {
            get { return _driverLicenseGroup; }
            set { _driverLicenseGroup = value; }
        }
        [DisplayName("PERSONEL EHLİYET NUMARASI (SÜRÜCÜ İSE)")]
        public string DriverLicenseNumber
        {
            get { return _driverLicenseNumber; }
            set { _driverLicenseNumber = value; }
        }
    }
    public class EmployeeTypeModel
    {
        private int _id;
        private string _type;

        [Key]
        [Required]
        [DisplayName("PERSONEL TİPİ ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("PERSONEL TİPİ / MESLEK")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
    public class VehicleModel
    {        
        private int _id;        
        private string _vehiclePlate;
        private int _vehicleTypeId;
        private VehicleTypeModel _vehicleType;
        private int _transportTypeId;
        private TransportTypeModel _transportType;
        private int _companyId;
        private CompanyModel _company;
        private Decimal _weightCapacity;
        private Decimal _unitPrice;

        [Key]
        [Required]
        [DisplayName("ARAÇ ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("ARAÇ PLAKA NUMARASI")]
        public string PlateNumber
        {
            get { return _vehiclePlate; }
            set { _vehiclePlate = value; }
        }
        public int VehicleTypeId
        {
            get { return _vehicleTypeId; }
            set { _vehicleTypeId = value; }
        }
        public VehicleTypeModel VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
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
        public int CompanyId
        {
            get { return _companyId; }
            set { _companyId = value; }
        }
        public CompanyModel Company
        {
            get { return _company; }
            set { _company = value; }
        }
        [DisplayName("ARAÇ MAKSİMUM KAPASİTESİ (TON)")]
        public Decimal WeightCapacity
        {
            get { return _weightCapacity; }
            set { _weightCapacity = value; }
        }
        [DisplayName("ARAÇ TAŞIMA KİLOMETRE FİYATI (TÜRK LİRASI)")]
        public Decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
    }
    public class VehicleTypeModel
    {        
        private int _id;        
        private string _type;

        [Key]
        [Required]
        [DisplayName("ARAÇ TİPİ ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("ARAÇ TİPİ")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
    public class TransportTypeModel
    {
        private int _id;
        private string _type;
        [Key]
        [Required]
        [DisplayName("TAŞIMA TİPİ ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("TAŞIMA TİPİ")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
    public class VehicleEmployeeModel
    {        
        private int _id;
        private int _vehicleId;
        private VehicleModel _vehicle;
        private int _employeeId;
        private EmployeeModel _employee;

        [Key]
        [Required]
        [DisplayName("ARAÇ - PERSONEL ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        public EmployeeModel Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
    }

    #endregion

    #region Contexts

    public class CompanyContext : DbContext
    {
        protected TransportationDatabaseEntities databaseEntities;
        public TransportationDatabaseEntities DatabaseEntities
        {
            //get { return new TransportationDatabaseEntities(); }
            get { return databaseEntities; }
            set { databaseEntities = value; }
        }
        private TransportContext transportContext;
        public TransportContext TransportContext
        {
            get { return transportContext; }
            set { transportContext = value; }
        }
        public CompanyContext()
        {
            //CompanyService = new CompanyService();
            TransportContext = new TransportContext();
            DatabaseEntities = new TransportationDatabaseEntities();
        }    
    }

    #endregion
    
    /*
    #region Repositories

    public interface ICompanyRepositoy<T>
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

    public class CompanyRepository<T> : ICompanyRepositoy<T> where T : class
    {
        protected TransportService transportService;
        protected CompanyContext companyContext;
        protected TransportContext transportContext;
        public CompanyRepository(CompanyContext contextCompany)
        {
            companyContext = contextCompany;
            transportContext = new TransportContext();
            //transportService = new TransportService(transportContext);
        }
        public T GetById(int id)
        {
            return companyContext.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return companyContext.Set<T>().ToList();
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return companyContext.Set<T>().Where(expression);
        }
        public int Add(T entity)
        {
            companyContext.Set<T>().Add(entity);
            return companyContext.SaveChanges();
        }
        public int AddRange(IEnumerable<T> entities)
        {
            int result = 0;
            foreach (T entity in entities)
            {
                companyContext.Set<T>().Add(entity);
                companyContext.SaveChanges();
                result = 1;
            }
            return result;
        }        
        public int Delete(T entity)
        {
            companyContext.Set<T>().Remove(entity);
            return companyContext.SaveChanges();
        }
        public int DeleteRange(IEnumerable<T> entities)
        {
            int result = 0;
            foreach (T entity in entities)
            {
                companyContext.Set<T>().Remove(entity);
                companyContext.SaveChanges();
                result = 1;
            }
            return result;
        }
        public int Update(T entity)
        {
            companyContext.Entry(entity).State = EntityState.Modified;
            return companyContext.SaveChanges();
        }
        public int UpdateRange(IEnumerable<T> entities)
        {
            int result = 0;
            foreach (T entity in entities)
            {
                result = 0;
                companyContext.Entry(entity).State = EntityState.Modified;
                companyContext.SaveChanges();
                result = 1;
            }
            return result;
        }
    }

    #endregion
     * */
    
    #region Services

    public interface ICompanyService
    {
        int AddCompany(CompanyModel companyModel);
        int AddVehicle(VehicleModel VehicleModel);
        int AddEmployee(EmployeeModel EmployeeModel);
        int AddVehicleEmployee(VehicleEmployeeModel VehicleEmployeeModel);
        List<SelectListItem> GetVehicleTypeList();
        List<SelectListItem> GetCompanyList();
        List<SelectListItem> GetTransportTypeList();
        List<SelectListItem> GetVehicleList();
        List<SelectListItem> GetVehicleList(int transportTypeId);
        List<SelectListItem> GetEmployeeList(Boolean isManager);
        List<SelectListItem> GetEmployeeTypeList();
        List<SelectListItem> GetTransportList(int userId);
    }

    public class CompanyService : ICompanyService
    {
        public CompanyService() { }

        public int AddCompany(CompanyModel CompanyModel)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0;
                    var _COMPANY = new COMPANY
                    {
                        NAME = CompanyModel.Name,
                        OWNER = CompanyModel.Owner,
                        TELEPHONE = CompanyModel.Telephone,
                        FAX = CompanyModel.Fax,
                        EMAIL = CompanyModel.Email,
                        ESTABLISHMENTDATE = CompanyModel.EstablishmentDate
                    };
                    {
                        if (CompanyModel != null && (companyContext.DatabaseEntities.COMPANies.Where
                            (c => c.NAME == CompanyModel.Name).FirstOrDefault() == null))
                        {
                            if (_COMPANY.ID == 0)
                            {
                                if (companyContext.DatabaseEntities.COMPANies.ToList().Count != 0)
                                    _COMPANY.ID = companyContext.DatabaseEntities.COMPANies.Max(c => c.ID) + 1;
                                else
                                    _COMPANY.ID = 1;
                            }
                            if (_COMPANY.ID != 0)
                            {
                                //Şirket bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                companyContext.DatabaseEntities.COMPANies.AddObject(_COMPANY);
                                result1 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        _COMPANY = companyContext.DatabaseEntities.COMPANies.ToList().Where
                            (c => c.NAME == CompanyModel.Name).FirstOrDefault();
                        if (_COMPANY.ID != 0)
                        {
                            CompanyModel.Id = _COMPANY.ID;
                        }
                    }
                    {
                        CompanyModel.Address.City.Name = companyContext.DatabaseEntities.CITies
                            .Where(c => c.ID == CompanyModel.Address.CityId).FirstOrDefault().NAME;
                        //Şirketin adresi kayıtlı değilse yeni adres eklenir.
                        if (CompanyModel.Address != null
                            && companyContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == CompanyModel.Address.CityId && a.TOWN == CompanyModel.Address.Town
                            && a.NEIGHBOURHOOD == CompanyModel.Address.Neighbourhood
                            && a.STREET == CompanyModel.Address.Street
                            && a.HOMESTREET == CompanyModel.Address.HomeStreet
                            && a.BUILDINGNO == CompanyModel.Address.BuildingNo
                            && a.INNERDOORNO == CompanyModel.Address.InnerDoorNo).FirstOrDefault() == null)
                        {
                            result2 = companyContext.TransportContext.TransportService.AddAddress(CompanyModel.Address);
                        }
                        //Şirketin adresi kayıtlı ise adresi güncellenir.
                        if (CompanyModel.Address != null
                            && companyContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == CompanyModel.Address.CityId && a.TOWN == CompanyModel.Address.Town
                            && a.NEIGHBOURHOOD == CompanyModel.Address.Neighbourhood
                            && a.STREET == CompanyModel.Address.Street
                            && a.HOMESTREET == CompanyModel.Address.HomeStreet
                            && a.BUILDINGNO == CompanyModel.Address.BuildingNo
                            && a.INNERDOORNO == CompanyModel.Address.InnerDoorNo).FirstOrDefault() != null)
                        {
                            var _ADDRESS = companyContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.CITYID == CompanyModel.Address.CityId
                                && a.TOWN == CompanyModel.Address.Town
                                && a.NEIGHBOURHOOD == CompanyModel.Address.Neighbourhood
                                && a.STREET == CompanyModel.Address.Street
                                && a.HOMESTREET == CompanyModel.Address.HomeStreet
                                && a.BUILDINGNO == CompanyModel.Address.BuildingNo
                                && a.INNERDOORNO == CompanyModel.Address.InnerDoorNo).FirstOrDefault();
                            _COMPANY.ADDRESSID = _ADDRESS.ID;
                            CompanyModel.AddressId = _ADDRESS.ID;
                            if (_COMPANY != null)
                            {
                                result3 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    return result1 & result2 & result3;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.Message);
                }
            }
            return 0;
        }

        public int AddVehicle(VehicleModel VehicleModel)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0;
                    var _VEHICLE = new VEHICLE
                    {
                        PLATENUMBER = VehicleModel.PlateNumber,
                        WEIGHTCAPACITY = VehicleModel.WeightCapacity,
                        UNITPRICE = VehicleModel.UnitPrice
                    };
                    {
                        if (VehicleModel != null
                            && (companyContext.DatabaseEntities.VEHICLEs.Where
                            (v => v.PLATENUMBER == VehicleModel.PlateNumber).FirstOrDefault() == null))
                        {
                            if (_VEHICLE.ID == 0)
                            {
                                if (companyContext.DatabaseEntities.VEHICLEs.ToList().Count != 0)
                                    _VEHICLE.ID = companyContext.DatabaseEntities.VEHICLEs.Max(v => v.ID) + 1;
                                else
                                    _VEHICLE.ID = 1;
                            }
                            if (_VEHICLE.ID != 0)
                            {
                                //Araç bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                companyContext.DatabaseEntities.VEHICLEs.AddObject(_VEHICLE);
                                result1 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        _VEHICLE = companyContext.DatabaseEntities.VEHICLEs.Where
                            (v => v.PLATENUMBER == VehicleModel.PlateNumber).FirstOrDefault();
                        if (_VEHICLE.ID != 0)
                        {
                            VehicleModel.Id = _VEHICLE.ID;
                        }
                    }
                    {
                        VehicleModel.VehicleType.Type = companyContext.DatabaseEntities.VEHICLETYPEs
                            .Where(v => v.ID == VehicleModel.VehicleTypeId).FirstOrDefault().TYPE;
                        //Aracın tipi kayıtlı değilse araç bilgilerine yeni araç tipi eklenir.
                        if (VehicleModel.VehicleTypeId != null && VehicleModel.VehicleTypeId != 0)
                        {
                            _VEHICLE.VEHICLETYPEID = VehicleModel.VehicleTypeId;
                            var _VEHICLETYPE = companyContext.DatabaseEntities.VEHICLETYPEs.Where
                                (v => v.ID == VehicleModel.VehicleTypeId).FirstOrDefault();
                            _VEHICLE.VEHICLETYPE = _VEHICLETYPE;
                            if (_VEHICLE != null)
                            {
                                result2 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        VehicleModel.TransportType.Type = companyContext.DatabaseEntities.TRANSPORTTYPEs
                            .Where(v => v.ID == VehicleModel.TransportTypeId).FirstOrDefault().TYPE;
                        //Aracın taşıma tipi kayıtlı değilse araç bilgilerine yeni taşıma tipi eklenir.
                        if (VehicleModel.TransportTypeId != null && VehicleModel.TransportTypeId != 0)
                        {
                            _VEHICLE.TRANSPORTTYPEID = VehicleModel.TransportTypeId;
                            var _TRANSPORTTYPE = companyContext.DatabaseEntities.TRANSPORTTYPEs.Where
                                (v => v.ID == VehicleModel.TransportTypeId).FirstOrDefault();
                            _VEHICLE.TRANSPORTTYPE = _TRANSPORTTYPE;
                            if (_VEHICLE != null)
                            {
                                result2 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        if (VehicleModel.CompanyId != null && VehicleModel.CompanyId != 0)
                        {
                            _VEHICLE.COMPANYID = VehicleModel.CompanyId;
                            var _COMPANY = companyContext.DatabaseEntities.COMPANies.Where
                                (c => c.ID == VehicleModel.CompanyId).FirstOrDefault();
                            _VEHICLE.COMPANY = _COMPANY;
                            if (_VEHICLE != null)
                            {
                                result3 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    return result1 & result2 & result3;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return 0;            
        }

        public int AddEmployee(EmployeeModel EmployeeModel)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0; var result4 = 0;
                    var _EMPLOYEE = new EMPLOYEE
                    {
                        NAME = EmployeeModel.Name,
                        SURNAME = EmployeeModel.Surname,
                        IDENTITYNUMBER = EmployeeModel.IdentityNumber,
                        TELEPHONE = EmployeeModel.Telephone,
                        EMAIL = EmployeeModel.Email,
                        GENDER = EmployeeModel.Gender.ToString(),
                        BIRTHDATE = Convert.ToDateTime(EmployeeModel.BirthDate),
                        DRIVERLICENSEGROUP = EmployeeModel.DriverLicenseGroup,
                        DRIVERLICENSENUMBER = EmployeeModel.DriverLicenseNumber
                    };
                    {
                        if (EmployeeModel != null
                            && (companyContext.DatabaseEntities.EMPLOYEEs.Where
                            (e => e.IDENTITYNUMBER == EmployeeModel.IdentityNumber
                            && e.NAME == EmployeeModel.Name && e.SURNAME == EmployeeModel.Surname).FirstOrDefault() == null))
                        {
                            if (_EMPLOYEE.ID == 0)
                            {
                                if (companyContext.DatabaseEntities.EMPLOYEEs.ToList().Count != 0)
                                    _EMPLOYEE.ID = companyContext.DatabaseEntities.EMPLOYEEs.Max(e => e.ID) + 1;
                                else
                                    _EMPLOYEE.ID = 1;
                            }
                            if (_EMPLOYEE.ID != 0)
                            {
                                //Personel bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                companyContext.DatabaseEntities.EMPLOYEEs.AddObject(_EMPLOYEE);
                                result1 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        if (_EMPLOYEE.ID != 0)
                        {
                            _EMPLOYEE = companyContext.DatabaseEntities.EMPLOYEEs.Where(e => e.ID == _EMPLOYEE.ID).FirstOrDefault();
                        }
                        else
                        {
                            _EMPLOYEE = companyContext.DatabaseEntities.EMPLOYEEs.Where
                                (e => e.IDENTITYNUMBER == EmployeeModel.IdentityNumber
                                && e.NAME == EmployeeModel.Name && e.SURNAME == EmployeeModel.Surname).FirstOrDefault();
                        }
                        if (_EMPLOYEE.ID != 0)
                        {
                            EmployeeModel.Id = _EMPLOYEE.ID;
                        }
                    }
                    {
                        //Personelin adresi kayıtlı ise adresi güncellenir.
                        EmployeeModel.Address.City.Name = companyContext.DatabaseEntities.CITies
                            .Where(c => c.ID == EmployeeModel.Address.CityId).FirstOrDefault().NAME;
                        //Şirketin adresi kayıtlı değilse yeni adres eklenir.
                        if (EmployeeModel.Address != null
                            && companyContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == EmployeeModel.Address.CityId && a.TOWN == EmployeeModel.Address.Town
                            && a.NEIGHBOURHOOD == EmployeeModel.Address.Neighbourhood
                            && a.STREET == EmployeeModel.Address.Street
                            && a.HOMESTREET == EmployeeModel.Address.HomeStreet
                            && a.BUILDINGNO == EmployeeModel.Address.BuildingNo
                            && a.INNERDOORNO == EmployeeModel.Address.InnerDoorNo).FirstOrDefault() == null)
                        {
                            result2 = companyContext.TransportContext.TransportService.AddAddress(EmployeeModel.Address);
                        }
                        //Şirketin adresi kayıtlı ise adresi güncellenir.
                        if (EmployeeModel.Address != null
                            && companyContext.DatabaseEntities.ADDRESSes.Where
                            (a => a.CITYID == EmployeeModel.Address.CityId && a.TOWN == EmployeeModel.Address.Town
                            && a.NEIGHBOURHOOD == EmployeeModel.Address.Neighbourhood
                            && a.STREET == EmployeeModel.Address.Street
                            && a.HOMESTREET == EmployeeModel.Address.HomeStreet
                            && a.BUILDINGNO == EmployeeModel.Address.BuildingNo
                            && a.INNERDOORNO == EmployeeModel.Address.InnerDoorNo).FirstOrDefault() != null)
                        {
                            var _ADDRESS = companyContext.DatabaseEntities.ADDRESSes.Where
                                (a => a.CITYID == EmployeeModel.Address.CityId
                                && a.TOWN == EmployeeModel.Address.Town
                                && a.NEIGHBOURHOOD == EmployeeModel.Address.Neighbourhood
                                && a.STREET == EmployeeModel.Address.Street
                                && a.HOMESTREET == EmployeeModel.Address.HomeStreet
                                && a.BUILDINGNO == EmployeeModel.Address.BuildingNo
                                && a.INNERDOORNO == EmployeeModel.Address.InnerDoorNo)
                                .FirstOrDefault();
                            _EMPLOYEE.ADDRESSID = _ADDRESS.ID;
                            EmployeeModel.AddressId = _ADDRESS.ID;
                            if (_EMPLOYEE != null)
                            {
                                result3 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Personelin çalıştığı şirket kayıtlı değilse güncellenir.
                        if (EmployeeModel.Company != null && EmployeeModel.CompanyId != 0)
                        {
                            _EMPLOYEE.COMPANYID = EmployeeModel.CompanyId;
                            var _COMPANY = companyContext.DatabaseEntities.COMPANies.Where
                                (c => c.ID == EmployeeModel.CompanyId).FirstOrDefault();
                            _EMPLOYEE.COMPANY = _COMPANY;
                            if (_EMPLOYEE != null)
                            {
                                result3 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Personelin tipi kayıtlı değilse güncellenir.
                        if (EmployeeModel.EmployeeType != null && EmployeeModel.EmployeeTypeId != 0)
                        {
                            _EMPLOYEE.EMPLOYEETYPEID = EmployeeModel.EmployeeTypeId;
                            var _EMPLOYEETYPE = companyContext.DatabaseEntities.EMPLOYEETYPEs.Where
                                (et => et.ID == EmployeeModel.EmployeeTypeId).FirstOrDefault();
                            _EMPLOYEE.EMPLOYEETYPE = _EMPLOYEETYPE;
                            if (_EMPLOYEETYPE != null)
                            {
                                result4 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    return result1 & result2 & result3 & result4;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return 0;
        }

        public int AddVehicleEmployee(VehicleEmployeeModel VehicleEmployeeModel)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    var result1 = 0; var result2 = 0; var result3 = 0;
                    var _VEHICLEEMPLOYEE = new VEHICLE_EMPLOYEE
                    {

                    };
                    {
                        if (VehicleEmployeeModel != null &&
                            (companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.Where(ve => ve.VEHICLEID == VehicleEmployeeModel.VehicleId
                            && ve.EMPLOYEEID == VehicleEmployeeModel.EmployeeId).FirstOrDefault() == null))
                        {
                            if (_VEHICLEEMPLOYEE.ID == 0)
                            {
                                if (companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.ToList().Count != 0)
                                    _VEHICLEEMPLOYEE.ID = companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.Max(e => e.ID) + 1;
                                else
                                    _VEHICLEEMPLOYEE.ID = 1;
                            }
                            if (_VEHICLEEMPLOYEE.ID != 0)
                            {
                                //Araç-Personel bilgileri veritabanında yoksa bilgiler veritabanına kaydedilir.
                                companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.AddObject(_VEHICLEEMPLOYEE);
                                result1 = companyContext.DatabaseEntities.SaveChanges();

                                _VEHICLEEMPLOYEE = companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.Where
                                    (ve => ve.ID == _VEHICLEEMPLOYEE.ID).FirstOrDefault();
                            }
                        }
                        else
                        {
                            _VEHICLEEMPLOYEE = companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.Where
                                (ve => ve.VEHICLEID == VehicleEmployeeModel.VehicleId
                                && ve.EMPLOYEEID == VehicleEmployeeModel.EmployeeId).FirstOrDefault();
                        }
                    }
                    {
                        if (_VEHICLEEMPLOYEE.ID != 0)
                        {
                            _VEHICLEEMPLOYEE = companyContext.DatabaseEntities.VEHICLE_EMPLOYEE.Where
                                (ve => ve.ID == _VEHICLEEMPLOYEE.ID).FirstOrDefault();
                            VehicleEmployeeModel.Id = _VEHICLEEMPLOYEE.ID;
                        }
                    }
                    {
                        //Araç-Personel tablosuna Araç eklenir.
                        if (VehicleEmployeeModel.VehicleId != null && VehicleEmployeeModel.VehicleId != 0)
                        {
                            _VEHICLEEMPLOYEE.VEHICLEID = VehicleEmployeeModel.VehicleId;
                            var _VEHICLE = companyContext.DatabaseEntities.VEHICLEs.Where
                                (v => v.ID == VehicleEmployeeModel.VehicleId).FirstOrDefault();
                            _VEHICLEEMPLOYEE.VEHICLE = _VEHICLE;
                            if (_VEHICLEEMPLOYEE != null)
                            {
                                result2 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    {
                        //Araç-Personel tablosuna Personel eklenir.
                        if (VehicleEmployeeModel.EmployeeId != null && VehicleEmployeeModel.EmployeeId != 0)
                        {
                            _VEHICLEEMPLOYEE.EMPLOYEEID = VehicleEmployeeModel.EmployeeId;
                            var _EMPLOYEE = companyContext.DatabaseEntities.EMPLOYEEs.Where
                                (e => e.ID == VehicleEmployeeModel.EmployeeId).FirstOrDefault();
                            _VEHICLEEMPLOYEE.EMPLOYEE = _EMPLOYEE;
                            if (_VEHICLEEMPLOYEE != null)
                            {
                                result3 = companyContext.DatabaseEntities.SaveChanges();
                            }
                        }
                    }
                    return result1 & result2 & result3;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return 0;
        }

        public List<SelectListItem> GetVehicleTypeList()
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    List<SelectListItem> VehicleTypeList = new List<SelectListItem>();
                    var List = transportContext.DatabaseEntities.VEHICLETYPEs.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        VehicleTypeList.Add(new SelectListItem() { Text = "ARAÇ TİPLERİ", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.TYPE.ToString();
                            NewItem.Value = Item.ID.ToString();
                            VehicleTypeList.Add(NewItem);
                        }
                    }
                    return VehicleTypeList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetCompanyList()
        {
            using (var transportContext = new TransportContext())
            {
                try
                {
                    List<SelectListItem> CompanyList = new List<SelectListItem>();
                    var List = transportContext.DatabaseEntities.COMPANies.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        CompanyList.Add(new SelectListItem() { Text = "ŞİRKETLER", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.NAME.ToString();
                            NewItem.Value = Item.ID.ToString();
                            CompanyList.Add(NewItem);
                        }
                    }
                    return CompanyList;
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

        public List<SelectListItem> GetVehicleList()
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    List<SelectListItem> VehicleList = new List<SelectListItem>();
                    var List = companyContext.DatabaseEntities.VEHICLEs.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        VehicleList.Add(new SelectListItem() { Text = "ARAÇLAR", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.COMPANY.NAME.ToString() + " - " 
                                + Item.VEHICLETYPE.TYPE.ToString() + " - " + Item.PLATENUMBER.ToString();
                            NewItem.Value = Item.ID.ToString();
                            VehicleList.Add(NewItem);
                        }
                    }
                    return VehicleList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetVehicleList(int transportTypeId)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    List<SelectListItem> VehicleList = new List<SelectListItem>();
                    var List = companyContext.DatabaseEntities.VEHICLEs.
                        Where(v => v.TRANSPORTTYPEID == transportTypeId).ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        VehicleList.Add(new SelectListItem() { Text = "ARAÇLAR", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.COMPANY.NAME.ToString() + " - "
                                + Item.VEHICLETYPE.TYPE.ToString() + " - " + Item.PLATENUMBER.ToString()
                                + " - Maks Ağırlık Kapasitesi:" + Item.WEIGHTCAPACITY;
                            NewItem.Value = Item.ID.ToString();
                            VehicleList.Add(NewItem);
                        }
                    }
                    return VehicleList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetEmployeeList(Boolean isManager)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    List<SelectListItem> EmployeeList = new List<SelectListItem>();
                    var List = companyContext.DatabaseEntities.EMPLOYEEs.ToList();
                    if (isManager == false)
                    {
                        List = companyContext.DatabaseEntities.EMPLOYEEs.Where(e => e.EMPLOYEETYPEID == 2
                            || e.EMPLOYEETYPEID == 3).ToList();
                    }
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        EmployeeList.Add(new SelectListItem() { Text = "PERSONELLER", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.IDENTITYNUMBER.ToString() 
                                + " - " + Item.NAME.ToString() + " " + Item.SURNAME.ToString()
                                + " - " + Item.EMPLOYEETYPE.TYPE.ToString();
                            NewItem.Value = Item.ID.ToString();
                            EmployeeList.Add(NewItem);
                        }
                    }
                    return EmployeeList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetEmployeeTypeList()
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    List<SelectListItem> EmployeeTypeList = new List<SelectListItem>();
                    var List = companyContext.DatabaseEntities.EMPLOYEETYPEs.ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        EmployeeTypeList.Add(new SelectListItem() { Text = "PERSONEL TİPLERİ / MESLEKLER", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.TYPE.ToString();
                            NewItem.Value = Item.ID.ToString();
                            EmployeeTypeList.Add(NewItem);
                        }
                    }
                    return EmployeeTypeList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }

        public List<SelectListItem> GetTransportList(int userId)
        {
            using (var companyContext = new CompanyContext())
            {
                try
                {
                    List<SelectListItem> ApplicationList = new List<SelectListItem>();
                    var List = companyContext.DatabaseEntities.APPLICATIONs.
                        Where(a => a.USERID == userId).ToList();
                    if (List != null && List.Count > 0)
                    {
                        SelectListItem NewItem = null;
                        ApplicationList.Add(new SelectListItem() { Text = "TAŞIMA TALEPLERİ", Value = "0" });
                        foreach (var Item in List)
                        {
                            NewItem = new SelectListItem();
                            NewItem.Text = Item.TRANSPORTTYPE.TYPE.ToString() + " - " + Item.TRANSPORTDATE.ToString();
                            NewItem.Value = Item.ID.ToString();
                            ApplicationList.Add(NewItem);
                        }
                    }
                    return ApplicationList;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.InnerException.ToString());
                }
            }
            return null;
        }
        
    }

    #endregion
}
