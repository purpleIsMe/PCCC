using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _uow;

        public CityService(ICityRepository cityRepository, 
            IDistrictRepository districtRepository,
            IUnitOfWork uow)
        {
            _cityRepository = cityRepository;
            _districtRepository = districtRepository;
            _uow = uow;
        }

        public IEnumerable<City> GetAllCity()
        {
            return _cityRepository.GetAll();
        }


        public bool InsertCity(City city)
        {
            _cityRepository.Add(city);
            return _uow.SaveChanges();
        }

        public bool InsertDistrict(District district)
        {
            _districtRepository.Add(district);
            return _uow.SaveChanges();
        }

        public string testMethod()
        {
            return "Hello world";
        }

        public bool UpdateCity(City city)
        {
            _cityRepository.Update(city);
            return _uow.SaveChanges();
        }

        public bool UpdateDistrict(District district)
        {
            _districtRepository.Update(district);
            return _uow.SaveChanges();
        }
    }
}
