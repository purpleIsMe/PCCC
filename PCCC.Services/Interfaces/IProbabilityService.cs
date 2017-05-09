using PCCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Services.Interfaces
{
    public interface IProbabilityService
    {
        IEnumerable<Probability> GetAllProbability();

        IEnumerable<Facility> GetAllFacility();

        bool InsertProbability(Probability probability);

        bool InsertFacility(Facility facility);

        bool UpdateProbability(Probability probability);

        bool UpdateFacility(Facility facility);

        bool DeleteProbability(int id);

        bool DeleteFacility(int id);
    }
}
