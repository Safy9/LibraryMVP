using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    public class CountryService
    {
        private static void countryParameterInsert(int id,string name,SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /// <summary>
        /// Methoud to execute stored procedure insert country
        /// </summary>
        /// <param name="id">country id</param>
        /// <param name="name">country name</param>
        /// <returns></returns>
        public static bool countryInsert(int id,string name)
        {
            return DBHelper.executeData("countryInsert", () => countryParameterInsert(id,name,DBHelper.cmd));
        }

        private static void countryParameterUpdate(int id,string name ,SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /// <summary>
        /// Methoud to execute stored procedure update country
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool countryUpdate(int id, string name)
        {
            return DBHelper.executeData("countryUpdate", () => countryParameterUpdate(id, name, DBHelper.cmd));
        }

        private static void countryParameterDelete(int id,SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }


        /// <summary>
        /// Methoud to execute stored procedure Delete country
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool CountryDelete(int id)
        {
            return DBHelper.executeData("countryDelete", () => countryParameterDelete(id, DBHelper.cmd));
        }

        private static void countryParameterDeleteAll()
        {

        }
        /// <summary>
        /// Methoud to execute stored procedure Delete All country
        /// </summary>
        /// <returns></returns>
        public static bool countryDeleteAll()
        {
            return DBHelper.executeData("countryDeleteAll", () => countryParameterDeleteAll());
        }
    }
}
