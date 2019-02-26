﻿using System;
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
            adapter.UpdateCommand = null;
            adapter.DeleteCommand = null;

            using (conn)
            {
                conn.Open();
                adapter.Update(table);
            }            
        }

        private SqlCommand CreateInsertCommadSummary(SqlConnection conn, DataTable table, string userName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_summary";

            command.Parameters.Add("@summaryDate", SqlDbType.NChar, 200, "Дата");
            command.Parameters.Add("@projectName", SqlDbType.NChar, 200, "Проект");
            command.Parameters.Add("@itemDescription", SqlDbType.NChar, 200, "Статья");
            command.Parameters.Add("@transcriptItemDescription", SqlDbType.NChar, 200, "Расшифровка");
            command.Parameters.Add("@accountableName", SqlDbType.NChar, 200, "Подотчетник");
            command.Parameters.Add("@sign", SqlDbType.Char, 1, "Знак");
            command.Parameters.Add("@summa", SqlDbType.Int, 32,"Сумма");
            command.Parameters.Add("@userName", SqlDbType.NChar, 30, userName);

            return command;
        }
        
    }
}