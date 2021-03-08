using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library_MVP.Logic.Services
{
    class CategoryService
    {       
        private static void categoryParameterInsert(int id,string name ,SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        /// <summary>
        /// Methoud to execute stored procedure insert category
        /// </summary>
        /// <param name="id">cat id</param>
        /// <param name="name">cat name</param>
        /// <returns></returns>
        public static bool categoryInsert(int id, string name)
        {
            return DBHelper.executeData("categoryInsert", () => categoryParameterInsert(id, name, DBHelper.cmd));
        }

        private static void categoryParameterUpdate(int id, string name, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /// <summary>
        /// Methoud to execute stored procedure to update category
        /// </summary>
        /// <param name="id">cat id</param>
        /// <param name="name">cat name</param>
        /// <returns></returns>
        public static bool categoryUpdate(int id, string name)
        {
            return DBHelper.executeData("categoryUpdate", () => categoryParameterUpdate(id, name, DBHelper.cmd));
        }

        private static void categoryParameterDelete(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        /// <summary>
        /// Methoud to execute stored procedure to delete one category
        /// </summary>
        /// <param name="id">cat id</param>
        /// <param name="name">cat name</param>
        /// <returns></returns>
        public static bool categoryDelete(int id)
        {
            return DBHelper.executeData("categoryDelete", () => categoryParameterDelete(id, DBHelper.cmd));
        }

        private static void categoryParameterDeleteAll()
        {
        }
        /// <summary>
        /// Methoud to execute stored procedure to delete all category
        /// </summary>
        /// <returns></returns>
        public static bool categoryDeleteAll()
        {
            return DBHelper.executeData("categoryDeleteAll", () => categoryParameterDeleteAll());
        }
    }
}
