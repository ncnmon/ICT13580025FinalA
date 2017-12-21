using ICT13580025FinalA.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT13580025FinalA.Helpers
{
    class DbHelper
    {
        SQLiteConnection db;
        public DbHelper(String dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Data>();
        }

    }
}
