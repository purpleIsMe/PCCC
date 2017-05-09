using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Services.Implements
{
    class LogErrorService
    {
        private readonly ILogErrorRepository _logErrorRepository;
        private readonly IUnitOfWork _uow;

        public LogErrorService(ILogErrorRepository logErrorRepository, 
            IUnitOfWork uow)
        {
            _logErrorRepository = logErrorRepository;
            _uow = uow;
        }

        public LogErrorService()
        {
            // TODO: Complete member initialization
        }

        public IEnumerable<LogError> GetAllLogError()
        {
            return _logErrorRepository.GetAll();
        }

        public bool InsertLogError(LogError log)
        {
            _logErrorRepository.Add(log);
            return _uow.SaveChanges();
        }

        public bool UpdateLogError(LogError log)
        {
            _logErrorRepository.Update(log);
            return _uow.SaveChanges();
        }

        public bool DeleteLogError(int id)
        {
            _logErrorRepository.Delete(id);
            return _uow.SaveChanges();
        }
    }
}
