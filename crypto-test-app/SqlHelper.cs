using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class SqlHelper
{
    public static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conStr"].ToString();

    public SqlHelper()
    {

    }

    public static DataTable GetDataTable(string sql,
                                         Dictionary<string, object> Parameters = null,
                                         ArrayList PrimaryKeys = null,
                                         CommandType cmdType = CommandType.Text,
                                         int timeout = 600)
    {
        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable result = new DataTable();

        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.CommandType = cmdType;
            cmd.CommandTimeout = timeout;
            cmd.Connection = con;
            cmd.CommandText = sql;

            if (Parameters != null)
            {
                foreach (var kvp in Parameters)
                {
                    cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }
            }

            adap.SelectCommand = cmd;
            adap.Fill(result);

            if (PrimaryKeys != null)
            {
                DataColumn[] keys = new DataColumn[PrimaryKeys.Count];

                for (int i = 0; i < PrimaryKeys.Count; i++)
                {
                    keys[i] = result.Columns[PrimaryKeys[i].ToString()];
                }

                result.PrimaryKey = keys;
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cmd.Dispose();
            adap.Dispose();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        return result;

    }

    public static void ExecuteSqlQuery(string sql,
                                       Dictionary<string, object> Parameters = null,
                                       CommandType cmdType = CommandType.Text,
                                       int timeout = 600)
    {
        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();

        try
        {
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = timeout;
            cmd.Connection = con;
            cmd.CommandText = sql;

            if (Parameters != null)
            {
                foreach (var kvp in Parameters)
                {
                    cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cmd.Dispose();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

    }

    public static object ExecuteScalarSqlQuery(string sql,
                                               Dictionary<string, object> Parameters = null,
                                               CommandType cmdType = CommandType.Text,
                                               int timeout = 600)
    {
        object result = null;

        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();

        try
        {
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = timeout;
            cmd.Connection = con;
            cmd.CommandText = sql;

            if (Parameters != null)
            {
                foreach (var kvp in Parameters)
                {
                    cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            result = cmd.ExecuteScalar();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cmd.Dispose();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

        return result;
    }

}//end class