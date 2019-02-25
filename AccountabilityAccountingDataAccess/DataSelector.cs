﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountabilityAccountingDataAccess
{
    public class DataSelector
    {
        public DataTable GetSummary(string dateStart, string dateEnd)
        {
            DataTable table = new DataTable("Summary");
            SqlConnection conn;
            SqlDataAdapter adapter;

            using (conn = new SqlConnection())
            {
                conn.ConnectionString = DBAccess.AccountabilityAccountingConnectionString;
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "get_summary";

                SqlParameter dsParam = new SqlParameter();
                dsParam.ParameterName = "@ds";
                dsParam.DbType = DbType.DateTime;
                dsParam.Value = DateTime.Parse(dateStart);
                command.Parameters.Add(dsParam);

                SqlParameter deParam = new SqlParameter();
                deParam.ParameterName = "@de";
                deParam.DbType = DbType.DateTime;
                deParam.Value = DateTime.Parse(dateEnd);
                command.Parameters.Add(deParam);

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                conn.Open();

                adapter.Fill(table);
            }


                return table;
        }
    }
}