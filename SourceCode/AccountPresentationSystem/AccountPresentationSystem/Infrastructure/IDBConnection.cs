using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationSystem.Infrastructure
{
    public interface IDBConnection
    {
        DataTable SelectQuery(string SQL);
        int ExecuteStatement(string SQL);
    }
}
