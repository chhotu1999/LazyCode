using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroPasal.DataAccess
{
    public interface IDataAccessService
    {
        Task<IDbConnection> GetConnection();
    }
}
