using DutchmanSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
                            Log.PKEY = reader.GetInt32(reader.GetOrdinal("PKEY"));
                            Log.IsPublished = reader.GetInt32(reader.GetOrdinal("isPublished"));
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
    }
}