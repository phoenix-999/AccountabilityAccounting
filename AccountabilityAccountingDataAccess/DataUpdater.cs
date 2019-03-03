using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountabilityAccountingDataAccess
{
    public class DataUpdater
    {
        
        public void UpdateSummary(DataTable table, string userName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DBAccess.AccountabilityAccountingConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = CreateInsertCommadSummary(conn, table, userName);
            adapter.UpdateCommand = CreateUpdateCommadSummary(conn, table, userName);
            adapter.DeleteCommand = CreateDeleteCommadSummary(conn, table, userName);

            using (conn)
            {
                conn.Open();
                adapter.Update(table);
                table.AcceptChanges();
            }            
        }

        private SqlCommand CreateInsertCommadSummary(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_summary";

            command.Parameters.Add("@summaryDate", SqlDbType.DateTime, 32, "Дата");
            command.Parameters.Add("@projectName", SqlDbType.NChar, 200, "Проект");
            command.Parameters.Add("@itemDescription", SqlDbType.NChar, 200, "Статья");
            command.Parameters.Add("@transcriptItemDescription", SqlDbType.NChar, 200, "Расшифровка");
            command.Parameters.Add("@accountableName", SqlDbType.NChar, 200, "Подотчетник");
            command.Parameters.Add("@sign", SqlDbType.Char, 1, "Приход/Расход");
            command.Parameters.Add("@summa", SqlDbType.Float, 64, "Сумма");

            SqlParameter userNameParam = new SqlParameter();
            userNameParam.SqlDbType = SqlDbType.NVarChar;
            userNameParam.Size = 30;
            userNameParam.ParameterName = "@userName";
            userNameParam.Value = userName;

            command.Parameters.Add(userNameParam);

            return command;
        }

        private SqlCommand CreateUpdateCommadSummary(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "update_summary";
            // New Parametres
            SqlParameter summaryDateNew = command.Parameters.Add("@summaryDateNew", SqlDbType.DateTime, 64, "Дата");
            summaryDateNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter projectNameNew = command.Parameters.Add("@projectNameNew", SqlDbType.NVarChar, 200, "Проект");
            projectNameNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter itemDescriptionNew = command.Parameters.Add("@itemDescriptionNew", SqlDbType.NVarChar, 200, "Статья");
            itemDescriptionNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter transcriptItemDescriptionNew = command.Parameters.Add("@transcriptItemDescriptionNew", SqlDbType.NVarChar, 200, "Расшифровка");
            transcriptItemDescriptionNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter accountableNameNew = command.Parameters.Add("@accountableNameNew", SqlDbType.NVarChar, 200, "Подотчетник");
            accountableNameNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter signNew = command.Parameters.Add("@signNew", SqlDbType.Char, 1, "Приход/Расход");
            signNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter summaNew = command.Parameters.Add("@summaNew", SqlDbType.Float, 64, "Сумма");
            summaNew.SourceVersion = DataRowVersion.Current;
            

            SqlParameter userNameParam = new SqlParameter();
            userNameParam.SqlDbType = SqlDbType.NVarChar;
            userNameParam.Size = 30;
            userNameParam.ParameterName = "@userNameNew";
            userNameParam.Value = userName;
            command.Parameters.Add(userNameParam);

            // Old Parametres
            SqlParameter summaryDateOld = command.Parameters.Add("@summaryDateOld", SqlDbType.DateTime, 64, "Дата");
            summaryDateOld.SourceVersion = DataRowVersion.Original;
            

            SqlParameter projectNameOld = command.Parameters.Add("@projectNameOld", SqlDbType.NVarChar, 200, "Проект");
            projectNameOld.SourceVersion = DataRowVersion.Original;
            

            SqlParameter itemDescriptionOld = command.Parameters.Add("@itemDescriptionOld", SqlDbType.NVarChar, 200, "Статья");
            itemDescriptionOld.SourceVersion = DataRowVersion.Original;
            

            SqlParameter transcriptItemDescriptionOld = command.Parameters.Add("@transcriptItemDescriptionOld", SqlDbType.NVarChar, 200, "Расшифровка");
            transcriptItemDescriptionOld.SourceVersion = DataRowVersion.Original;
            

            SqlParameter accountableNameOld = command.Parameters.Add("@accountableNameOld", SqlDbType.NVarChar, 200, "Подотчетник");
            accountableNameOld.SourceVersion = DataRowVersion.Original;
            

            SqlParameter signOld = command.Parameters.Add("@signOld", SqlDbType.Char, 1, "Приход/Расход");
            signOld.SourceVersion = DataRowVersion.Original;
            

            SqlParameter summaOld = command.Parameters.Add("@summaOld", SqlDbType.Float, 64, "Сумма");
            summaOld.SourceVersion = DataRowVersion.Original;
            

            return command;
        }

        private SqlCommand CreateDeleteCommadSummary(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "delete_summary";

            command.Parameters.Add("@summaryDate", SqlDbType.DateTime, 32, "Дата");
            command.Parameters.Add("@projectName", SqlDbType.NChar, 200, "Проект");
            command.Parameters.Add("@itemDescription", SqlDbType.NChar, 200, "Статья");
            command.Parameters.Add("@transcriptItemDescription", SqlDbType.NChar, 200, "Расшифровка");
            command.Parameters.Add("@accountableName", SqlDbType.NChar, 200, "Подотчетник");
            command.Parameters.Add("@sign", SqlDbType.Char, 1, "Приход/Расход");
            command.Parameters.Add("@summa", SqlDbType.Float, 64, "Сумма");

            return command;
        }

        public void UpdateAccountables(DataTable table, string userName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DBAccess.AccountabilityAccountingConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = CreateInsertCommndAccountables(conn, table, userName);
            adapter.UpdateCommand = CreateUpdateCommndAccountables(conn, table, userName);
            adapter.DeleteCommand = CreateDeleteCommndAccountables(conn, table, userName);

            using (conn)
            {
                conn.Open();
                adapter.Update(table);
                table.AcceptChanges();
            }
        }

        private SqlCommand CreateInsertCommndAccountables(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_accountables";

            command.Parameters.Add("@accountableName", SqlDbType.NVarChar, 30, "Подотчетник");

            return command;
        }

        private SqlCommand CreateUpdateCommndAccountables(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "update_accountables";

            SqlParameter newAccountable = command.Parameters.Add("@accountableNameNew", SqlDbType.NVarChar, 30, "Подотчетник");
            newAccountable.SourceVersion = DataRowVersion.Current;

            SqlParameter oldAccountable = command.Parameters.Add("@accountableNameOld", SqlDbType.NVarChar, 30, "Подотчетник");
            oldAccountable.SourceVersion = DataRowVersion.Original;

            return command;
        }

        private SqlCommand CreateDeleteCommndAccountables(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "delete_accountables";

            command.Parameters.Add("@accountableName", SqlDbType.NVarChar, 30, "Подотчетник");

            return command;
        }


        public void UpdateProjects(DataTable table, string userName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DBAccess.AccountabilityAccountingConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = CreateInsertCommndProjects(conn, table, userName);
            adapter.UpdateCommand = CreateUpdateCommndProjects(conn, table, userName);
            adapter.DeleteCommand = CreateDeleteCommndProjects(conn, table, userName);

            using (conn)
            {
                conn.Open();
                adapter.Update(table);
                table.AcceptChanges();
            }
        }

        private SqlCommand CreateInsertCommndProjects(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_projects";

            command.Parameters.Add("@projectName", SqlDbType.NVarChar, 200, "Проект");

            return command;
        }

        private SqlCommand CreateUpdateCommndProjects(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "update_projects";

            SqlParameter newAccountable = command.Parameters.Add("@projectNameNew", SqlDbType.NVarChar, 200, "Проект");
            newAccountable.SourceVersion = DataRowVersion.Current;

            SqlParameter oldAccountable = command.Parameters.Add("@projectNameOld", SqlDbType.NVarChar, 200, "Проект");
            oldAccountable.SourceVersion = DataRowVersion.Original;

            return command;
        }

        private SqlCommand CreateDeleteCommndProjects(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "delete_project";

            command.Parameters.Add("@projectName", SqlDbType.NVarChar, 200, "Проект");

            return command;
        }
    }
}
