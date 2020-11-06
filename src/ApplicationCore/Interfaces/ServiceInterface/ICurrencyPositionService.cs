using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.CustomModels;

namespace ApplicationCore.Interfaces.ServiceInterface
{
    public interface ICurrencyPositionService
    {
        Task<List<CurrencyPosition>> GetCurrencyPositions(DateTime date1, DateTime date2, int HideAbsNum);
    }
}
