using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.CustomModels;
using ApplicationCore.Interfaces.ServiceInterface;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;

namespace Infrastructure.Data.Services
{
    public class CurrencyPositionService : ICurrencyPositionService
    {
        private readonly CustomModelContext _context;

        public CurrencyPositionService(CustomModelContext context)
        {
            _context = context;
        }

        public Task<List<CurrencyPosition>> GetCurrencyPositions(DateTime date1, DateTime date2, int hideAbsNum)
        {
            date1 = date1.Date;
            date2 = date2.Date;

            var dateClause = date1 == date2
                ? $"pos.DVALUEDATE (+)= :date1"
                : $"pos.DVALUEDATE (+)between :date1 and :date2";

            return _context.CurrencyPositions
                .FromSqlRaw(
                    @$"SELECT * FROM 
                (SELECT distinct rem.CACC,
            rem.CACCTYPECODE,
            rem.CCURRCODE,
            rem.NACCKEY,
            GETREM(rem.NACCKEY, :date2, rem.CCURRCODE, :hideAbsNum) AS NSUM,
                nvl(sum(pos.NSUM * decode(pos.isb, 1, 0, 1)), 0) as ndeb,
            nvl(sum(pos.NSUM * decode(pos.isb, 2, 0, 1)), 0) as ncred,
            GETREM(rem.NACCKEY, :date1 - 1, rem.CCURRCODE, 0) AS NIN,
                rem.BACTIVE
                from CURRACC rem, v_currpos pos
            where {dateClause} and pos.NACCKEY(+) = rem.NACCKEY and pos.CCURRCODE(+) = rem.CCURRCODE and {"0=0" /*TODO CTYPE*/} and {"0=0" /*TODO WHERE*/} AND {"0=0" /*TODO HIDEAB*/}
            GROUP BY rem.cacc, rem.cacctypecode, rem.ccurrcode, rem.nacckey, rem.bactive) WHERE {"0=0" /*TODO ACTIVE*/}                
            ",
                    new OracleParameter("date1", date1),
                    new OracleParameter("date2", date2),
                    new OracleParameter("hideAbsNum", hideAbsNum)).ToListAsync();

            return _context.CurrencyPositions.FromSqlInterpolated(@$"SELECT * FROM 
                (SELECT distinct rem.CACC,
            rem.CACCTYPECODE,
            rem.CCURRCODE,
            rem.NACCKEY,
            GETREM(rem.NACCKEY, {date2}, rem.CCURRCODE, {hideAbsNum}) AS NSUM,
                nvl(sum(pos.NSUM * decode(pos.isb, 1, 0, 1)), 0) as ndeb,
            nvl(sum(pos.NSUM * decode(pos.isb, 2, 0, 1)), 0) as ncred,
            GETREM(rem.NACCKEY, {date1} - 1, rem.CCURRCODE, 0) AS NIN,
                rem.BACTIVE
                from CURRACC rem, v_currpos pos
            where {dateClause} and pos.NACCKEY(+) = rem.NACCKEY and pos.CCURRCODE(+) = rem.CCURRCODE and {"0=0" /*TODO CTYPE*/} and {"0=0" /*TODO WHERE*/} AND {"0=0" /*TODO HIDEAB*/}
            GROUP BY rem.cacc, rem.cacctypecode, rem.ccurrcode, rem.nacckey, rem.bactive) WHERE {"0=0" /*TODO ACTIVE*/}                
            ").ToListAsync(); // TODO: ORDER
        }
    }
}