using DutchmanSite.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutchmanSite.Models
{
    public class DevLogsModel
    {
        public string Site { get; set; }
        public int IsPublished { get; set; }
        public string Icon { get; set; }
        public string IconText { get; set; }
        public string Title { get; set; }
        public string Summery { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int PKEY { get; set; }

        public void CreateNew(string site, string icon, string iconText, string title, string summery, string description, int isPublished)
        {
            DevLogDBHelper DBHelp = new DevLogDBHelper();

            //sanitizing this value so that if its null or somehow an int other than 0/1 it will be saved as a draft.
            if (isPublished != 1) { isPublished = 0; }

            DBHelp.NewLog(site, icon, iconText, title, summery, description, isPublished);
        }

        public string LogEditList()
        {
            return "test";
        }
    }
}