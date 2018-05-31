using DutchmanSite.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DutchmanSite.Models
{
    public class DevLogsModel
    {
        public string Site { get; set; }
        public Boolean IsPublished { get; set; }
        public string Icon { get; set; }
        public string IconText { get; set; }
        public string Title { get; set; }
        public string Summery { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public long PKEY { get; set; }

        public void CreateNew(string site, string icon, string iconText, string title, string summery, string description, int isPublished)
        {
            DevLogDBHelper DBHelp = new DevLogDBHelper();

            //sanitizing this value so that if its null or somehow an int other than 0/1 it will be saved as a draft.
            if (isPublished != 1) { isPublished = 0; }

            DBHelp.NewLog(site, icon, iconText, title, summery, description, isPublished);
        }

        public string LogEditList()
        {
            DevLogDBHelper DB = new DevLogDBHelper();
            var Temp = DB.ListAll();
            List<DevLogsModel> List = new List<DevLogsModel>();
            //sort list here, can we pass in the method to sort by?
            List = Temp.OrderByDescending(o => o.Date).ToList();
            string DevLogString = "";
            foreach (var Log in List)
            {
                StringBuilder sb = new StringBuilder(DevLogString);
                sb.Append("<p><li class='well'>");
                sb.Append(Log.Date.ToShortDateString());
                if (Log.IsPublished)
                {
                    sb.Append(" | Live on ");
                    sb.Append(Log.Site);
                    sb.Append(" | ");
                }
                else
                {
                    sb.Append(" | Draft for ");
                    sb.Append(Log.Site);
                    sb.Append(" | ");
                }
                sb.Append("<a href='/Home/EditDevLog/(PKEY)'>Edit Post</a></p>"); //make this edit page!
                sb.Append("<i class='");
                sb.Append(Log.Icon);
                sb.Append("'></i></br><p><b>Icon Text:</b> ");
                sb.Append(Log.IconText);
                sb.Append("</br><b>Title:</b> ");
                sb.Append(Log.Title);
                sb.Append("</br><b>Summery:</b> ");
                sb.Append(Log.Summery);
                sb.Append("</p></br><div class='DevLogDescription'>");
                sb.Append(Log.Description);
                sb.Append("</div></li>");
                DevLogString = sb.ToString();
            }
            return DevLogString;
        }
    }
}