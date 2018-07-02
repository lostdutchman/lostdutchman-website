using DutchmanSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace DutchmanSite.Helper
{
    public class DevLogDBHelper
    {
        public void NewLog(string site, string icon, string iconText, string title, string summery, string description, int isPublished)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LostDutchmanSite"].ToString()))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO DevLogs (Site, isPublished, Icon, IconText, Title, Summery, Description, Date) VALUES (@site, @ispublished, @icon, @icontext, @title, @summery, @description, @date)";
                    command.Parameters.AddWithValue("@site", site);
                    command.Parameters.AddWithValue("@ispublished", isPublished);
                    command.Parameters.AddWithValue("@icon", icon);
                    command.Parameters.AddWithValue("@icontext", iconText);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@summery", summery);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@date", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch { throw; }
                }
            }
        }

        public List<DevLogsModel> ListAll()
        {
            var DevLogs = new List<DevLogsModel>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LostDutchmanSite"].ToString()))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM DevLogs");
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Log = new DevLogsModel();
                            Log.PKEY = reader.GetInt64(reader.GetOrdinal("PKEY"));
                            Log.IsPublished = reader.GetBoolean(reader.GetOrdinal("isPublished"));
                            Log.Icon = reader.GetString(reader.GetOrdinal("Icon"));
                            Log.IconText = reader.GetString(reader.GetOrdinal("IconText"));
                            Log.Title = reader.GetString(reader.GetOrdinal("Title"));
                            Log.Summery = reader.GetString(reader.GetOrdinal("Summery"));
                            Log.Description = reader.GetString(reader.GetOrdinal("Description"));
                            Log.Site = reader.GetString(reader.GetOrdinal("Site"));
                            Log.Date = reader.GetDateTime(reader.GetOrdinal("Date"));

                            DevLogs.Add(Log);
                        }
                    }
                }
            }
            return DevLogs;
        }

        public List<DevLogsModel> SingleLog(long PKEY)
        {
            var DevLog = new List<DevLogsModel>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LostDutchmanSite"].ToString()))
            {
                connection.Open();
                string query = String.Format("SELECT * FROM DevLogs WHERE PKEY =" + PKEY);
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Log = new DevLogsModel();
                            Log.PKEY = reader.GetInt64(reader.GetOrdinal("PKEY"));
                            Log.IsPublished = reader.GetBoolean(reader.GetOrdinal("isPublished"));
                            Log.Icon = reader.GetString(reader.GetOrdinal("Icon"));
                            Log.IconText = reader.GetString(reader.GetOrdinal("IconText"));
                            Log.Title = reader.GetString(reader.GetOrdinal("Title"));
                            Log.Summery = reader.GetString(reader.GetOrdinal("Summery"));
                            Log.Description = reader.GetString(reader.GetOrdinal("Description"));
                            Log.Site = reader.GetString(reader.GetOrdinal("Site"));
                            Log.Date = reader.GetDateTime(reader.GetOrdinal("Date"));

                            DevLog.Add(Log);
                        }
                    }
                }
            }
            return DevLog;
        }

        public void Remove(long PKEY)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LostDutchmanSite"].ToString()))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM DevLogs WHERE PKEY = @Key";
                    command.Parameters.AddWithValue("@Key", PKEY);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch { throw; }
                }
            }
        }

        public List<DevLogsModel> PublishedLogs(string Website)
        {
            var DevLogs = new List<DevLogsModel>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LostDutchmanSite"].ToString()))
                {
                    connection.Open();
                    string query = String.Format("SELECT * FROM DevLogs WHERE Site='" + Website + "' AND IsPublished=1 ORDER BY Date DESC");
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var Log = new DevLogsModel();
                                Log.PKEY = reader.GetInt64(reader.GetOrdinal("PKEY"));
                                Log.IsPublished = reader.GetBoolean(reader.GetOrdinal("isPublished"));
                                Log.Icon = reader.GetString(reader.GetOrdinal("Icon"));
                                Log.IconText = reader.GetString(reader.GetOrdinal("IconText"));
                                Log.Title = reader.GetString(reader.GetOrdinal("Title"));
                                Log.Summery = reader.GetString(reader.GetOrdinal("Summery"));
                                Log.Description = reader.GetString(reader.GetOrdinal("Description"));
                                Log.Site = reader.GetString(reader.GetOrdinal("Site"));
                                Log.Date = reader.GetDateTime(reader.GetOrdinal("Date"));

                                DevLogs.Add(Log);
                            }
                        }
                    }
                }
            }
            catch
            {
                var Log = new DevLogsModel();
                Log.IconText = "For your eyes only.";
                Log.Icon = "fas fa-user-secret fa-7x";
                Log.Title = "We know your secrets.";
                Log.Summery = "Want to learn one of ours?";
                Log.Description = "<h4>This log means that we are having database issues.</h4> If you are not currently in a forgotten city hundreds of miles below the surface of the superstition mountains then you should never see this. Something has gone wrong and I've got to get this fixed before our horrible, <i>oozing</i> management team finds me.</br></br></br>";
                DevLogs.Add(Log);
            }

            return DevLogs;
        }

        //This cannot be used unless/until we move to a hosting account where the hosting and sql database are on the same server
        //public void Backup()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["LostDutchmanSite"].ConnectionString;
        //    var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);
        //    string backupFileName = String.Format("{0}{1}DB_{2}.BAK", HostingEnvironment.ApplicationPhysicalPath + @"Content\DatabaseBackups\", sqlConStrBuilder.InitialCatalog, DateTime.Now.ToString("yyyy-MM-dd_hh-mm"));

        //    using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
        //    {
        //        string query = String.Format("BACKUP DATABASE {0} TO disk='{1}'", sqlConStrBuilder.InitialCatalog, backupFileName);

        //        using (var command = new SqlCommand(query, connection))
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}