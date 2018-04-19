using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Threading.Tasks;

namespace SQLDataRetrieval
{
    class SqlStoredProcedures
    {
        const string connDefault = @"Server=PL8\MTCDB;Database=JobSearch;Trusted_Connection=True;";
        SqlConnection sqlConn;

        private bool DBConnect(String ConnectString = "")
        {
            bool returnValue;

            // If no connection string was specified, use the default.
            // if (ConnectionString.Length == 0)
            //     ConnectionString = connDefault;

            try
            {
                // Open the connection to SQL Server. conndefault = sams jobsearch
                sqlConn = new SqlConnection(connDefault);
                sqlConn.Open();
                returnValue = true;
            }
            catch (Exception ex)
            {
                // If there was an error, return false and throw it back.
                returnValue = false;
                throw ex;
            }

            return returnValue;
        }

        public DataTable DtInactive_Leads()
        {
            DataTable dtInactive_Leads = new DataTable();

            // Get a list of leads that haven't been active for at least 7 days
            // dtInactive_Leads is the name of the data table. InactiveLeads is the name of the procedure.

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("InactiveLeads", sqlConn);
                    sqlDA.Fill(dtInactive_Leads);
                }
                else
                {
                    throw new Exception("Could not load inactive leads.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtInactive_Leads;
        }




        public DataTable DtLeadsBySource()
        {
            DataTable DtLeadsBySource = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("LeadsBySource", sqlConn);
                    sqlDA.Fill(DtLeadsBySource);
                }
                else
                {
                    throw new Exception("Could not load leads by source.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtLeadsBySource;
        }




        public DataTable DtActiveContactList()
        {
            DataTable DtActiveContactList = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("ActiveContactList", sqlConn);
                    sqlDA.Fill(DtActiveContactList);
                }
                else
                {
                    throw new Exception("Could not load active contact list.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtActiveContactList;
        }




        public DataTable DtActiveLeads()
        {
            DataTable DtActiveLeads = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("ActiveLeads", sqlConn);
                    sqlDA.Fill(DtActiveLeads);
                }
                else
                {
                    throw new Exception("Could not load active leads.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtActiveLeads;
        }



        public bool UpdateSource(DateTime FromDate, DateTime UntilDate)
        {
            bool returnValue = false;

            try
            {
                if (DBConnect())
                {
                    // Create new command for stored procedure.
                    SqlCommand insertSourceCmd = new SqlCommand("spUpdateSource", sqlConn);
                    insertSourceCmd.CommandType = CommandType.StoredProcedure;

                    //this connects the variables to the variables within the procedure

                    insertSourceCmd.Parameters.AddWithValue("@FromDate", FromDate);
                    insertSourceCmd.Parameters.AddWithValue("@UntilDate", UntilDate);

                    // Run command.
                    insertSourceCmd.ExecuteNonQuery();

                    returnValue = true;
                }
            }
            catch (Exception ex)
            {
                returnValue = false;
                throw ex;
            }

            return returnValue;
        }



        public DataTable DtSearchLog(DateTime Fromdate, DateTime Untildate)
        {
            DataTable DtSearchLog = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlCommand InsertSourceCmd = new SqlCommand("SearchLog", sqlConn);
                    InsertSourceCmd.CommandType = CommandType.StoredProcedure;

                    InsertSourceCmd.Parameters.AddWithValue("@Fromdate", Fromdate);
                    InsertSourceCmd.Parameters.AddWithValue("@Untildate", Untildate);



                    SqlDataAdapter sqlDA = new SqlDataAdapter(InsertSourceCmd);
                    sqlDA.Fill(DtSearchLog);

                    


                }
                else
                {
                    throw new Exception("Could not load search log.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtSearchLog;
        }



        public DataTable DtJobLeadsPerDay(DateTime Fromdate, DateTime Untildate)
        {
            DataTable DtJobLeadsPerDay = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlCommand InsertSourceCmd = new SqlCommand("JobLeadsPerDay", sqlConn);
                    InsertSourceCmd.CommandType = CommandType.StoredProcedure;

                    InsertSourceCmd.Parameters.AddWithValue("@Fromdate", Fromdate);
                    InsertSourceCmd.Parameters.AddWithValue("@Untildate", Untildate);



                    SqlDataAdapter sqlDA = new SqlDataAdapter(InsertSourceCmd);
                    sqlDA.Fill(DtJobLeadsPerDay);




                }
                else
                {
                    throw new Exception("Could not load job leads per day.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtJobLeadsPerDay;
        }




        public DataTable DtLeadReport()
        {
            DataTable DtLeadReport = new DataTable();

            try
            {
                if (DBConnect())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("LeadReport", sqlConn);
                    sqlDA.Fill(DtLeadReport);
                }
                else
                {
                    throw new Exception("Could not load lead report.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtLeadReport;
        }
    }
    }
