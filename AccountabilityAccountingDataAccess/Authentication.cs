using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountabilityAccountingDataAccess
{
    public class Authentication
    {
        private SqlDataAdapter adapter;
        public Authentication()
        {
            adapter = new SqlDataAdapter();
        }
        public DataTable GetUserAccountabilityAccounting(string login, string password)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(DBAccess.AccountabilityAccountingConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "get_user";

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@login";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Size = 30;
                param.Value = login;
                param.Direction = ParameterDirection.Input;
                command.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@password";
                param2.SqlDbType = SqlDbType.NVarChar;
                param2.Size = 30;
                param2.Value = password;
                param2.Direction = ParameterDirection.Input;
                command.Parameters.Add(param2);

                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@userName";
                param3.SqlDbType = SqlDbType.NVarChar;
                param3.Size = 30;
                param3.Direction = ParameterDirection.Output;
                command.Parameters.Add(param3);

                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@IdUser";
                param4.SqlDbType = SqlDbType.Int;
                param4.Direction = ParameterDirection.Output;
                command.Parameters.Add(param4);

                conn.Open();

                command.ExecuteNonQuery();
               

                table.Columns.Add(new DataColumn("IdUser", typeof(int)));
                table.Columns.Add(new DataColumn("UserName", typeof(string)));

                DataRow row = table.NewRow(); ;
                row["IdUser"] = command.Parameters["@IdUser"].Value;
                row["UserName"] = command.Parameters["@userName"].Value;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
