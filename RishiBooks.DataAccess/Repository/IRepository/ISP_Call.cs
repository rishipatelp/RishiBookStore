using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper;

namespace RishiBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        // First column of first row
        T Single<T>(string prodedurename, DynamicParameters param = null);

        //execute something to the database but not retrieve anything
        void Execute(string produurename, DynamicParameters param = null);

        //retrieves the complete row or records
        T OneRecord<T>(string producername, DynamicParameters param = null);

        //get all of the rows
        IEnumerable<T> List<T>(string producername, DynamicParameters param = null);

        //stored procedure that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string producername, DynamicParameters param = null);

    }
}
