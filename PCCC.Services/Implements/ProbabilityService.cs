using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using PCCC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Services.Implements
{
    public class ProbabilityService:IProbabilityService
    {
        private readonly IProbabilityRepository _probabilityRepository;
        private readonly IFacilityRepository _facilityRepository;
        private readonly IUnitOfWork _uow;

        public ProbabilityService(IProbabilityRepository probabilityRepository, 
            IFacilityRepository facilityRepository,
            IUnitOfWork uow)
        {
            _probabilityRepository = probabilityRepository;
            _facilityRepository = facilityRepository;
            _uow = uow;
        }

        public ProbabilityService()
        {
            // TODO: Complete member initialization
        }

        public IEnumerable<Probability> GetAllProbability()
        {
            return _probabilityRepository.GetAll();
        }

        public IEnumerable<Facility> GetAllFacility()
        {
            return _facilityRepository.GetAll();
        }

        public bool InsertProbability(Probability pro)
        {
            _probabilityRepository.Add(pro);
            return _uow.SaveChanges();
        }

        public bool InsertFacility(Facility fac)
        {
            _facilityRepository.Add(fac);
            return _uow.SaveChanges();
        }

        public bool UpdateProbability(Probability pro)
        {
            _probabilityRepository.Update(pro);
            return _uow.SaveChanges();
        }

        public bool UpdateFacility(Facility fac)
        {
            _facilityRepository.Update(fac);
            return _uow.SaveChanges();
        }

        public bool DeleteProbability(int id)
        {
            _probabilityRepository.Delete(id);
            return _uow.SaveChanges();
        }

        public bool DeleteFacility(int id)
        {
            _facilityRepository.Delete(id);
            return _uow.SaveChanges();
        }
    }
}
