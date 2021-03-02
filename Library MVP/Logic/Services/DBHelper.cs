using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Library_MVP.Logic.Services
{
    public class DBHelper
    {
        public static SqlCommand cmd;
        /// <summary>
        /// Methoud to get connection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnentionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.ServeName;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;

            return new SqlConnection(builder.ConnectionString);
        }

        /// <summary>
        /// Methoud to execute NonQuary from stored procedure (Insert ,Update ,Delete
        /// </summary>
        /// <param name="spName">Stored Procedures</param>
        /// <param name="methoud">Methoud contain the parameters</param>
        /// <returns></returns>
        public static bool executeData(string spName, Action methoud)
        {
            using (SqlConnection conn = GetConnentionString())
            {
                try
                {
                    cmd = new SqlCommand(spName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    methoud.Invoke();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();             
                }
            }
        }

    }
}
