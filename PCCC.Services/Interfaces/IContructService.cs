using PCCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Services.Interfaces
{
    public interface IContructService
    {
        IEnumerable<Contruction> GetAllContruction();

        IEnumerable<Picture> GetAllPicture();

        IEnumerable<DetailFactor> GetAllDetailFactor();

        IEnumerable<Factor> GetAllFactor();

        IEnumerable<Formula> GetAllFormula();

        bool InsertContruction(Contruction Contruction);

        bool InsertPicture(Picture Picture);

        bool InsertFormula(Formula formula);

        bool InsertDetailFactor(DetailFactor detailFactor);

        bool InsertFactor(Factor factor);

        bool UpdateContruction(Contruction Contruction);

        bool UpdatePicture(Picture Picture);

        bool UpdateFormula(Formula formula);

        bool UpdateDetailFactor(DetailFactor detailFactor);

        bool UpdateFactor(Factor factor);

        bool DeleteContruction(int id);

        bool DeletePicture(int id);

        bool DeleteFormula(int id);

        bool DeleteDetailFactor(int id);

        bool DeleteFactor(int id);
    }
}
