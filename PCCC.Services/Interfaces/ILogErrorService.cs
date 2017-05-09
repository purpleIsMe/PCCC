using PCCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Services.Interfaces
{
    public interface ILogErrorService
    {
        IEnumerable<LogError> GetAllLogError();

        bool InsertLogError(LogError log);

        bool UpdateLogError(LogError log);

        bool DeleteLogError(int id);
    }
}
