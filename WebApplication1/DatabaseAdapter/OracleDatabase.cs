using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interface;

namespace WebApplication1.DatabaseAdapter
{
    public class OracleDatabase : IDatabase
    {
       public static int _counter = 0;
        public OracleDatabase()
        {
            if(_counter == 0)
            _counter++;
            else 
            _counter = -1;
        }

        public bool AddRecord()
        {
            // TODO: Added the records
            return false;
        }


    }
}