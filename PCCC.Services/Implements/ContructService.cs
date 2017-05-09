using PCCC.Services.Interfaces;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using PCCC.Repositories.Infrastructure;
using PCCC.Models;

namespace PCCC.Services.Implements
{
    public class ContructService : IContructService
    {
        private readonly IPicRepository _picRepository;
        private readonly IContructRepository _contructRepository;
        private readonly IFormulaRepository _formulaRepository;
        private readonly IDetailFactorRepository _detailFactorRepository;
        private readonly IFactorRepository _factorRepository;
        private readonly IUnitOfWork _uow;

        public ContructService(IPicRepository picRepository, 
            IContructRepository contructRepository,
            IFormulaRepository formulaRepository,
            IDetailFactorRepository detailFactorRepository,
            IFactorRepository factorRepository,
            IUnitOfWork uow)
        {
            _picRepository = picRepository;
            _contructRepository = contructRepository;
            _formulaRepository = formulaRepository;
            _detailFactorRepository = detailFactorRepository;
            _factorRepository = factorRepository;
            _uow = uow;
        }

        public ContructService()
        {
            // TODO: Complete member initialization
        }

        public IEnumerable<Contruction> GetAllContruction()
        {
            return _contructRepository.GetAll();
        }

        public IEnumerable<Picture> GetAllPicture()
        {
            return _picRepository.GetAll();
        }

        public IEnumerable<Formula> GetAllFormula()
        {
            return _formulaRepository.GetAll();
        }

        public IEnumerable<DetailFactor> GetAllDetailFactor()
        {
            return _detailFactorRepository.GetAll();
        }

        public IEnumerable<Factor> GetAllFactor()
        {
            return _factorRepository.GetAll();
        }

        public bool InsertPicture(Picture pic)
        {
            _picRepository.Add(pic);
            return _uow.SaveChanges();
        }

        public bool InsertContruction(Contruction con)
        {
            _contructRepository.Add(con);
            return _uow.SaveChanges();
        }

        public bool InsertDetailFactor(DetailFactor fac)
        {
            _detailFactorRepository.Add(fac);
            return _uow.SaveChanges();
        }

        public bool InsertFactor(Factor fac)
        {
            _factorRepository.Add(fac);
            return _uow.SaveChanges();
        }

        public bool InsertFormula(Formula formula)
        {
            _formulaRepository.Add(formula);
            return _uow.SaveChanges();
        }

        public bool UpdatePicture(Picture pic)
        {
            _picRepository.Update(pic);
            return _uow.SaveChanges();
        }

        public bool UpdateContruction(Contruction con)
        {
            _contructRepository.Update(con);
            return _uow.SaveChanges();
        }

        public bool UpdateDetailFactor(DetailFactor fac)
        {
            _detailFactorRepository.Update(fac);
            return _uow.SaveChanges();
        }

        public bool UpdateFactor(Factor fac)
        {
            _factorRepository.Update(fac);
            return _uow.SaveChanges();
        }

        public bool UpdateFormula(Formula formula)
        {
            _formulaRepository.Update(formula);
            return _uow.SaveChanges();
        }

        public bool DeletePicture(int id)
        {
            _picRepository.Delete(id);
            return _uow.SaveChanges();
        }

        public bool DeleteContruction(int id)
        {
            _contructRepository.Delete(id);
            return _uow.SaveChanges();
        }

        public bool DeleteDetailFactor(int id)
        {
            _detailFactorRepository.Delete(id);
            return _uow.SaveChanges();
        }

        public bool DeleteFactor(int id)
        {
            _factorRepository.Delete(id);
            return _uow.SaveChanges();
        }

        public bool DeleteFormula(int id)
        {
            _formulaRepository.Delete(id);
            return _uow.SaveChanges();
        }


        //public bool InsertContruction(Contruction Contruction)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool UpdateContruction(Contruction Contruction)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool DeleteContruction(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
