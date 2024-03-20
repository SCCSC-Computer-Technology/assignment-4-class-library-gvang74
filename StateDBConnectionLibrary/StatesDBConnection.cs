using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using StateDBConnectionLibrary;
using System.Data.SqlClient;

namespace StateDBConnectionLibrary
{
    public static class StatesDBConnection
    {
        private static DataClasses1DataContext db = new DataClasses1DataContext();

        //SqlConnection connect = new SqlConnection(@"Data Source =.\SQLEXPRESS; AttachDbFilename=C:\Users\gong_\Desktop\2024SP - CPT 206 - A80S - Adv Event-Driven Program\gvang_CPT_206_StateApp2\gvang_CPT_206_StateApp2\50statesDB.mdf;Integrated Security = True; Connect Timeout = 30");

        //Disposes the database.
        public static void DisposeDatabaseConnection() { db.Dispose(); }




        //All State rows from the database</returns>
        //public static StateTable[] GetAllStates() => db.StateTables.ToArray();



        //All State rows from the database that match the parameters</returns>
        public static StateTable[] StateName(string stateName)
        {
            var state = db.StateTables;
            var result = stateName != "" ? state.Where((StateTable) => StateTable.StateName.Contains(stateName)) : state;
            
            return result.ToArray();
        }
        
       
    }
}


